namespace SerializationOrnek
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.txtAdi = new System.Windows.Forms.TextBox();
			this.txtTelefon = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txtMaas = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtDepartman = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.dateTimeDogum = new System.Windows.Forms.DateTimePicker();
			this.btnSerialized = new System.Windows.Forms.Button();
			this.btnDeSerialized = new System.Windows.Forms.Button();
			this.SonucLabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(170, 106);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(31, 15);
			this.label1.TabIndex = 0;
			this.label1.Text = "Ad : ";
			// 
			// txtAdi
			// 
			this.txtAdi.Location = new System.Drawing.Point(270, 103);
			this.txtAdi.Name = "txtAdi";
			this.txtAdi.Size = new System.Drawing.Size(211, 23);
			this.txtAdi.TabIndex = 1;
			// 
			// txtTelefon
			// 
			this.txtTelefon.Location = new System.Drawing.Point(270, 145);
			this.txtTelefon.Name = "txtTelefon";
			this.txtTelefon.Size = new System.Drawing.Size(211, 23);
			this.txtTelefon.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(170, 148);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(54, 15);
			this.label2.TabIndex = 2;
			this.label2.Text = "Telefon : ";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(170, 192);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(87, 15);
			this.label3.TabIndex = 4;
			this.label3.Text = "Doğum Tarihi : ";
			// 
			// txtMaas
			// 
			this.txtMaas.Location = new System.Drawing.Point(270, 285);
			this.txtMaas.Name = "txtMaas";
			this.txtMaas.Size = new System.Drawing.Size(226, 23);
			this.txtMaas.TabIndex = 9;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(170, 285);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(44, 15);
			this.label4.TabIndex = 8;
			this.label4.Text = "Maaş : ";
			// 
			// txtDepartman
			// 
			this.txtDepartman.Location = new System.Drawing.Point(270, 244);
			this.txtDepartman.Name = "txtDepartman";
			this.txtDepartman.Size = new System.Drawing.Size(226, 23);
			this.txtDepartman.TabIndex = 7;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(170, 247);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(78, 15);
			this.label5.TabIndex = 6;
			this.label5.Text = "Departmanı : ";
			// 
			// dateTimeDogum
			// 
			this.dateTimeDogum.Location = new System.Drawing.Point(270, 186);
			this.dateTimeDogum.Name = "dateTimeDogum";
			this.dateTimeDogum.Size = new System.Drawing.Size(211, 23);
			this.dateTimeDogum.TabIndex = 10;
			this.dateTimeDogum.Value = new System.DateTime(2023, 2, 21, 14, 45, 24, 0);
			// 
			// btnSerialized
			// 
			this.btnSerialized.Location = new System.Drawing.Point(270, 334);
			this.btnSerialized.Name = "btnSerialized";
			this.btnSerialized.Size = new System.Drawing.Size(101, 23);
			this.btnSerialized.TabIndex = 11;
			this.btnSerialized.Text = "XML Serialized";
			this.btnSerialized.UseVisualStyleBackColor = true;
			this.btnSerialized.Click += new System.EventHandler(this.btnSerialized_Click);
			// 
			// btnDeSerialized
			// 
			this.btnDeSerialized.Location = new System.Drawing.Point(391, 334);
			this.btnDeSerialized.Name = "btnDeSerialized";
			this.btnDeSerialized.Size = new System.Drawing.Size(105, 23);
			this.btnDeSerialized.TabIndex = 12;
			this.btnDeSerialized.Text = "XML DeSerialized";
			this.btnDeSerialized.UseVisualStyleBackColor = true;
			this.btnDeSerialized.Click += new System.EventHandler(this.btnDeSerialized_Click);
			// 
			// SonucLabel
			// 
			this.SonucLabel.AutoSize = true;
			this.SonucLabel.Location = new System.Drawing.Point(541, 103);
			this.SonucLabel.Name = "SonucLabel";
			this.SonucLabel.Size = new System.Drawing.Size(49, 15);
			this.SonucLabel.TabIndex = 13;
			this.SonucLabel.Text = "Sonuc : ";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.SonucLabel);
			this.Controls.Add(this.btnDeSerialized);
			this.Controls.Add(this.btnSerialized);
			this.Controls.Add(this.dateTimeDogum);
			this.Controls.Add(this.txtMaas);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtDepartman);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtTelefon);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtAdi);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Label label1;
		private TextBox txtAdi;
		private TextBox txtTelefon;
		private Label label2;
		private Label label3;
		private TextBox txtMaas;
		private Label label4;
		private TextBox txtDepartman;
		private Label label5;
		private DateTimePicker dateTimeDogum;
		private Button btnSerialized;
		private Button btnDeSerialized;
		private Label SonucLabel;
	}
}