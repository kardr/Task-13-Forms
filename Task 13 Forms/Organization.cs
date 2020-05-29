using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_13_Forms
{
    public class Organization : Client
    {
        public string name;
        public DateTime Date;
        public double number;
        public decimal sum;
        public Organization(string nname, DateTime ddate, double nnumber, decimal ssum)
        {
            name = nname;
            Date = ddate;
            number = nnumber;
            sum = ssum;
        }
        public override string Print()
        {
            string s = "";
            s += "\n\r" + "Hазвание:  " + name + "\n\r";
            s += "\n\r" + "Дата открытия счета:  " + Date + "\n\r";
            s += "\n\r" + "Номер счета:  " + number + "\n\r";
            s += "\n\r" + "Cумма на счету: " + sum + "\n\r";
            return s;
        }
        public override bool Quest(DateTime date)
        {
            if (Date == date)
                return true;
            return false;
        }
    }
}
