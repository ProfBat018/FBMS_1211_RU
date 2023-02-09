using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ASP_Auth.DbContexts;
using ASP_Auth.Models;
using ASP_Auth.Services.Validators;


namespace ASP_Auth.Controllers
{
    public class AuthController : Controller
    {
        public List<AuthModel>? Data { get; set; }
        private readonly AuthModelContext? _context;

        public AuthController(AuthModelContext? context)
        {
            _context = context;
        }

        // GET: Auth
        public async Task<IActionResult> Index()
        {
            var users = await _context!.Users?.ToListAsync();


            return View(users);
        }

        // GET: Auth/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Users == null)
            {
                return NotFound();
            }

            var authModel = await _context.Users
                .FirstOrDefaultAsync(m => m.Id == id);
            if (authModel == null)
            {
                return NotFound();
            }
            return View(authModel);
        }

        // GET: Auth/Create
        public IActionResult Create()
        {
            return View();
        }

     
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Email,Password,ConfirmPassword")] AuthModel authModel)
        {
            if (ModelState.IsValid)
            {
                _context?.Add(authModel);
                await _context?.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(authModel);
        }

        // GET: Auth/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context!.Users == null)
            {
                return NotFound();
            }

            var authModel = await _context.Users.FindAsync(id);
            if (authModel == null)
            {
                return NotFound();
            }
            
            return View(authModel);
        }

        // POST: Auth/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Email,Password,ConfirmPassword")] AuthModel authModel)
        {
            if (id != authModel.Id)
            {
                return NotFound();
            }

            var validator = new AuthModelValidator();
            var res = validator.Validate(authModel);

            if (!res.IsValid)
            {
                ViewData["pass_error"] = res.Errors[0];
            }
            
            if (ModelState.IsValid && res.IsValid)
            {
                try
                {
                    _context?.Update(authModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AuthModelExists(authModel.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(authModel);
        }
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Users == null)
            {
                return NotFound();
            }

            var authModel = await _context.Users
                .FirstOrDefaultAsync(m => m.Id == id);
            if (authModel == null)
            {
                return NotFound();
            }

            return View(authModel);
        }

        // POST: Auth/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Users == null)
            {
                return Problem("Entity set 'AuthModelContext.Users'  is null.");
            }
            var authModel = await _context.Users.FindAsync(id);
            if (authModel != null)
            {
                _context.Users.Remove(authModel);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AuthModelExists(int id)
        {
            return _context.Users.Any(e => e.Id == id);
        }
    }
}
