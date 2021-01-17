namespace FunPractices
{
    partial class HorseRace
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HorseRace));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.picHorse1 = new System.Windows.Forms.PictureBox();
            this.picHorse3 = new System.Windows.Forms.PictureBox();
            this.picHorse2 = new System.Windows.Forms.PictureBox();
            this.lblFinish = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblWinner = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtName1 = new System.Windows.Forms.TextBox();
            this.txtName3 = new System.Windows.Forms.TextBox();
            this.txtName2 = new System.Windows.Forms.TextBox();
            this.btnRestart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picHorse1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHorse3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHorse2)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Honeydew;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(921, 10);
            this.label1.TabIndex = 0;
            this.label1.Text = " ";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Honeydew;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Location = new System.Drawing.Point(0, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(921, 10);
            this.label2.TabIndex = 1;
            this.label2.Text = " ";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Honeydew;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Location = new System.Drawing.Point(0, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(921, 10);
            this.label3.TabIndex = 2;
            this.label3.Text = " ";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Honeydew;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Location = new System.Drawing.Point(0, 330);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(921, 10);
            this.label4.TabIndex = 3;
            this.label4.Text = " ";
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.SeaGreen;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStart.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnStart.ForeColor = System.Drawing.Color.Honeydew;
            this.btnStart.Location = new System.Drawing.Point(20, 19);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(138, 40);
            this.btnStart.TabIndex = 4;
            this.btnStart.Text = "START";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // picHorse1
            // 
            this.picHorse1.Image = ((System.Drawing.Image)(resources.GetObject("picHorse1.Image")));
            this.picHorse1.Location = new System.Drawing.Point(2, 21);
            this.picHorse1.Name = "picHorse1";
            this.picHorse1.Size = new System.Drawing.Size(83, 68);
            this.picHorse1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picHorse1.TabIndex = 5;
            this.picHorse1.TabStop = false;
            // 
            // picHorse3
            // 
            this.picHorse3.Image = ((System.Drawing.Image)(resources.GetObject("picHorse3.Image")));
            this.picHorse3.Location = new System.Drawing.Point(2, 240);
            this.picHorse3.Name = "picHorse3";
            this.picHorse3.Size = new System.Drawing.Size(83, 68);
            this.picHorse3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picHorse3.TabIndex = 6;
            this.picHorse3.TabStop = false;
            // 
            // picHorse2
            // 
            this.picHorse2.Image = ((System.Drawing.Image)(resources.GetObject("picHorse2.Image")));
            this.picHorse2.Location = new System.Drawing.Point(2, 131);
            this.picHorse2.Name = "picHorse2";
            this.picHorse2.Size = new System.Drawing.Size(83, 68);
            this.picHorse2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picHorse2.TabIndex = 8;
            this.picHorse2.TabStop = false;
            // 
            // lblFinish
            // 
            this.lblFinish.BackColor = System.Drawing.Color.Crimson;
            this.lblFinish.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblFinish.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.lblFinish.ForeColor = System.Drawing.Color.Honeydew;
            this.lblFinish.Location = new System.Drawing.Point(870, 0);
            this.lblFinish.Name = "lblFinish";
            this.lblFinish.Size = new System.Drawing.Size(36, 340);
            this.lblFinish.TabIndex = 9;
            this.lblFinish.Text = " F\r\n\r\nI\r\n\r\nN\r\n\r\nI\r\n\r\nS\r\n\r\nH\r\n";
            this.lblFinish.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblWinner
            // 
            this.lblWinner.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblWinner.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblWinner.ForeColor = System.Drawing.Color.Honeydew;
            this.lblWinner.Location = new System.Drawing.Point(188, 39);
            this.lblWinner.Name = "lblWinner";
            this.lblWinner.Size = new System.Drawing.Size(700, 48);
            this.lblWinner.TabIndex = 10;
            this.lblWinner.Text = "...";
            this.lblWinner.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.btnRestart);
            this.panel1.Controls.Add(this.lblWinner);
            this.panel1.Controls.Add(this.btnStart);
            this.panel1.Location = new System.Drawing.Point(0, 337);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(919, 124);
            this.panel1.TabIndex = 14;
            // 
            // txtName1
            // 
            this.txtName1.BackColor = System.Drawing.Color.SeaGreen;
            this.txtName1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtName1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtName1.ForeColor = System.Drawing.Color.Honeydew;
            this.txtName1.Location = new System.Drawing.Point(2, 90);
            this.txtName1.Name = "txtName1";
            this.txtName1.Size = new System.Drawing.Size(82, 15);
            this.txtName1.TabIndex = 15;
            this.txtName1.Text = "ONYX";
            this.txtName1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtName3
            // 
            this.txtName3.BackColor = System.Drawing.Color.SeaGreen;
            this.txtName3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtName3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtName3.ForeColor = System.Drawing.Color.Honeydew;
            this.txtName3.Location = new System.Drawing.Point(3, 309);
            this.txtName3.Name = "txtName3";
            this.txtName3.Size = new System.Drawing.Size(82, 15);
            this.txtName3.TabIndex = 16;
            this.txtName3.Text = "CINNAMON";
            this.txtName3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtName2
            // 
            this.txtName2.BackColor = System.Drawing.Color.SeaGreen;
            this.txtName2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtName2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtName2.ForeColor = System.Drawing.Color.Honeydew;
            this.txtName2.Location = new System.Drawing.Point(3, 201);
            this.txtName2.Name = "txtName2";
            this.txtName2.Size = new System.Drawing.Size(82, 15);
            this.txtName2.TabIndex = 17;
            this.txtName2.Text = "NAPOLEON";
            this.txtName2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnRestart
            // 
            this.btnRestart.BackColor = System.Drawing.Color.SeaGreen;
            this.btnRestart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRestart.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRestart.ForeColor = System.Drawing.Color.Honeydew;
            this.btnRestart.Location = new System.Drawing.Point(20, 65);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(138, 40);
            this.btnRestart.TabIndex = 11;
            this.btnRestart.Text = "RESTART";
            this.btnRestart.UseVisualStyleBackColor = false;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // HorseRace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(918, 459);
            this.Controls.Add(this.txtName2);
            this.Controls.Add(this.txtName3);
            this.Controls.Add(this.txtName1);
            this.Controls.Add(this.lblFinish);
            this.Controls.Add(this.picHorse2);
            this.Controls.Add(this.picHorse3);
            this.Controls.Add(this.picHorse1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HorseRace";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Horse Race";
            ((System.ComponentModel.ISupportInitialize)(this.picHorse1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHorse3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHorse2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.PictureBox picHorse1;
        private System.Windows.Forms.PictureBox picHorse3;
        private System.Windows.Forms.PictureBox picHorse2;
        private System.Windows.Forms.Label lblFinish;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblWinner;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtName1;
        private System.Windows.Forms.TextBox txtName3;
        private System.Windows.Forms.TextBox txtName2;
        private System.Windows.Forms.Button btnRestart;
    }
}