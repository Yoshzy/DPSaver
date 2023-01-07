using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DP_Saver.Src;
using DP_Saver.Data;
using MySql.Data.MySqlClient;

namespace DP_Saver
{
    public partial class CdT1 : Form
    {
        Cadastro cd = new Cadastro();
        Cadastro _cadastro;
        public CdT1(Cadastro cadastro)
        {
            InitializeComponent();
            _cadastro = cadastro;
        }

        private void GetBoxPic()
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.jpeg)|*.jpg; *.jpeg";
            if (open.ShowDialog() == DialogResult.OK)
            {
                picBox.Text = open.FileName;
            }
        }


        private void btnPic_Click(object sender, EventArgs e)
        {
            GetBoxPic();

        }
        private void Register()
        {
            Dbc db = new Dbc();

            try
            {
                MySqlCommand cmd = new MySqlCommand("INSERT INTO `produtos`(`codigo`, `nome`, `quantia`, `foto`, `prateleira`, `numero`, `letra`,`link`) VALUES (@codigo, @nome, @quantia, @foto, @prateleira, @numero, @letra, @link)", db.GetConn());
                cmd.Parameters.Add("@codigo", MySqlDbType.VarChar).Value = codBox.Text;
                cmd.Parameters.Add("@nome", MySqlDbType.VarChar).Value = nomeBox.Text;
                cmd.Parameters.Add("@quantia", MySqlDbType.Int32).Value = qtyBox.Text;
                cmd.Parameters.Add("@foto", MySqlDbType.VarChar).Value = $"http://127.0.0.1/Fotos/{Servidor._pNome}";
                cmd.Parameters.Add("@prateleira", MySqlDbType.Int32).Value = prateleiraBox.Text;
                cmd.Parameters.Add("@numero", MySqlDbType.Int32).Value = numBox.Text;
                cmd.Parameters.Add("@letra", MySqlDbType.VarChar).Value = letterBox.Text.ToUpper();
                cmd.Parameters.Add("@link", MySqlDbType.VarChar).Value = linkBox.Text;
                db.conn.Open();
                if (!CheckBoxes())
                {

                            if (cmd.ExecuteNonQuery() == 1)
                            {
                                MessageBox.Show("Produto inserido com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                CleanBoxes();
                                db.conn.Close();

                            }
                            else
                            {
                                MessageBox.Show("Algo deu errado revise os campos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                else
                {
                    MessageBox.Show("Preencha todos os campos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            db.conn.Close();
        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Dbc db = new Dbc();
           if(!Fatorador())
           {
                if (Servidor.SendImages(picBox.Text))
                {

                    Register();
                }
                else
                {
                    string message = "Houve um problema ao enviar a imagem, deseja continuar?";
                    string title = "Ops!";
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result = MessageBox.Show(message, title, buttons);
                    if (result == DialogResult.Yes)
                    {
                        Register();
                    }
                }
            }
                
         }

        private bool CheckBoxes()
        {
                string codigo = codBox.Text;
                string nome = nomeBox.Text;
                string quantia = qtyBox.Text;
                string fotos = picBox.Text;
                string Prateleira = prateleiraBox.Text;
                string numero = numBox.Text;
                string letra = letterBox.Text;
                string link = linkBox.Text;
                if (codigo.Equals("") || nome.Equals("") || quantia.Equals("") || fotos.Equals("") || Prateleira.Equals("") || numero.Equals("") || letra.Equals("") || link.Equals(""))
                {
                    return true;
            }
            else
            {
              return false;
            }

            
           
        }
        private bool Fatorador()
        {
            string refquantia = qtyBox.Text.ToLower();
            string reftPrateleira = prateleiraBox.Text.ToLower();
            string reftnum = numBox.Text.ToLower();
            char[] re = { '.', ',', '-', '=', '/', '*', '&', '^', '%', '$', '#', '@', '!', '{', '}', '[', ']', '+', '<', '>', 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

            if (refquantia.Trim(re).Equals("") || reftPrateleira.Trim(re).Equals("") || reftnum.Trim(re).Equals(""))
            {
                MessageBox.Show("São aceitos apenas numeros em quantia, corredor e numero.", "Valor Invalido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                qtyBox.Focus();
                return true;
            }
            else
            {
                return false;
            }
        }
        /*private bool checkCode(int codigo)
        {
            Dbc db = new Dbc();
            try
            {

                DataTable table = new DataTable();

                MySqlDataAdapter adapter = new MySqlDataAdapter();

                MySqlCommand cmd = new MySqlCommand($"SELECT * FROM `produtos` WHERE `codigo` = @codigo", db.GetConn());

                cmd.Parameters.Add("@codigo", MySqlDbType.VarChar).Value = codigo;

                adapter.SelectCommand = cmd;
                adapter.Fill(table);

                if (table.Rows.Count > 0)
                {
                    return true;
                }
                db.conn.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
                db.conn.Close();
            }
            return false;

        }*/
       
        private void CleanBoxes()
        {
            codBox.Clear();
            nomeBox.Clear();
            qtyBox.Clear();
            picBox.Clear();
            prateleiraBox.Clear();
            numBox.Clear();
            letterBox.Clear();
            linkBox.Clear();
        }

        private void CdT1_Load(object sender, EventArgs e)
        {

        }
    }
}
