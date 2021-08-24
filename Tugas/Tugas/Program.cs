using System;
using RomanNumerals;

namespace Tugas
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 10982;
            Console.WriteLine(Generated(counter));

        }
        static string Generated(int angka)
         {
            angka++;
            string getmonth, getyear,getdayNum,getdayAlp,getyear2Dig;
            string hasil;
            int dateNum, yearInt;
            DateTime hariini = DateTime.Today;
            getmonth = hariini.ToString("MM");
            getyear = hariini.ToString("yyyy");
            getdayNum = hariini.ToString("ddd");
            dateNum = (int)hariini.Day;
            getdayAlp = getdayNum.Substring(0, 2);
            getyear2Dig = getyear.Substring(2, 2);
            yearInt = Convert.ToInt32(getyear2Dig);
            var getdate =  new RomanNumeral(dateNum);
            var getyearNum = new RomanNumeral(yearInt);
            hasil = $"INV/{getyear}{getmonth}/{getdayAlp.ToUpper()}/{getdate}/{getyearNum}/{angka}";
            return hasil;
         }
    }
}
