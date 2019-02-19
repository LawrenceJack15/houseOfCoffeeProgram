using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace houseOfCoffeeLieberry
{
    public class OwnerInputSales
    {
        public void ownerInput()
        {
            OwnerInputSales owner = new OwnerInputSales();

            int smallNum, mediumNum, largeNum, eggNum, chickenNum;
            double smallp, mediump, largep, eggp, chickenp, smallc, mediumc, largec, eggc, chickenc;
            double small, medium, large, egg, chicken, totalProfit, totalSales, totalCOGS;
            try
            {
                Console.WriteLine("How many small coffees has your shop sold this week?");
                smallNum = checked (Convert.ToInt32(Console.ReadLine()));

                Console.WriteLine("How many medium coffees has your shop sold this week?");
                mediumNum = checked(Convert.ToInt32(Console.ReadLine()));

                Console.WriteLine("How many large coffees has your shop sold this week?");
                largeNum = checked(Convert.ToInt32(Console.ReadLine()));

                Console.WriteLine("How many egg sandwiches has your shop sold this week?");
                eggNum = checked(Convert.ToInt32(Console.ReadLine()));

                Console.WriteLine("How many chicken biscuits has your shop sold this week?");
                chickenNum = checked(Convert.ToInt32(Console.ReadLine()));

                smallp = totalsOfEach(smallNum, Item.psmall);
                mediump = totalsOfEach(mediumNum, Item.pmedium);
                largep = totalsOfEach(largeNum, Item.plarge);
                eggp = totalsOfEach(eggNum, Item.pegg);
                chickenp = totalsOfEach(chickenNum, Item.pchicken);

                smallc = totalsOfEach(smallNum, Item.csmall);
                mediumc = totalsOfEach(mediumNum, Item.cmedium);
                largec = totalsOfEach(largeNum, Item.clarge);
                eggc = totalsOfEach(eggNum, Item.cegg);
                chickenc = totalsOfEach(chickenNum, Item.cchicken);

                small = profitOfEach(smallNum, Item.psmall, Item.csmall);
                medium = profitOfEach(mediumNum, Item.pmedium, Item.cmedium);
                large = profitOfEach(largeNum, Item.plarge, Item.clarge);
                egg = profitOfEach(eggNum, Item.pegg, Item.cegg);
                chicken = profitOfEach(chickenNum, Item.pchicken, Item.cchicken);

                totalSales = totals(smallp, mediump, largep, eggp, chickenp);
                totalCOGS = totals(smallc, mediumc, largec, eggc, chickenc);
                totalProfit = small + medium + large + egg + chicken;

                Console.WriteLine($"Todays' Total Sales = {totalSales:c}");
                Console.WriteLine($"Todays' Total Cost of Goods Sold = {totalCOGS:c}");
                Console.WriteLine($"Todays' Total Profit = {totalProfit:c}");

            }
            catch(Exception Error)
            {
                Console.WriteLine(Error.Message.ToString());
            }
        }
        public static double totalsOfEach(int numOfItem, double s)
        {
            return numOfItem * s;
        }
        public static double profitOfEach(int numOfItem, double s, double cosToMake)
        {
            return numOfItem * (s + cosToMake);
        }
        public static double totals(double s, double m, double l, double e, double c)
        {
            return s + m + l + e + c;
        }
    }
}
