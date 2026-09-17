namespace Tenis1
{
    partial class Form1
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
            this.txtArray = new System.Windows.Forms.TextBox();
            this.btArray = new System.Windows.Forms.Button();
            this.lbArray = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbLista = new System.Windows.Forms.ListBox();
            this.btLista = new System.Windows.Forms.Button();
            this.txtLista = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtArray
            // 
            this.txtArray.Location = new System.Drawing.Point(13, 26);
            this.txtArray.Name = "txtArray";
            this.txtArray.Size = new System.Drawing.Size(100, 20);
            this.txtArray.TabIndex = 0;
            // 
            // btArray
            // 
            this.btArray.Location = new System.Drawing.Point(13, 52);
            this.btArray.Name = "btArray";
            this.btArray.Size = new System.Drawing.Size(100, 23);
            this.btArray.TabIndex = 1;
            this.btArray.Text = "+";
            this.btArray.UseVisualStyleBackColor = true;
            this.btArray.Click += new System.EventHandler(this.btArray_Click);
            // 
            // lbArray
            // 
            this.lbArray.FormattingEnabled = true;
            this.lbArray.Location = new System.Drawing.Point(13, 82);
            this.lbArray.Name = "lbArray";
            this.lbArray.Size = new System.Drawing.Size(120, 329);
            this.lbArray.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Arrays";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(209, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Listas";
            // 
            // lbLista
            // 
            this.lbLista.FormattingEnabled = true;
            this.lbLista.Location = new System.Drawing.Point(182, 82);
            this.lbLista.Name = "lbLista";
            this.lbLista.Size = new System.Drawing.Size(120, 329);
            this.lbLista.TabIndex = 7;
            // 
            // btLista
            // 
            this.btLista.Location = new System.Drawing.Point(182, 52);
            this.btLista.Name = "btLista";
            this.btLista.Size = new System.Drawing.Size(100, 23);
            this.btLista.TabIndex = 6;
            this.btLista.Text = "+";
            this.btLista.UseVisualStyleBackColor = true;
            this.btLista.Click += new System.EventHandler(this.btLista_Click);
            // 
            // txtLista
            // 
            this.txtLista.Location = new System.Drawing.Point(182, 26);
            this.txtLista.Name = "txtLista";
            this.txtLista.Size = new System.Drawing.Size(100, 20);
            this.txtLista.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbLista);
            this.Controls.Add(this.btLista);
            this.Controls.Add(this.txtLista);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbArray);
            this.Controls.Add(this.btArray);
            this.Controls.Add(this.txtArray);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtArray;
        private System.Windows.Forms.Button btArray;
        private System.Windows.Forms.ListBox lbArray;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lbLista;
        private System.Windows.Forms.Button btLista;
        private System.Windows.Forms.TextBox txtLista;
    }
}

