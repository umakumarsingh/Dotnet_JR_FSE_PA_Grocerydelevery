﻿using GroceryDelivery.BusinessLayer.Interfaces;
using GroceryDelivery.BusinessLayer.Services;
using GroceryDelivery.BusinessLayer.Services.Repository;
using GroceryDelivery.Entites;
using Moq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Xunit;

namespace Grocerydelevery.Tests.TestCases
{
    public class BoundaryTest
    {
        /// <summary>
        /// Creating Referance Variable of Service Interface and Mocking Repository Interface and class
        /// </summary>
        private readonly IGroceryServices _GroceryServices;
        public readonly Mock<IGroceryRepository> service = new Mock<IGroceryRepository>();
        private readonly Product _product;
        private readonly Menubar _menubar;
        private readonly ApplicationUser _user;
        public BoundaryTest()
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
        static BoundaryTest()
        {
            if (!File.Exists("../../../../output_boundary_revised.txt"))
                try
                {
                    File.Create("../../../../output_boundary_revised.txt").Dispose();
                }
                catch (Exception)
                {

                }
            else
            {
                File.Delete("../../../../output_boundary_revised.txt");
                File.Create("../../../../output_boundary_revised.txt").Dispose();
            }
        }
        /// <summary>
        /// Test to validate product id
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task<bool> Testfor_ValidateProductId()
        {
            //Arrange
            bool res = false;
            //Act
            service.Setup(repo => repo.AddProduct(_product)).ReturnsAsync(_product);
            var result = await _GroceryServices.AddProduct(_product);
            if (result.ProductId == _product.ProductId)
            {
                res = true;
            }
            //Asert
            //final result displaying in text file
            await File.AppendAllTextAsync("../../../../output_boundary_revised.txt", "Testfor_ValidateProductId=" + res + "\n");
            return res;
        }
        /// <summary>
        /// Validate Mobile Number
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task<bool> Testfor_ValidateMobileNumber()
        {
            //Arrange
            bool res = false;
            //Act
            service.Setup(repo => repo.PlaceOrder(_product.ProductId,_user)).ReturnsAsync(_user);
            var result = await _GroceryServices.PlaceOrder(_product.ProductId, _user);
            var actualLength = _user.MobileNumber.ToString().Length;
            if (result.ToString().Length == actualLength)
            {
                res = true;
            }
            //Asert
            //final result displaying in text file
            await File.AppendAllTextAsync("../../../../output_boundary_revised.txt", "Testfor_ValidateMobileNumber=" + res + "\n");
            return res;
        }
        /// <summary>
        /// Testfor_ValidEmail used for test the valid Email
        /// </summary>
        [Fact]
        public async void Testfor_ValidEmail()
        {
            //Arrange
            bool res = false;
            //Act
            bool isEmail = Regex.IsMatch(_user.Email, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase);
            //Assert
            Assert.True(isEmail);
            res = isEmail;
            //final result displaying in text file
            await File.AppendAllTextAsync("../../../../output_boundary_revised.txt", "Testfor_ValidEmail=" + res + "\n");
        }
    }
}
