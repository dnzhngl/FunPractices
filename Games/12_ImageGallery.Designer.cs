namespace Games
{
    partial class ImageGallery
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
            this.FlowLayoutPanelImg = new System.Windows.Forms.FlowLayoutPanel();
            this.pbBuyukResim = new System.Windows.Forms.PictureBox();
            this.btnRandom = new System.Windows.Forms.Button();
            this.btnPreviousImg = new System.Windows.Forms.Button();
            this.btnFirstImg = new System.Windows.Forms.Button();
            this.btnNextImg = new System.Windows.Forms.Button();
            this.btnSlide = new System.Windows.Forms.Button();
            this.btnLastImg = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbBuyukResim)).BeginInit();
            this.SuspendLayout();
            // 
            // FlowLayoutPanelImg
            // 
            this.FlowLayoutPanelImg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.FlowLayoutPanelImg.Location = new System.Drawing.Point(11, 12);
            this.FlowLayoutPanelImg.Margin = new System.Windows.Forms.Padding(4);
            this.FlowLayoutPanelImg.Name = "FlowLayoutPanelImg";
            this.FlowLayoutPanelImg.Size = new System.Drawing.Size(221, 534);
            this.FlowLayoutPanelImg.TabIndex = 0;
            // 
            // pbBuyukResim
            // 
            this.pbBuyukResim.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbBuyukResim.Location = new System.Drawing.Point(242, 10);
            this.pbBuyukResim.Margin = new System.Windows.Forms.Padding(4);
            this.pbBuyukResim.Name = "pbBuyukResim";
            this.pbBuyukResim.Size = new System.Drawing.Size(798, 490);
            this.pbBuyukResim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBuyukResim.TabIndex = 1;
            this.pbBuyukResim.TabStop = false;
            // 
            // btnRandom
            // 
            this.btnRandom.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnRandom.FlatAppearance.BorderSize = 0;
            this.btnRandom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRandom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRandom.Location = new System.Drawing.Point(514, 508);
            this.btnRandom.Margin = new System.Windows.Forms.Padding(4);
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.Size = new System.Drawing.Size(119, 38);
            this.btnRandom.TabIndex = 2;
            this.btnRandom.Text = "Random";
            this.btnRandom.UseVisualStyleBackColor = false;
            this.btnRandom.Click += new System.EventHandler(this.btnRandom_Click);
            // 
            // btnPreviousImg
            // 
            this.btnPreviousImg.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnPreviousImg.FlatAppearance.BorderSize = 0;
            this.btnPreviousImg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPreviousImg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPreviousImg.Location = new System.Drawing.Point(379, 508);
            this.btnPreviousImg.Margin = new System.Windows.Forms.Padding(4);
            this.btnPreviousImg.Name = "btnPreviousImg";
            this.btnPreviousImg.Size = new System.Drawing.Size(119, 38);
            this.btnPreviousImg.TabIndex = 2;
            this.btnPreviousImg.Text = "<<";
            this.btnPreviousImg.UseVisualStyleBackColor = false;
            this.btnPreviousImg.Click += new System.EventHandler(this.btnPreviousImg_Click);
            // 
            // btnFirstImg
            // 
            this.btnFirstImg.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnFirstImg.FlatAppearance.BorderSize = 0;
            this.btnFirstImg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFirstImg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFirstImg.Location = new System.Drawing.Point(244, 508);
            this.btnFirstImg.Margin = new System.Windows.Forms.Padding(4);
            this.btnFirstImg.Name = "btnFirstImg";
            this.btnFirstImg.Size = new System.Drawing.Size(119, 38);
            this.btnFirstImg.TabIndex = 2;
            this.btnFirstImg.Text = "<<<<";
            this.btnFirstImg.UseVisualStyleBackColor = false;
            this.btnFirstImg.Click += new System.EventHandler(this.btnFirstImg_Click);
            // 
            // btnNextImg
            // 
            this.btnNextImg.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnNextImg.FlatAppearance.BorderSize = 0;
            this.btnNextImg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNextImg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnNextImg.Location = new System.Drawing.Point(784, 508);
            this.btnNextImg.Margin = new System.Windows.Forms.Padding(4);
            this.btnNextImg.Name = "btnNextImg";
            this.btnNextImg.Size = new System.Drawing.Size(119, 38);
            this.btnNextImg.TabIndex = 2;
            this.btnNextImg.Text = ">>";
            this.btnNextImg.UseVisualStyleBackColor = false;
            this.btnNextImg.Click += new System.EventHandler(this.btnNextImg_Click);
            // 
            // btnSlide
            // 
            this.btnSlide.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnSlide.FlatAppearance.BorderSize = 0;
            this.btnSlide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSlide.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSlide.Location = new System.Drawing.Point(649, 508);
            this.btnSlide.Margin = new System.Windows.Forms.Padding(4);
            this.btnSlide.Name = "btnSlide";
            this.btnSlide.Size = new System.Drawing.Size(119, 38);
            this.btnSlide.TabIndex = 2;
            this.btnSlide.Text = "Slide";
            this.btnSlide.UseVisualStyleBackColor = false;
            this.btnSlide.Click += new System.EventHandler(this.btnSlide_Click);
            // 
            // btnLastImg
            // 
            this.btnLastImg.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnLastImg.FlatAppearance.BorderSize = 0;
            this.btnLastImg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLastImg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnLastImg.Location = new System.Drawing.Point(919, 508);
            this.btnLastImg.Margin = new System.Windows.Forms.Padding(4);
            this.btnLastImg.Name = "btnLastImg";
            this.btnLastImg.Size = new System.Drawing.Size(119, 38);
            this.btnLastImg.TabIndex = 2;
            this.btnLastImg.Text = ">>>>";
            this.btnLastImg.UseVisualStyleBackColor = false;
            this.btnLastImg.Click += new System.EventHandler(this.btnLastImg_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ImageGallery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1052, 554);
            this.Controls.Add(this.btnSlide);
            this.Controls.Add(this.btnFirstImg);
            this.Controls.Add(this.btnLastImg);
            this.Controls.Add(this.btnNextImg);
            this.Controls.Add(this.btnPreviousImg);
            this.Controls.Add(this.btnRandom);
            this.Controls.Add(this.pbBuyukResim);
            this.Controls.Add(this.FlowLayoutPanelImg);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.DimGray;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ImageGallery";
            this.Text = "Image Gallery";
            this.Load += new System.EventHandler(this.ImageGallery_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbBuyukResim)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel FlowLayoutPanelImg;
        private System.Windows.Forms.PictureBox pbBuyukResim;
        private System.Windows.Forms.Button btnRandom;
        private System.Windows.Forms.Button btnPreviousImg;
        private System.Windows.Forms.Button btnFirstImg;
        private System.Windows.Forms.Button btnNextImg;
        private System.Windows.Forms.Button btnSlide;
        private System.Windows.Forms.Button btnLastImg;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Timer timer1;
    }
}