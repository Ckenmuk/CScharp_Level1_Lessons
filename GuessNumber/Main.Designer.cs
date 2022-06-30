namespace GuessNumber
{
    partial class Main
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonCheck = new System.Windows.Forms.Button();
            this.richTextBoxInput = new System.Windows.Forms.RichTextBox();
            this.labelLess = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelMore = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelMoves = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonCheck
            // 
            this.buttonCheck.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCheck.Location = new System.Drawing.Point(166, 193);
            this.buttonCheck.Name = "buttonCheck";
            this.buttonCheck.Size = new System.Drawing.Size(111, 64);
            this.buttonCheck.TabIndex = 1;
            this.buttonCheck.Text = "Check the result";
            this.buttonCheck.UseVisualStyleBackColor = true;
            this.buttonCheck.Click += new System.EventHandler(this.buttonCheck_Click);
            // 
            // richTextBoxInput
            // 
            this.richTextBoxInput.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBoxInput.Location = new System.Drawing.Point(200, 150);
            this.richTextBoxInput.Name = "richTextBoxInput";
            this.richTextBoxInput.Size = new System.Drawing.Size(50, 37);
            this.richTextBoxInput.TabIndex = 3;
            this.richTextBoxInput.Text = "";
            // 
            // labelLess
            // 
            this.labelLess.AutoSize = true;
            this.labelLess.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLess.Location = new System.Drawing.Point(100, 150);
            this.labelLess.Name = "labelLess";
            this.labelLess.Size = new System.Drawing.Size(51, 30);
            this.labelLess.TabIndex = 4;
            this.labelLess.Text = "less";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(90, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(287, 30);
            this.label2.TabIndex = 5;
            this.label2.Text = "Which number did I think?";
            // 
            // labelMore
            // 
            this.labelMore.AutoSize = true;
            this.labelMore.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMore.Location = new System.Drawing.Point(300, 150);
            this.labelMore.Name = "labelMore";
            this.labelMore.Size = new System.Drawing.Size(62, 30);
            this.labelMore.TabIndex = 4;
            this.labelMore.Text = "more";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(156, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 60);
            this.label4.TabIndex = 5;
            this.label4.Text = "Try to guess\r\n▼";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelMoves
            // 
            this.labelMoves.AutoSize = true;
            this.labelMoves.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMoves.Location = new System.Drawing.Point(30, 273);
            this.labelMoves.Name = "labelMoves";
            this.labelMoves.Size = new System.Drawing.Size(57, 23);
            this.labelMoves.TabIndex = 6;
            this.labelMoves.Text = "Moves";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 335);
            this.Controls.Add(this.labelMoves);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelMore);
            this.Controls.Add(this.labelLess);
            this.Controls.Add(this.richTextBoxInput);
            this.Controls.Add(this.buttonCheck);
            this.Name = "Main";
            this.Text = "Guess the number";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonCheck;
        private System.Windows.Forms.RichTextBox richTextBoxInput;
        private System.Windows.Forms.Label labelLess;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelMore;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelMoves;
    }
}

