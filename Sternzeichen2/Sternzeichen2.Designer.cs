
namespace Sternzeichen2
{
    partial class Sternzeichen2
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sternzeichen2));
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.BtnSuchen = new System.Windows.Forms.Button();
            this.PbSternzeichen = new System.Windows.Forms.PictureBox();
            this.LblSternzeichen = new System.Windows.Forms.Label();
            this.BtnKontakt = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PbSternzeichen)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Alien", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SkyBlue;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(387, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sternzeichen 2";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(21, 89);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // BtnSuchen
            // 
            this.BtnSuchen.BackColor = System.Drawing.Color.Navy;
            this.BtnSuchen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSuchen.ForeColor = System.Drawing.Color.SkyBlue;
            this.BtnSuchen.Location = new System.Drawing.Point(21, 116);
            this.BtnSuchen.Name = "BtnSuchen";
            this.BtnSuchen.Size = new System.Drawing.Size(200, 23);
            this.BtnSuchen.TabIndex = 2;
            this.BtnSuchen.Text = "Suchen";
            this.BtnSuchen.UseVisualStyleBackColor = false;
            this.BtnSuchen.Click += new System.EventHandler(this.BtnSuchen_Click);
            // 
            // PbSternzeichen
            // 
            this.PbSternzeichen.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PbSternzeichen.Image = global::Sternzeichen2.Properties.Resources._default;
            this.PbSternzeichen.Location = new System.Drawing.Point(21, 145);
            this.PbSternzeichen.Name = "PbSternzeichen";
            this.PbSternzeichen.Size = new System.Drawing.Size(200, 209);
            this.PbSternzeichen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbSternzeichen.TabIndex = 3;
            this.PbSternzeichen.TabStop = false;
            // 
            // LblSternzeichen
            // 
            this.LblSternzeichen.AutoSize = true;
            this.LblSternzeichen.BackColor = System.Drawing.Color.Transparent;
            this.LblSternzeichen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LblSternzeichen.Font = new System.Drawing.Font("ArnoldBoecklin", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSternzeichen.ForeColor = System.Drawing.Color.Gold;
            this.LblSternzeichen.Location = new System.Drawing.Point(16, 364);
            this.LblSternzeichen.Name = "LblSternzeichen";
            this.LblSternzeichen.Size = new System.Drawing.Size(227, 34);
            this.LblSternzeichen.TabIndex = 4;
            this.LblSternzeichen.Text = "Sternzeichen 2";
            this.LblSternzeichen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnKontakt
            // 
            this.BtnKontakt.BackColor = System.Drawing.Color.Transparent;
            this.BtnKontakt.BackgroundImage = global::Sternzeichen2.Properties.Resources.E_mail;
            this.BtnKontakt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnKontakt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnKontakt.Location = new System.Drawing.Point(350, 335);
            this.BtnKontakt.Name = "BtnKontakt";
            this.BtnKontakt.Size = new System.Drawing.Size(50, 50);
            this.BtnKontakt.TabIndex = 5;
            this.BtnKontakt.UseVisualStyleBackColor = false;
            this.BtnKontakt.Click += new System.EventHandler(this.BtnKontakt_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.BackColor = System.Drawing.Color.Transparent;
            this.BtnExit.BackgroundImage = global::Sternzeichen2.Properties.Resources.x_symbol;
            this.BtnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExit.Location = new System.Drawing.Point(350, 379);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(50, 50);
            this.BtnExit.TabIndex = 6;
            this.BtnExit.UseVisualStyleBackColor = false;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("ArnoldBoecklin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gold;
            this.label2.Location = new System.Drawing.Point(236, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 128);
            this.label2.TabIndex = 7;
            this.label2.Text = "Durch Eingabe des Geburtstdatums wird das entprechende Sternzeichen berechnet.";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Sternzeichen2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Sternzeichen2.Properties.Resources.Stars1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(414, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.BtnKontakt);
            this.Controls.Add(this.LblSternzeichen);
            this.Controls.Add(this.PbSternzeichen);
            this.Controls.Add(this.BtnSuchen);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Sternzeichen2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sternzeichen 2 | by Runenmeister 11/2023";
            ((System.ComponentModel.ISupportInitialize)(this.PbSternzeichen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button BtnSuchen;
        private System.Windows.Forms.PictureBox PbSternzeichen;
        private System.Windows.Forms.Label LblSternzeichen;
        private System.Windows.Forms.Button BtnKontakt;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Label label2;
    }
}

