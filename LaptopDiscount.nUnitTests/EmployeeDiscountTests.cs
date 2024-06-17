using System;

namespace LaptopDiscount.nUnitTests
{
    public class Tests
    {

        private EmployeeDiscount _employeeDiscount;

        [SetUp]
        public void Setup()
        {
            _employeeDiscount = new EmployeeDiscount();
        }

        [Test]
        public void Price_NoDiscountShouldBeProvided()
        {
            // Arrange
            _employeeDiscount.Price = 100;
            decimal expectedPriceAfterDiscount = 100;

            // Act
            decimal calculatedPriceWithDiscount = _employeeDiscount.CalculateDiscountedPrice();

            // Assert
            Assert.That(calculatedPriceWithDiscount, Is.EqualTo(expectedPriceAfterDiscount));
        }

        [Test]
        public void NullEmployeeType_NoDiscountShouldBeProvided()
        {
            // Arrange
            _employeeDiscount.Price = 100;
            decimal expectedPriceAfterDiscount = 100;

            // Act
            decimal calculatedPriceWithDiscount = _employeeDiscount.CalculateDiscountedPrice();

            // Assert
            Assert.That(calculatedPriceWithDiscount, Is.EqualTo(expectedPriceAfterDiscount));
        }

        [Test]
        public void PartTime_NoDiscountShouldBeProvided()
        {
            // Arrange 
            // 0 discount should be provided
            _employeeDiscount.Price = 100;
            _employeeDiscount.EmployeeType = EmployeeType.PartTime;
            decimal expectedPriceAfterDiscount = 100;

            // Act
            decimal calculatedPriceWithDiscount = _employeeDiscount.CalculateDiscountedPrice();

            // Assert
            Assert.That(calculatedPriceWithDiscount, Is.EqualTo(expectedPriceAfterDiscount));
        }

        [Test]
        public void PartialLoad_DiscountShouldBeProvided()
        {
            // Arrange
            // 5% discount should be provided
            _employeeDiscount.Price = 100;
            _employeeDiscount.EmployeeType = EmployeeType.PartialLoad;
            decimal expectedPriceAfterDiscount = 95;

            // Act
            decimal calculatedPriceWithDiscount = _employeeDiscount.CalculateDiscountedPrice();

            // Assert
            Assert.That(calculatedPriceWithDiscount, Is.EqualTo(expectedPriceAfterDiscount));
        }

        [Test]
        public void FullTime_DiscountShouldBeProvided()
        {
            // Arrange
            // 10% discount should be provided
            _employeeDiscount.Price = 100;
            _employeeDiscount.EmployeeType = EmployeeType.FullTime;
            decimal expectedPriceAfterDiscount = 90;

            // Act
            decimal calculatedPriceWithDiscount = _employeeDiscount.CalculateDiscountedPrice();

            // Assert
            Assert.That(calculatedPriceWithDiscount, Is.EqualTo(expectedPriceAfterDiscount));
        }

        [Test]
        public void Data_ShouldBeSetCorrectly()
        {
            // Arrange
            // 20% discount should be provided
            _employeeDiscount.Price = 100;
            _employeeDiscount.EmployeeType = EmployeeType.FullTime;
            decimal expectedPrice = 100;
            EmployeeType expectedEmployeeType = EmployeeType.FullTime;


            // Act & Assert
            Assert.That(_employeeDiscount.Price, Is.EqualTo(expectedPrice));
            Assert.That(_employeeDiscount.EmployeeType, Is.EqualTo(expectedEmployeeType));
        }
    }
}