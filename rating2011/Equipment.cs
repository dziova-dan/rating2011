using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rating2011
{
    public class Equipment
    {
        public string Type { get; set; }
        public string Brand { get; set; }
        public int AvailableCount { get; set; }

        public Equipment(string type, string brand, int count)
        {
            Type = type;
            Brand = brand;
            AvailableCount = count;
        }

        public override string ToString()
        {
            return $"{Type} {Brand} (Доступно: {AvailableCount})";
        }
    }

    public class Booking
    {
        public Equipment Eq { get; set; }
        public string ForemanName { get; set; }
        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }

        public override string ToString()
        {
            return $"{Eq.Type} {Eq.Brand} | Прораб: {ForemanName} | До: {DateTo:dd.MM.yyyy}";
        }
    }


}
