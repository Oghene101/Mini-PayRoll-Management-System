global using Xunit;
using MiniPayRollManagementSysytem1.Modelling;

namespace TestProject1
{
    public class TestPayroll
    {
        [Fact]
        public void Employee_CalculatePayroll_ToCalculateCorrectPayroll()
        {   
            //Arrange
            var employee = new Employee(regularRate:100, overtimeRate:150);
            employee.OvertimeHours = 10;
            employee.RegularHours = 10;
            employee.IsActive = true;

            //Act
            employee.CalculatePayRoll();

            //Assert
            Assert.Equal(2500, employee.GrossPay);
            Assert.NotEqual(5, employee.Medicals);
            //Assert.


        }

        
    }
}
