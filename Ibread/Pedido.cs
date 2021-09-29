using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace Ibread
{
    public partial class Pedido : UserControl
    {
        public Pedido()
        {
            InitializeComponent();
        }

       
        private MySqlConnectionStringBuilder conexaoBanco()
        {
            MySqlConnectionStringBuilder conexaoBD = new MySqlConnectionStringBuilder();
            conexaoBD.Server = "localhost";
            conexaoBD.Database = "ibread";
            conexaoBD.UserID = "root";
            conexaoBD.Password = "";
            conexaoBD.SslMode = 0;
            return conexaoBD;
        }

        private void Pedido_Load(object sender, EventArgs e)
        {
            atualizaGrid();
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Roboto", 10);
        }

        private void atualizaGrid()
        {
            MySqlConnectionStringBuilder conexaoBD = conexaoBanco();
            MySqlConnection realizaConexacoBD = new MySqlConnection(conexaoBD.ToString());
            try
            {
                realizaConexacoBD.Open();

                MySqlCommand comandoMySql = realizaConexacoBD.CreateCommand();
                comandoMySql.CommandText = "SELECT * FROM ibread";
                MySqlDataReader reader = comandoMySql.ExecuteReader();

                dataGridView1.Rows.Clear();

                while (reader.Read())
                {
                    DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[0].Clone();//FAZ UM CAST E CLONA A LINHA DA TABELA
                    row.Cells[1].Value = reader.GetString(1);//NOME
                    row.Cells[2].Value = reader.GetString(2);//CPF
                    row.Cells[3].Value = reader.GetString(3);//TELEFONE
                    row.Cells[4].Value = reader.GetString(4);//QUANTIDADE PÃO
                    dataGridView1.Rows.Add(row);//ADICIONO A LINHA NA TABELA
                }

                realizaConexacoBD.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection ! ");
                Console.WriteLine(ex.Message);
            }
        }
        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }


        private void tbNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void bLimpar_Click_1(object sender, EventArgs e)
        {
            limparCampos();
        }
 
        private void limparCampos()
        {
            tbNome.Clear();
            tbCPF.Clear();
            tbTelefone.Clear();
            tbPaes.Clear();
        }

        private void bInserir_Click(object sender, EventArgs e)
        {
            {
                MySqlConnectionStringBuilder conexaoBD = conexaoBanco();
                MySqlConnection realizaConexacoBD = new MySqlConnection(conexaoBD.ToString());
                try
                {
                    realizaConexacoBD.Open();

                    MySqlCommand comandoMySql = realizaConexacoBD.CreateCommand();

                    comandoMySql.CommandText = "INSERT INTO ibread (cliente_nome, cliente_cpf, cliente_telefone, cliente_paes) " +
                        "VALUES('" + tbNome.Text + "', '" + tbCPF.Text + "','" + tbTelefone.Text + "', " + tbPaes.Text + ")";
                    comandoMySql.ExecuteNonQuery();

                    realizaConexacoBD.Close();
                    MessageBox.Show("Inserido com sucesso");
                    atualizaGrid();
                    limparCampos();

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    MessageBox.Show("Erro ao inserir");
                }
            }
        }

        private void Pedido_Load_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void bAlterar_Click(object sender, EventArgs e)
        {
            MySqlConnectionStringBuilder conexaoBD = conexaoBanco();
            MySqlConnection realizaConexacoBD = new MySqlConnection(conexaoBD.ToString());
            try
            {
                realizaConexacoBD.Open(); //Abre a conexão com o banco

                MySqlCommand comandoMySql = realizaConexacoBD.CreateCommand(); //Crio um comando SQL
                comandoMySql.CommandText = "UPDATE ibread SET cliente_nome = '" + tbNome.Text + "', " +
                    "cliente_CPF = '" + tbCPF.Text + "', " +
                    "cliente_telefone = '" + tbTelefone.Text + "', " +
                    "cliente_paes = " + tbPaes.Text +
                    " WHERE tbID = " + tbID.Text + "";
                comandoMySql.ExecuteNonQuery();

                realizaConexacoBD.Close(); // Fecho a conexão com o banco
                MessageBox.Show("Atualizado com sucesso"); //Exibo mensagem de aviso
                atualizaGrid();
                limparCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possivel alterar o item, tente novamente! ");
                Console.WriteLine(ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dataGridView1.CurrentRow.Selected = true;
                //preenche os textbox com as células da linha selecionada
                tbNome.Text = dataGridView1.Rows[e.RowIndex].Cells["cliente_nome"].FormattedValue.ToString();
                tbCPF.Text = dataGridView1.Rows[e.RowIndex].Cells["cliente_cpf"].FormattedValue.ToString();
                tbTelefone.Text = dataGridView1.Rows[e.RowIndex].Cells["cliente_telefone"].FormattedValue.ToString();
                tbPaes.Text = dataGridView1.Rows[e.RowIndex].Cells["cliente_paes"].FormattedValue.ToString();


            }
        }
    }
}