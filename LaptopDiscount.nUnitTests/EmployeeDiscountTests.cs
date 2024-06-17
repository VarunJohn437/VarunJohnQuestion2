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
    }
}