namespace Ex2_CarregarImagem
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            rbClever = new RadioButton();
            rbWolf = new RadioButton();
            rbBook = new RadioButton();
            rbCarrot = new RadioButton();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // rbClever
            // 
            rbClever.AutoSize = true;
            rbClever.Location = new Point(34, 45);
            rbClever.Name = "rbClever";
            rbClever.Size = new Size(56, 19);
            rbClever.TabIndex = 0;
            rbClever.TabStop = true;
            rbClever.Text = "clever";
            rbClever.UseVisualStyleBackColor = true;
            rbClever.CheckedChanged += rbChanged;
            // 
            // rbWolf
            // 
            rbWolf.AutoSize = true;
            rbWolf.Location = new Point(34, 92);
            rbWolf.Name = "rbWolf";
            rbWolf.Size = new Size(48, 19);
            rbWolf.TabIndex = 1;
            rbWolf.TabStop = true;
            rbWolf.Text = "wolf";
            rbWolf.UseVisualStyleBackColor = true;
            rbWolf.CheckedChanged += rbChanged;
            // 
            // rbBook
            // 
            rbBook.AutoSize = true;
            rbBook.Location = new Point(34, 138);
            rbBook.Name = "rbBook";
            rbBook.Size = new Size(52, 19);
            rbBook.TabIndex = 2;
            rbBook.TabStop = true;
            rbBook.Text = "book";
            rbBook.UseVisualStyleBackColor = true;
            rbBook.CheckedChanged += rbChanged;
            // 
            // rbCarrot
            // 
            rbCarrot.AutoSize = true;
            rbCarrot.Location = new Point(34, 181);
            rbCarrot.Name = "rbCarrot";
            rbCarrot.Size = new Size(56, 19);
            rbCarrot.TabIndex = 3;
            rbCarrot.TabStop = true;
            rbCarrot.Text = "carrot";
            rbCarrot.UseVisualStyleBackColor = true;
            rbCarrot.CheckedChanged += rbChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(157, 13);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(429, 433);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(597, 450);
            Controls.Add(pictureBox1);
            Controls.Add(rbCarrot);
            Controls.Add(rbBook);
            Controls.Add(rbWolf);
            Controls.Add(rbClever);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton rbClever;
        private RadioButton rbWolf;
        private RadioButton rbBook;
        private RadioButton rbCarrot;
        private PictureBox pictureBox1;
    }
}
