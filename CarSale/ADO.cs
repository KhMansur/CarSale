using CarSale.Models;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace CarSale
{
    internal class ADO
    {

        NpgsqlConnection conn = new NpgsqlConnection("Server = localhost; User id = postgres; Password = 12345678mn; database = carsale");


    public async Task Add()
        {

          

           await conn.OpenAsync();

            await using (var cmd = new NpgsqlCommand("INSERT INTO car (Model, Narxi) VALUES (@Model, @Narxi)", conn))
            {
                cmd.Parameters.AddWithValue("Model", Console.ReadLine());
                cmd.Parameters.AddWithValue("Narxi", int.Parse(Console.ReadLine()));

                cmd.ExecuteReaderAsync();
            }
            
               
            
        }


        //public async Task<Car> GetALL()
        //{
        //    await using var conn = new NpgsqlConnection(connString);
        //    await conn.OpenAsync();

        //    string commandText = "SELECT * FROM CarSale";

        //    await using (NpgsqlCommand cmd = new NpgsqlCommand(commandText, conn))
        //    {
        //        await using (NpgsqlDataReader reader = await cmd.ExecuteReaderAsync())
        //            while (await reader.ReadAsync())
        //            {
        //                Car car = new Car();
        //                car.Model = reader["Model"] as string;
        //                car.Narxi = reader["Narxi"] as int?;

        //                Console.WriteLine(car.Model, car.Narxi);

        //            }
        //    }

        //    return null;
        //}
    }
}
