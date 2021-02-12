namespace ServerConsole
{
    partial class FormaServer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormaServer));
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnPokreni = new System.Windows.Forms.Button();
            this.btnZaustavi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblStatus.Font = new System.Drawing.Font("Futura Md BT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.Black;
            this.lblStatus.Location = new System.Drawing.Point(113, 61);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(215, 22);
            this.lblStatus.TabIndex = 0;
            this.lblStatus.Text = "Server nije pokrenut!";
            // 
            // btnPokreni
            // 
            this.btnPokreni.BackColor = System.Drawing.Color.LightGray;
            this.btnPokreni.Font = new System.Drawing.Font("Futura Md BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPokreni.Location = new System.Drawing.Point(50, 111);
            this.btnPokreni.Name = "btnPokreni";
            this.btnPokreni.Size = new System.Drawing.Size(151, 39);
            this.btnPokreni.TabIndex = 1;
            this.btnPokreni.Text = "Pokreni server";
            this.btnPokreni.UseVisualStyleBackColor = false;
            this.btnPokreni.Click += new System.EventHandler(this.btnPokreni_Click);
            // 
            // btnZaustavi
            // 
            this.btnZaustavi.BackColor = System.Drawing.Color.LightGray;
            this.btnZaustavi.Enabled = false;
            this.btnZaustavi.Font = new System.Drawing.Font("Futura Md BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZaustavi.Location = new System.Drawing.Point(225, 111);
            this.btnZaustavi.Name = "btnZaustavi";
            this.btnZaustavi.Size = new System.Drawing.Size(151, 39);
            this.btnZaustavi.TabIndex = 2;
            this.btnZaustavi.Text = "Zaustavi server";
            this.btnZaustavi.UseVisualStyleBackColor = false;
            this.btnZaustavi.Click += new System.EventHandler(this.btnZaustavi_Click);
            // 
            // FormaServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(438, 219);
            this.Controls.Add(this.btnZaustavi);
            this.Controls.Add(this.btnPokreni);
            this.Controls.Add(this.lblStatus);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormaServer";
            this.Text = "Server";
            this.Load += new System.EventHandler(this.FormaServer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnPokreni;
        private System.Windows.Forms.Button btnZaustavi;
    }
}

