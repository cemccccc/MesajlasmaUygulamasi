namespace MesajlasmaUygulamasi
{
	partial class Form2
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.LblNumara = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.LblAdSoyad = new System.Windows.Forms.Label();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.dataGridView2 = new System.Windows.Forms.DataGridView();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.button1 = new System.Windows.Forms.Button();
			this.TxtBaslik = new System.Windows.Forms.TextBox();
			this.RchMesaj = new System.Windows.Forms.RichTextBox();
			this.MskAlici = new System.Windows.Forms.MaskedTextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
			this.groupBox3.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(13, 25);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(64, 19);
			this.label1.TabIndex = 0;
			this.label1.Text = "Numara:";
			// 
			// LblNumara
			// 
			this.LblNumara.AutoSize = true;
			this.LblNumara.Location = new System.Drawing.Point(83, 25);
			this.LblNumara.Name = "LblNumara";
			this.LblNumara.Size = new System.Drawing.Size(41, 19);
			this.LblNumara.TabIndex = 1;
			this.LblNumara.Text = "0000";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(157, 25);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(72, 19);
			this.label3.TabIndex = 2;
			this.label3.Text = "Ad Soyad:";
			// 
			// LblAdSoyad
			// 
			this.LblAdSoyad.AutoSize = true;
			this.LblAdSoyad.Location = new System.Drawing.Point(235, 25);
			this.LblAdSoyad.Name = "LblAdSoyad";
			this.LblAdSoyad.Size = new System.Drawing.Size(65, 19);
			this.LblAdSoyad.TabIndex = 3;
			this.LblAdSoyad.Text = "Null Null";
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridView1.Location = new System.Drawing.Point(3, 23);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(357, 248);
			this.dataGridView1.TabIndex = 4;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.dataGridView1);
			this.groupBox1.Location = new System.Drawing.Point(12, 56);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(363, 274);
			this.groupBox1.TabIndex = 5;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Gelen Kutusu";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.dataGridView2);
			this.groupBox2.Location = new System.Drawing.Point(403, 56);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(363, 271);
			this.groupBox2.TabIndex = 5;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Giden Kutusu";
			// 
			// dataGridView2
			// 
			this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridView2.Location = new System.Drawing.Point(3, 23);
			this.dataGridView2.Name = "dataGridView2";
			this.dataGridView2.Size = new System.Drawing.Size(357, 245);
			this.dataGridView2.TabIndex = 4;
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.button1);
			this.groupBox3.Controls.Add(this.TxtBaslik);
			this.groupBox3.Controls.Add(this.RchMesaj);
			this.groupBox3.Controls.Add(this.MskAlici);
			this.groupBox3.Controls.Add(this.label4);
			this.groupBox3.Controls.Add(this.label2);
			this.groupBox3.Location = new System.Drawing.Point(15, 347);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(751, 221);
			this.groupBox3.TabIndex = 6;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Mesaj Paneli";
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Calibri", 10F);
			this.button1.Location = new System.Drawing.Point(649, 182);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(96, 28);
			this.button1.TabIndex = 4;
			this.button1.Text = "Gönder";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// TxtBaslik
			// 
			this.TxtBaslik.Location = new System.Drawing.Point(309, 26);
			this.TxtBaslik.Name = "TxtBaslik";
			this.TxtBaslik.Size = new System.Drawing.Size(169, 27);
			this.TxtBaslik.TabIndex = 3;
			// 
			// RchMesaj
			// 
			this.RchMesaj.Location = new System.Drawing.Point(10, 65);
			this.RchMesaj.Name = "RchMesaj";
			this.RchMesaj.Size = new System.Drawing.Size(738, 111);
			this.RchMesaj.TabIndex = 2;
			this.RchMesaj.Text = "";
			// 
			// MskAlici
			// 
			this.MskAlici.Location = new System.Drawing.Point(63, 26);
			this.MskAlici.Mask = "0000";
			this.MskAlici.Name = "MskAlici";
			this.MskAlici.Size = new System.Drawing.Size(169, 27);
			this.MskAlici.TabIndex = 1;
			this.MskAlici.ValidatingType = typeof(int);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(252, 29);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(51, 19);
			this.label4.TabIndex = 0;
			this.label4.Text = "Başlık:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(6, 32);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(41, 19);
			this.label2.TabIndex = 0;
			this.label2.Text = "Alıcı:";
			// 
			// Form2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(780, 593);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.LblAdSoyad);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.LblNumara);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "Form2";
			this.Text = "Mesaj Paneli";
			this.Load += new System.EventHandler(this.Form2_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label LblNumara;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label LblAdSoyad;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.DataGridView dataGridView2;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox TxtBaslik;
		private System.Windows.Forms.RichTextBox RchMesaj;
		private System.Windows.Forms.MaskedTextBox MskAlici;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label4;
	}
}