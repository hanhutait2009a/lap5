using System;

namespace Exercise2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var highSchooolTeacher = new HighSchoolTeacher()
            {
                IdentityNumber = "Id0001",
                Name = "Spring Hero",
                BaseSalary = 100,
                Level = 1,
                Bonus = 100,
                IsSenior = false,
            };
            Console.WriteLine(highSchooolTeacher.CulculateSalary());
            var universityTeacher = new UniversityTeacher()
            {
                IdentityNumber = "Id0002",
                Name = "Dao Xuan",
                BaseSalary = 60000,
                Level = 1,
                Bonus = 9000,
                IsSenior = true,
                EnglishLevel = 2,
                UniversityCode = "UN001"
            };
            Console.WriteLine(universityTeacher.CulculateSalary());
        }
    }
}