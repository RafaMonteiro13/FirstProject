using MySql.Data.MySqlClient;
using System;

namespace FirstProject
{
    public partial class index : System.Web.UI.Page
    {
        Conexao conexao;

        protected void Page_Load(object sender, EventArgs e)
        {
            conexao = new Conexao();
        }

        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            if(txtnome.Text == null)
            {
                lblMensagemErro.Text = "Preencha o campo nome!";
                return;
            } else if (txtdescricao.Text == null){

                lblMensagemErro.Text = "Preencha o campo descrição!";

            } else if(txtvalor.Text == null){

                lblMensagemErro.Text = "Preencha o campo valor!";

            } else if(txtquantidade.Text == null){

                lblMensagemErro.Text = "Preencha o campo quantidade!";
            }

            Salvar();

        }


        private void Salvar()
        {
            
            string sql;
            sql = "INSERT INTO produtos (nome,descricao,valor,quantidade) VALUES (@nome,@descricao,@valor,@quantidade)";
            //MySqlConnection connection = new MySqlConnection("SERVER=localhost;DATABASE=produtos;UID=root;PWD=rafaq1w2e3r4##;PORT=3306;");
            //connection.Open();
            conexao.AbrirCon();
            MySqlCommand cmd = new MySqlCommand(sql, conexao.con);


            cmd.Parameters.AddWithValue("@nome", txtnome.Text);
            cmd.Parameters.AddWithValue("@descricao", txtdescricao.Text);
            cmd.Parameters.AddWithValue("@valor", txtvalor.Text);
            cmd.Parameters.AddWithValue("@quantidade", txtquantidade.Text);

            cmd.ExecuteReader();

            lblMensagemOk.Text = "Salvo com sucesso!";

            conexao.FecharCon();
        }

    }
}