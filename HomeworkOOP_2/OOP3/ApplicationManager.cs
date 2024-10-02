using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    internal class ApplicationManager
    {
        //Method injection
        public void Apply(ILoanManager loanManager,ILoggerService loggerService)
        {
            //Başvuran bilgilerini değerlendirme
            //MortgageLoanManager mortgageLoanManager = new MortgageLoanManager(); // Doğru bir yöntem değil.

            loanManager.Calculate();
            loggerService.Log();

        }

        public void DoLoanPreInformation(List<ILoanManager> loans)
        {
            foreach (var loan in loans)
            {
                loan.Calculate();
            }
        }

    }
}
