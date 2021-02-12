namespace Klijent.KorisnickiInterfejs
{
    partial class DetaljiRezervacije
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DetaljiRezervacije));
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.gbRezervacija = new System.Windows.Forms.GroupBox();
            this.txtDatum = new System.Windows.Forms.TextBox();
            this.cmbRadnik = new System.Windows.Forms.ComboBox();
            this.lblRadnik = new System.Windows.Forms.Label();
            this.cmbDestinacija = new System.Windows.Forms.ComboBox();
            this.lblDestinacija = new System.Windows.Forms.Label();
            this.cmbTurista = new System.Windows.Forms.ComboBox();
            this.lblTurista = new System.Windows.Forms.Label();
            this.txtBroj = new System.Windows.Forms.TextBox();
            this.lblBroj = new System.Windows.Forms.Label();
            this.cmbMesto = new System.Windows.Forms.ComboBox();
            this.lblMesto = new System.Windows.Forms.Label();
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.lblDatum = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gbRezervacija.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(219, 21);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(50, 20);
            this.txtID.TabIndex = 61;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Futura Md BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(187, 23);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(26, 16);
            this.lblID.TabIndex = 60;
            this.lblID.Text = "ID:";
            // 
            // gbRezervacija
            // 
            this.gbRezervacija.Controls.Add(this.txtDatum);
            this.gbRezervacija.Controls.Add(this.cmbRadnik);
            this.gbRezervacija.Controls.Add(this.lblRadnik);
            this.gbRezervacija.Controls.Add(this.cmbDestinacija);
            this.gbRezervacija.Controls.Add(this.lblDestinacija);
            this.gbRezervacija.Controls.Add(this.cmbTurista);
            this.gbRezervacija.Controls.Add(this.lblTurista);
            this.gbRezervacija.Controls.Add(this.txtBroj);
            this.gbRezervacija.Controls.Add(this.lblBroj);
            this.gbRezervacija.Controls.Add(this.cmbMesto);
            this.gbRezervacija.Controls.Add(this.lblMesto);
            this.gbRezervacija.Controls.Add(this.btnSacuvaj);
            this.gbRezervacija.Controls.Add(this.lblDatum);
            this.gbRezervacija.Controls.Add(this.pictureBox1);
            this.gbRezervacija.Enabled = false;
            this.gbRezervacija.Font = new System.Drawing.Font("Futura Md BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbRezervacija.Location = new System.Drawing.Point(23, 53);
            this.gbRezervacija.Name = "gbRezervacija";
            this.gbRezervacija.Size = new System.Drawing.Size(447, 321);
            this.gbRezervacija.TabIndex = 62;
            this.gbRezervacija.TabStop = false;
            this.gbRezervacija.Text = "Unos rezervacije";
            // 
            // txtDatum
            // 
            this.txtDatum.Location = new System.Drawing.Point(17, 198);
            this.txtDatum.Multiline = true;
            this.txtDatum.Name = "txtDatum";
            this.txtDatum.Size = new System.Drawing.Size(229, 49);
            this.txtDatum.TabIndex = 62;
            // 
            // cmbRadnik
            // 
            this.cmbRadnik.FormattingEnabled = true;
            this.cmbRadnik.Location = new System.Drawing.Point(18, 148);
            this.cmbRadnik.Name = "cmbRadnik";
            this.cmbRadnik.Size = new System.Drawing.Size(228, 24);
            this.cmbRadnik.TabIndex = 61;
            // 
            // lblRadnik
            // 
            this.lblRadnik.AutoSize = true;
            this.lblRadnik.Font = new System.Drawing.Font("Futura Md BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRadnik.Location = new System.Drawing.Point(15, 129);
            this.lblRadnik.Name = "lblRadnik";
            this.lblRadnik.Size = new System.Drawing.Size(53, 16);
            this.lblRadnik.TabIndex = 60;
            this.lblRadnik.Text = "Radnik:";
            // 
            // cmbDestinacija
            // 
            this.cmbDestinacija.FormattingEnabled = true;
            this.cmbDestinacija.Location = new System.Drawing.Point(18, 101);
            this.cmbDestinacija.Name = "cmbDestinacija";
            this.cmbDestinacija.Size = new System.Drawing.Size(228, 24);
            this.cmbDestinacija.TabIndex = 59;
            // 
            // lblDestinacija
            // 
            this.lblDestinacija.AutoSize = true;
            this.lblDestinacija.Font = new System.Drawing.Font("Futura Md BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDestinacija.Location = new System.Drawing.Point(15, 77);
            this.lblDestinacija.Name = "lblDestinacija";
            this.lblDestinacija.Size = new System.Drawing.Size(78, 16);
            this.lblDestinacija.TabIndex = 58;
            this.lblDestinacija.Text = "Destinacija:";
            // 
            // cmbTurista
            // 
            this.cmbTurista.FormattingEnabled = true;
            this.cmbTurista.Location = new System.Drawing.Point(17, 49);
            this.cmbTurista.Name = "cmbTurista";
            this.cmbTurista.Size = new System.Drawing.Size(229, 24);
            this.cmbTurista.TabIndex = 57;
            // 
            // lblTurista
            // 
            this.lblTurista.AutoSize = true;
            this.lblTurista.Font = new System.Drawing.Font("Futura Md BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTurista.Location = new System.Drawing.Point(14, 25);
            this.lblTurista.Name = "lblTurista";
            this.lblTurista.Size = new System.Drawing.Size(53, 16);
            this.lblTurista.TabIndex = 56;
            this.lblTurista.Text = "Turista:";
            // 
            // txtBroj
            // 
            this.txtBroj.Location = new System.Drawing.Point(270, 198);
            this.txtBroj.Multiline = true;
            this.txtBroj.Name = "txtBroj";
            this.txtBroj.Size = new System.Drawing.Size(147, 49);
            this.txtBroj.TabIndex = 52;
            // 
            // lblBroj
            // 
            this.lblBroj.AutoSize = true;
            this.lblBroj.Font = new System.Drawing.Font("Futura Md BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBroj.Location = new System.Drawing.Point(267, 178);
            this.lblBroj.Name = "lblBroj";
            this.lblBroj.Size = new System.Drawing.Size(77, 16);
            this.lblBroj.TabIndex = 51;
            this.lblBroj.Text = "Broj turista:";
            // 
            // cmbMesto
            // 
            this.cmbMesto.FormattingEnabled = true;
            this.cmbMesto.Items.AddRange(new object[] {
            "Sava Centar - Beograd",
            "Centar - Nis",
            "Glavna autobuska stanica - \"Lasta\"",
            "Aerodrom \"Nikola Tesla\"",
            "Centar - Novi Sad"});
            this.cmbMesto.Location = new System.Drawing.Point(17, 276);
            this.cmbMesto.Name = "cmbMesto";
            this.cmbMesto.Size = new System.Drawing.Size(229, 24);
            this.cmbMesto.TabIndex = 50;
            // 
            // lblMesto
            // 
            this.lblMesto.AutoSize = true;
            this.lblMesto.Font = new System.Drawing.Font("Futura Md BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMesto.Location = new System.Drawing.Point(16, 257);
            this.lblMesto.Name = "lblMesto";
            this.lblMesto.Size = new System.Drawing.Size(100, 16);
            this.lblMesto.TabIndex = 49;
            this.lblMesto.Text = "Mesto polaska:";
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.Font = new System.Drawing.Font("Futura Md BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSacuvaj.Location = new System.Drawing.Point(270, 264);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(147, 36);
            this.btnSacuvaj.TabIndex = 47;
            this.btnSacuvaj.Text = "Izmeni rezervaciju";
            this.btnSacuvaj.UseVisualStyleBackColor = true;
            this.btnSacuvaj.Click += new System.EventHandler(this.btnSacuvaj_Click_1);
            // 
            // lblDatum
            // 
            this.lblDatum.AutoSize = true;
            this.lblDatum.Font = new System.Drawing.Font("Futura Md BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatum.Location = new System.Drawing.Point(16, 178);
            this.lblDatum.Name = "lblDatum";
            this.lblDatum.Size = new System.Drawing.Size(206, 16);
            this.lblDatum.TabIndex = 46;
            this.lblDatum.Text = "Datum rezervacije: (dd/MM/yyyy)";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Klijent.Properties.Resources.fly;
            this.pictureBox1.Location = new System.Drawing.Point(252, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(183, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 45;
            this.pictureBox1.TabStop = false;
            // 
            // DetaljiRezervacije
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 396);
            this.Controls.Add(this.gbRezervacija);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblID);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DetaljiRezervacije";
            this.Text = "Detalji rezervacije";
            this.Load += new System.EventHandler(this.DetaljiRezervacije_Load);
            this.gbRezervacija.ResumeLayout(false);
            this.gbRezervacija.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.GroupBox gbRezervacija;
        private System.Windows.Forms.TextBox txtDatum;
        private System.Windows.Forms.ComboBox cmbRadnik;
        private System.Windows.Forms.Label lblRadnik;
        private System.Windows.Forms.ComboBox cmbDestinacija;
        private System.Windows.Forms.Label lblDestinacija;
        private System.Windows.Forms.ComboBox cmbTurista;
        private System.Windows.Forms.Label lblTurista;
        private System.Windows.Forms.TextBox txtBroj;
        private System.Windows.Forms.Label lblBroj;
        private System.Windows.Forms.ComboBox cmbMesto;
        private System.Windows.Forms.Label lblMesto;
        private System.Windows.Forms.Button btnSacuvaj;
        private System.Windows.Forms.Label lblDatum;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}