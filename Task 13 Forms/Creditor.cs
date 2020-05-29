using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_13_Forms
{
    public class Creditor : Client
    {
        public string Famil;
        public DateTime Date;
        public double prozent;
        public decimal razmer, osta;
        public Creditor(string famil, DateTime ddate, decimal rrazmer, double pprozent, decimal oosta)
        {
            Famil = famil;
            Date = ddate;
            razmer = rrazmer;
            prozent = pprozent;
            osta = oosta;
        }
        public override string Print()
        {
            string s = "";
            s += "\n\r" + "Фамилия:  " + Famil + "\n\r";
            s += "\n\r" + "Дата открытия вклада:  " + Date + "\n\r";
            s += "\n\r" + "Размер вклада:  " + razmer + "\n\r";
            s += "\n\r" + "Процент по вкладу:  " + prozent + "\n\r";
            s += "\n\r" + "Остаток долга: " + osta + "\n\r";
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
