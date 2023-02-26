using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MesajlasmaUygulamasi
{
	public partial class Form2 : Form
	{
		public Form2()
		{
			InitializeComponent();
		}

		SqlConnection baglanti = new SqlConnection(@"Data Source=CEMC\SQLEXPRESS01;Initial Catalog=DbMesajlasma;Integrated Security=True");
		public string numara;

		private void Form2_Load(object sender, EventArgs e)
		{
			this.BackColor = ColorTranslator.FromHtml("0xff8989");
			LblNumara.Text = numara;
			AdSoyadGosterim();
			GelenKutusu();
			GidenKutusu();
		}
		private void button1_Click(object sender, EventArgs e)
		{
			MesajGonder();
			GelenKutusu();
			GidenKutusu();
		}


		public void AdSoyadGosterim()
		{
			baglanti.Open();
			SqlCommand komut = new SqlCommand("select CONCAT(AD, ' ', SOYAD) from TblKisiler where NUMARA=@p1", baglanti);
			komut.Parameters.AddWithValue("p1", numara);
			SqlDataReader dr = komut.ExecuteReader();

			while (dr.Read())
			{
				LblAdSoyad.Text = dr[0].ToString();
			}
			baglanti.Close();
		}

		public void GelenKutusu()
		{
			baglanti.Open();
			SqlDataAdapter da = new SqlDataAdapter("select * from TblMesajlar where ALICI= " + numara,baglanti);
			DataTable dt = new DataTable();
			da.Fill(dt);
			dataGridView1.DataSource= dt;
			baglanti.Close();
		}

		public void GidenKutusu()
		{
			baglanti.Open();
			SqlDataAdapter da = new SqlDataAdapter("select * from TblMesajlar where GONDEREN= " + numara, baglanti);
			DataTable dt = new DataTable();
			da.Fill(dt);
			dataGridView2.DataSource = dt;
			baglanti.Close();
		}

		public void MesajGonder()
		{
			baglanti.Open();
			SqlCommand komut = new SqlCommand("insert into TblMesajlar (GONDEREN, ALICI, BASLIK, ICERIK) values (@p1, @p2, @p3, @p4)",baglanti);
			komut.Parameters.AddWithValue("p1", numara);
			komut.Parameters.AddWithValue("p2", MskAlici.Text);
			komut.Parameters.AddWithValue("p3", TxtBaslik.Text);
			komut.Parameters.AddWithValue("p4", RchMesaj.Text);
			komut.ExecuteNonQuery();
			baglanti.Close();
			MessageBox.Show("Mesaj gönderimi başarılı...", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}
	}
}
