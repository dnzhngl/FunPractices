namespace FunPractices
{
    partial class VowelOrConstant
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
            this.txtLetter = new System.Windows.Forms.TextBox();
            this.Vowels = new System.Windows.Forms.ListBox();
            this.Consonants = new System.Windows.Forms.ListBox();
            this.lblVowels = new System.Windows.Forms.Label();
            this.lblConsonant = new System.Windows.Forms.Label();
            this.btnCheck = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtLetter
            // 
            this.txtLetter.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtLetter.Location = new System.Drawing.Point(50, 25);
            this.txtLetter.MaxLength = 1;
            this.txtLetter.Name = "txtLetter";
            this.txtLetter.Size = new System.Drawing.Size(157, 24);
            this.txtLetter.TabIndex = 0;
            this.txtLetter.Text = "Enter a Letter";
            this.txtLetter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Vowels
            // 
            this.Vowels.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Vowels.FormattingEnabled = true;
            this.Vowels.ItemHeight = 18;
            this.Vowels.Location = new System.Drawing.Point(48, 126);
            this.Vowels.Name = "Vowels";
            this.Vowels.Size = new System.Drawing.Size(70, 112);
            this.Vowels.TabIndex = 1;
            // 
            // Consonants
            // 
            this.Consonants.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Consonants.FormattingEnabled = true;
            this.Consonants.ItemHeight = 18;
            this.Consonants.Location = new System.Drawing.Point(135, 126);
            this.Consonants.Name = "Consonants";
            this.Consonants.Size = new System.Drawing.Size(70, 112);
            this.Consonants.TabIndex = 1;
            // 
            // lblVowels
            // 
            this.lblVowels.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblVowels.Location = new System.Drawing.Point(40, 100);
            this.lblVowels.Name = "lblVowels";
            this.lblVowels.Size = new System.Drawing.Size(89, 29);
            this.lblVowels.TabIndex = 2;
            this.lblVowels.Text = "Vowels";
            this.lblVowels.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblConsonant
            // 
            this.lblConsonant.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblConsonant.Location = new System.Drawing.Point(119, 100);
            this.lblConsonant.Name = "lblConsonant";
            this.lblConsonant.Size = new System.Drawing.Size(102, 29);
            this.lblConsonant.TabIndex = 3;
            this.lblConsonant.Text = "Consonant";
            this.lblConsonant.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCheck
            // 
            this.btnCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCheck.Location = new System.Drawing.Point(77, 56);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(91, 35);
            this.btnCheck.TabIndex = 4;
            this.btnCheck.Text = "CHECK";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // VowelOrConstant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(255, 275);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.Consonants);
            this.Controls.Add(this.Vowels);
            this.Controls.Add(this.txtLetter);
            this.Controls.Add(this.lblConsonant);
            this.Controls.Add(this.lblVowels);
            this.Name = "VowelOrConstant";
            this.Text = "Vowel or Consonant";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLetter;
        private System.Windows.Forms.ListBox Vowels;
        private System.Windows.Forms.ListBox Consonants;
        private System.Windows.Forms.Label lblVowels;
        private System.Windows.Forms.Label lblConsonant;
        private System.Windows.Forms.Button btnCheck;
    }
}