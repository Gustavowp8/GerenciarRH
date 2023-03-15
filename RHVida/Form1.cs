using MySql.Data.MySqlClient;

namespace RHVida
{
    public partial class Form1 : Form
    {
        private MySqlConnection Conexao;
        private string data_source = "datasource=localhost;username=root;password=81523123;database=rh_agenda";
        //conexão

        public Form1()
        {
            InitializeComponent();

            lvlLista.View = View.Details;
            lvlLista.LabelEdit = true;
            lvlLista.AllowColumnReorder = true;
            lvlLista.FullRowSelect = true;
            lvlLista.GridLines = true;


            lvlLista.Columns.Add("ID", 30, HorizontalAlignment.Left);
            lvlLista.Columns.Add("Nome", 150, HorizontalAlignment.Left);
            lvlLista.Columns.Add("E-mail", 150, HorizontalAlignment.Left);
            lvlLista.Columns.Add("Telefone", 150, HorizontalAlignment.Left);

            carregar_lista();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                Conexao = new MySqlConnection(data_source);

                Conexao.Open();

                //string de conexão

                //cria conexão
                MySqlCommand cmd = new MySqlCommand();

                cmd.Connection = Conexao;

                cmd.CommandText = "INSERT INTO contatos (nome, email, telefone) " +
                                  "VALUES " +
                                  "(@nome, @email, @telefone) ";


                cmd.Parameters.AddWithValue("@nome", txtNome.Text);
                cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@telefone", txtTelefone.Text);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Salvo com sucesso!", 
                                "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtNome.Text = string.Empty;
                txtEmail.Text = "";
                txtTelefone.Text = "";

                carregar_lista();

                //Executar insert
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {  
                
                Conexao.Close(); 
            
            }
        }

        private void brn_busca_Click(object sender, EventArgs e)
        {
            try
            {
                Conexao = new MySqlConnection(data_source);

                Conexao.Open();

                //string de conexão

                //cria conexão
                MySqlCommand cmd = new MySqlCommand();

                cmd.Connection = Conexao;
                cmd.CommandText = "SELECT * FROM contatos WHERE nome LIKE @q OR email LIKE @q ";
                cmd.Parameters.AddWithValue("@q", "%" + txtBusca.Text + "%");

                //Codigo antigo

                MySqlDataReader reader = cmd.ExecuteReader();

                lvlLista.Items.Clear();

                while(reader.Read())
                {
                    string[] row =
                    {
                        reader.GetString(0),
                        reader.GetString(1),
                        reader.GetString(2),
                        reader.GetString(3),
                    };
                   
                    lvlLista.Items.Add(new ListViewItem(row));
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Conexao.Close();
            }
        }

        private void carregar_lista()
        {
            try
            {
                Conexao = new MySqlConnection(data_source);

                Conexao.Open();

                //string de conexão

                //cria conexão
                MySqlCommand cmd = new MySqlCommand();

                cmd.Connection = Conexao;
                cmd.CommandText = "SELECT * FROM contatos ORDER BY id DESC";

                //Codigo antigo

                MySqlDataReader reader = cmd.ExecuteReader();

                lvlLista.Items.Clear();

                while (reader.Read())
                {
                    string[] row =
                    {
                        reader.GetString(0),
                        reader.GetString(1),
                        reader.GetString(2),
                        reader.GetString(3),
                    };

                    lvlLista.Items.Add(new ListViewItem(row));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Conexao.Close();
            }
        }
    }
}