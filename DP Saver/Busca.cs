using BarcodeLib;
using QRCoder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DP_Saver.Data;
using DP_Saver.Src;
using MySql.Data.MySqlClient;

namespace DP_Saver
{
    public partial class Busca : Form
    {
        private string code;
        private string nome;
        private string quantidade;
        private string loc;
        private string foto;
        private string link;

        public string _Codigo { get { return code; } }

        public string _Nome { get { return nome; } }
        public string _Quantidade { get { return quantidade; } }

        public string _Loc { get { return loc; } }
        public string _Foto { get { return foto; } }
        public string _Link {  get { return link; } }
        public Busca()
        {
            InitializeComponent();
        }

        private void Busca_Load(object sender, EventArgs e)
        {
            /*
                Barcode barcode = new Barcode();
            barcode.IncludeLabel = true;
            Image img = barcode.Encode(BarcodeLib.TYPE.CODE128, "111475", Color.Black, Color.White, 300,95);
            barPic.Image = img;

            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode("http://dispropil.com.br", QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new QRCode(qrCodeData);
            Bitmap qrCodeImage = qrCode.GetGraphic(20);
            picQrc.Image = qrCodeImage;
            */
        }
        private void GetItem(string codigo)
        {
            Dbc db = new Dbc();
            listB.Items.Clear();
            try
            {
                MySqlCommand cmd = new MySqlCommand($"SELECT codigo, nome, quantia, foto, prateleira, numero, letra, link FROM `produtos` WHERE `codigo` = '{codigo}'", db.GetConn());
                db.conn.Open();
                MySqlDataReader rd = cmd.ExecuteReader();

                while (rd.Read())
                {

                    code = rd["codigo"].ToString();
                    nome = rd["nome"].ToString();
                    quantidade = SomaDuplicada(codigo).ToString();
                    foto = rd["foto"].ToString();
                    link = rd["link"].ToString();
                    loc = $"Prateleira: {rd["prateleira"]}  Número: {rd["numero"]} Letra: {rd["letra"]}";
                    LoadBoxes();

                }
                db.conn.Close();
            }catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void ClearBoxes()
        {
            codBox.Clear();
            nomeBox.Clear();
            qtyBox.Clear();
            linkBox.Clear();

        }

        private int SomaDuplicada(string codigo)
        {
            Dbc db = new Dbc();
            int sumRet = 0;
            try
            {
                MySqlCommand cmd = new MySqlCommand($"SELECT SUM(quantia) AS vTotal FROM `produtos` WHERE `codigo` = '{codigo}'", db.GetConn());
                db.conn.Open();
                MySqlDataReader rd = cmd.ExecuteReader();

                while (rd.Read())
                {

                   
                    sumRet = int.Parse(rd["vTotal"].ToString());

                }
                return sumRet;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return 0;
            }
            db.conn.Close();
        }
       
        private void LoadBoxes()
        {
            codBox.Text = _Codigo;
            nomeBox.Text = _Nome;
            qtyBox.Text = _Quantidade;
            pictureProd.Load(_Foto);
            linkBox.Text = _Link;
            listB.Items.Add(_Loc);


            //bars, qrcode
            Barcode barcode = new Barcode();
            barcode.IncludeLabel = true;
            Image img = barcode.Encode(BarcodeLib.TYPE.CODE128, _Codigo, Color.Black, Color.White, 300, 95);
            barPic.Image = img;

            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(_Link, QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new QRCode(qrCodeData);
            Bitmap qrCodeImage = qrCode.GetGraphic(20);
            picQrc.Image = qrCodeImage;

        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ClearBoxes();
            GetItem(codigoBox.Text);
        }

        private void btnImpre_Click(object sender, EventArgs e)
        {
            
            PrintDialog imprimir = new PrintDialog();
            if (imprimir.ShowDialog() == DialogResult.OK)
            {
                printDoc.PrinterSettings = imprimir.PrinterSettings;
                printDoc.Print();
            }
        }
        private string CheckString(string valor)
        {
            string res = string.Empty;
         
                if(valor.Length < 34)
                {
                    return valor;
                }
                else
                {
                   return res = valor.Substring(0, 34);
                }
        }
        private void printDoc_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Font font12 = new Font("Arial", 12);
            e.Graphics.DrawString(CheckString(_Nome), font12, Brushes.Black, 370, 150);
            e.Graphics.DrawImage(picQrc.Image, 170, 103, picQrc.Width, picQrc.Height);
            e.Graphics.DrawImage(barPic.Image, 360, 185, barPic.Width, barPic.Height);
            e.Graphics.DrawImage(pictureBox4.Image, 580, 115, 100, 20);

        }
        
    }
}
