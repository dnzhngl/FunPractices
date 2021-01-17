namespace FunPractices
{
    partial class WordOrNumber
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
            this.btnPlace = new System.Windows.Forms.Button();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.lstWord = new System.Windows.Forms.ListBox();
            this.lstNumber = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnPlace
            // 
            this.btnPlace.BackColor = System.Drawing.Color.YellowGreen;
            this.btnPlace.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPlace.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPlace.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnPlace.Location = new System.Drawing.Point(202, 21);
            this.btnPlace.Name = "btnPlace";
            this.btnPlace.Size = new System.Drawing.Size(139, 33);
            this.btnPlace.TabIndex = 7;
            this.btnPlace.Text = "Separate";
            this.btnPlace.UseVisualStyleBackColor = false;
            this.btnPlace.Click += new System.EventHandler(this.btnPlace_Click);
            // 
            // txtInput
            // 
            this.txtInput.BackColor = System.Drawing.Color.Azure;
            this.txtInput.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtInput.Location = new System.Drawing.Point(22, 26);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(139, 22);
            this.txtInput.TabIndex = 6;
            // 
            // lstWord
            // 
            this.lstWord.BackColor = System.Drawing.Color.Azure;
            this.lstWord.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lstWord.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lstWord.FormattingEnabled = true;
            this.lstWord.ItemHeight = 16;
            this.lstWord.Location = new System.Drawing.Point(202, 79);
            this.lstWord.Name = "lstWord";
            this.lstWord.Size = new System.Drawing.Size(139, 228);
            this.lstWord.TabIndex = 5;
            // 
            // lstNumber
            // 
            this.lstNumber.BackColor = System.Drawing.Color.Azure;
            this.lstNumber.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lstNumber.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lstNumber.FormattingEnabled = true;
            this.lstNumber.ItemHeight = 16;
            this.lstNumber.Location = new System.Drawing.Point(22, 79);
            this.lstNumber.Name = "lstNumber";
            this.lstNumber.Size = new System.Drawing.Size(139, 228);
            this.lstNumber.TabIndex = 4;
            // 
            // WordOrNumber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(360, 329);
            this.Controls.Add(this.btnPlace);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.lstWord);
            this.Controls.Add(this.lstNumber);
            this.Name = "WordOrNumber";
            this.Text = "Word or Number ?";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPlace;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.ListBox lstWord;
        private System.Windows.Forms.ListBox lstNumber;
    }
}