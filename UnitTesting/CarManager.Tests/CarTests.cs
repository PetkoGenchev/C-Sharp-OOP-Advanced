using CarManager;
using NUnit.Framework;
using System;

namespace Tests
{
    public class CarTests
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        [TestCase("VW", "Gold", 10, 100)]
        [TestCase("BMW", "3", 20, 200)]
        public void TestMainConstructorSettingData(
            string make,
            string model,
            double fuelConsumption,
            double fuelCapacity)
        {
            Car car = new Car(
                make: make,
                model: model,
                fuelConsumption: fuelConsumption,
                fuelCapacity: fuelCapacity);

            Assert.AreEqual(car.Make, make);
            Assert.AreEqual(car.Model, model);
            Assert.AreEqual(car.FuelConsumption, fuelConsumption);
            Assert.AreEqual(car.FuelCapacity, fuelCapacity);

        }



        [Test]
        [TestCase("")]
        [TestCase(null)]
        public void TestIfMakeThrowsExceptionWithNullOrEmptyEntry(string make)
        {
            Assert.Throws<ArgumentException>(() => new Car(make, "Golf", 2, 3));
        }


        [Test]
        [TestCase("")]
        [TestCase(null)]
        public void TestIfModelThrowsExceptionWithNullOrEmptyEntry(string model)
        {
            Assert.Throws<ArgumentException>(() => new Car("VW", model, 2, 3));
        }


        [Test]
        [TestCase(0)]
        [TestCase(-5)]
        public void TestIfFuelConsumptionThrowsExceptionWithZeroOrNegative(double fuelConsumption)
        {
            Assert.Throws<ArgumentException>(() => new Car("VW", "Golf", fuelConsumption, 30));
        }


        [Test]
        [TestCase(0)]
        [TestCase(-100)]
        public void TestIfFuelCapacityThrowsExceptionWithZeroOrNegative(double fuelCapacity)
        {
            Assert.Throws<ArgumentException>(() => new Car("VW", "Golf", 2, fuelCapacity));
        }


        [Test]
        [TestCase(0)]
        [TestCase(-10)]

        public void TestRefuelExceptionIfNegativeOrZeroInput(double fuelToRefuel)
        {
            Car car = new Car("VW", "Passat", 1, 10);

            Assert.Throws<ArgumentException>(() => car.Refuel(fuelToRefuel));
        }


        [Test]
        [TestCase(10)]

        public void TestRefueIfFuelIsLess(double fuelToRefuel)
        {
            Car car2 = new Car("VW", "Passat", 1, 20);

            car2.Refuel(fuelToRefuel);

            var expectedResult = 10;
            var actualResult = car2.FuelAmount;

            Assert.AreEqual(expectedResult, actualResult);
        }



        [Test]
        [TestCase(100)]

        public void TestRefueIfFuelMoreThanCapacity(double fuelToRefuel)
        {
            Car car3 = new Car("VW", "Passat", 1, 20);

            car3.Refuel(fuelToRefuel);

            var expectedResult = 20;
            var actualResult = car3.FuelAmount;

            Assert.AreEqual(expectedResult, actualResult);

        }


        [Test]
        [TestCase(10000)]

        public void TestIfDistanceIfMoreThanFuelException(double distanceToDrive)
        {
            Car car4 = new Car("VW", "Passat", 10, 20);
            car4.Refuel(20);

            Assert.Throws<InvalidOperationException>(() => car4.Drive(distanceToDrive));
        }



        [Test]
        [TestCase(100)]

        public void TestFuelDecreaseWhenCarIsDriven(double distanceToDrive)
        {
            Car car4 = new Car("VW", "Passat", 10, 20);
            car4.Refuel(20);
            car4.Drive(distanceToDrive);

            var expectedResult = 10;
            var actualResult = car4.FuelAmount;

            Assert.AreEqual(expectedResult, actualResult);
        }


    }
}