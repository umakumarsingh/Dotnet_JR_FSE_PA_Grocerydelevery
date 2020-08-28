using GroceryDelivery.BusinessLayer.Interfaces;
using GroceryDelivery.BusinessLayer.Services;
using GroceryDelivery.BusinessLayer.Services.Repository;
using GroceryDelivery.Entites;
using Moq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Grocerydelevery.Tests.TestCases
{
    public class ExceptionalTest
    {
        /// <summary>
        /// Creating Referance Variable of Service Interface and Mocking Repository Interface and class
        /// </summary>
        private readonly IGroceryServices _GroceryServices;
        public readonly Mock<IGroceryRepository> service = new Mock<IGroceryRepository>();
        private readonly Product _product;
        private readonly Menubar _menubar;
        private readonly ApplicationUser _user;
        public ExceptionalTest()
        {
            //Creating New mock Object with value.
            _GroceryServices = new GroceryServices(service.Object);
            _product = new Product
            {
                ProductId = 2,
                ProductName = "Samsung - TV",
                Description = "Size - 72, SSD-128 GB, Processor-Snap Dragon 805, Screen - 4500X3000PX",
                Amount = 12990,
                stock = 13,
                CatId = 2
            };
            _menubar = new Menubar
            {
                Id = 1,
                Title = "Home",
                Url = "~/",
                OpenInNewWindow = false
            };
            _user = new ApplicationUser()
            {
                UserId = 2,
                Name = "Name1",
                Email = "namelast@gmail.com",
                MobileNumber = 9631438113,
                PinCode = 823311,
                HouseNo_Building_Name = "9/11",
                Road_area = "Manpur Gaya",
                City = "Gaya",
                State = "Bihar"
            };
        }
        /// <summary>
        /// Creating test output text file that store the result in boolean result
        /// </summary>
        static ExceptionalTest()
        {
            if (!File.Exists("../../../../output_exception_revised.txt"))
                try
                {
                    File.Create("../../../../output_exception_revised.txt").Dispose();
                }
                catch (Exception)
                {

                }
            else
            {
                File.Delete("../../../../output_exception_revised.txt");
                File.Create("../../../../output_exception_revised.txt").Dispose();
            }
        }
        /// <summary>
        /// Test for placing invalid order
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task<bool> Testfor_Validate_InvlidPlaceOrder()
        {
            //Arrange
            bool res = false;
            var _userApp = new ApplicationUser()
            {
                UserId = 2,
                Name = "Name1",
                Email = "namelast@gmail.com",
                MobileNumber = 9631438113,
                PinCode = 823311,
                HouseNo_Building_Name = "9/11",
                Road_area = "Manpur Gaya",
                City = "Gaya",
                State = "Bihar"
            };
            _userApp = null;
            //Act
            service.Setup(repo => repo.PlaceOrder(_product.ProductId,_user)).ReturnsAsync(_userApp = null);
            var result = await _GroceryServices.PlaceOrder(_product.ProductId, _user);
            if (result == null)
            {
                res = true;
            }
            //Asert
            //final result displaying in text file
            await File.AppendAllTextAsync("../../../../output_exception_revised.txt", "Testfor_Validate_InvlidPlaceOrder=" + res + "\n");
            return res;
        }
    }
}
