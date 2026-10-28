namespace ExemploFormModBus
{
    partial class MainFrm
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
            components = new System.ComponentModel.Container();
            statusStrip1 = new StatusStrip();
            SLbModBus = new ToolStripStatusLabel();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            tLbModBus2 = new ToolStripStatusLabel();
            splitContainer1 = new SplitContainer();
            uC_Exemplo2 = new UC_Exemplo();
            uC_Exemplo1 = new UC_Exemplo();
            ucTest4 = new UCTest();
            ucTest3 = new UCTest();
            ucTest2 = new UCTest();
            ucTest1 = new UCTest();
            richTextBox2 = new RichTextBox();
            richTextBox1 = new RichTextBox();
            timer1 = new System.Windows.Forms.Timer(components);
            statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { SLbModBus, toolStripStatusLabel1, tLbModBus2 });
            statusStrip1.Location = new Point(0, 576);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(926, 22);
            statusStrip1.TabIndex = 0;
            statusStrip1.Text = "statusStrip1";
            // 
            // SLbModBus
            // 
            SLbModBus.Name = "SLbModBus";
            SLbModBus.Size = new Size(51, 17);
            SLbModBus.Text = "ModBus";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(10, 17);
            toolStripStatusLabel1.Text = "|";
            // 
            // tLbModBus2
            // 
            tLbModBus2.Name = "tLbModBus2";
            tLbModBus2.Size = new Size(57, 17);
            tLbModBus2.Text = "ModBus2";
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(uC_Exemplo2);
            splitContainer1.Panel2.Controls.Add(uC_Exemplo1);
            splitContainer1.Panel2.Controls.Add(ucTest4);
            splitContainer1.Panel2.Controls.Add(ucTest3);
            splitContainer1.Panel2.Controls.Add(ucTest2);
            splitContainer1.Panel2.Controls.Add(ucTest1);
            splitContainer1.Panel2.Controls.Add(richTextBox2);
            splitContainer1.Panel2.Controls.Add(richTextBox1);
            splitContainer1.Size = new Size(926, 576);
            splitContainer1.SplitterDistance = 64;
            splitContainer1.TabIndex = 1;
            // 
            // uC_Exemplo2
            // 
            uC_Exemplo2.Location = new Point(254, 284);
            uC_Exemplo2.Name = "uC_Exemplo2";
            uC_Exemplo2.Size = new Size(199, 204);
            uC_Exemplo2.TabIndex = 3;
            // 
            // uC_Exemplo1
            // 
            uC_Exemplo1.Location = new Point(715, 284);
            uC_Exemplo1.Name = "uC_Exemplo1";
            uC_Exemplo1.Size = new Size(199, 204);
            uC_Exemplo1.TabIndex = 3;
            // 
            // ucTest4
            // 
            ucTest4.Location = new Point(383, 193);
            ucTest4.Name = "ucTest4";
            ucTest4.Size = new Size(150, 150);
            ucTest4.TabIndex = 2;
            // 
            // ucTest3
            // 
            ucTest3.Location = new Point(178, 193);
            ucTest3.Name = "ucTest3";
            ucTest3.Size = new Size(150, 150);
            ucTest3.TabIndex = 2;
            // 
            // ucTest2
            // 
            ucTest2.Location = new Point(383, 16);
            ucTest2.Name = "ucTest2";
            ucTest2.Size = new Size(150, 150);
            ucTest2.TabIndex = 2;
            // 
            // ucTest1
            // 
            ucTest1.Location = new Point(178, 16);
            ucTest1.Name = "ucTest1";
            ucTest1.Size = new Size(150, 150);
            ucTest1.TabIndex = 2;
            // 
            // richTextBox2
            // 
            richTextBox2.Location = new Point(585, 0);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(203, 376);
            richTextBox2.TabIndex = 1;
            richTextBox2.Text = "";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(0, 0);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(172, 376);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 200;
            timer1.Tick += timer1_Tick;
            // 
            // MainFrm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(926, 598);
            Controls.Add(splitContainer1);
            Controls.Add(statusStrip1);
            Name = "MainFrm";
            Text = "ConexãoModBus";
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private StatusStrip statusStrip1;
        private ToolStripStatusLabel SLbModBus;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private SplitContainer splitContainer1;
        private System.Windows.Forms.Timer timer1;
        private RichTextBox richTextBox1;
        private RichTextBox richTextBox2;
        private ToolStripStatusLabel tLbModBus2;
        private UCTest ucTest4;
        private UCTest ucTest3;
        private UCTest ucTest2;
        private UCTest ucTest1;
        private UC_Exemplo uC_Exemplo2;
        private UC_Exemplo uC_Exemplo1;
    }
}
