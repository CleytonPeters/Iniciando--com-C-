using System.Globalization;

namespace Aula78_ExercicioFixacao {
    class Employees {
        public int Id;
        public string Name;
        public double Salary;

        public void IncreaseSalary(double percentage) {
            Salary += ((Salary * percentage) / 100);
        }        
        public override string ToString() {
            return Id
                + ", "
                + Name
                + ", "
                + Salary.ToString("F2", CultureInfo.InvariantCulture);
        }


    }
}
