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
        public static string path = @"C:\Users\HackerU\Desktop\3103hw.db";

        SQLiteConnection con = new SQLiteConnection($"Data Source = {path}; Version = 3;");

        public DAO()
        {
            con.Open();
        }

        public void GetCountryAndItsCapitalCityName(int countryid)
        {
            var ad = default(object);
            using (cmd =  new SQLiteCommand($"select Country.name, CapitalCity.capname from Country" +
                $" join CapitalCity on Country.CapitalCity_id = CapitalCity.id where Country.id ={countryid};" ,con))
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
                            capName = (string)reader["capname"],
                        };

                        ad = new { c.Name, capc.capName } ;
                    }
                }
            }
            Console.WriteLine(ad);
        }

        public void GetCountryAndItsCapitalCityDetails(int countryid)
        {
            var ad = default(object);
            using (cmd = new SQLiteCommand($"select country.name, CapitalCity.Country_id, CapitalCity.NumCitizens, " +
                $"CapitalCity.id, CapitalCity.capname from Country join CapitalCity on country.id = CapitalCity.id " +
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
                            capName = (string)reader["capname"],
                            _NumCitizens = (int)reader["NumCitizens"],
                            Country_Id = (int)reader["Country_id"]
                        };

                        ad = new { c.Name, capc.Country_Id, capc._NumCitizens, capc.Id, capc.capName };
                    }
                }
            }
            Console.WriteLine(ad);
        }

        public void GetCountryAndItsCapitalCityName(string countryname)
        {
            var ad = default(object);
            using (cmd = new SQLiteCommand($"select Country.name, CapitalCity.capname from Country" +
                $" join CapitalCity on Country.CapitalCity_id = CapitalCity.id where Country.name ='{countryname}';", con))
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
                            capName = (string)reader["capname"],
                        };

                        ad = new { c.Name, capc.capName };
                    }
                }
            }
            Console.WriteLine(ad);
        }

        public void GetCountryAndItsCapitalCityDetails(string countryname)
        {
            var ad = default(object);
            using (cmd = new SQLiteCommand($"select country.name, CapitalCity.Country_id, CapitalCity.NumCitizens, " +
                $"CapitalCity.id, CapitalCity.capname from Country join CapitalCity on country.id = CapitalCity.id " +
                $"where Country.name ='{countryname}'", con))
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
                            capName = (string)reader["capname"],
                            _NumCitizens = (int)reader["NumCitizens"],
                            Country_Id = (int)reader["Country_id"]
                        };

                        ad = new { c.Name, capc.Country_Id, capc._NumCitizens, capc.Id, capc.capName };
                    }
                }
            }
            Console.WriteLine(ad);
        }
    }
}
