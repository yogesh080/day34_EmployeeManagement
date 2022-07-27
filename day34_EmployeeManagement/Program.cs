namespace day34_EmployeeManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welcome to Employee Management system");

            EmployeeRepo employeeRepository = new EmployeeRepo();
            employeeRepository.GetAllemployee();


        }
    }
}