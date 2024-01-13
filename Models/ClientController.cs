using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;
using CRUD_Clients.Models;

namespace CRUD_Clients.Models
{
    public class ClientController
    {
        private readonly string connectionString = "";

        public List<Client> GetAllClients()
        {
            List<Client> clients = new List<Client>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM Client";
                SqlCommand command = new SqlCommand(query, connection);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while(reader.Read())
                    {
                        clients.add(new Client
                        {
                            ID = Convert.ToInt32(reader["ID"]),
                            Name = reader["Name"].ToString(),
                            Number = reader["Number"].ToString(),
                            Email = reader["Email"].ToString()
                        });
                    }
                }
            }

            return clients;
        }

        public void AddClient(Client newClient)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "INSERT INTO Client (Name, Number, Email) VALUES (@Name, @Number, @Email)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Name", newClient.Name);
                command.Parameters.AddWithValue("@Number", newClient.Number);
                command.Parameters.AddWithValue("@Email", newClient.Email);

                command.ExecuteNonQuery();
            }
        }

        public void UpdateClient(Client updatedClient)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "UPDATE Client SET Name = @Name, Number = @Number, Email = @Email WHERE ID = @ID";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ID", updatedClient.ID);
                command.Parameters.AddWithValue("@Name", updatedClient.Name);
                command.Parameters.AddWithValue("@Number", updatedClient.Number);
                command.Parameters.AddWithValue("@Email", updatedClient.Email);

                command.ExecuteNonQuery();
            }
        }

        public void DeleteClient(int clientId)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "DELETE FROM Client WHERE ID = @ID";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ID", clientId);

                command.ExecuteNonQuery();
            }
        }
    }
}