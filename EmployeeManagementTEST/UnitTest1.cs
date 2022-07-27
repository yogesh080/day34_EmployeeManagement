using day34_EmployeeManagement;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Globalization;
namespace EmployeeManagementTEST
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GivenSalary_Able_toUpdateSalary()
        {
            //Arrange
            EmployeeRepo salary = new EmployeeRepo();

            SalaryUpdateModel Updatemodel = new SalaryUpdateModel()
            {
                SalaryId = 2,
                Month ="jan",
                EmployeeSalary = 1300,
                EmployeeId = 2

            };

            //ACT

            int EmpSalary = EmployeeRepo.UpdatingSalaryModel(Updatemodel);

            Assert.Equals(Updatemodel.EmployeeSalary, EmpSalary);
        }
    }
}