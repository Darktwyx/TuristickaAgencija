namespace Klijent.KorisnickiInterfejs
{
    partial class UnosFakultativnogIzleta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UnosFakultativnogIzleta));
            this.btnKreiraj = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.gbFakultativniIzlet = new System.Windows.Forms.GroupBox();
            this.lblDin = new System.Windows.Forms.Label();
            this.txtCena = new System.Windows.Forms.TextBox();
            this.txtOpis = new System.Windows.Forms.TextBox();
            this.txtMesto = new System.Windows.Forms.TextBox();
            this.lblCena = new System.Windows.Forms.Label();
            this.lblOpis = new System.Windows.Forms.Label();
            this.lblMesto = new System.Windows.Forms.Label();
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.gbFakultativniIzlet.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnKreiraj
            // 
            this.btnKreiraj.BackColor = System.Drawing.Color.LightGray;
            this.btnKreiraj.Font = new System.Drawing.Font("Futura Md BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKreiraj.Location = new System.Drawing.Point(222, 19);
            this.btnKreiraj.Name = "btnKreiraj";
            this.btnKreiraj.Size = new System.Drawing.Size(92, 35);
            this.btnKreiraj.TabIndex = 7;
            this.btnKreiraj.Text = "Kreiraj";
            this.btnKreiraj.UseVisualStyleBackColor = false;
            this.btnKreiraj.Click += new System.EventHandler(this.btnKreiraj_Click);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(136, 27);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(50, 20);
            this.txtID.TabIndex = 6;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Futura Md BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(104, 29);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(26, 16);
            this.lblID.TabIndex = 5;
            this.lblID.Text = "ID:";
            // 
            // gbFakultativniIzlet
            // 
            this.gbFakultativniIzlet.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gbFakultativniIzlet.Controls.Add(this.lblDin);
            this.gbFakultativniIzlet.Controls.Add(this.txtCena);
            this.gbFakultativniIzlet.Controls.Add(this.txtOpis);
            this.gbFakultativniIzlet.Controls.Add(this.txtMesto);
            this.gbFakultativniIzlet.Controls.Add(this.lblCena);
            this.gbFakultativniIzlet.Controls.Add(this.lblOpis);
            this.gbFakultativniIzlet.Controls.Add(this.lblMesto);
            this.gbFakultativniIzlet.Controls.Add(this.btnSacuvaj);
            this.gbFakultativniIzlet.Enabled = false;
            this.gbFakultativniIzlet.Font = new System.Drawing.Font("Futura Md BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbFakultativniIzlet.Location = new System.Drawing.Point(35, 66);
            this.gbFakultativniIzlet.Name = "gbFakultativniIzlet";
            this.gbFakultativniIzlet.Size = new System.Drawing.Size(334, 222);
            this.gbFakultativniIzlet.TabIndex = 4;
            this.gbFakultativniIzlet.TabStop = false;
            this.gbFakultativniIzlet.Text = "Podaci o fakultativnom izletu";
            // 
            // lblDin
            // 
            this.lblDin.AutoSize = true;
            this.lblDin.Font = new System.Drawing.Font("Futura Md BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDin.Location = new System.Drawing.Point(288, 112);
            this.lblDin.Name = "lblDin";
            this.lblDin.Size = new System.Drawing.Size(31, 16);
            this.lblDin.TabIndex = 17;
            this.lblDin.Text = "din.";
            // 
            // txtCena
            // 
            this.txtCena.Location = new System.Drawing.Point(112, 109);
            this.txtCena.Multiline = true;
            this.txtCena.Name = "txtCena";
            this.txtCena.Size = new System.Drawing.Size(170, 48);
            this.txtCena.TabIndex = 16;
            // 
            // txtOpis
            // 
            this.txtOpis.Location = new System.Drawing.Point(112, 74);
            this.txtOpis.Name = "txtOpis";
            this.txtOpis.Size = new System.Drawing.Size(207, 23);
            this.txtOpis.TabIndex = 15;
            // 
            // txtMesto
            // 
            this.txtMesto.Location = new System.Drawing.Point(112, 37);
            this.txtMesto.Name = "txtMesto";
            this.txtMesto.Size = new System.Drawing.Size(207, 23);
            this.txtMesto.TabIndex = 14;
            // 
            // lblCena
            // 
            this.lblCena.AutoSize = true;
            this.lblCena.Font = new System.Drawing.Font("Futura Md BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCena.Location = new System.Drawing.Point(25, 112);
            this.lblCena.Name = "lblCena";
            this.lblCena.Size = new System.Drawing.Size(44, 16);
            this.lblCena.TabIndex = 6;
            this.lblCena.Text = "Cena:";
            // 
            // lblOpis
            // 
            this.lblOpis.AutoSize = true;
            this.lblOpis.Font = new System.Drawing.Font("Futura Md BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpis.Location = new System.Drawing.Point(25, 77);
            this.lblOpis.Name = "lblOpis";
            this.lblOpis.Size = new System.Drawing.Size(40, 16);
            this.lblOpis.TabIndex = 5;
            this.lblOpis.Text = "Opis:";
            // 
            // lblMesto
            // 
            this.lblMesto.AutoSize = true;
            this.lblMesto.Font = new System.Drawing.Font("Futura Md BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMesto.Location = new System.Drawing.Point(25, 40);
            this.lblMesto.Name = "lblMesto";
            this.lblMesto.Size = new System.Drawing.Size(48, 16);
            this.lblMesto.TabIndex = 4;
            this.lblMesto.Text = "Mesto:";
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.BackColor = System.Drawing.Color.LightGray;
            this.btnSacuvaj.Font = new System.Drawing.Font("Futura Md BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSacuvaj.Location = new System.Drawing.Point(112, 166);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(207, 38);
            this.btnSacuvaj.TabIndex = 4;
            this.btnSacuvaj.Text = "Sacuvaj";
            this.btnSacuvaj.UseVisualStyleBackColor = false;
            this.btnSacuvaj.Click += new System.EventHandler(this.btnSacuvaj_Click);
            // 
            // UnosFakultativnogIzleta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(405, 311);
            this.Controls.Add(this.btnKreiraj);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.gbFakultativniIzlet);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UnosFakultativnogIzleta";
            this.Text = "Unos novog fakultativnog izleta";
            this.Load += new System.EventHandler(this.UnosFakultativnogIzleta_Load);
            this.gbFakultativniIzlet.ResumeLayout(false);
            this.gbFakultativniIzlet.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnKreiraj;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.GroupBox gbFakultativniIzlet;
        private System.Windows.Forms.Label lblDin;
        private System.Windows.Forms.TextBox txtCena;
        private System.Windows.Forms.TextBox txtOpis;
        private System.Windows.Forms.TextBox txtMesto;
        private System.Windows.Forms.Label lblCena;
        private System.Windows.Forms.Label lblOpis;
        private System.Windows.Forms.Label lblMesto;
        private System.Windows.Forms.Button btnSacuvaj;
    }
}