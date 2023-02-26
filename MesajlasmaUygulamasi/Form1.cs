using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MesajlasmaUygulamasi
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		SqlConnection baglanti = new SqlConnection(@"Data Source=CEMC\SQLEXPRESS01;Initial Catalog=DbMesajlasma;Integrated Security=True");

		private void Form1_Load(object sender, EventArgs e)
		{
			this.BackColor =ColorTranslator.FromHtml("0xff8989");
		}



		private void button1_Click(object sender, EventArgs e)
		{
			baglanti.Open();
			SqlCommand komut = new SqlCommand("select * from TblKisiler where NUMARA=@p1 and SIFRE=@p2 ",baglanti);
			komut.Parameters.AddWithValue("p1", MskNumara.Text);
			komut.Parameters.AddWithValue("p2", TxtSifre.Text);
			SqlDataReader dr = komut.ExecuteReader();
			if (dr.Read())
			{
				Form2 frm= new Form2();
				frm.numara=MskNumara.Text;
				frm.Show();
			}
			else
			{
				MessageBox.Show("Hatalı giriş yaptınız..","Hata",MessageBoxButtons.OK,MessageBoxIcon.Error);
			}
			baglanti.Close();

		}
	}
}
