using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using houseOfCoffeeLieberry;

namespace houseOfCoffeeProgramUsingStructsAndEnums
{
    class Program
    {
        static void Main(string[] args)
        {
            OwnerInputSales ownerInput = new OwnerInputSales();
            ownerInput.ownerInput();
            OwnerInputPayroll ownerInputPayroll = new OwnerInputPayroll();
            ownerInputPayroll.ownerInputPayroll();
        }
    }
}
