namespace GestaoAlunos
{
    partial class FrmPrincipal
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
            this.btConectar = new System.Windows.Forms.Button();
            this.btLerBD = new System.Windows.Forms.Button();
            this.btInserir = new System.Windows.Forms.Button();
            this.btLerRegisto = new System.Windows.Forms.Button();
            this.btAtualizar = new System.Windows.Forms.Button();
            this.btApagar = new System.Windows.Forms.Button();
            this.gbDados = new System.Windows.Forms.GroupBox();
            this.rbDados = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNMeca = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMaxID = new System.Windows.Forms.TextBox();
            this.btMaxID = new System.Windows.Forms.Button();
            this.gbDados.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btConectar
            // 
            this.btConectar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btConectar.Location = new System.Drawing.Point(12, 12);
            this.btConectar.Name = "btConectar";
            this.btConectar.Size = new System.Drawing.Size(196, 44);
            this.btConectar.TabIndex = 0;
            this.btConectar.Text = "Conectar";
            this.btConectar.UseVisualStyleBackColor = true;
            this.btConectar.Click += new System.EventHandler(this.btConectar_Click);
            // 
            // btLerBD
            // 
            this.btLerBD.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btLerBD.Location = new System.Drawing.Point(12, 78);
            this.btLerBD.Name = "btLerBD";
            this.btLerBD.Size = new System.Drawing.Size(196, 44);
            this.btLerBD.TabIndex = 1;
            this.btLerBD.Text = "Ler Base Dados";
            this.btLerBD.UseVisualStyleBackColor = true;
            this.btLerBD.Click += new System.EventHandler(this.btLerBD_Click);
            // 
            // btInserir
            // 
            this.btInserir.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btInserir.Location = new System.Drawing.Point(12, 158);
            this.btInserir.Name = "btInserir";
            this.btInserir.Size = new System.Drawing.Size(196, 44);
            this.btInserir.TabIndex = 2;
            this.btInserir.Text = "Inserir Registo";
            this.btInserir.UseVisualStyleBackColor = true;
            this.btInserir.Click += new System.EventHandler(this.btInserir_Click);
            // 
            // btLerRegisto
            // 
            this.btLerRegisto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btLerRegisto.Location = new System.Drawing.Point(12, 229);
            this.btLerRegisto.Name = "btLerRegisto";
            this.btLerRegisto.Size = new System.Drawing.Size(196, 44);
            this.btLerRegisto.TabIndex = 3;
            this.btLerRegisto.Text = "Ler Registo";
            this.btLerRegisto.UseVisualStyleBackColor = true;
            this.btLerRegisto.Click += new System.EventHandler(this.btLerRegisto_Click);
            // 
            // btAtualizar
            // 
            this.btAtualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btAtualizar.Location = new System.Drawing.Point(12, 304);
            this.btAtualizar.Name = "btAtualizar";
            this.btAtualizar.Size = new System.Drawing.Size(196, 44);
            this.btAtualizar.TabIndex = 4;
            this.btAtualizar.Text = "Atualizar Registo";
            this.btAtualizar.UseVisualStyleBackColor = true;
            // 
            // btApagar
            // 
            this.btApagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btApagar.Location = new System.Drawing.Point(12, 366);
            this.btApagar.Name = "btApagar";
            this.btApagar.Size = new System.Drawing.Size(196, 44);
            this.btApagar.TabIndex = 5;
            this.btApagar.Text = "Apagar Registo";
            this.btApagar.UseVisualStyleBackColor = true;
            this.btApagar.Click += new System.EventHandler(this.btApagar_Click);
            // 
            // gbDados
            // 
            this.gbDados.Controls.Add(this.rbDados);
            this.gbDados.Location = new System.Drawing.Point(243, 45);
            this.gbDados.Name = "gbDados";
            this.gbDados.Size = new System.Drawing.Size(545, 274);
            this.gbDados.TabIndex = 6;
            this.gbDados.TabStop = false;
            this.gbDados.Text = "Dados";
            // 
            // rbDados
            // 
            this.rbDados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rbDados.Location = new System.Drawing.Point(3, 16);
            this.rbDados.Name = "rbDados";
            this.rbDados.Size = new System.Drawing.Size(539, 255);
            this.rbDados.TabIndex = 0;
            this.rbDados.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtNMeca);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtTelefone);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtNome);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtId);
            this.groupBox1.Location = new System.Drawing.Point(246, 325);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(542, 113);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registo";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(61, 32);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(34, 20);
            this.txtId.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nome";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(61, 58);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(328, 20);
            this.txtNome.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Telefone";
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(61, 87);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(100, 20);
            this.txtTelefone.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(130, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Nº Mecanográfico";
            // 
            // txtNMeca
            // 
            this.txtNMeca.Location = new System.Drawing.Point(229, 32);
            this.txtNMeca.Name = "txtNMeca";
            this.txtNMeca.Size = new System.Drawing.Size(72, 20);
            this.txtNMeca.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(641, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "MaxID";
            // 
            // txtMaxID
            // 
            this.txtMaxID.Location = new System.Drawing.Point(686, 8);
            this.txtMaxID.Name = "txtMaxID";
            this.txtMaxID.ReadOnly = true;
            this.txtMaxID.Size = new System.Drawing.Size(100, 20);
            this.txtMaxID.TabIndex = 9;
            // 
            // btMaxID
            // 
            this.btMaxID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btMaxID.Location = new System.Drawing.Point(508, 8);
            this.btMaxID.Name = "btMaxID";
            this.btMaxID.Size = new System.Drawing.Size(127, 31);
            this.btMaxID.TabIndex = 10;
            this.btMaxID.Text = "Max ID";
            this.btMaxID.UseVisualStyleBackColor = true;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btMaxID);
            this.Controls.Add(this.txtMaxID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbDados);
            this.Controls.Add(this.btApagar);
            this.Controls.Add(this.btAtualizar);
            this.Controls.Add(this.btLerRegisto);
            this.Controls.Add(this.btInserir);
            this.Controls.Add(this.btLerBD);
            this.Controls.Add(this.btConectar);
            this.Name = "FrmPrincipal";
            this.Text = "Form1";
            this.gbDados.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btConectar;
        private System.Windows.Forms.Button btLerBD;
        private System.Windows.Forms.Button btInserir;
        private System.Windows.Forms.Button btLerRegisto;
        private System.Windows.Forms.Button btAtualizar;
        private System.Windows.Forms.Button btApagar;
        private System.Windows.Forms.GroupBox gbDados;
        private System.Windows.Forms.RichTextBox rbDados;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNMeca;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMaxID;
        private System.Windows.Forms.Button btMaxID;
    }
}

