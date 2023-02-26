namespace MesajlasmaUygulamasi
{
	partial class Form1
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
			this.MskNumara = new System.Windows.Forms.MaskedTextBox();
			this.TxtSifre = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// MskNumara
			// 
			this.MskNumara.Location = new System.Drawing.Point(124, 54);
			this.MskNumara.Mask = "0000";
			this.MskNumara.Name = "MskNumara";
			this.MskNumara.Size = new System.Drawing.Size(147, 23);
			this.MskNumara.TabIndex = 0;
			this.MskNumara.ValidatingType = typeof(int);
			// 
			// TxtSifre
			// 
			this.TxtSifre.Location = new System.Drawing.Point(124, 83);
			this.TxtSifre.Name = "TxtSifre";
			this.TxtSifre.PasswordChar = '*';
			this.TxtSifre.Size = new System.Drawing.Size(147, 23);
			this.TxtSifre.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Calibri", 12F);
			this.label1.Location = new System.Drawing.Point(50, 54);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(64, 19);
			this.label1.TabIndex = 2;
			this.label1.Text = "Numara:";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(189, 112);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(82, 26);
			this.button1.TabIndex = 3;
			this.button1.Text = "Giriş Yap";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Calibri", 12F);
			this.label2.Location = new System.Drawing.Point(50, 83);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(42, 19);
			this.label2.TabIndex = 2;
			this.label2.Text = "Şifre:";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Salmon;
			this.ClientSize = new System.Drawing.Size(327, 191);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.TxtSifre);
			this.Controls.Add(this.MskNumara);
			this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.Name = "Form1";
			this.Text = "Mesajlaşma Uygulaması";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MaskedTextBox MskNumara;
		private System.Windows.Forms.TextBox TxtSifre;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label2;
	}
}

