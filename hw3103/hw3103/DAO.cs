using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw3103
{
    class DAO
    {
        SQLiteCommand cmd;
        public static string path = @"C:\Users\Amity\Desktop\לימודים\hw3103\3103hw.db";
        SQLiteConnection con = new SQLiteConnection($"Data Source = {path}; Version = 3;");

        public DAO()
        {

        }

        public void GetCountryAndItsCapitalCityName(int countryid)
        {
            con.Open();
            using (cmd =  new SQLiteCommand($"select Country.name, CapitalCity.name from Country " +
                $"join CapitalCity on Country.CapitalCity_id = CapitalCity.id where Country.id = {countryid}", con))
            {
                using (SQLiteDataReader reader = cmd.ExecuteReader())
                {
                    while(reader.Read() == true)
                    {
                        Country c = new Country
                        {
                            Name = (string)reader["name"],
                        };

                        CapitalCity capc = new CapitalCity
                        {
                            Name = (string)reader["name"],
                        };
                    }
                }
            }
        }

        public void GetCountryAndItsCapitalCityDetails(int countryid)
        {
            con.Open();
            using (cmd = new SQLiteCommand($"select country.name, CapitalCity.Country_id, CapitalCity.NumCitizens, " +
                $"CapitalCity.id, CapitalCity.name from Country join CapitalCity on country.id = CapitalCity.id " +
                $"where Country.id = {countryid}", con))
            {
                using (SQLiteDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read() == true)
                    {
                        Country c = new Country
                        {
                            Name = (string)reader["name"],
                        };

                        CapitalCity capc = new CapitalCity
                        {
                            Id = (int)reader["id"],
                            Name = (string)reader["name"],
                            _NumCitizens = (int)reader["NumCitizens"],
                            Country_Id = (int)reader["Country_id"]
                        };

                        Console.WriteLine($"{c} {capc}");
                    }
                }
            }
        }

        public void GetCountryAndItsCapitalCityName(string countryname)
        {

        }

        public void GetCountryAndItsCapitalCityDetails(string countryname)
        {

        }


    }
}
