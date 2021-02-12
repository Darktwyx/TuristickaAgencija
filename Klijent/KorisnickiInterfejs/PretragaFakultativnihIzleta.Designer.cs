namespace Klijent.KorisnickiInterfejs
{
    partial class PretragaFakultativnihIzleta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PretragaFakultativnihIzleta));
            this.lblKriterijumPretrage = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.txtMesto = new System.Windows.Forms.TextBox();
            this.lblMesto = new System.Windows.Forms.Label();
            this.btnObrisi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // lblKriterijumPretrage
            // 
            this.lblKriterijumPretrage.AutoSize = true;
            this.lblKriterijumPretrage.Font = new System.Drawing.Font("Futura Md BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKriterijumPretrage.Location = new System.Drawing.Point(116, 22);
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
            this.dataGridView.Location = new System.Drawing.Point(21, 93);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.Size = new System.Drawing.Size(435, 224);
            this.dataGridView.TabIndex = 21;
            // 
            // txtMesto
            // 
            this.txtMesto.Location = new System.Drawing.Point(78, 51);
            this.txtMesto.Name = "txtMesto";
            this.txtMesto.Size = new System.Drawing.Size(196, 20);
            this.txtMesto.TabIndex = 20;
            this.txtMesto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMesto_KeyDown);
            // 
            // lblMesto
            // 
            this.lblMesto.AutoSize = true;
            this.lblMesto.Font = new System.Drawing.Font("Futura Md BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMesto.Location = new System.Drawing.Point(23, 52);
            this.lblMesto.Name = "lblMesto";
            this.lblMesto.Size = new System.Drawing.Size(48, 16);
            this.lblMesto.TabIndex = 19;
            this.lblMesto.Text = "Mesto:";
            // 
            // btnObrisi
            // 
            this.btnObrisi.Font = new System.Drawing.Font("Futura Md BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnObrisi.Location = new System.Drawing.Point(304, 48);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(152, 23);
            this.btnObrisi.TabIndex = 23;
            this.btnObrisi.Text = "Obrisi fakultativni izlet";
            this.btnObrisi.UseVisualStyleBackColor = true;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // PretragaFakultativnihIzleta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(478, 339);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.lblKriterijumPretrage);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.txtMesto);
            this.Controls.Add(this.lblMesto);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PretragaFakultativnihIzleta";
            this.Text = "Pretraga fakultativnih izleta";
            this.Load += new System.EventHandler(this.PretragaFakultativnihIzleta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKriterijumPretrage;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.TextBox txtMesto;
        private System.Windows.Forms.Label lblMesto;
        private System.Windows.Forms.Button btnObrisi;
    }
}