using MagazinAuto.Models;
using Npgsql;
using StatisticsDashboard.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace DuplicateService
{
    public class Service
    {
        private const string connectionString = "Server=localhost;Port=5432;Database=postgres;Username=postgres;Password=postgres";
        public List<Car> GetCars()
        {
            var sql = "SELECT * FROM public.anunturi";
            var result = new List<Car>();
            using (var connection = new NpgsqlConnection(connectionString))
            {
                using (var command = new NpgsqlCommand(sql, connection))
                {
                    connection.Open();

                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            result.Add(new Car
                            {
                                Id = (Guid)reader[0],
                                Caroserie = (Caroserie)decimal.ToInt32((decimal)reader[1]),
                                Cutie = (Cutie)decimal.ToInt32((decimal)reader[2]),
                                Transmisie = (Transmisie)decimal.ToInt32((decimal)reader[3]),
                                NormaPoluare = (NormaPoluare)decimal.ToInt32((decimal)reader[4]),
                                Combustibil = (Combustibil)decimal.ToInt32((decimal)reader[5]),
                                CP = decimal.ToInt32((decimal)reader[6]),
                                CapacitateCilindrica = decimal.ToInt32((decimal)reader[7]),
                                Km = decimal.ToInt32((decimal)reader[8]),
                                Pret = decimal.ToInt32((decimal)reader[9]),
                                AnFabricatie = decimal.ToInt32((decimal)reader[10]),
                                Marca = (string)reader[11],
                                Model = (string)reader[12],
                                Descriere = (string)reader[13]
                            });
                        }
                    }
                }
            }

            return result;
        }
        public Stats GetStats(List<Car> cars)
        {
            return new Stats
            {
                Automata = cars.Count(c => c.Cutie == Cutie.Automata),
                Manuala = cars.Count(c => c.Cutie == Cutie.Manuala),
                Benzina = cars.Count(c => c.Combustibil == Combustibil.Benzina),
                Disel = cars.Count(c => c.Combustibil == Combustibil.Disel),
                Electrica = cars.Count(c => c.Combustibil == Combustibil.Electric),
                GPL = cars.Count(c => c.Combustibil == Combustibil.GPL)
            };
        }
    }
}
