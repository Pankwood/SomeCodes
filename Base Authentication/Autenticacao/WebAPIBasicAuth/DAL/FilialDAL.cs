using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using WebAPIBasicAuth.Models;

namespace WebAPIBasicAuth.DAL
{
    public class FilialDAL
    {
        public static ListaFilial ListaFilial(String filial)
        {
            SqlConnection conn = new SqlConnection("IMPUT STRING CONNECTION");

            try
            {
                conn.Open();

                String sqlFilial = "Select Endereco, Bairro, Uf, Telefone, Cidade";
                sqlFilial += " from filial ";
                sqlFilial += " where Ativo = 'S' ";

                SqlDataAdapter dapFilial = new SqlDataAdapter(sqlFilial, conn);
                DataTable dtsFilial = new DataTable();

                dapFilial.Fill(dtsFilial);

                List<Filial> lus = new List<Filial>();
                Filial us = null;

                if (dtsFilial.Rows.Count != 0)
                {
                    for (int i = 0; i <= dtsFilial.Rows.Count - 1; i++)
                    {
                        us = new Filial();
                        us.Endereco = dtsFilial.Rows[i]["Endereco"].ToString();
                        us.Bairro = dtsFilial.Rows[i]["Bairro"].ToString();
                        us.UF = dtsFilial.Rows[i]["UF"].ToString();
                        us.Telefone = dtsFilial.Rows[i]["Telefone"].ToString();
                        us.Cidade = dtsFilial.Rows[i]["Cidade"].ToString();
                        lus.Add(us);
                    }
                }

                ListaFilial list = new ListaFilial();
                list.Filial = lus;

                return list;
            }
            finally
            {
                conn.Close();
            }
        }
    }
}