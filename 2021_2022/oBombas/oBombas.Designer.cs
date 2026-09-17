namespace oBombas
{
    partial class oBombas
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
            this.button1 = new System.Windows.Forms.Button();
            this.gbMinimo = new System.Windows.Forms.GroupBox();
            this.gbMaximo = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(370, 185);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // gbMinimo
            // 
            this.gbMinimo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gbMinimo.Location = new System.Drawing.Point(12, 109);
            this.gbMinimo.Name = "gbMinimo";
            this.gbMinimo.Size = new System.Drawing.Size(83, 44);
            this.gbMinimo.TabIndex = 6;
            this.gbMinimo.TabStop = false;
            this.gbMinimo.Text = "NivelMinimo";
            // 
            // gbMaximo
            // 
            this.gbMaximo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gbMaximo.Location = new System.Drawing.Point(12, 12);
            this.gbMaximo.Name = "gbMaximo";
            this.gbMaximo.Size = new System.Drawing.Size(83, 44);
            this.gbMaximo.TabIndex = 7;
            this.gbMaximo.TabStop = false;
            this.gbMaximo.Text = "NivelMinimo";
            // 
            // oBombas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbMaximo);
            this.Controls.Add(this.gbMinimo);
            this.Controls.Add(this.button1);
            this.Name = "oBombas";
            this.Text = "o Bombas";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox gbMinimo;
        private System.Windows.Forms.GroupBox gbMaximo;
    }
}

