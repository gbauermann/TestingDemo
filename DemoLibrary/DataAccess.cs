using DemoLibrary.Models;
using System;
using System.Collections.Generic;
using System.IO;

namespace DemoLibrary
{
    public static class DataAccess
    {
        private static string personTextFile = "PersonText.txt";

        public static void AddNewPerson(PersonModel person)
        {
            
            var people = GetAllPeople();

            AddPersonToList(person, people);

            var lines = ConvertModelsToCsv(people);

            File.WriteAllLines(personTextFile, lines);
        }

        public static List<PersonModel> GetAllPeople()
        {
            var output = new List<PersonModel>();
            string[] content = File.ReadAllLines(personTextFile);

            foreach (var line in content)
            {
                var data = line.Split(',');
                output.Add(new PersonModel() { FisrtName = data[0], LastName = data[1] });
            }

            return output;
        }

        #region métodos criados para fins de teste unitário

        public static void AddPersonToList(PersonModel person, List<PersonModel> people)
        {
            if (string.IsNullOrWhiteSpace(person.FisrtName))
            {
                throw new ArgumentException("Valor inválido", "person.FirstName");
            }

            if (string.IsNullOrWhiteSpace(person.LastName))
            {
                throw new ArgumentException("Valor inválido", "person.LastName");
            }

            people.Add(person);
        }

        public static List<string> ConvertModelsToCsv(List<PersonModel> people)
        {
            var output = new List<string>();

            foreach (var user in people)
            {
                output.Add($"{user.FisrtName},{user.LastName}");
            }

            return output;
        }

        #endregion
    }
}
