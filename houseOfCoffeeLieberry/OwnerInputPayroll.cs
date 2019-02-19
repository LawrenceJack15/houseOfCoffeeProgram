using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace houseOfCoffeeLieberry
{
    public class OwnerInputPayroll
    {
        public enum Employees { Jackie, Fuentes, Cantwell, Cortes, Elaine }
        public void ownerInputPayroll()
        {
            int emphrs;
            double GrandPayroll;
            double S = 0, SumS = 0, SumO = 0, O = 0;
            Employees Name = Employees.Jackie;

            foreach (Employees employees in (Employees[]) Enum.GetValues(typeof(Employees)))
            {
                Restart:
                try
                {
                    Console.WriteLine($" How many hours did {Name} work this week?");
                    emphrs = checked(Convert.ToInt32(Console.ReadLine()));
                    if ((emphrs <= 40) && (emphrs >= 0))
                    {
                        S = Convert.ToInt32(empPayroll(emphrs));
                        SumS += S;
                    }
                    else if ((emphrs > 40) && (emphrs >= 0))
                    {
                        O = Convert.ToInt32(empOvertime(emphrs));
                        SumO += O;
                    }
                    else
                    {
                        Console.WriteLine("Please enter a number greater than or equal to 0");
                        goto Restart;
                    }
                }
                catch (Exception Error)
                {
                    Console.WriteLine(Error.Message.ToString());
                    goto Restart;
                }
                Name++;
            }
            GrandPayroll = grandP(SumS, SumO);

            Console.WriteLine($"Standard payroll = {SumS:c}\n");
            Console.WriteLine($"Standard payroll = {SumO:c}\n");
            Console.WriteLine($"The grand total for this weeks payroll = {GrandPayroll}");
        }
        public static double empPayroll(int hrs)
        {
            return hrs * 12.50;
        }
        public static double empOvertime(int hrs)
        {
            return ((hrs - 40) * 18.75) + 500;
        }
        public static double grandP(double e1,double e2)
        {
            return e1 + e2;
        }
    }
}
