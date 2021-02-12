namespace Klijent.KorisnickiInterfejs
{
    partial class UnosDestinacijeForma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UnosDestinacijeForma));
            this.btnKreiraj = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.lblPolazak = new System.Windows.Forms.Label();
            this.lblNaziv = new System.Windows.Forms.Label();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.lblOpis = new System.Windows.Forms.Label();
            this.txtOpis = new System.Windows.Forms.TextBox();
            this.lblDolazak = new System.Windows.Forms.Label();
            this.lblFakultativniIzlet = new System.Windows.Forms.Label();
            this.cmbFakultativniIzlet = new System.Windows.Forms.ComboBox();
            this.btnDodajFoto = new System.Windows.Forms.Button();
            this.btnObrisiFoto = new System.Windows.Forms.Button();
            this.dataGridViewFoto = new System.Windows.Forms.DataGridView();
            this.lblCena = new System.Windows.Forms.Label();
            this.txtCena = new System.Windows.Forms.TextBox();
            this.lblDin = new System.Windows.Forms.Label();
            this.lblPrevoz = new System.Windows.Forms.Label();
            this.cmbPrevoz = new System.Windows.Forms.ComboBox();
            this.lblDatumRealizacije = new System.Windows.Forms.Label();
            this.txtDatumPolaska = new System.Windows.Forms.TextBox();
            this.txtDatumDolaska = new System.Windows.Forms.TextBox();
            this.txtDatumRealizacije = new System.Windows.Forms.TextBox();
            this.lblGreskaFoto = new System.Windows.Forms.Label();
            this.gbDestinacija = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFoto)).BeginInit();
            this.gbDestinacija.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnKreiraj
            // 
            this.btnKreiraj.BackColor = System.Drawing.Color.LightGray;
            this.btnKreiraj.Font = new System.Drawing.Font("Futura Md BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKreiraj.Location = new System.Drawing.Point(296, 21);
            this.btnKreiraj.Name = "btnKreiraj";
            this.btnKreiraj.Size = new System.Drawing.Size(92, 35);
            this.btnKreiraj.TabIndex = 7;
            this.btnKreiraj.Text = "Kreiraj";
            this.btnKreiraj.UseVisualStyleBackColor = false;
            this.btnKreiraj.Click += new System.EventHandler(this.btnKreiraj_Click);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(210, 29);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(50, 20);
            this.txtID.TabIndex = 6;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Futura Md BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(178, 31);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(26, 16);
            this.lblID.TabIndex = 5;
            this.lblID.Text = "ID:";
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.BackColor = System.Drawing.Color.LightGray;
            this.btnSacuvaj.Enabled = false;
            this.btnSacuvaj.Font = new System.Drawing.Font("Futura Md BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSacuvaj.Location = new System.Drawing.Point(415, 19);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(207, 38);
            this.btnSacuvaj.TabIndex = 4;
            this.btnSacuvaj.Text = "Sacuvaj destinaciju";
            this.btnSacuvaj.UseVisualStyleBackColor = false;
            this.btnSacuvaj.Click += new System.EventHandler(this.btnSacuvaj_Click);
            // 
            // lblPolazak
            // 
            this.lblPolazak.AutoSize = true;
            this.lblPolazak.Font = new System.Drawing.Font("Futura Md BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPolazak.Location = new System.Drawing.Point(25, 235);
            this.lblPolazak.Name = "lblPolazak";
            this.lblPolazak.Size = new System.Drawing.Size(105, 32);
            this.lblPolazak.TabIndex = 7;
            this.lblPolazak.Text = "Datum polaska:\r\n(dd/MM/yyyy)\r\n";
            // 
            // lblNaziv
            // 
            this.lblNaziv.AutoSize = true;
            this.lblNaziv.Font = new System.Drawing.Font("Futura Md BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNaziv.Location = new System.Drawing.Point(25, 40);
            this.lblNaziv.Name = "lblNaziv";
            this.lblNaziv.Size = new System.Drawing.Size(45, 16);
            this.lblNaziv.TabIndex = 4;
            this.lblNaziv.Text = "Naziv:";
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(112, 37);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(249, 23);
            this.txtNaziv.TabIndex = 14;
            // 
            // lblOpis
            // 
            this.lblOpis.AutoSize = true;
            this.lblOpis.Font = new System.Drawing.Font("Futura Md BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpis.Location = new System.Drawing.Point(25, 69);
            this.lblOpis.Name = "lblOpis";
            this.lblOpis.Size = new System.Drawing.Size(40, 16);
            this.lblOpis.TabIndex = 15;
            this.lblOpis.Text = "Opis:";
            // 
            // txtOpis
            // 
            this.txtOpis.Location = new System.Drawing.Point(112, 69);
            this.txtOpis.Multiline = true;
            this.txtOpis.Name = "txtOpis";
            this.txtOpis.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtOpis.Size = new System.Drawing.Size(249, 73);
            this.txtOpis.TabIndex = 16;
            // 
            // lblDolazak
            // 
            this.lblDolazak.AutoSize = true;
            this.lblDolazak.Font = new System.Drawing.Font("Futura Md BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDolazak.Location = new System.Drawing.Point(25, 289);
            this.lblDolazak.Name = "lblDolazak";
            this.lblDolazak.Size = new System.Drawing.Size(105, 32);
            this.lblDolazak.TabIndex = 17;
            this.lblDolazak.Text = "Datum dolaska:\r\n(dd/MM/yyyy)\r\n";
            // 
            // lblFakultativniIzlet
            // 
            this.lblFakultativniIzlet.AutoSize = true;
            this.lblFakultativniIzlet.Font = new System.Drawing.Font("Futura Md BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFakultativniIzlet.Location = new System.Drawing.Point(385, 238);
            this.lblFakultativniIzlet.Name = "lblFakultativniIzlet";
            this.lblFakultativniIzlet.Size = new System.Drawing.Size(108, 16);
            this.lblFakultativniIzlet.TabIndex = 19;
            this.lblFakultativniIzlet.Text = "Fakultativni izlet:";
            // 
            // cmbFakultativniIzlet
            // 
            this.cmbFakultativniIzlet.FormattingEnabled = true;
            this.cmbFakultativniIzlet.Location = new System.Drawing.Point(509, 235);
            this.cmbFakultativniIzlet.Name = "cmbFakultativniIzlet";
            this.cmbFakultativniIzlet.Size = new System.Drawing.Size(199, 24);
            this.cmbFakultativniIzlet.TabIndex = 20;
            // 
            // btnDodajFoto
            // 
            this.btnDodajFoto.BackColor = System.Drawing.Color.LightGray;
            this.btnDodajFoto.Font = new System.Drawing.Font("Futura Md BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajFoto.Location = new System.Drawing.Point(439, 188);
            this.btnDodajFoto.Name = "btnDodajFoto";
            this.btnDodajFoto.Size = new System.Drawing.Size(123, 35);
            this.btnDodajFoto.TabIndex = 23;
            this.btnDodajFoto.Text = "Dodaj fotografiju";
            this.btnDodajFoto.UseVisualStyleBackColor = false;
            this.btnDodajFoto.Click += new System.EventHandler(this.btnDodajFoto_Click);
            // 
            // btnObrisiFoto
            // 
            this.btnObrisiFoto.BackColor = System.Drawing.Color.LightGray;
            this.btnObrisiFoto.Font = new System.Drawing.Font("Futura Md BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnObrisiFoto.Location = new System.Drawing.Point(585, 188);
            this.btnObrisiFoto.Name = "btnObrisiFoto";
            this.btnObrisiFoto.Size = new System.Drawing.Size(123, 35);
            this.btnObrisiFoto.TabIndex = 24;
            this.btnObrisiFoto.Text = "Obrisi fotografiju";
            this.btnObrisiFoto.UseVisualStyleBackColor = false;
            this.btnObrisiFoto.Click += new System.EventHandler(this.btnObrisiFoto_Click);
            // 
            // dataGridViewFoto
            // 
            this.dataGridViewFoto.AllowUserToAddRows = false;
            this.dataGridViewFoto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewFoto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFoto.Location = new System.Drawing.Point(439, 22);
            this.dataGridViewFoto.Name = "dataGridViewFoto";
            this.dataGridViewFoto.RowHeadersVisible = false;
            this.dataGridViewFoto.Size = new System.Drawing.Size(269, 120);
            this.dataGridViewFoto.TabIndex = 25;
            // 
            // lblCena
            // 
            this.lblCena.AutoSize = true;
            this.lblCena.Font = new System.Drawing.Font("Futura Md BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCena.Location = new System.Drawing.Point(25, 151);
            this.lblCena.Name = "lblCena";
            this.lblCena.Size = new System.Drawing.Size(44, 16);
            this.lblCena.TabIndex = 26;
            this.lblCena.Text = "Cena:";
            // 
            // txtCena
            // 
            this.txtCena.Location = new System.Drawing.Point(112, 148);
            this.txtCena.Multiline = true;
            this.txtCena.Name = "txtCena";
            this.txtCena.Size = new System.Drawing.Size(188, 45);
            this.txtCena.TabIndex = 27;
            // 
            // lblDin
            // 
            this.lblDin.AutoSize = true;
            this.lblDin.Font = new System.Drawing.Font("Futura Md BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDin.Location = new System.Drawing.Point(306, 151);
            this.lblDin.Name = "lblDin";
            this.lblDin.Size = new System.Drawing.Size(31, 16);
            this.lblDin.TabIndex = 28;
            this.lblDin.Text = "din.";
            // 
            // lblPrevoz
            // 
            this.lblPrevoz.AutoSize = true;
            this.lblPrevoz.Font = new System.Drawing.Font("Futura Md BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrevoz.Location = new System.Drawing.Point(26, 201);
            this.lblPrevoz.Name = "lblPrevoz";
            this.lblPrevoz.Size = new System.Drawing.Size(51, 16);
            this.lblPrevoz.TabIndex = 29;
            this.lblPrevoz.Text = "Prevoz:";
            // 
            // cmbPrevoz
            // 
            this.cmbPrevoz.FormattingEnabled = true;
            this.cmbPrevoz.Items.AddRange(new object[] {
            "Avion",
            "Autobus",
            "Sopstveni prevoz"});
            this.cmbPrevoz.Location = new System.Drawing.Point(112, 198);
            this.cmbPrevoz.Name = "cmbPrevoz";
            this.cmbPrevoz.Size = new System.Drawing.Size(249, 24);
            this.cmbPrevoz.TabIndex = 30;
            // 
            // lblDatumRealizacije
            // 
            this.lblDatumRealizacije.AutoSize = true;
            this.lblDatumRealizacije.Font = new System.Drawing.Font("Futura Md BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatumRealizacije.Location = new System.Drawing.Point(387, 274);
            this.lblDatumRealizacije.Name = "lblDatumRealizacije";
            this.lblDatumRealizacije.Size = new System.Drawing.Size(116, 32);
            this.lblDatumRealizacije.TabIndex = 32;
            this.lblDatumRealizacije.Text = "Datum realizacije:\r\n(dd/MM/yyyy)\r\n";
            // 
            // txtDatumPolaska
            // 
            this.txtDatumPolaska.Location = new System.Drawing.Point(136, 232);
            this.txtDatumPolaska.Multiline = true;
            this.txtDatumPolaska.Name = "txtDatumPolaska";
            this.txtDatumPolaska.Size = new System.Drawing.Size(225, 43);
            this.txtDatumPolaska.TabIndex = 33;
            // 
            // txtDatumDolaska
            // 
            this.txtDatumDolaska.Location = new System.Drawing.Point(136, 286);
            this.txtDatumDolaska.Multiline = true;
            this.txtDatumDolaska.Name = "txtDatumDolaska";
            this.txtDatumDolaska.Size = new System.Drawing.Size(225, 43);
            this.txtDatumDolaska.TabIndex = 34;
            // 
            // txtDatumRealizacije
            // 
            this.txtDatumRealizacije.Location = new System.Drawing.Point(509, 271);
            this.txtDatumRealizacije.Multiline = true;
            this.txtDatumRealizacije.Name = "txtDatumRealizacije";
            this.txtDatumRealizacije.Size = new System.Drawing.Size(199, 58);
            this.txtDatumRealizacije.TabIndex = 35;
            // 
            // lblGreskaFoto
            // 
            this.lblGreskaFoto.AutoSize = true;
            this.lblGreskaFoto.Font = new System.Drawing.Font("Futura Md BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGreskaFoto.Location = new System.Drawing.Point(441, 158);
            this.lblGreskaFoto.Name = "lblGreskaFoto";
            this.lblGreskaFoto.Size = new System.Drawing.Size(0, 16);
            this.lblGreskaFoto.TabIndex = 36;
            // 
            // gbDestinacija
            // 
            this.gbDestinacija.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gbDestinacija.Controls.Add(this.lblGreskaFoto);
            this.gbDestinacija.Controls.Add(this.txtDatumRealizacije);
            this.gbDestinacija.Controls.Add(this.txtDatumDolaska);
            this.gbDestinacija.Controls.Add(this.txtDatumPolaska);
            this.gbDestinacija.Controls.Add(this.lblDatumRealizacije);
            this.gbDestinacija.Controls.Add(this.cmbPrevoz);
            this.gbDestinacija.Controls.Add(this.lblPrevoz);
            this.gbDestinacija.Controls.Add(this.lblDin);
            this.gbDestinacija.Controls.Add(this.txtCena);
            this.gbDestinacija.Controls.Add(this.lblCena);
            this.gbDestinacija.Controls.Add(this.dataGridViewFoto);
            this.gbDestinacija.Controls.Add(this.btnObrisiFoto);
            this.gbDestinacija.Controls.Add(this.btnDodajFoto);
            this.gbDestinacija.Controls.Add(this.cmbFakultativniIzlet);
            this.gbDestinacija.Controls.Add(this.lblFakultativniIzlet);
            this.gbDestinacija.Controls.Add(this.lblDolazak);
            this.gbDestinacija.Controls.Add(this.txtOpis);
            this.gbDestinacija.Controls.Add(this.lblOpis);
            this.gbDestinacija.Controls.Add(this.txtNaziv);
            this.gbDestinacija.Controls.Add(this.lblNaziv);
            this.gbDestinacija.Controls.Add(this.lblPolazak);
            this.gbDestinacija.Enabled = false;
            this.gbDestinacija.Font = new System.Drawing.Font("Futura Md BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDestinacija.Location = new System.Drawing.Point(27, 72);
            this.gbDestinacija.Name = "gbDestinacija";
            this.gbDestinacija.Size = new System.Drawing.Size(732, 351);
            this.gbDestinacija.TabIndex = 4;
            this.gbDestinacija.TabStop = false;
            this.gbDestinacija.Text = "Podaci o destinaciji";
            // 
            // UnosDestinacijeForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(786, 448);
            this.Controls.Add(this.btnKreiraj);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.btnSacuvaj);
            this.Controls.Add(this.gbDestinacija);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UnosDestinacijeForma";
            this.Text = "Unos nove destinacije";
            this.Load += new System.EventHandler(this.UnosDestinacijeForma_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFoto)).EndInit();
            this.gbDestinacija.ResumeLayout(false);
            this.gbDestinacija.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnKreiraj;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Button btnSacuvaj;
        private System.Windows.Forms.Label lblPolazak;
        private System.Windows.Forms.Label lblNaziv;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.Label lblOpis;
        private System.Windows.Forms.TextBox txtOpis;
        private System.Windows.Forms.Label lblDolazak;
        private System.Windows.Forms.Label lblFakultativniIzlet;
        private System.Windows.Forms.ComboBox cmbFakultativniIzlet;
        private System.Windows.Forms.Button btnDodajFoto;
        private System.Windows.Forms.Button btnObrisiFoto;
        private System.Windows.Forms.DataGridView dataGridViewFoto;
        private System.Windows.Forms.Label lblCena;
        private System.Windows.Forms.TextBox txtCena;
        private System.Windows.Forms.Label lblDin;
        private System.Windows.Forms.Label lblPrevoz;
        private System.Windows.Forms.ComboBox cmbPrevoz;
        private System.Windows.Forms.Label lblDatumRealizacije;
        private System.Windows.Forms.TextBox txtDatumPolaska;
        private System.Windows.Forms.TextBox txtDatumDolaska;
        private System.Windows.Forms.TextBox txtDatumRealizacije;
        private System.Windows.Forms.Label lblGreskaFoto;
        private System.Windows.Forms.GroupBox gbDestinacija;
    }
}