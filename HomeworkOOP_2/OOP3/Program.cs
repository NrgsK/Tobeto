using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ILoanManager personalLoanManager = new PersonalLoanManager();
            VehicleLoanManager vehicleLoanManager = new VehicleLoanManager();
            MortgageLoanManager mortgageLoanManager = new MortgageLoanManager();
            
            ILoggerService databaseLoggerService=new DatabaseLoggerService();
            ILoggerService fileLoggerService=new FileLoggerService();


            //interface'lerde implemente edilen sınıfın referans numarasını tutar.

            ApplicationManager applicationManager = new ApplicationManager();
            applicationManager.Apply(mortgageLoanManager,databaseLoggerService);

            List<ILoanManager> loans = new List<ILoanManager>() { personalLoanManager,vehicleLoanManager};
            //applicationManager.DoLoanPreInformation(loans);


            Console.ReadKey();
        }
    }
}
