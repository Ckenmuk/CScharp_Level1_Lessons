namespace Doubler
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
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonPlus = new System.Windows.Forms.Button();
            this.buttonMulty = new System.Windows.Forms.Button();
            this.labelComputerNumber = new System.Windows.Forms.Label();
            this.labelUserNumber = new System.Windows.Forms.Label();
            this.labelMoves = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.labelTries = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripNewGame = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonReset
            // 
            this.buttonReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonReset.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonReset.Location = new System.Drawing.Point(255, 12);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(96, 49);
            this.buttonReset.TabIndex = 0;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // buttonPlus
            // 
            this.buttonPlus.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonPlus.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPlus.Location = new System.Drawing.Point(255, 67);
            this.buttonPlus.Name = "buttonPlus";
            this.buttonPlus.Size = new System.Drawing.Size(96, 49);
            this.buttonPlus.TabIndex = 1;
            this.buttonPlus.Text = "+1";
            this.buttonPlus.UseVisualStyleBackColor = true;
            this.buttonPlus.Click += new System.EventHandler(this.buttonPlus_Click);
            // 
            // buttonMulty
            // 
            this.buttonMulty.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonMulty.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonMulty.Location = new System.Drawing.Point(255, 122);
            this.buttonMulty.Name = "buttonMulty";
            this.buttonMulty.Size = new System.Drawing.Size(96, 49);
            this.buttonMulty.TabIndex = 2;
            this.buttonMulty.Text = "x2";
            this.buttonMulty.UseVisualStyleBackColor = true;
            this.buttonMulty.Click += new System.EventHandler(this.buttonMulty_Click);
            // 
            // labelComputerNumber
            // 
            this.labelComputerNumber.AutoSize = true;
            this.labelComputerNumber.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelComputerNumber.Location = new System.Drawing.Point(2, 38);
            this.labelComputerNumber.Name = "labelComputerNumber";
            this.labelComputerNumber.Size = new System.Drawing.Size(116, 23);
            this.labelComputerNumber.TabIndex = 3;
            this.labelComputerNumber.Text = "Get a number";
            // 
            // labelUserNumber
            // 
            this.labelUserNumber.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelUserNumber.AutoSize = true;
            this.labelUserNumber.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelUserNumber.Location = new System.Drawing.Point(2, 110);
            this.labelUserNumber.Name = "labelUserNumber";
            this.labelUserNumber.Size = new System.Drawing.Size(131, 23);
            this.labelUserNumber.TabIndex = 4;
            this.labelUserNumber.Text = "Current number";
            // 
            // labelMoves
            // 
            this.labelMoves.AutoSize = true;
            this.labelMoves.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMoves.Location = new System.Drawing.Point(2, 172);
            this.labelMoves.Name = "labelMoves";
            this.labelMoves.Size = new System.Drawing.Size(57, 23);
            this.labelMoves.TabIndex = 5;
            this.labelMoves.Text = "Moves";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCancel.Location = new System.Drawing.Point(255, 213);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(96, 45);
            this.buttonCancel.TabIndex = 6;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // labelTries
            // 
            this.labelTries.AutoSize = true;
            this.labelTries.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTries.Location = new System.Drawing.Point(337, 213);
            this.labelTries.Name = "labelTries";
            this.labelTries.Size = new System.Drawing.Size(25, 19);
            this.labelTries.TabIndex = 8;
            this.labelTries.Text = "x2";
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripNewGame});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(384, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripNewGame
            // 
            this.toolStripNewGame.Name = "toolStripNewGame";
            this.toolStripNewGame.Size = new System.Drawing.Size(77, 20);
            this.toolStripNewGame.Text = "New Game";
            this.toolStripNewGame.Click += new System.EventHandler(this.toolStripNewGame_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.labelTries);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.labelMoves);
            this.Controls.Add(this.labelUserNumber);
            this.Controls.Add(this.labelComputerNumber);
            this.Controls.Add(this.buttonMulty);
            this.Controls.Add(this.buttonPlus);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.menuStrip1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(400, 300);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(400, 300);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Doubler";
            this.Load += new System.EventHandler(this.Main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonPlus;
        private System.Windows.Forms.Button buttonMulty;
        private System.Windows.Forms.Label labelComputerNumber;
        private System.Windows.Forms.Label labelUserNumber;
        private System.Windows.Forms.Label labelMoves;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label labelTries;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripNewGame;
    }
}

