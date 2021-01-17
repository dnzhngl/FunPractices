namespace FunPractices
{
    partial class Dice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dice));
            this.picDice1 = new System.Windows.Forms.PictureBox();
            this.picDice2 = new System.Windows.Forms.PictureBox();
            this.btnDice = new System.Windows.Forms.Button();
            this.lblScoreL = new System.Windows.Forms.Label();
            this.lblTotalScoreL = new System.Windows.Forms.Label();
            this.lblTotalScore = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.btnStop = new System.Windows.Forms.Button();
            this.lblCounter = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picDice1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDice2)).BeginInit();
            this.SuspendLayout();
            // 
            // picDice1
            // 
            this.picDice1.BackColor = System.Drawing.Color.OliveDrab;
            this.picDice1.Location = new System.Drawing.Point(27, 30);
            this.picDice1.Name = "picDice1";
            this.picDice1.Size = new System.Drawing.Size(100, 100);
            this.picDice1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDice1.TabIndex = 0;
            this.picDice1.TabStop = false;
            // 
            // picDice2
            // 
            this.picDice2.BackColor = System.Drawing.Color.OliveDrab;
            this.picDice2.Location = new System.Drawing.Point(156, 30);
            this.picDice2.Name = "picDice2";
            this.picDice2.Size = new System.Drawing.Size(100, 100);
            this.picDice2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDice2.TabIndex = 1;
            this.picDice2.TabStop = false;
            // 
            // btnDice
            // 
            this.btnDice.BackColor = System.Drawing.Color.Salmon;
            this.btnDice.FlatAppearance.BorderColor = System.Drawing.Color.Snow;
            this.btnDice.FlatAppearance.BorderSize = 3;
            this.btnDice.Font = new System.Drawing.Font("Candara", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDice.ForeColor = System.Drawing.Color.Snow;
            this.btnDice.Location = new System.Drawing.Point(20, 209);
            this.btnDice.Name = "btnDice";
            this.btnDice.Size = new System.Drawing.Size(114, 65);
            this.btnDice.TabIndex = 2;
            this.btnDice.Text = "START";
            this.btnDice.UseVisualStyleBackColor = false;
            this.btnDice.Click += new System.EventHandler(this.btnDice_Click);
            // 
            // lblScoreL
            // 
            this.lblScoreL.AutoSize = true;
            this.lblScoreL.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblScoreL.ForeColor = System.Drawing.Color.Snow;
            this.lblScoreL.Location = new System.Drawing.Point(21, 135);
            this.lblScoreL.Name = "lblScoreL";
            this.lblScoreL.Size = new System.Drawing.Size(78, 26);
            this.lblScoreL.TabIndex = 3;
            this.lblScoreL.Text = "Score : ";
            // 
            // lblTotalScoreL
            // 
            this.lblTotalScoreL.AutoSize = true;
            this.lblTotalScoreL.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTotalScoreL.ForeColor = System.Drawing.Color.Snow;
            this.lblTotalScoreL.Location = new System.Drawing.Point(21, 168);
            this.lblTotalScoreL.Name = "lblTotalScoreL";
            this.lblTotalScoreL.Size = new System.Drawing.Size(128, 26);
            this.lblTotalScoreL.TabIndex = 4;
            this.lblTotalScoreL.Text = "Total Score : ";
            // 
            // lblTotalScore
            // 
            this.lblTotalScore.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTotalScore.ForeColor = System.Drawing.Color.Snow;
            this.lblTotalScore.Location = new System.Drawing.Point(146, 168);
            this.lblTotalScore.Name = "lblTotalScore";
            this.lblTotalScore.Size = new System.Drawing.Size(80, 26);
            this.lblTotalScore.TabIndex = 5;
            this.lblTotalScore.Text = " ";
            // 
            // lblScore
            // 
            this.lblScore.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblScore.ForeColor = System.Drawing.Color.Snow;
            this.lblScore.Location = new System.Drawing.Point(105, 135);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(95, 26);
            this.lblScore.TabIndex = 6;
            this.lblScore.Text = " ";
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.Color.Salmon;
            this.btnStop.FlatAppearance.BorderColor = System.Drawing.Color.Snow;
            this.btnStop.FlatAppearance.BorderSize = 3;
            this.btnStop.Font = new System.Drawing.Font("Candara", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnStop.ForeColor = System.Drawing.Color.Snow;
            this.btnStop.Location = new System.Drawing.Point(151, 209);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(114, 65);
            this.btnStop.TabIndex = 7;
            this.btnStop.Text = "STOP";
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // lblCounter
            // 
            this.lblCounter.AutoSize = true;
            this.lblCounter.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCounter.ForeColor = System.Drawing.Color.Snow;
            this.lblCounter.Location = new System.Drawing.Point(260, -2);
            this.lblCounter.Name = "lblCounter";
            this.lblCounter.Size = new System.Drawing.Size(26, 29);
            this.lblCounter.TabIndex = 8;
            this.lblCounter.Text = "0";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(197, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 26);
            this.label1.TabIndex = 9;
            this.label1.Text = "Turn : ";
            // 
            // Dice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OliveDrab;
            this.ClientSize = new System.Drawing.Size(287, 297);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCounter);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.lblTotalScore);
            this.Controls.Add(this.lblTotalScoreL);
            this.Controls.Add(this.lblScoreL);
            this.Controls.Add(this.btnDice);
            this.Controls.Add(this.picDice2);
            this.Controls.Add(this.picDice1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Dice";
            this.Text = "Dice !";
            ((System.ComponentModel.ISupportInitialize)(this.picDice1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDice2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picDice1;
        private System.Windows.Forms.PictureBox picDice2;
        private System.Windows.Forms.Button btnDice;
        private System.Windows.Forms.Label lblScoreL;
        private System.Windows.Forms.Label lblTotalScoreL;
        private System.Windows.Forms.Label lblTotalScore;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Label lblCounter;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
    }
}