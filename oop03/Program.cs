namespace oop03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee[] employees = new Employee[3];

            employees[0] = new Employee(1, "Ahmed", Gender.M, 12000, SecurityLevel.DBA, new HireDate(1, 1, 2022));
            employees[1] = new Employee(2, "Mona", Gender.F, 6000, SecurityLevel.Guest, new HireDate(5, 6, 2023));
            employees[2] = new Employee(3, "Ali", Gender.M, 15000, SecurityLevel.SecurityOfficer, new HireDate(15, 4, 2020));

            foreach (Employee emp in employees){

                Console.WriteLine(emp);
                Console.WriteLine("===============================");
            }
            
        }
    }
}
