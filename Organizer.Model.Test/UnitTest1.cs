namespace Organizer.Model.Test {
    public class Tests {
        [SetUp]
        public void Setup() {
        }

        [Test]
        public void Test1() {
            var model = new DataModel();
            model.guns = new List<Gun>() { new Gun() {Name = "AK-47", Description = "Strong weapon on close and high range",Cost = 5000 },
            new Gun() {Name = "M4-A1s", Description = "Good weapon on close and high range",Cost = 3500 }};
            model.weaponShops = new List<WeaponShop> { new WeaponShop() { Name = "MyNewWeaponShop", Description = " This is completly new shop!" } };
            model.gunSellers = new List<GunSeller> { new GunSeller() { Name = "Illia", Description = "19years,student", Salary = 500 } };
            DataSerializer.SerializeData(@"G:\orgaizer.dat", model);
            Assert.Pass();
            
        }
        [Test]
        public void Test2() {
            var model = DataSerializer.DeserializeData(@"G:\orgaizer.dat");
            string name = null;
            foreach (var seller in model.gunSellers)
                name = seller.Name;
            Assert.AreEqual("Illia", name);
        }
    }
}