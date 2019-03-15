using DemoLibrary;
using DemoLibrary.Models;
using System;
using System.Collections.Generic;
using Xunit;

namespace DemoLibrary_Tests
{
    public class DataAccessTest
    {
        [Fact]
        public void AddPersonToList_Test()
        {
            var newPerson = new PersonModel { FisrtName = "Gabriel", LastName = "Bauermann" };
            var people = new List<PersonModel>();

            DataAccess.AddPersonToList(newPerson, people);

            Assert.True(people.Count == 1);
            Assert.Contains<PersonModel>(newPerson, people);
        }

        [Theory]
        [InlineData("Gabriel", "", "person.LastName")]
        [InlineData("", "Bauermann", "person.FirstName")]
        public void AddPersonToList_TestInvalidParameter(string firstName, string lastName, string param)
        {
            var newPerson = new PersonModel { FisrtName = firstName, LastName = lastName };
            var people = new List<PersonModel>();

            Assert.Throws<ArgumentException>(param, () => DataAccess.AddPersonToList(newPerson, people));
        }

        [Fact]
        public void ConvertModelsToCsv_Test()
        {
            var name = "Gabriel,Bauermann";
            var expected = new List<string> { name };
            var newPerson = new PersonModel { FisrtName = "Gabriel", LastName = "Bauermann" };
            var people = new List<PersonModel>();

            DataAccess.AddPersonToList(newPerson, people);

            var actual = DataAccess.ConvertModelsToCsv(people);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void GetAllPeople_Test()
        {
            var expected = DataAccess.GetAllPeople();

            Assert.NotNull(expected);
            Assert.True(expected.Count > 0);
            Assert.IsType<List<PersonModel>>(expected);
        }
    }
}
