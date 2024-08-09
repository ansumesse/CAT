
using System;

namespace Tasks.Part_2
{
    public class Employee
    {
        public Employee() { }
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime HireDate { get; set; }

        public string Gender { get; set; }

        public string Department { get; set; }
         
        public bool HasHealthInsurance { get; set; }

        public bool HasPensionPlan { get; set; }

        public decimal Salary { get; set; }

        public override bool Equals(object? obj)
        {
            if (obj is null)
                return false;
            if (obj.GetType() != this.GetType())
                return false;

            var temp = (Employee)obj;
            return temp.FirstName.Equals(this.FirstName)
                && temp.LastName.Equals(this.LastName)
                && temp.HireDate.Equals(this.HireDate)
                && temp.Gender.Equals(this.Gender)
                && temp.Department.Equals(this.Department)
                && temp.HasHealthInsurance.Equals(this.HasHealthInsurance)
                && temp.HasPensionPlan.Equals(this.HasPensionPlan)
                && temp.Salary.Equals(this.Salary);
        }
        public override int GetHashCode()
        {
            int hash = 47;
            hash *= 13 + FirstName.GetHashCode();
            hash *= 13 + LastName.GetHashCode();
            hash *= 13 + HireDate.GetHashCode();
            hash *= 13 + Gender.GetHashCode();
            hash *= 13 + Department.GetHashCode();
            hash *= 13 + HasHealthInsurance.GetHashCode();
            hash *= 13 + HasPensionPlan.GetHashCode();
            hash *= 13 + Salary.GetHashCode();

            return hash;
        }
        public override string ToString()
        {
            return
                    string.Format($"" +
                    $"{Id}\t" +
                    $" {String.Concat(LastName, ", ", FirstName).PadRight(15, ' ')}\t" + 
                    $"{HireDate.Date.ToShortDateString()}\t" +
                    $"{Gender.PadRight(10, ' ')}\t" +
                    $"{Department.PadRight(10, ' ')}\t" +
                    $"{HasHealthInsurance}\t" +
                    $"{HasPensionPlan}\t" +
                    $"${Salary.ToString("0.00")}");
        }
    }

    
}
