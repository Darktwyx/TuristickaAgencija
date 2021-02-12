namespace Klijent.KorisnickiInterfejs
{
    partial class DetaljiDestinacije
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DetaljiDestinacije));
            this.gbDestinacija = new System.Windows.Forms.GroupBox();
            this.lblDatumRealizacije = new System.Windows.Forms.Label();
            this.cmbPrevoz = new System.Windows.Forms.ComboBox();
            this.lblPrevoz = new System.Windows.Forms.Label();
            this.lblDin = new System.Windows.Forms.Label();
            this.txtCena = new System.Windows.Forms.TextBox();
            this.lblCena = new System.Windows.Forms.Label();
            this.cmbFakultativniIzlet = new System.Windows.Forms.ComboBox();
            this.lblFakultativniIzlet = new System.Windows.Forms.Label();
            this.lblDolazak = new System.Windows.Forms.Label();
            this.txtOpis = new System.Windows.Forms.TextBox();
            this.lblOpis = new System.Windows.Forms.Label();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.lblNaziv = new System.Windows.Forms.Label();
            this.lblPolazak = new System.Windows.Forms.Label();
            this.btnIzmeni = new System.Windows.Forms.Button();
            this.btnDesno = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnLevo = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.txtDatumPolaska = new System.Windows.Forms.TextBox();
            this.txtDatumDolaska = new System.Windows.Forms.TextBox();
            this.txtDatumRealizacije = new System.Windows.Forms.TextBox();
            this.gbDestinacija.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // gbDestinacija
            // 
            this.gbDestinacija.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gbDestinacija.Controls.Add(this.txtDatumRealizacije);
            this.gbDestinacija.Controls.Add(this.txtDatumDolaska);
            this.gbDestinacija.Controls.Add(this.txtDatumPolaska);
            this.gbDestinacija.Controls.Add(this.lblDatumRealizacije);
            this.gbDestinacija.Controls.Add(this.cmbPrevoz);
            this.gbDestinacija.Controls.Add(this.lblPrevoz);
            this.gbDestinacija.Controls.Add(this.lblDin);
            this.gbDestinacija.Controls.Add(this.txtCena);
            this.gbDestinacija.Controls.Add(this.lblCena);
            this.gbDestinacija.Controls.Add(this.cmbFakultativniIzlet);
            this.gbDestinacija.Controls.Add(this.lblFakultativniIzlet);
            this.gbDestinacija.Controls.Add(this.lblDolazak);
            this.gbDestinacija.Controls.Add(this.txtOpis);
            this.gbDestinacija.Controls.Add(this.lblOpis);
            this.gbDestinacija.Controls.Add(this.txtNaziv);
            this.gbDestinacija.Controls.Add(this.lblNaziv);
            this.gbDestinacija.Controls.Add(this.lblPolazak);
            this.gbDestinacija.Controls.Add(this.btnIzmeni);
            this.gbDestinacija.Controls.Add(this.btnDesno);
            this.gbDestinacija.Controls.Add(this.btnLevo);
            this.gbDestinacija.Controls.Add(this.pictureBox);
            this.gbDestinacija.Font = new System.Drawing.Font("Futura Md BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDestinacija.Location = new System.Drawing.Point(29, 53);
            this.gbDestinacija.Name = "gbDestinacija";
            this.gbDestinacija.Size = new System.Drawing.Size(691, 405);
            this.gbDestinacija.TabIndex = 5;
            this.gbDestinacija.TabStop = false;
            this.gbDestinacija.Text = "Podaci o destinaciji";
            // 
            // lblDatumRealizacije
            // 
            this.lblDatumRealizacije.AutoSize = true;
            this.lblDatumRealizacije.Font = new System.Drawing.Font("Futura Md BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatumRealizacije.Location = new System.Drawing.Point(358, 331);
            this.lblDatumRealizacije.Name = "lblDatumRealizacije";
            this.lblDatumRealizacije.Size = new System.Drawing.Size(116, 32);
            this.lblDatumRealizacije.TabIndex = 50;
            this.lblDatumRealizacije.Text = "Datum realizacije:\r\n(dd/MM/yyyy)\r\n";
            // 
            // cmbPrevoz
            // 
            this.cmbPrevoz.FormattingEnabled = true;
            this.cmbPrevoz.Items.AddRange(new object[] {
            "Avion",
            "Autobus",
            "Sopstveni prevoz"});
            this.cmbPrevoz.Location = new System.Drawing.Point(111, 218);
            this.cmbPrevoz.Name = "cmbPrevoz";
            this.cmbPrevoz.Size = new System.Drawing.Size(225, 24);
            this.cmbPrevoz.TabIndex = 49;
            // 
            // lblPrevoz
            // 
            this.lblPrevoz.AutoSize = true;
            this.lblPrevoz.Font = new System.Drawing.Font("Futura Md BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrevoz.Location = new System.Drawing.Point(24, 222);
            this.lblPrevoz.Name = "lblPrevoz";
            this.lblPrevoz.Size = new System.Drawing.Size(51, 16);
            this.lblPrevoz.TabIndex = 48;
            this.lblPrevoz.Text = "Prevoz:";
            // 
            // lblDin
            // 
            this.lblDin.AutoSize = true;
            this.lblDin.Font = new System.Drawing.Font("Futura Md BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDin.Location = new System.Drawing.Point(304, 162);
            this.lblDin.Name = "lblDin";
            this.lblDin.Size = new System.Drawing.Size(31, 16);
            this.lblDin.TabIndex = 47;
            this.lblDin.Text = "din.";
            // 
            // txtCena
            // 
            this.txtCena.Location = new System.Drawing.Point(111, 155);
            this.txtCena.Multiline = true;
            this.txtCena.Name = "txtCena";
            this.txtCena.Size = new System.Drawing.Size(187, 51);
            this.txtCena.TabIndex = 46;
            // 
            // lblCena
            // 
            this.lblCena.AutoSize = true;
            this.lblCena.Font = new System.Drawing.Font("Futura Md BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCena.Location = new System.Drawing.Point(24, 158);
            this.lblCena.Name = "lblCena";
            this.lblCena.Size = new System.Drawing.Size(44, 16);
            this.lblCena.TabIndex = 45;
            this.lblCena.Text = "Cena:";
            // 
            // cmbFakultativniIzlet
            // 
            this.cmbFakultativniIzlet.FormattingEnabled = true;
            this.cmbFakultativniIzlet.Location = new System.Drawing.Point(481, 296);
            this.cmbFakultativniIzlet.Name = "cmbFakultativniIzlet";
            this.cmbFakultativniIzlet.Size = new System.Drawing.Size(188, 24);
            this.cmbFakultativniIzlet.TabIndex = 44;
            // 
            // lblFakultativniIzlet
            // 
            this.lblFakultativniIzlet.AutoSize = true;
            this.lblFakultativniIzlet.Font = new System.Drawing.Font("Futura Md BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFakultativniIzlet.Location = new System.Drawing.Point(358, 299);
            this.lblFakultativniIzlet.Name = "lblFakultativniIzlet";
            this.lblFakultativniIzlet.Size = new System.Drawing.Size(108, 16);
            this.lblFakultativniIzlet.TabIndex = 43;
            this.lblFakultativniIzlet.Text = "Fakultativni izlet:";
            // 
            // lblDolazak
            // 
            this.lblDolazak.AutoSize = true;
            this.lblDolazak.Font = new System.Drawing.Font("Futura Md BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDolazak.Location = new System.Drawing.Point(24, 331);
            this.lblDolazak.Name = "lblDolazak";
            this.lblDolazak.Size = new System.Drawing.Size(105, 32);
            this.lblDolazak.TabIndex = 41;
            this.lblDolazak.Text = "Datum dolaska:\r\n(dd/MM/yyyy)\r\n";
            // 
            // txtOpis
            // 
            this.txtOpis.Location = new System.Drawing.Point(111, 72);
            this.txtOpis.Multiline = true;
            this.txtOpis.Name = "txtOpis";
            this.txtOpis.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtOpis.Size = new System.Drawing.Size(225, 73);
            this.txtOpis.TabIndex = 40;
            // 
            // lblOpis
            // 
            this.lblOpis.AutoSize = true;
            this.lblOpis.Font = new System.Drawing.Font("Futura Md BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpis.Location = new System.Drawing.Point(24, 72);
            this.lblOpis.Name = "lblOpis";
            this.lblOpis.Size = new System.Drawing.Size(40, 16);
            this.lblOpis.TabIndex = 39;
            this.lblOpis.Text = "Opis:";
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(111, 37);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(225, 23);
            this.txtNaziv.TabIndex = 38;
            // 
            // lblNaziv
            // 
            this.lblNaziv.AutoSize = true;
            this.lblNaziv.Font = new System.Drawing.Font("Futura Md BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNaziv.Location = new System.Drawing.Point(24, 40);
            this.lblNaziv.Name = "lblNaziv";
            this.lblNaziv.Size = new System.Drawing.Size(45, 16);
            this.lblNaziv.TabIndex = 35;
            this.lblNaziv.Text = "Naziv:";
            // 
            // lblPolazak
            // 
            this.lblPolazak.AutoSize = true;
            this.lblPolazak.Font = new System.Drawing.Font("Futura Md BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPolazak.Location = new System.Drawing.Point(24, 259);
            this.lblPolazak.Name = "lblPolazak";
            this.lblPolazak.Size = new System.Drawing.Size(105, 32);
            this.lblPolazak.TabIndex = 36;
            this.lblPolazak.Text = "Datum polaska:\r\n(dd/MM/yyyy)\r\n";
            // 
            // btnIzmeni
            // 
            this.btnIzmeni.BackColor = System.Drawing.Color.LightGray;
            this.btnIzmeni.Font = new System.Drawing.Font("Futura Md BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIzmeni.Location = new System.Drawing.Point(371, 246);
            this.btnIzmeni.Name = "btnIzmeni";
            this.btnIzmeni.Size = new System.Drawing.Size(288, 35);
            this.btnIzmeni.TabIndex = 10;
            this.btnIzmeni.Text = "Izmeni destinaciju";
            this.btnIzmeni.UseVisualStyleBackColor = false;
            this.btnIzmeni.Click += new System.EventHandler(this.btnIzmeni_Click);
            // 
            // btnDesno
            // 
            this.btnDesno.BackColor = System.Drawing.Color.LightGray;
            this.btnDesno.Font = new System.Drawing.Font("Futura Md BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDesno.ImageIndex = 1;
            this.btnDesno.ImageList = this.imageList1;
            this.btnDesno.Location = new System.Drawing.Point(567, 205);
            this.btnDesno.Name = "btnDesno";
            this.btnDesno.Size = new System.Drawing.Size(92, 35);
            this.btnDesno.TabIndex = 34;
            this.btnDesno.UseVisualStyleBackColor = false;
            this.btnDesno.Click += new System.EventHandler(this.btnDesno_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "ArrowLeft.png");
            this.imageList1.Images.SetKeyName(1, "ArrowRight.png");
            // 
            // btnLevo
            // 
            this.btnLevo.BackColor = System.Drawing.Color.LightGray;
            this.btnLevo.Enabled = false;
            this.btnLevo.Font = new System.Drawing.Font("Futura Md BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLevo.ImageIndex = 0;
            this.btnLevo.ImageList = this.imageList1;
            this.btnLevo.Location = new System.Drawing.Point(371, 205);
            this.btnLevo.Name = "btnLevo";
            this.btnLevo.Size = new System.Drawing.Size(92, 35);
            this.btnLevo.TabIndex = 33;
            this.btnLevo.UseVisualStyleBackColor = false;
            this.btnLevo.Click += new System.EventHandler(this.btnLevo_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(371, 37);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(288, 162);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 32;
            this.pictureBox.TabStop = false;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(365, 18);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(50, 20);
            this.txtID.TabIndex = 53;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Futura Md BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(333, 20);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(26, 16);
            this.lblID.TabIndex = 52;
            this.lblID.Text = "ID:";
            // 
            // txtDatumPolaska
            // 
            this.txtDatumPolaska.Location = new System.Drawing.Point(148, 256);
            this.txtDatumPolaska.Multiline = true;
            this.txtDatumPolaska.Name = "txtDatumPolaska";
            this.txtDatumPolaska.Size = new System.Drawing.Size(188, 58);
            this.txtDatumPolaska.TabIndex = 52;
            // 
            // txtDatumDolaska
            // 
            this.txtDatumDolaska.Location = new System.Drawing.Point(148, 328);
            this.txtDatumDolaska.Multiline = true;
            this.txtDatumDolaska.Name = "txtDatumDolaska";
            this.txtDatumDolaska.Size = new System.Drawing.Size(188, 58);
            this.txtDatumDolaska.TabIndex = 53;
            // 
            // txtDatumRealizacije
            // 
            this.txtDatumRealizacije.Location = new System.Drawing.Point(481, 328);
            this.txtDatumRealizacije.Multiline = true;
            this.txtDatumRealizacije.Name = "txtDatumRealizacije";
            this.txtDatumRealizacije.Size = new System.Drawing.Size(188, 58);
            this.txtDatumRealizacije.TabIndex = 54;
            // 
            // DetaljiDestinacije
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(751, 485);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.gbDestinacija);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DetaljiDestinacije";
            this.Text = "Detalji destinacije";
            this.Load += new System.EventHandler(this.DetaljiDestinacije_Load);
            this.gbDestinacija.ResumeLayout(false);
            this.gbDestinacija.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDestinacija;
        private System.Windows.Forms.Button btnDesno;
        private System.Windows.Forms.Button btnLevo;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button btnIzmeni;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label lblDatumRealizacije;
        private System.Windows.Forms.ComboBox cmbPrevoz;
        private System.Windows.Forms.Label lblPrevoz;
        private System.Windows.Forms.Label lblDin;
        private System.Windows.Forms.TextBox txtCena;
        private System.Windows.Forms.Label lblCena;
        private System.Windows.Forms.ComboBox cmbFakultativniIzlet;
        private System.Windows.Forms.Label lblFakultativniIzlet;
        private System.Windows.Forms.Label lblDolazak;
        private System.Windows.Forms.TextBox txtOpis;
        private System.Windows.Forms.Label lblOpis;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.Label lblNaziv;
        private System.Windows.Forms.Label lblPolazak;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtDatumRealizacije;
        private System.Windows.Forms.TextBox txtDatumDolaska;
        private System.Windows.Forms.TextBox txtDatumPolaska;
    }
}