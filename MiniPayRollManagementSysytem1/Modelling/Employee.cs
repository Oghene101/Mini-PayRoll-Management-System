using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniPayRollManagementSysytem1.Modelling
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime PayDate { get; set; }
        public double RegularHours { get; set; }
        public double OvertimeHours { get; set; }

        private double regularRate;
        private double overtimeRate;

        public double RegularRate
        {
            get { return regularRate; }
        }

        public double OvertimeRate
        {
            get { return overtimeRate; }
        }

        public double GrossPay {  get;  set; }
        public double NetPay { get;  set; }
        public double Medicals { get; set; }
        public double Rent { get; set; }
        public double Food { get; set; }


        public Employee(double regularRate, double overtimeRate)
        {
            this.regularRate = regularRate;
            this.overtimeRate = overtimeRate;
        }

        public void CalculatePayRoll()
        {
            if(IsActive )
            {
                GrossPay = (RegularHours * RegularRate) + (OvertimeHours * OvertimeRate);
                Medicals = 0.02 * GrossPay;
                Rent = 0.05 * GrossPay;
                Food = 0.03 * GrossPay;

                NetPay = GrossPay - (Medicals + Rent + Food);

            }
        }


    }
}
