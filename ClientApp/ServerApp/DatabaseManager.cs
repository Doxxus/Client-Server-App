using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Newtonsoft.Json;

namespace ServerApp {
    class DatabaseManager : StorageManager {
        public override void init(string arg) {
            connector = arg;

            try {
                using (SqlConnection conn = new SqlConnection()) {
                    conn.ConnectionString = connector;
                    conn.Open();

                    Console.WriteLine("Initializing Database.");

                    try {
                        SqlCommand command = new SqlCommand("SELECT * FROM dbo.Clients", conn);

                        using (SqlDataReader reader = command.ExecuteReader()) {
                            while (reader.Read())
                            {
                                Console.WriteLine(String.Format("{0}, {1}",
                                    reader[0], reader[1]));
                            }
                        }
                    } catch (Exception e) {
                        SqlCommand command = new SqlCommand("CREATE TABLE dbo.Clients(" +
                            "FirstName varchar(255)," +
                            "LastName varchar(255)," +
                            "DateofBirth varchar(255)," +
                            "EmailAddress varchar(255)," +
                            "PhoneNumber varchar(255));", conn);

                        using (SqlDataReader reader = command.ExecuteReader()) {
                            while (reader.Read()) {
                                Console.WriteLine(String.Format("{0}, {1}",
                                    reader[0], reader[1]));
                            }
                        }
                    }
                }
            } catch (Exception e) {
                Console.WriteLine(e);
            }
        }

        public override bool save(ClientInfo client) {
            using (SqlConnection conn = new SqlConnection()) {
                conn.ConnectionString = connector;
                conn.Open();

                SqlCommand insertCommand = new SqlCommand("INSERT INTO dbo.Clients (FirstName, LastName, DateofBirth, EmailAddress, PhoneNumber) VALUES (@fn, @ln, @dob, @em, @ph)", conn);
                insertCommand.Parameters.Add("@fn", System.Data.SqlDbType.VarChar);
                insertCommand.Parameters["@fn"].Value = client.fname;
                insertCommand.Parameters.Add("@ln", System.Data.SqlDbType.VarChar);
                insertCommand.Parameters["@ln"].Value = client.lname;
                insertCommand.Parameters.Add("@dob", System.Data.SqlDbType.VarChar);
                insertCommand.Parameters["@dob"].Value = client.dateOfBirth;
                insertCommand.Parameters.Add("@em", System.Data.SqlDbType.VarChar);
                insertCommand.Parameters["@em"].Value = client.email;
                insertCommand.Parameters.Add("@ph", System.Data.SqlDbType.VarChar);
                insertCommand.Parameters["@ph"].Value = client.phone;

                try {
                    Int32 rowsAffected = insertCommand.ExecuteNonQuery();
                    Console.WriteLine("RowsAffected: {0}", rowsAffected);
                    return true;
                } catch (Exception e) {
                    Console.WriteLine(e.Message);
                    return false;
                }
            }
        }

        public override List<ClientInfo> collectClients() {
            List<ClientInfo> ret = new List<ClientInfo>();
            
            using (SqlConnection conn = new SqlConnection()) {
                conn.ConnectionString = connector;
                conn.Open();

                SqlCommand command = new SqlCommand("SELECT * FROM dbo.Clients", conn);
                using (SqlDataReader reader = command.ExecuteReader()) {
                    while (reader.Read()) {
                        ClientInfo temp = new ClientInfo();
                        
                        Console.WriteLine(String.Format("{0}, {1}, {2}, {3}, {4}",
                            reader[0], reader[1], reader[2], reader[3], reader[4]));

                        temp.fname = reader[0].ToString();
                        temp.lname = reader[1].ToString();
                        temp.dateOfBirth = reader[2].ToString();
                        temp.email = reader[3].ToString();
                        temp.phone = reader[4].ToString();

                        ret.Add(temp);
                    }
                }
            }

            return ret;
        }
    }
}
