using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestTodoList
{
    public class ToDo
    {
        public string? Name { get; set; }
        public string? Info { get; set; }
        public bool IsImportant { get; set; }
        public DateTime Date { get; set; }
    }
}
