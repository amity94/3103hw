using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw3103
{
    class Program
    {
        static void Main(string[] args)
        {
            DAO d = new DAO();

            d.GetCountryAndItsCapitalCityName(1);
            d.GetCountryAndItsCapitalCityDetails(1);

            d.GetCountryAndItsCapitalCityName("Israel");
            d.GetCountryAndItsCapitalCityDetails("Israel");
        }
    }
}
