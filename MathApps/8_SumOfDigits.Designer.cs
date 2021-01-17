namespace FunPractices
{
    partial class SumofDigits
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
            this.txtNum = new System.Windows.Forms.TextBox();
            this.btnSum = new System.Windows.Forms.Button();
            this.lblSum = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNum
            // 
            this.txtNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtNum.Location = new System.Drawing.Point(44, 42);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(159, 22);
            this.txtNum.TabIndex = 0;
            this.txtNum.Text = "Enter a Number";
            this.txtNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNum.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtNum_MouseClick);
            // 
            // btnSum
            // 
            this.btnSum.BackColor = System.Drawing.Color.IndianRed;
            this.btnSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSum.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSum.Location = new System.Drawing.Point(66, 86);
            this.btnSum.Name = "btnSum";
            this.btnSum.Size = new System.Drawing.Size(109, 35);
            this.btnSum.TabIndex = 1;
            this.btnSum.Text = "SUM";
            this.btnSum.UseVisualStyleBackColor = false;
            this.btnSum.Click += new System.EventHandler(this.btnSum_Click);
            // 
            // lblSum
            // 
            this.lblSum.BackColor = System.Drawing.Color.White;
            this.lblSum.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSum.Location = new System.Drawing.Point(44, 138);
            this.lblSum.Name = "lblSum";
            this.lblSum.Size = new System.Drawing.Size(159, 44);
            this.lblSum.TabIndex = 2;
            this.lblSum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SumofDigits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(249, 227);
            this.Controls.Add(this.lblSum);
            this.Controls.Add(this.btnSum);
            this.Controls.Add(this.txtNum);
            this.Name = "SumofDigits";
            this.Text = "Sum of Digits";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.Button btnSum;
        private System.Windows.Forms.Label lblSum;
    }
}