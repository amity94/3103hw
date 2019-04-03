using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw3103
{
    class Country
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int SizeKm { get; set; }
        public int BirthYear { get; set; }
        public int CapitalCity_Id { get; set; }

        public Country()
        {

        }

        public override string ToString()
        {
            return $"Country: {Name}, Id: {Id}, Size: {SizeKm}, Birth Year: {BirthYear}, Capital City {CapitalCity_Id}";
        }

    }
}
