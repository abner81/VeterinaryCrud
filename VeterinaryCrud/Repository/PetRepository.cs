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
using System.Drawing;
using System.Globalization;

namespace VeterinaryCrud.Repository
{
    public class PetRepository : IPetRepository
    {
        private string connectionString = "Data Source=177.125.253.204,5050;Initial Catalog=Abner_Database_Estudo;Persist Security Info=True;User ID=abner;Password=Abiner081!";

        private void ConnectionFactory(Action<SqlCommand> func)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                func(command);
            }
        }

        public void Add(Pet pet)
        {
            ConnectionFactory(command =>
            {
                command.CommandText = "insert into Pet values (@name, @type, @color)";
                command.Parameters.Add("@name", SqlDbType.VarChar).Value = pet.Name;
                command.Parameters.Add("@type", SqlDbType.VarChar).Value = pet.Type;
                command.Parameters.Add("@color", SqlDbType.VarChar).Value = pet.Color;

                command.ExecuteNonQuery();
            });
        }

        public void Delete(int id)
        {
            ConnectionFactory(command =>
            {
                command.CommandText = "delete from Pet where id=@id";
                command.Parameters.Add("@id", SqlDbType.Int).Value = id;

                command.ExecuteNonQuery();
            });
        }

        public void Edit(Pet pet)
        {
            ConnectionFactory(command =>
            {
                command.CommandText = "update Pet set name=@name, type=@type, color=@color where id=@id";
                command.Parameters.Add("@name", SqlDbType.VarChar).Value = pet.Name;
                command.Parameters.Add("@type", SqlDbType.VarChar).Value = pet.Type;
                command.Parameters.Add("@color", SqlDbType.VarChar).Value = pet.Color;
                command.Parameters.Add("@id", SqlDbType.Int).Value = pet.Id;

                command.ExecuteNonQuery();
            });
        }

        private string transformPascalCase(string value) {
            TextInfo myTI = new CultureInfo("pt-BR", false).TextInfo;
            return myTI.ToTitleCase(value);
        }

        private Pet PetFactory(SqlDataReader reader)
        {

            var id = (int)reader[0];
            var name = transformPascalCase( reader[1].ToString());
            var type = transformPascalCase(reader[2].ToString());
            var color = transformPascalCase(reader[3].ToString());

            return new Pet(id, name, type, color);
        }




        public IEnumerable<Pet> GetAll()
        {
            var petList = new List<Pet>();
            ConnectionFactory(command =>
            {
                command.CommandText = "select * from Pet order by id desc";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var pet = PetFactory(reader);
                        petList.Add(pet);
                    }
                }
            });
            return petList;
        }

        public IEnumerable<Pet> GetByValue(string value)
        {
            var petList = new List<Pet>();
            ConnectionFactory(command =>
            {
                int petId = int.TryParse(value, out _) ? Convert.ToInt32(value) : 0;
                command.CommandText = @"select * from Pet where id=@id or name LIKE '%@name1%' order by id desc";
                command.Parameters.Add("@id", SqlDbType.Int).Value = petId;
                command.Parameters.Add("@name", SqlDbType.VarChar).Value = value;

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var pet = PetFactory(reader);
                        petList.Add(pet);
                    }

                }
            });

            return petList;
        }
    }
}
