namespace ExemploFicheiros
{
    partial class frmFicheiro
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbFicheiros = new System.Windows.Forms.ListBox();
            this.btAbrir = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblPasta = new System.Windows.Forms.ToolStripStatusLabel();
            this.btAtualizar = new System.Windows.Forms.Button();
            this.fDDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.gbFicheiro = new System.Windows.Forms.GroupBox();
            this.rbFicheiro = new System.Windows.Forms.RichTextBox();
            this.btSalvar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.gbFicheiro.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbFicheiros);
            this.groupBox1.Location = new System.Drawing.Point(12, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(197, 384);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lista *.txt";
            // 
            // lbFicheiros
            // 
            this.lbFicheiros.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbFicheiros.FormattingEnabled = true;
            this.lbFicheiros.Location = new System.Drawing.Point(3, 16);
            this.lbFicheiros.Name = "lbFicheiros";
            this.lbFicheiros.Size = new System.Drawing.Size(191, 365);
            this.lbFicheiros.TabIndex = 0;
            this.lbFicheiros.SelectedIndexChanged += new System.EventHandler(this.lbFicheiros_SelectedIndexChanged);
            // 
            // btAbrir
            // 
            this.btAbrir.Location = new System.Drawing.Point(12, 12);
            this.btAbrir.Name = "btAbrir";
            this.btAbrir.Size = new System.Drawing.Size(75, 23);
            this.btAbrir.TabIndex = 1;
            this.btAbrir.Text = "Listar Pasta";
            this.btAbrir.UseVisualStyleBackColor = true;
            this.btAbrir.Click += new System.EventHandler(this.btAbrir_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.lblPasta});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(38, 17);
            this.toolStripStatusLabel1.Text = "Pasta:";
            // 
            // lblPasta
            // 
            this.lblPasta.Name = "lblPasta";
            this.lblPasta.Size = new System.Drawing.Size(19, 17);
            this.lblPasta.Text = "....";
            // 
            // btAtualizar
            // 
            this.btAtualizar.Location = new System.Drawing.Point(131, 12);
            this.btAtualizar.Name = "btAtualizar";
            this.btAtualizar.Size = new System.Drawing.Size(75, 23);
            this.btAtualizar.TabIndex = 3;
            this.btAtualizar.Text = "Atualizar";
            this.btAtualizar.UseVisualStyleBackColor = true;
            this.btAtualizar.Click += new System.EventHandler(this.btAtualizar_Click);
            // 
            // gbFicheiro
            // 
            this.gbFicheiro.Controls.Add(this.rbFicheiro);
            this.gbFicheiro.Location = new System.Drawing.Point(230, 41);
            this.gbFicheiro.Name = "gbFicheiro";
            this.gbFicheiro.Size = new System.Drawing.Size(570, 381);
            this.gbFicheiro.TabIndex = 4;
            this.gbFicheiro.TabStop = false;
            this.gbFicheiro.Text = "Detalhes ficheiro:";
            // 
            // rbFicheiro
            // 
            this.rbFicheiro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rbFicheiro.Location = new System.Drawing.Point(3, 16);
            this.rbFicheiro.Name = "rbFicheiro";
            this.rbFicheiro.Size = new System.Drawing.Size(564, 362);
            this.rbFicheiro.TabIndex = 0;
            this.rbFicheiro.Text = "";
            // 
            // btSalvar
            // 
            this.btSalvar.Location = new System.Drawing.Point(713, 12);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(75, 23);
            this.btSalvar.TabIndex = 5;
            this.btSalvar.Text = "Salvar";
            this.btSalvar.UseVisualStyleBackColor = true;
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // frmFicheiro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btSalvar);
            this.Controls.Add(this.gbFicheiro);
            this.Controls.Add(this.btAtualizar);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btAbrir);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmFicheiro";
            this.Text = "Ficheiro";
            this.groupBox1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.gbFicheiro.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btAbrir;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel lblPasta;
        private System.Windows.Forms.Button btAtualizar;
        private System.Windows.Forms.FolderBrowserDialog fDDialog;
        private System.Windows.Forms.GroupBox gbFicheiro;
        private System.Windows.Forms.RichTextBox rbFicheiro;
        private System.Windows.Forms.Button btSalvar;
        private System.Windows.Forms.ListBox lbFicheiros;
    }
}

