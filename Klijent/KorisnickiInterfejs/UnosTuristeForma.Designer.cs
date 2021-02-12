namespace Klijent.KorisnickiInterfejs
{
    partial class UnosTuristeForma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UnosTuristeForma));
            this.btnKreiraj = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.gbTurista = new System.Windows.Forms.GroupBox();
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.txtBrojTelefona = new System.Windows.Forms.TextBox();
            this.txtAdresa = new System.Windows.Forms.TextBox();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.lblBrojTelefona = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblAdresa = new System.Windows.Forms.Label();
            this.lblPrezime = new System.Windows.Forms.Label();
            this.lblIme = new System.Windows.Forms.Label();
            this.txtDatum = new System.Windows.Forms.TextBox();
            this.gbTurista.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnKreiraj
            // 
            this.btnKreiraj.BackColor = System.Drawing.Color.LightGray;
            this.btnKreiraj.Font = new System.Drawing.Font("Futura Md BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKreiraj.Location = new System.Drawing.Point(214, 23);
            this.btnKreiraj.Name = "btnKreiraj";
            this.btnKreiraj.Size = new System.Drawing.Size(92, 35);
            this.btnKreiraj.TabIndex = 10;
            this.btnKreiraj.Text = "Kreiraj";
            this.btnKreiraj.UseVisualStyleBackColor = false;
            this.btnKreiraj.Click += new System.EventHandler(this.btnKreiraj_Click);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(128, 31);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(50, 20);
            this.txtID.TabIndex = 9;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Futura Md BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(96, 33);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(26, 16);
            this.lblID.TabIndex = 8;
            this.lblID.Text = "ID:";
            // 
            // gbTurista
            // 
            this.gbTurista.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gbTurista.Controls.Add(this.txtDatum);
            this.gbTurista.Controls.Add(this.btnSacuvaj);
            this.gbTurista.Controls.Add(this.txtBrojTelefona);
            this.gbTurista.Controls.Add(this.txtAdresa);
            this.gbTurista.Controls.Add(this.txtPrezime);
            this.gbTurista.Controls.Add(this.txtIme);
            this.gbTurista.Controls.Add(this.lblBrojTelefona);
            this.gbTurista.Controls.Add(this.lblDate);
            this.gbTurista.Controls.Add(this.lblAdresa);
            this.gbTurista.Controls.Add(this.lblPrezime);
            this.gbTurista.Controls.Add(this.lblIme);
            this.gbTurista.Enabled = false;
            this.gbTurista.Font = new System.Drawing.Font("Futura Md BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTurista.Location = new System.Drawing.Point(25, 80);
            this.gbTurista.Name = "gbTurista";
            this.gbTurista.Size = new System.Drawing.Size(360, 259);
            this.gbTurista.TabIndex = 11;
            this.gbTurista.TabStop = false;
            this.gbTurista.Text = "Podaci o turisti";
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.BackColor = System.Drawing.Color.LightGray;
            this.btnSacuvaj.Font = new System.Drawing.Font("Futura Md BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSacuvaj.Location = new System.Drawing.Point(133, 205);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(148, 35);
            this.btnSacuvaj.TabIndex = 12;
            this.btnSacuvaj.Text = "Sacuvaj";
            this.btnSacuvaj.UseVisualStyleBackColor = false;
            this.btnSacuvaj.Click += new System.EventHandler(this.btnSacuvaj_Click);
            // 
            // txtBrojTelefona
            // 
            this.txtBrojTelefona.Location = new System.Drawing.Point(133, 172);
            this.txtBrojTelefona.Name = "txtBrojTelefona";
            this.txtBrojTelefona.Size = new System.Drawing.Size(208, 23);
            this.txtBrojTelefona.TabIndex = 19;
            // 
            // txtAdresa
            // 
            this.txtAdresa.Location = new System.Drawing.Point(133, 94);
            this.txtAdresa.Name = "txtAdresa";
            this.txtAdresa.Size = new System.Drawing.Size(208, 23);
            this.txtAdresa.TabIndex = 18;
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(133, 64);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(208, 23);
            this.txtPrezime.TabIndex = 17;
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(133, 33);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(208, 23);
            this.txtIme.TabIndex = 13;
            // 
            // lblBrojTelefona
            // 
            this.lblBrojTelefona.AutoSize = true;
            this.lblBrojTelefona.Location = new System.Drawing.Point(21, 174);
            this.lblBrojTelefona.Name = "lblBrojTelefona";
            this.lblBrojTelefona.Size = new System.Drawing.Size(88, 16);
            this.lblBrojTelefona.TabIndex = 4;
            this.lblBrojTelefona.Text = "Broj telefona:";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(21, 125);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(111, 32);
            this.lblDate.TabIndex = 3;
            this.lblDate.Text = "Datum rodjenja: \r\n(dd/mm/yyyy)";
            // 
            // lblAdresa
            // 
            this.lblAdresa.AutoSize = true;
            this.lblAdresa.Location = new System.Drawing.Point(21, 97);
            this.lblAdresa.Name = "lblAdresa";
            this.lblAdresa.Size = new System.Drawing.Size(55, 16);
            this.lblAdresa.TabIndex = 2;
            this.lblAdresa.Text = "Adresa:";
            // 
            // lblPrezime
            // 
            this.lblPrezime.AutoSize = true;
            this.lblPrezime.Location = new System.Drawing.Point(21, 67);
            this.lblPrezime.Name = "lblPrezime";
            this.lblPrezime.Size = new System.Drawing.Size(58, 16);
            this.lblPrezime.TabIndex = 1;
            this.lblPrezime.Text = "Prezime:";
            // 
            // lblIme
            // 
            this.lblIme.AutoSize = true;
            this.lblIme.Location = new System.Drawing.Point(21, 36);
            this.lblIme.Name = "lblIme";
            this.lblIme.Size = new System.Drawing.Size(34, 16);
            this.lblIme.TabIndex = 0;
            this.lblIme.Text = "Ime:";
            // 
            // txtDatum
            // 
            this.txtDatum.Location = new System.Drawing.Point(133, 125);
            this.txtDatum.Multiline = true;
            this.txtDatum.Name = "txtDatum";
            this.txtDatum.Size = new System.Drawing.Size(208, 41);
            this.txtDatum.TabIndex = 20;
            // 
            // UnosTuristeForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(410, 364);
            this.Controls.Add(this.gbTurista);
            this.Controls.Add(this.btnKreiraj);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblID);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UnosTuristeForma";
            this.Text = "Unos novog turiste";
            this.Load += new System.EventHandler(this.UnosTuristeForma_Load);
            this.gbTurista.ResumeLayout(false);
            this.gbTurista.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnKreiraj;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.GroupBox gbTurista;
        private System.Windows.Forms.Label lblIme;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblAdresa;
        private System.Windows.Forms.Label lblPrezime;
        private System.Windows.Forms.Label lblBrojTelefona;
        private System.Windows.Forms.Button btnSacuvaj;
        private System.Windows.Forms.TextBox txtBrojTelefona;
        private System.Windows.Forms.TextBox txtAdresa;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.TextBox txtDatum;
    }
}