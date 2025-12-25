using Xunit;
using EA_DAL.Models;
using Microsoft.EntityFrameworkCore;
namespace TestProject1
{
    public class UnitTest1
    {
        private readonly AllDbForItContext _db;

        public UnitTest1()
        {
            var options = new DbContextOptionsBuilder<AllDbForItContext>()
                .UseInMemoryDatabase("TestDb")
                .Options;

            _db = new AllDbForItContext(options);
        }
        [Fact]
        public void Test1()
        {
            var eq = new Equipment
            {
                InventoryNumber = "TEST001",
                Name = "Тестовый ПК"
            };

            _db.Equipment.Add(eq);
            _db.SaveChanges();

            var saved = _db.Equipment.Single(e => e.InventoryNumber == "TEST001");
            Assert.Equal("Тестовый ПК", saved.Name);
        }
        public void Dispose() => _db.Dispose();
    }
}