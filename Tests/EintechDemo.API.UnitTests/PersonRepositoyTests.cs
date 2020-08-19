using System;
using System.Collections.Generic;
using System.Linq;
using EintechDemo.API.Controllers;
using EintechDemo.API.Data;
using EintechDemo.API.Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace EintechDemo.API.UnitTests
{
    [TestClass]
    public class PersonRepositoyTests
    {
        Mock<IEintechDemoContext> MockContext = new Mock<IEintechDemoContext>();

        [TestInitialize]
        public void Init()
        {
            // Mocking DB Return Objects
            MockContext.Setup(c => c.GetPeople()).Returns(new List<Models.Person>()
            {
                new Models.Person()
                {
                    PersonID = 1,
                    Name = "Fred Flintstone",
                    CreatedDateTime = DateTime.Now
                },
                new Models.Person()
                {
                    PersonID = 2,
                    Name = "Wilma Flintstone",
                    CreatedDateTime = DateTime.Now
                },
                new Models.Person()
                {
                    PersonID = 3,
                    Name = "Barney Rubble",
                    CreatedDateTime = DateTime.Now
                },
                new Models.Person()
                {
                    PersonID = 4,
                    Name = "Betty Rubble",
                    CreatedDateTime = DateTime.Now
                }
            });
        }

        [TestMethod]
        public void ShouldGetTestPeople()
        {
            // Arrange
            var repo = new PersonRepository(MockContext.Object);

            // Act
            var output = repo.GetAll();

            // Assert
            Assert.IsNotNull(output);
            Assert.IsTrue(output.Count() == 4);
            MockContext.Verify(c => c.GetPeople(), Times.Once);
        }

        [TestMethod]
        public void ShouldCallInsertPerson()
        {
            // Arrange
            var repo = new PersonRepository(MockContext.Object);
            var name = "Pierce Brosnan";

            // Act
            repo.InsertPerson(name);

            // Assert
            MockContext.Verify(c => c.InsertPerson(It.IsAny<string>()), Times.Once);
        }
    }
}
