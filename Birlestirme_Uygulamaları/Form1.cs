using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Birlestirme_Uygulamaları
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-2HOS6DT\SQLEXPRESS;Initial Catalog=Test;Integrated Security=True");
        private void Form1_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select HAREKETID, URUNAD, (AD+ ' ' +SOYAD) as MUSTERI, ADSOYAD as PERSONEL, TBLHAREKETLER.FIYAT from TBLHAREKETLER inner join TBLURUNLER on TBLHAREKETLER.URUN=TBLURUNLER.URUNID inner join TBLMUSTERI on TBLHAREKETLER.MUSTERI = TBLMUSTERI.ID inner join TBLPERSONEL on TBLHAREKETLER.PESONEL = TBLPERSONEL.ID", baglanti);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
