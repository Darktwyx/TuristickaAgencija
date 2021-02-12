namespace Klijent.KorisnickiInterfejs
{
    partial class PretragaRezervacije
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PretragaRezervacije));
            this.lblKriterijumPretrage = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.txtMestoPolaska = new System.Windows.Forms.TextBox();
            this.lblMestoPolaska = new System.Windows.Forms.Label();
            this.btnObrisi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // lblKriterijumPretrage
            // 
            this.lblKriterijumPretrage.AutoSize = true;
            this.lblKriterijumPretrage.Font = new System.Drawing.Font("Futura Md BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKriterijumPretrage.Location = new System.Drawing.Point(183, 24);
            this.lblKriterijumPretrage.Name = "lblKriterijumPretrage";
            this.lblKriterijumPretrage.Size = new System.Drawing.Size(121, 16);
            this.lblKriterijumPretrage.TabIndex = 22;
            this.lblKriterijumPretrage.Text = "Kriterijum pretrage";
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(29, 93);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.Size = new System.Drawing.Size(435, 224);
            this.dataGridView.TabIndex = 21;
            this.dataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellDoubleClick);
            // 
            // txtMestoPolaska
            // 
            this.txtMestoPolaska.Location = new System.Drawing.Point(132, 53);
            this.txtMestoPolaska.Name = "txtMestoPolaska";
            this.txtMestoPolaska.Size = new System.Drawing.Size(190, 20);
            this.txtMestoPolaska.TabIndex = 20;
            this.txtMestoPolaska.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNaziv_KeyDown);
            // 
            // lblMestoPolaska
            // 
            this.lblMestoPolaska.AutoSize = true;
            this.lblMestoPolaska.Font = new System.Drawing.Font("Futura Md BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMestoPolaska.Location = new System.Drawing.Point(26, 54);
            this.lblMestoPolaska.Name = "lblMestoPolaska";
            this.lblMestoPolaska.Size = new System.Drawing.Size(100, 16);
            this.lblMestoPolaska.TabIndex = 19;
            this.lblMestoPolaska.Text = "Mesto polaska:";
            // 
            // btnObrisi
            // 
            this.btnObrisi.Font = new System.Drawing.Font("Futura Md BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnObrisi.Location = new System.Drawing.Point(335, 51);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(129, 23);
            this.btnObrisi.TabIndex = 24;
            this.btnObrisi.Text = "Obrisi rezervaciju";
            this.btnObrisi.UseVisualStyleBackColor = true;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // PretragaRezervacije
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(496, 341);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.lblKriterijumPretrage);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.txtMestoPolaska);
            this.Controls.Add(this.lblMestoPolaska);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PretragaRezervacije";
            this.Text = "Pretraga rezervacije";
            this.Load += new System.EventHandler(this.PretragaRezervacije_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKriterijumPretrage;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.TextBox txtMestoPolaska;
        private System.Windows.Forms.Label lblMestoPolaska;
        private System.Windows.Forms.Button btnObrisi;
    }
}