using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebAPIBasicAuth.DAL
{
    public class RoleAcess
    {
        public static bool IsUserInRole(String username, String roleName)
        {
            SqlConnection conn = new SqlConnection("IMPUT STRING CONNECTION");

            try
            {
                conn.Open();

                bool value = true;
                String sql = @"select * from usuario, token 
                                     where usuario.Token = token.Token  
                                     and UserName = @UserName
                                     and Servico = @Servico ";


                SqlCommand Command = new SqlCommand(sql, conn);
                Command.Parameters.Clear();
                Command.Parameters.Add("@UserName", System.Data.SqlDbType.VarChar, 0, "UserName").Value = username;
                Command.Parameters.Add("@Servico", System.Data.SqlDbType.VarChar, 0, "Servico").Value = roleName;
                SqlDataReader DR = Command.ExecuteReader();

                if ((DR.Read()) && (DR.HasRows))
                {
                    value = true;
                }
                else
                {
                    value = false;
                }

                DR.Close();
                return value;


            }
            finally
            {
                conn.Close();
            }

        }

        public static string[] GetUsers()
        {
            SqlConnection conn = new SqlConnection("IMPUT STRING CONNECTION");

            try
            {
                conn.Open();

                string[] value;
                String sql = @"select UserName from Usuario";

                SqlCommand Command = new SqlCommand(sql, conn);
                SqlDataReader DR = Command.ExecuteReader();

                if (DR.HasRows)
                {
                    DR.Read();
                    value = new string[DR.FieldCount];
                    for (int i = 0; i < DR.FieldCount; i++)
                    {
                        value[i] = DR[i].ToString();

                    }
                }
                else
                {
                    value = null;
                }

                DR.Close();
                return value;
            }
            finally
            {
                conn.Close();
            }

        }

        internal static bool GetUsers(string usuario, string senha)
        {
            SqlConnection conn = new SqlConnection("IMPUT STRING CONNECTION");

            try
            {
                conn.Open();

                bool value;
                String sql = @"select UserName from Usuario where UserName = @UserName and PassWord = @PassWord";

                SqlCommand Command = new SqlCommand(sql, conn);
                Command.Parameters.Clear();
                Command.Parameters.Add("@UserName", System.Data.SqlDbType.VarChar, 0, "UserName").Value = usuario;
                Command.Parameters.Add("@PassWord", System.Data.SqlDbType.VarChar, 0, "PassWord").Value = senha;
                SqlDataReader DR = Command.ExecuteReader();

                if ((DR.Read()) && (DR.HasRows))
                {
                    value = true;
                }
                else
                {
                    value = false;
                }

                DR.Close();
                return value;

            }
            finally
            {
                conn.Close();
            }
        }
    }
}