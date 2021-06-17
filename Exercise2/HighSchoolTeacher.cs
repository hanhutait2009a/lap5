namespace Exercise2
{
    public class HighSchoolTeacher :AbstractTeacher
    {
        public override double CulculateSalary()
        {
            if (Bonus>10000)
            {
                throw new AmountException("Bonus is more than 10,000", Name);
            }

            var salary = BaseSalary * Level * Bonus;
            if (IsSenior && salary < 60000)
            {
                throw new AmountException("Senior Lecturer gets less than 60,000 ,salary",salary);
            }

            return salary;
        }
    }
}