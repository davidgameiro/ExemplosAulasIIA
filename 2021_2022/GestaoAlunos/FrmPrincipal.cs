using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestaoAlunos
{
    public partial class FrmPrincipal : Form
    {
        MySqlConnection mySqlConnection = new MySqlConnection();
        MySqlCommand MySqlCommand = new MySqlCommand();

        MySqlDataReader mySQLReader;

        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void btConectar_Click(object sender, EventArgs e)
        {
            mySqlConnection.ConnectionString = "Server=127.0.0.1; user id=root; password=12345; database=recursos";
            try
            {
                mySqlConnection.Open();
                MySqlCommand.Connection = mySqlConnection;
            }catch(Exception ex)
            {
                mySqlConnection.Close();
                MessageBox.Show("Erro ao conectar " + ex.Message);
            }

        }

        private void btLerBD_Click(object sender, EventArgs e)
        {
            if(mySqlConnection.State != ConnectionState.Open)
            {
                MessageBox.Show("necessario conexão ao servidor");
                return;
            }
            string query = "select id,  Nome, NMecanografico, Telefone from `dados_al`;";

            MySqlCommand.CommandText = query;
            mySQLReader = MySqlCommand.ExecuteReader();
            rbDados.Clear();
            while(mySQLReader.Read())
            {
                int id = mySQLReader.GetInt16(0);
                string Nome = mySQLReader.GetString(1);
                string NMeca = mySQLReader["NMecanografico"].ToString();//mySQLReader.GetString(2);
                string Telefone = mySQLReader["Telefone"].ToString();
                rbDados.AppendText(id.ToString()+"\t" + Nome+ "\t" + NMeca + "\t" + Telefone+"\n");
            }
            mySQLReader.Close();
        }

        private void btInserir_Click(object sender, EventArgs e)
        {
            if (mySqlConnection.State != ConnectionState.Open)
            {
                MessageBox.Show("necessario conexão ao servidor");
                return;
            }
            bool CamposValidos = !string.IsNullOrEmpty(txtNome.Text) & !string.IsNullOrEmpty(txtNMeca.Text) & !string.IsNullOrEmpty(txtTelefone.Text);

            if(!CamposValidos)
            {
                return;
            }
            string query = "insert into dados_al(Nome, NMecanografico, telefone) values('"+ txtNome.Text + "', '"+ txtNMeca.Text + "', '"+ txtTelefone.Text + "');";

            MySqlCommand.CommandText = query;

            MySqlCommand.ExecuteNonQuery();


            txtId.Clear();
            txtNMeca.Clear();
            txtNome.Clear();
            txtTelefone.Clear();
            btLerBD_Click(null, null);
        }

        private void btLerRegisto_Click(object sender, EventArgs e)
        {
            if (mySqlConnection.State != ConnectionState.Open)
            {
                MessageBox.Show("necessario conexão ao servidor");
                return;
            }
            int id;
            if (!int.TryParse(txtId.Text, out id))//verifico se existe 1 inteiro na caixa de texto
            {
                return;
            }
            string query = "select Nome, NMecanografico, Telefone from dados_al where id='"+id.ToString()+"';";
            //select Nome, NMecanografico, Telefone from dados_al where id='3';

            MySqlCommand.CommandText = query;
            mySQLReader = MySqlCommand.ExecuteReader();
            txtNMeca.Clear();
            txtNome.Clear();
            txtTelefone.Clear();
            if (mySQLReader != null)
            {
                while(mySQLReader.Read())
                {
                    txtNome.Text = mySQLReader.GetString(0);
                    txtNMeca.Text = mySQLReader.GetString(1);
                    txtTelefone.Text = mySQLReader.GetString(2);
                }
                mySQLReader.Close();
            }
            btLerBD_Click(null, null);
        }

        private void btApagar_Click(object sender, EventArgs e)
        {
            if (mySqlConnection.State != ConnectionState.Open)
            {
                MessageBox.Show("necessario conexão ao servidor");
                return;
            }
            int id;
            if (!int.TryParse(txtId.Text, out id))//verifico se existe 1 inteiro na caixa de texto
            {
                return;
            }
            string query = "DELETE FROM `dados_al` WHERE (`id` = '"+ id.ToString() + "');";
            //select Nome, NMecanografico, Telefone from dados_al where id='3';

            MySqlCommand.CommandText = query;
            MySqlCommand.ExecuteNonQuery();
            btLerBD_Click(null, null);
        }
    }
}
