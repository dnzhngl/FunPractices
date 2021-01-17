namespace FunPractices
{
    partial class RollTheDice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RollTheDice));
            this.label1 = new System.Windows.Forms.Label();
            this.lblPlayer2TotalScore = new System.Windows.Forms.Label();
            this.lblPlayer1TotalScore = new System.Windows.Forms.Label();
            this.lblTurn = new System.Windows.Forms.Label();
            this.lblScore2 = new System.Windows.Forms.Label();
            this.txtPlayer2 = new System.Windows.Forms.TextBox();
            this.txtPlayer1 = new System.Windows.Forms.TextBox();
            this.lblScore1 = new System.Windows.Forms.Label();
            this.picDice2 = new System.Windows.Forms.PictureBox();
            this.picDice1 = new System.Windows.Forms.PictureBox();
            this.btnRoll = new System.Windows.Forms.Button();
            this.lblTurnTxt = new System.Windows.Forms.Label();
            this.lblWinner = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picDice2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDice1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Orange;
            this.label1.Location = new System.Drawing.Point(68, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 48);
            this.label1.TabIndex = 28;
            this.label1.Text = " TOTAL  SCORE";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPlayer2TotalScore
            // 
            this.lblPlayer2TotalScore.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPlayer2TotalScore.ForeColor = System.Drawing.Color.Orange;
            this.lblPlayer2TotalScore.Location = new System.Drawing.Point(216, 130);
            this.lblPlayer2TotalScore.Name = "lblPlayer2TotalScore";
            this.lblPlayer2TotalScore.Size = new System.Drawing.Size(115, 39);
            this.lblPlayer2TotalScore.TabIndex = 26;
            this.lblPlayer2TotalScore.Text = "0";
            this.lblPlayer2TotalScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPlayer1TotalScore
            // 
            this.lblPlayer1TotalScore.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPlayer1TotalScore.ForeColor = System.Drawing.Color.Orange;
            this.lblPlayer1TotalScore.Location = new System.Drawing.Point(67, 130);
            this.lblPlayer1TotalScore.Name = "lblPlayer1TotalScore";
            this.lblPlayer1TotalScore.Size = new System.Drawing.Size(115, 39);
            this.lblPlayer1TotalScore.TabIndex = 25;
            this.lblPlayer1TotalScore.Text = "0";
            this.lblPlayer1TotalScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTurn
            // 
            this.lblTurn.BackColor = System.Drawing.Color.Transparent;
            this.lblTurn.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTurn.ForeColor = System.Drawing.Color.White;
            this.lblTurn.Location = new System.Drawing.Point(348, 6);
            this.lblTurn.Name = "lblTurn";
            this.lblTurn.Size = new System.Drawing.Size(47, 33);
            this.lblTurn.TabIndex = 23;
            this.lblTurn.Text = "0";
            this.lblTurn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblScore2
            // 
            this.lblScore2.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblScore2.ForeColor = System.Drawing.Color.Navy;
            this.lblScore2.Location = new System.Drawing.Point(347, 290);
            this.lblScore2.Name = "lblScore2";
            this.lblScore2.Size = new System.Drawing.Size(51, 54);
            this.lblScore2.TabIndex = 22;
            this.lblScore2.Text = "0";
            this.lblScore2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPlayer2
            // 
            this.txtPlayer2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txtPlayer2.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPlayer2.ForeColor = System.Drawing.Color.White;
            this.txtPlayer2.Location = new System.Drawing.Point(213, 90);
            this.txtPlayer2.Name = "txtPlayer2";
            this.txtPlayer2.Size = new System.Drawing.Size(130, 33);
            this.txtPlayer2.TabIndex = 21;
            this.txtPlayer2.Text = "Player 2";
            this.txtPlayer2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPlayer1
            // 
            this.txtPlayer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txtPlayer1.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPlayer1.ForeColor = System.Drawing.Color.White;
            this.txtPlayer1.Location = new System.Drawing.Point(52, 90);
            this.txtPlayer1.Name = "txtPlayer1";
            this.txtPlayer1.Size = new System.Drawing.Size(130, 33);
            this.txtPlayer1.TabIndex = 20;
            this.txtPlayer1.Text = "Player 1";
            this.txtPlayer1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblScore1
            // 
            this.lblScore1.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblScore1.ForeColor = System.Drawing.Color.Navy;
            this.lblScore1.Location = new System.Drawing.Point(7, 290);
            this.lblScore1.Name = "lblScore1";
            this.lblScore1.Size = new System.Drawing.Size(55, 54);
            this.lblScore1.TabIndex = 19;
            this.lblScore1.Text = "0";
            this.lblScore1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picDice2
            // 
            this.picDice2.Location = new System.Drawing.Point(211, 242);
            this.picDice2.Name = "picDice2";
            this.picDice2.Size = new System.Drawing.Size(130, 130);
            this.picDice2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDice2.TabIndex = 18;
            this.picDice2.TabStop = false;
            // 
            // picDice1
            // 
            this.picDice1.Location = new System.Drawing.Point(63, 242);
            this.picDice1.Name = "picDice1";
            this.picDice1.Size = new System.Drawing.Size(130, 130);
            this.picDice1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDice1.TabIndex = 17;
            this.picDice1.TabStop = false;
            // 
            // btnRoll
            // 
            this.btnRoll.BackColor = System.Drawing.Color.Orange;
            this.btnRoll.Font = new System.Drawing.Font("Corbel", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRoll.ForeColor = System.Drawing.Color.White;
            this.btnRoll.Location = new System.Drawing.Point(95, 406);
            this.btnRoll.Name = "btnRoll";
            this.btnRoll.Size = new System.Drawing.Size(206, 82);
            this.btnRoll.TabIndex = 16;
            this.btnRoll.Text = "DICE";
            this.btnRoll.UseVisualStyleBackColor = false;
            this.btnRoll.Click += new System.EventHandler(this.btnRoll_Click);
            // 
            // lblTurnTxt
            // 
            this.lblTurnTxt.BackColor = System.Drawing.Color.Transparent;
            this.lblTurnTxt.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTurnTxt.ForeColor = System.Drawing.Color.White;
            this.lblTurnTxt.Location = new System.Drawing.Point(294, 6);
            this.lblTurnTxt.Name = "lblTurnTxt";
            this.lblTurnTxt.Size = new System.Drawing.Size(104, 33);
            this.lblTurnTxt.TabIndex = 24;
            this.lblTurnTxt.Text = "Turn:";
            this.lblTurnTxt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblWinner
            // 
            this.lblWinner.Font = new System.Drawing.Font("Comic Sans MS", 27F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblWinner.ForeColor = System.Drawing.Color.Orange;
            this.lblWinner.Location = new System.Drawing.Point(63, 169);
            this.lblWinner.Name = "lblWinner";
            this.lblWinner.Size = new System.Drawing.Size(278, 73);
            this.lblWinner.TabIndex = 27;
            this.lblWinner.Text = " ";
            this.lblWinner.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RollTheDice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(404, 541);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblPlayer2TotalScore);
            this.Controls.Add(this.lblPlayer1TotalScore);
            this.Controls.Add(this.lblTurn);
            this.Controls.Add(this.lblScore2);
            this.Controls.Add(this.txtPlayer2);
            this.Controls.Add(this.txtPlayer1);
            this.Controls.Add(this.lblScore1);
            this.Controls.Add(this.picDice2);
            this.Controls.Add(this.picDice1);
            this.Controls.Add(this.btnRoll);
            this.Controls.Add(this.lblTurnTxt);
            this.Controls.Add(this.lblWinner);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RollTheDice";
            this.Text = "Roll The Dice !";
            ((System.ComponentModel.ISupportInitialize)(this.picDice2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDice1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPlayer2TotalScore;
        private System.Windows.Forms.Label lblPlayer1TotalScore;
        private System.Windows.Forms.Label lblTurn;
        private System.Windows.Forms.Label lblScore2;
        private System.Windows.Forms.TextBox txtPlayer2;
        private System.Windows.Forms.TextBox txtPlayer1;
        private System.Windows.Forms.Label lblScore1;
        private System.Windows.Forms.PictureBox picDice2;
        private System.Windows.Forms.PictureBox picDice1;
        private System.Windows.Forms.Button btnRoll;
        private System.Windows.Forms.Label lblTurnTxt;
        private System.Windows.Forms.Label lblWinner;
    }
}