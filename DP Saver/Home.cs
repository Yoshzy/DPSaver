using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DP_Saver.Src;
using DP_Saver.Data;
using MySql.Data.MySqlClient;

namespace DP_Saver
{
    public partial class Home : Form
    {
        EditFile eF = new EditFile();
        public Home()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelData.Text = DateTime.Now.ToString();
            switch (DateTime.Now.Hour)
            {
                case 00:
                case 01:
                case 02:
                case 03:
                case 04:
                case 05:
                    boxImg(Environment.CurrentDirectory + @"\Res\madruga.png");
                    labelDesc.Text = $"Boa madrugada {eF.Nome}, mais um dia que está começando.";
                    break;
                case 06:
                case 07:
                case 08:
                case 09:
                case 10:
                case 11:
                    boxImg(Environment.CurrentDirectory + @"\Res\alarme.png");
                   labelDesc.Text = $"Bom dia {eF.Nome} que tal um café quentinho?";
                    break;
                case 12:
                case 13:
                case 14:
                case 15:
                case 16:
                case 17:
                    boxImg(Environment.CurrentDirectory + @"\Res\tarde.png");
                    labelDesc.Text = $"Boa tarde {eF.Nome} como está sendo o seu dia?";
                    break;
                case 18:
                case 19:
                case 20:
                case 21:
                case 22:
                case 23:
                    boxImg(Environment.CurrentDirectory + @"\Res\noite.png");
                    labelDesc.Text = $"Boa noite {eF.Nome} que tal ir descansar um pouco?";
                    break;
                default:
                    labelDesc.Text = $"Ola {eF.Nome} como posso te ajudar hoje?";
                    break;

            }
        }
        private void boxImg(string path)
        {
            if (File.Exists(path))
            {
                descImg.Image?.Dispose();
                descImg.Image = Image.FromFile(path, true);
            }
        }

        private void LoadSaldo()
        {
            Dbc db = new Dbc();
            try
            {
                MySqlCommand cmd = new MySqlCommand($"SELECT SUM(quantia) AS vTotal FROM `produtos`", db.GetConn());
                db.conn.Open();
                MySqlDataReader rd = cmd.ExecuteReader();

                while (rd.Read())
                {


                    labelItems.Text = rd["vTotal"].ToString();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            db.conn.Close();
        }

        private void LoadAlloc()
        {
            Dbc db = new Dbc();
            try
            {
                MySqlCommand cmd = new MySqlCommand("SELECT COUNT(*) AS vTotal FROM produtos WHERE letra <> 'nan'", db.GetConn());
                db.conn.Open();
                MySqlDataReader rd = cmd.ExecuteReader();

                while (rd.Read())
                {


                    labelValuel.Text = rd["vTotal"].ToString();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            db.conn.Close();
        }

        private void LoadNAlloc()
        {
            Dbc db = new Dbc();
            try
            {
                MySqlCommand cmd = new MySqlCommand("SELECT COUNT(*) AS vTotal FROM produtos WHERE letra = 'nan'", db.GetConn());
                db.conn.Open();
                MySqlDataReader rd = cmd.ExecuteReader();

                while (rd.Read())
                {


                    noLocItems.Text = rd["vTotal"].ToString();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            db.conn.Close();
        }
        private void Home_Load(object sender, EventArgs e)
        {
            eF.LoadIni();
            LoadSaldo();
            LoadAlloc();
            LoadNAlloc();
        }
    }
}
