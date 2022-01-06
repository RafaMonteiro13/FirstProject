using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FirstProject
{
    public class Conexao
    {
        public string conec = "SERVER=localhost;DATABASE=produtos;UID=root;PWD=rafaq1w2e3r4##;PORT=3306;";
        public MySqlConnection con;

        public void AbrirCon()
        {
            try
            {
                con = new MySqlConnection(conec);
                con.Open();
            }
            catch (Exception x)
            {

                HttpContext.Current.Response.Write("Erro ao abrir conexão!!" + x);
            }
        }

        public void FecharCon()
        {
            try
            {
                con = new MySqlConnection(conec);
                con.Close();
            }
            catch (Exception x )
            {
                HttpContext.Current.Response.Write("Erro ao fechar conexão!!" + x);
            }
        }
    }
}