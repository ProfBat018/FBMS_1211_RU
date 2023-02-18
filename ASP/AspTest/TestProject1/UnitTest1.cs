using Microsoft.AspNetCore.Mvc.Testing;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        private HttpClient _httpClient;

        [TestMethod]
        public async Task TestGetAll()
        {
            var webAppFactory = new WebApplicationFactory<Program>();
            _httpClient = webAppFactory.CreateDefaultClient();

            var response = await _httpClient.GetAsync("/Home/GetAll");

            bool responseRes = response.IsSuccessStatusCode;

            Assert.AreEqual(responseRes, true);
        }
    }
}