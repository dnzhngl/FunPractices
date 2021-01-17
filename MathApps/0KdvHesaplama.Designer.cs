namespace MathApps
{
    partial class KdvHesaplama
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
            this.lvKdv = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblSoyad = new System.Windows.Forms.Label();
            this.lblAd = new System.Windows.Forms.Label();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.txtKdvOrani = new System.Windows.Forms.TextBox();
            this.lblKdvOrani = new System.Windows.Forms.Label();
            this.txtPara = new System.Windows.Forms.TextBox();
            this.lblPara = new System.Windows.Forms.Label();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lvKdv
            // 
            this.lvKdv.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.lvKdv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader7});
            this.lvKdv.FullRowSelect = true;
            this.lvKdv.GridLines = true;
            this.lvKdv.HideSelection = false;
            this.lvKdv.HoverSelection = true;
            this.lvKdv.Location = new System.Drawing.Point(171, 12);
            this.lvKdv.Name = "lvKdv";
            this.lvKdv.Size = new System.Drawing.Size(426, 162);
            this.lvKdv.TabIndex = 22;
            this.lvKdv.UseCompatibleStateImageBehavior = false;
            this.lvKdv.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Ad";
            this.columnHeader1.Width = 70;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Soyad";
            this.columnHeader2.Width = 70;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Para Miktarı";
            this.columnHeader3.Width = 70;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "KDV Orani";
            this.columnHeader4.Width = 70;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "KDV\'si";
            this.columnHeader5.Width = 70;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Toplam";
            this.columnHeader7.Width = 70;
            // 
            // lblSoyad
            // 
            this.lblSoyad.AutoSize = true;
            this.lblSoyad.BackColor = System.Drawing.Color.Transparent;
            this.lblSoyad.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSoyad.ForeColor = System.Drawing.Color.Black;
            this.lblSoyad.Location = new System.Drawing.Point(12, 41);
            this.lblSoyad.Name = "lblSoyad";
            this.lblSoyad.Size = new System.Drawing.Size(42, 15);
            this.lblSoyad.TabIndex = 21;
            this.lblSoyad.Text = "Soyad";
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.BackColor = System.Drawing.Color.Transparent;
            this.lblAd.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAd.ForeColor = System.Drawing.Color.Black;
            this.lblAd.Location = new System.Drawing.Point(12, 15);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(22, 15);
            this.lblAd.TabIndex = 20;
            this.lblAd.Text = "Ad";
            // 
            // btnHesapla
            // 
            this.btnHesapla.BackColor = System.Drawing.Color.Transparent;
            this.btnHesapla.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHesapla.ForeColor = System.Drawing.Color.Black;
            this.btnHesapla.Location = new System.Drawing.Point(15, 142);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(150, 32);
            this.btnHesapla.TabIndex = 29;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = false;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // txtKdvOrani
            // 
            this.txtKdvOrani.Location = new System.Drawing.Point(84, 90);
            this.txtKdvOrani.Name = "txtKdvOrani";
            this.txtKdvOrani.Size = new System.Drawing.Size(81, 20);
            this.txtKdvOrani.TabIndex = 28;
            // 
            // lblKdvOrani
            // 
            this.lblKdvOrani.AutoSize = true;
            this.lblKdvOrani.BackColor = System.Drawing.Color.Transparent;
            this.lblKdvOrani.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKdvOrani.ForeColor = System.Drawing.Color.Black;
            this.lblKdvOrani.Location = new System.Drawing.Point(12, 93);
            this.lblKdvOrani.Name = "lblKdvOrani";
            this.lblKdvOrani.Size = new System.Drawing.Size(65, 15);
            this.lblKdvOrani.TabIndex = 27;
            this.lblKdvOrani.Text = "KDV Oranı";
            // 
            // txtPara
            // 
            this.txtPara.Location = new System.Drawing.Point(84, 64);
            this.txtPara.Name = "txtPara";
            this.txtPara.Size = new System.Drawing.Size(81, 20);
            this.txtPara.TabIndex = 26;
            // 
            // lblPara
            // 
            this.lblPara.AutoSize = true;
            this.lblPara.BackColor = System.Drawing.Color.Transparent;
            this.lblPara.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPara.ForeColor = System.Drawing.Color.Black;
            this.lblPara.Location = new System.Drawing.Point(12, 67);
            this.lblPara.Name = "lblPara";
            this.lblPara.Size = new System.Drawing.Size(34, 15);
            this.lblPara.TabIndex = 25;
            this.lblPara.Text = "Para";
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(84, 38);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(81, 20);
            this.txtSoyad.TabIndex = 24;
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(84, 12);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(81, 20);
            this.txtAd.TabIndex = 23;
            // 
            // KdvHesaplama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 186);
            this.Controls.Add(this.lvKdv);
            this.Controls.Add(this.lblSoyad);
            this.Controls.Add(this.lblAd);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.txtKdvOrani);
            this.Controls.Add(this.lblKdvOrani);
            this.Controls.Add(this.txtPara);
            this.Controls.Add(this.lblPara);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.txtAd);
            this.Name = "KdvHesaplama";
            this.Text = "KDV Hesaplama";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvKdv;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.Label lblSoyad;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.TextBox txtKdvOrani;
        private System.Windows.Forms.Label lblKdvOrani;
        private System.Windows.Forms.TextBox txtPara;
        private System.Windows.Forms.Label lblPara;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtAd;
    }
}

