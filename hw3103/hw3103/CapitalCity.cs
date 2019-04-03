using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw3103
{
    class CapitalCity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int _NumCitizens { get; set; }
        public int Country_Id { get; set; }

        public CapitalCity()
        {

        }

        public override string ToString()
        {
            return $"Capital City: {Name}, Id: {Id}, Number Of Citizens: {_NumCitizens}, Country: {Country_Id}";
        }
    }
}
