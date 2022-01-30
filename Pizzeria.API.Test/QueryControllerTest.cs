using Microsoft.AspNetCore.Mvc;
using Moq;
using Pizzeria.API.Controllers;
using Pizzeria.Application.Interface;
using Pizzeria.Common.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace Pizzeria.API.Test
{
    public class QueryControllerTest
    {

        #region Property  
        public Mock<IQueryApplication> mock = new Mock<IQueryApplication>();
        #endregion

        [Fact]
        public void getAllCrust_test()
        {
            //Arrange
            mock.Setup(p => p.GetAllCrust()).Returns(CrustDetails);
            List<Crust> crusts = CrustDetails(); 
            QueryController queryController = new QueryController(mock.Object);

            //Act
            var Queryresult = queryController.getAllCrust() as OkObjectResult;

            //Assert
            var result = ((IEnumerable<Crust>)Queryresult.Value).ToList();
            Assert.Equal(2, result.Count);

        }

        private List<Crust> CrustDetails()
        {
            return new List<Crust>() {
                new Crust(){
                   CurstId = 101,
                   name = "Small",
                   price= 250 ,
                   isAvailable =true,
                },
                 new Crust()
                {
                    CurstId = 102,
                    name = "Regular",
                    price = 350,
                    isAvailable = true,
                }
            };
        }

    }
}
