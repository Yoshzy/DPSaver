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
using DP_Saver.Data;
using DP_Saver.Src;

namespace DP_Saver
{
    public partial class Consulta : Form
    {
        Cadastro _cadastro;
        public Consulta(Cadastro cadastro)
        {
            InitializeComponent();
            _cadastro = cadastro;
        }
        public static string LoadList(string prateleira, int numero, string letra)
        {
            Dbc db = new Dbc();


            try
            {
                string rd = string.Empty;
                MySqlCommand cmd = new MySqlCommand($"SELECT * FROM `produtos` WHERE `prateleira` = '{prateleira}' AND `numero` = '{numero}' AND `letra` = '{letra}'", db.GetConn());
                db.conn.Open();
                MySqlDataReader read = cmd.ExecuteReader();
                while (read.Read())
                {

                    rd = $"Código: {read["codigo"].ToString()}    Nome: {read["nome"].ToString()}    Quantidade: {read["quantia"].ToString()}";

                }
                return rd;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return "";
            }
            db.conn.Close();
        }
        private bool CheckBoxes()
        {
            string prateleira = pratBox.Text;
            string numero = numBox.Text;
            string letra = letterBox.Text;
            if (prateleira.Equals("") || numero.Equals("") || letra.Equals(""))
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        private void listBtn_Click(object sender, EventArgs e)
        {
            if (!CheckBoxes())
            {
                Cadastro cd = new Cadastro();
               _cadastro.lb1.Items.Clear();
                _cadastro.lb1.Items.Add(LoadList(pratBox.Text, int.Parse(numBox.Text), letterBox.Text));
            }
            else
            {
                MessageBox.Show("Por informe a pratileira, o número e a letra!", "Erro!", MessageBoxButtons.OK);
            }


        }
    }
}
