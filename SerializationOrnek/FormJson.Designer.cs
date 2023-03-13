namespace SerializationOrnek
{
	partial class FormJson
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
			this.btnDosyayaYaz = new System.Windows.Forms.Button();
			this.btnDosyadanOku = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnDosyayaYaz
			// 
			this.btnDosyayaYaz.Location = new System.Drawing.Point(150, 180);
			this.btnDosyayaYaz.Name = "btnDosyayaYaz";
			this.btnDosyayaYaz.Size = new System.Drawing.Size(97, 23);
			this.btnDosyayaYaz.TabIndex = 0;
			this.btnDosyayaYaz.Text = "Dosyaya Yaz";
			this.btnDosyayaYaz.UseVisualStyleBackColor = true;
			this.btnDosyayaYaz.Click += new System.EventHandler(this.btnDosyayaYaz_Click);
			// 
			// btnDosyadanOku
			// 
			this.btnDosyadanOku.Location = new System.Drawing.Point(150, 266);
			this.btnDosyadanOku.Name = "btnDosyadanOku";
			this.btnDosyadanOku.Size = new System.Drawing.Size(97, 23);
			this.btnDosyadanOku.TabIndex = 1;
			this.btnDosyadanOku.Text = "Dosyadan Oku";
			this.btnDosyadanOku.UseVisualStyleBackColor = true;
			this.btnDosyadanOku.Click += new System.EventHandler(this.btnDosyadanOku_Click);
			// 
			// FormJson
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btnDosyadanOku);
			this.Controls.Add(this.btnDosyayaYaz);
			this.Name = "FormJson";
			this.Text = "FormBinary";
			this.ResumeLayout(false);

		}

		#endregion

		private Button btnDosyayaYaz;
		private Button btnDosyadanOku;
	}
}