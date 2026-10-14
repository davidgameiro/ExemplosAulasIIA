namespace ClienteModBus
{
    partial class FrmClnt
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btLigar = new System.Windows.Forms.Button();
            this.rb500 = new System.Windows.Forms.RadioButton();
            this.rb1000 = new System.Windows.Forms.RadioButton();
            this.rb2500 = new System.Windows.Forms.RadioButton();
            this.rb4000 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 300;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(152, 25);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(815, 364);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // btLigar
            // 
            this.btLigar.Location = new System.Drawing.Point(25, 41);
            this.btLigar.Name = "btLigar";
            this.btLigar.Size = new System.Drawing.Size(105, 50);
            this.btLigar.TabIndex = 1;
            this.btLigar.Text = "Ligar ModBus";
            this.btLigar.UseVisualStyleBackColor = true;
            this.btLigar.Click += new System.EventHandler(this.btLigar_Click);
            // 
            // rb500
            // 
            this.rb500.AutoSize = true;
            this.rb500.Location = new System.Drawing.Point(25, 135);
            this.rb500.Name = "rb500";
            this.rb500.Size = new System.Drawing.Size(91, 17);
            this.rb500.TabIndex = 2;
            this.rb500.TabStop = true;
            this.rb500.Text = "refresh 500ms";
            this.rb500.UseVisualStyleBackColor = true;
            this.rb500.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // rb1000
            // 
            this.rb1000.AutoSize = true;
            this.rb1000.Location = new System.Drawing.Point(25, 170);
            this.rb1000.Name = "rb1000";
            this.rb1000.Size = new System.Drawing.Size(71, 17);
            this.rb1000.TabIndex = 3;
            this.rb1000.TabStop = true;
            this.rb1000.Text = "refresh 1s";
            this.rb1000.UseVisualStyleBackColor = true;
            this.rb1000.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // rb2500
            // 
            this.rb2500.AutoSize = true;
            this.rb2500.Location = new System.Drawing.Point(25, 208);
            this.rb2500.Name = "rb2500";
            this.rb2500.Size = new System.Drawing.Size(80, 17);
            this.rb2500.TabIndex = 4;
            this.rb2500.TabStop = true;
            this.rb2500.Text = "refresh 2,5s";
            this.rb2500.UseVisualStyleBackColor = true;
            this.rb2500.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // rb4000
            // 
            this.rb4000.AutoSize = true;
            this.rb4000.Location = new System.Drawing.Point(25, 250);
            this.rb4000.Name = "rb4000";
            this.rb4000.Size = new System.Drawing.Size(71, 17);
            this.rb4000.TabIndex = 5;
            this.rb4000.TabStop = true;
            this.rb4000.Text = "refresh 4s";
            this.rb4000.UseVisualStyleBackColor = true;
            this.rb4000.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // FrmClnt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 430);
            this.Controls.Add(this.rb4000);
            this.Controls.Add(this.rb2500);
            this.Controls.Add(this.rb1000);
            this.Controls.Add(this.rb500);
            this.Controls.Add(this.btLigar);
            this.Controls.Add(this.richTextBox1);
            this.Name = "FrmClnt";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btLigar;
        private System.Windows.Forms.RadioButton rb500;
        private System.Windows.Forms.RadioButton rb1000;
        private System.Windows.Forms.RadioButton rb2500;
        private System.Windows.Forms.RadioButton rb4000;
    }
}

