using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using Opgave_1.Exeptions;

namespace Opgave_1
{
    public class Car
    {
        private static int _nextID = 1;
        private int _id;
        private string _model;
        private double _price;
        private string _plate;
        public int ID { get => _id; set => _id = value; }

        public string Model
        {
            get => _model;
            set
            {
                if (value.Length < 4)
                    throw new ModelNotLongEnough("Model has to be minimum of 4 characters long", value);

                _model = value;
            }
        }

        public double Price
        {
            get => _price;
            set
            {
                if (value <= 0)
                    throw new PriceHasToBeMoreThanZero("Price has to be more than zero", value);

                _price = value;
            }
        }

        public string LicensePlate
        {
            get => _plate;
            set
            {
                if (value.Length < 2 || value.Length > 7)
                    throw new LicensePlateHasToBeInRange("License plate has to be between 2 and 7 characters long", value);

                _plate = value;
            }
        }

        public Car() { }

        public Car(int id, string model, double price, string plate)
        {
            if (model.Length < 4)
                throw new ModelNotLongEnough("Model has to be minimum of 4 characters long", model);
            if (plate.Length < 2 || plate.Length > 7)
                throw new LicensePlateHasToBeInRange("License plate has to be between 2 and 7 characters long", plate);
            ID = id;
            Model = model;
            Price = price;
            LicensePlate = plate;
        }

        public override string ToString()
        {
            return $"ID: {ID}, Model: {Model}, Price: {Price}, License Plate: {LicensePlate}";
        }
    }
}
    }


            
    /*using Microsoft.VisualStudio.TestTools.UnitTesting;
using ObligatoriskOpgave.Models;
using ObligatoriskOpgave.Exeptions;

namespace ObligatoriskUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CarConstructorTest()
        {
            Assert.IsInstanceOfType(new Car(1, "Model X", 399.95, "XD69420"), typeof(Car));
        }

        [TestMethod]
        [ExpectedException(typeof(ModelNotLongEnough))]
        public void CarConstructorModelTest()
        {
            Car car = new Car(1, "Mo", 399.95, "XD69420");
        }

        [TestMethod]
        [ExpectedException(typeof(PriceHasToBeMoreThanZero))]
        public void CarConstructorPriceIsZeroTest()
        {
            Car car = new Car(1, "Model X", 0, "XD69420");
            Car car1 = new Car(2, "Model X", -100, "XD69420");
        }

        [TestMethod]
        [ExpectedException(typeof(LicensePlateHasToBeInRange))]
        public void CarConstructorLicensePlateLessThan2CharactersTest()
        {
            Car car = new Car(1, "Model X", 399.95, "X");
            Car car1 = new Car(2, "Model X", 399.95, "XD694200");

        }

        [TestMethod]
        public void CarPropertiesTest()
        {
            Car car = new Car(1, "Model X", 399.95, "XD69420");
            string toString = car.ToString();
            Assert.ThrowsException<ModelNotLongEnough>(() => car.Model = "M");
            Assert.ThrowsException<PriceHasToBeMoreThanZero>(() => car.Price = 0);
            Assert.ThrowsException<PriceHasToBeMoreThanZero>(() => car.Price = -1);
            Assert.ThrowsException<LicensePlateHasToBeInRange>(() => car.LicensePlate = "X");
            Assert.ThrowsException<LicensePlateHasToBeInRange>(() => car.LicensePlate = "XD694200");
            Assert.AreEqual(toString, car.ToString());
        }

        [TestMethod]
        public void ExeptionPropertyTest()
        {
            try
            {
                Car car = new Car(1, "Mo", 399.95, "XD69420");
            }
            catch (ModelNotLongEnough e)
            {
                Assert.IsNotNull(e.Model);
            }

            try
            {
                Car car = new Car(1, "Model X", 0, "XD69420");
            }
            catch (PriceHasToBeMoreThanZero e)
            {
                Assert.IsNotNull(e.Price);
            }

            try
            {
                Car car = new Car(1, "Model X", 399.95, "X");
            }
            catch (LicensePlateHasToBeInRange e)
            {
                Assert.IsNotNull(e.LicensePlate);
            }
        }
    }
}
© 2022 GitHub, Inc.
Term
}*/
}
