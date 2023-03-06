using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VeterinaryCrud.Model;
using System.Data.SqlClient;
using System.Data.Common;
using System.Data;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.Devices;

namespace VeterinaryCrud.Repository
{
    public class PetRepository: IPetRepository
    {
        private string connectionString = "Data Source=177.125.253.204,5050;Initial Catalog=Abner_Database_Estudo;Persist Security Info=True;User ID=abner;Password=Abiner081!";

        public void Add(Pet pet)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Edit(Pet pet)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Pet> GetAll()
        {
           var petList = new List<Pet>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "select * from Pet order by id desc";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var id = (int)reader[0];
                        var name = reader[1].ToString();
                        var type = reader[2].ToString();
                        var color = reader[3].ToString();

                        Console.WriteLine(name, type, color);

                        Pet pet = new(id, name, type, color);
                        petList.Add(pet);
                    }
                   
                }
            }

            return petList;
        }

      
        public IEnumerable<Pet> GetByValue(string value)
        {

            var petList = new List<Pet>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand())
            {
                int petId = int.TryParse(value, out _) ? Convert.ToInt32(value) : 0;
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"select * from Pet where id=@id or name LIKE '%@name1%' order by id desc";
                command.Parameters.Add("@id", SqlDbType.Int).Value = petId;
                command.Parameters.Add("@name", SqlDbType.VarChar).Value = value;

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var id = (int)reader[0];
                        var name = reader[1].ToString();
                        var type = reader[2].ToString();
                        var color = reader[3].ToString();

                        Pet pet = new(id, name, type, color);
                        petList.Add(pet);
                    }

                }
            }

            return petList;
        }
    }
}
