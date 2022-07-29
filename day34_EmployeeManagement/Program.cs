namespace day34_EmployeeManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welcome to Employee Management system");

            //EmployeeRepo repo = new EmployeeRepo();
            //repo.GetAllemployee();



            SalaryDetailModel salaryDetailModel = new SalaryDetailModel();

            salaryDetailModel.Month="jan";
            salaryDetailModel.EmployeeID=5;

            salaryDetailModel.EmployeeSalary = 300000;
            EmployeeRepo employeeRepository = new EmployeeRepo();

            employeeRepository.UpdatingSalaryModel(salaryDetailModel);



        }
    }
}