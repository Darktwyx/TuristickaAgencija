namespace Klijent.KorisnickiInterfejs
{
    partial class PretragaDestinacija
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PretragaDestinacija));
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.lblNaziv = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.lblKriterijumPretrage = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(141, 51);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(225, 20);
            this.txtNaziv.TabIndex = 16;
            this.txtNaziv.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNaziv_KeyDown);
            // 
            // lblNaziv
            // 
            this.lblNaziv.AutoSize = true;
            this.lblNaziv.Font = new System.Drawing.Font("Futura Md BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNaziv.Location = new System.Drawing.Point(90, 52);
            this.lblNaziv.Name = "lblNaziv";
            this.lblNaziv.Size = new System.Drawing.Size(45, 16);
            this.lblNaziv.TabIndex = 15;
            this.lblNaziv.Text = "Naziv:";
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(22, 91);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.Size = new System.Drawing.Size(435, 224);
            this.dataGridView.TabIndex = 17;
            this.dataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellDoubleClick);
            // 
            // lblKriterijumPretrage
            // 
            this.lblKriterijumPretrage.AutoSize = true;
            this.lblKriterijumPretrage.Font = new System.Drawing.Font("Futura Md BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKriterijumPretrage.Location = new System.Drawing.Point(195, 23);
            this.lblKriterijumPretrage.Name = "lblKriterijumPretrage";
            this.lblKriterijumPretrage.Size = new System.Drawing.Size(121, 16);
            this.lblKriterijumPretrage.TabIndex = 18;
            this.lblKriterijumPretrage.Text = "Kriterijum pretrage";
            // 
            // PretragaDestinacija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(479, 339);
            this.Controls.Add(this.lblKriterijumPretrage);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.lblNaziv);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PretragaDestinacija";
            this.Text = "Pretrazivanje destinacije";
            this.Load += new System.EventHandler(this.PretragaDestinacija_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.Label lblNaziv;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label lblKriterijumPretrage;
    }
}