using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositionWorker.Entites
{
    internal class HourContract
    {
        public DateTime date { get; set; }
        public double ValuePerHour { get; set; }
        public int Hours { get; set; }


        public HourContract()
        {

        }

        public HourContract(DateTime date, double valuePerHour, int hours)
        {
            this.date = date;
            this.ValuePerHour = valuePerHour;
            this.Hours = hours;
        }

        public double TotalValue()
        {
            return Hours * ValuePerHour;
        }
    }
}
