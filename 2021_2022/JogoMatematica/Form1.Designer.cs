namespace JogoMatematica
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTempoDecorrido = new System.Windows.Forms.Label();
            this.lblSomaVal1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblSomaVal2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblSubVal2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblSubVal1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblMultVal2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblMultVal1 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblDivVal2 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lblDivVal1 = new System.Windows.Forms.Label();
            this.lblResDiv = new System.Windows.Forms.Label();
            this.lblResMult = new System.Windows.Forms.Label();
            this.lblResSub = new System.Windows.Forms.Label();
            this.lblResSoma = new System.Windows.Forms.Label();
            this.btInicio = new System.Windows.Forms.Button();
            this.Temporizador = new System.Windows.Forms.Timer(this.components);
            this.lblMensagem = new System.Windows.Forms.Label();
            this.txtSoma = new System.Windows.Forms.TextBox();
            this.txtSub = new System.Windows.Forms.TextBox();
            this.txtMult = new System.Windows.Forms.TextBox();
            this.txtDiv = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tempo Decorrido";
            // 
            // lblTempoDecorrido
            // 
            this.lblTempoDecorrido.AutoSize = true;
            this.lblTempoDecorrido.Location = new System.Drawing.Point(107, 9);
            this.lblTempoDecorrido.Name = "lblTempoDecorrido";
            this.lblTempoDecorrido.Size = new System.Drawing.Size(49, 13);
            this.lblTempoDecorrido.TabIndex = 0;
            this.lblTempoDecorrido.Text = "0000000";
            // 
            // lblSomaVal1
            // 
            this.lblSomaVal1.AutoSize = true;
            this.lblSomaVal1.Location = new System.Drawing.Point(12, 61);
            this.lblSomaVal1.Name = "lblSomaVal1";
            this.lblSomaVal1.Size = new System.Drawing.Size(13, 13);
            this.lblSomaVal1.TabIndex = 1;
            this.lblSomaVal1.Text = "?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "+";
            // 
            // lblSomaVal2
            // 
            this.lblSomaVal2.AutoSize = true;
            this.lblSomaVal2.Location = new System.Drawing.Point(88, 61);
            this.lblSomaVal2.Name = "lblSomaVal2";
            this.lblSomaVal2.Size = new System.Drawing.Size(13, 13);
            this.lblSomaVal2.TabIndex = 3;
            this.lblSomaVal2.Text = "?";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(116, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "=";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(116, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "=";
            // 
            // lblSubVal2
            // 
            this.lblSubVal2.AutoSize = true;
            this.lblSubVal2.Location = new System.Drawing.Point(88, 98);
            this.lblSubVal2.Name = "lblSubVal2";
            this.lblSubVal2.Size = new System.Drawing.Size(13, 13);
            this.lblSubVal2.TabIndex = 8;
            this.lblSubVal2.Text = "?";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(43, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(10, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "-";
            // 
            // lblSubVal1
            // 
            this.lblSubVal1.AutoSize = true;
            this.lblSubVal1.Location = new System.Drawing.Point(12, 98);
            this.lblSubVal1.Name = "lblSubVal1";
            this.lblSubVal1.Size = new System.Drawing.Size(13, 13);
            this.lblSubVal1.TabIndex = 6;
            this.lblSubVal1.Text = "?";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(116, 136);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(13, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "=";
            // 
            // lblMultVal2
            // 
            this.lblMultVal2.AutoSize = true;
            this.lblMultVal2.Location = new System.Drawing.Point(88, 136);
            this.lblMultVal2.Name = "lblMultVal2";
            this.lblMultVal2.Size = new System.Drawing.Size(13, 13);
            this.lblMultVal2.TabIndex = 13;
            this.lblMultVal2.Text = "?";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(43, 136);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(12, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "x";
            // 
            // lblMultVal1
            // 
            this.lblMultVal1.AutoSize = true;
            this.lblMultVal1.Location = new System.Drawing.Point(12, 136);
            this.lblMultVal1.Name = "lblMultVal1";
            this.lblMultVal1.Size = new System.Drawing.Size(13, 13);
            this.lblMultVal1.TabIndex = 11;
            this.lblMultVal1.Text = "?";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(116, 166);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(13, 13);
            this.label12.TabIndex = 19;
            this.label12.Text = "=";
            // 
            // lblDivVal2
            // 
            this.lblDivVal2.AutoSize = true;
            this.lblDivVal2.Location = new System.Drawing.Point(88, 166);
            this.lblDivVal2.Name = "lblDivVal2";
            this.lblDivVal2.Size = new System.Drawing.Size(13, 13);
            this.lblDivVal2.TabIndex = 18;
            this.lblDivVal2.Text = "?";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(43, 166);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(12, 13);
            this.label14.TabIndex = 17;
            this.label14.Text = "/";
            // 
            // lblDivVal1
            // 
            this.lblDivVal1.AutoSize = true;
            this.lblDivVal1.Location = new System.Drawing.Point(12, 166);
            this.lblDivVal1.Name = "lblDivVal1";
            this.lblDivVal1.Size = new System.Drawing.Size(13, 13);
            this.lblDivVal1.TabIndex = 16;
            this.lblDivVal1.Text = "?";
            // 
            // lblResDiv
            // 
            this.lblResDiv.AutoSize = true;
            this.lblResDiv.Location = new System.Drawing.Point(211, 160);
            this.lblResDiv.Name = "lblResDiv";
            this.lblResDiv.Size = new System.Drawing.Size(13, 13);
            this.lblResDiv.TabIndex = 24;
            this.lblResDiv.Text = "=";
            // 
            // lblResMult
            // 
            this.lblResMult.AutoSize = true;
            this.lblResMult.Location = new System.Drawing.Point(211, 130);
            this.lblResMult.Name = "lblResMult";
            this.lblResMult.Size = new System.Drawing.Size(13, 13);
            this.lblResMult.TabIndex = 23;
            this.lblResMult.Text = "=";
            // 
            // lblResSub
            // 
            this.lblResSub.AutoSize = true;
            this.lblResSub.Location = new System.Drawing.Point(211, 92);
            this.lblResSub.Name = "lblResSub";
            this.lblResSub.Size = new System.Drawing.Size(13, 13);
            this.lblResSub.TabIndex = 22;
            this.lblResSub.Text = "=";
            // 
            // lblResSoma
            // 
            this.lblResSoma.AutoSize = true;
            this.lblResSoma.Location = new System.Drawing.Point(211, 55);
            this.lblResSoma.Name = "lblResSoma";
            this.lblResSoma.Size = new System.Drawing.Size(13, 13);
            this.lblResSoma.TabIndex = 21;
            this.lblResSoma.Text = "=";
            // 
            // btInicio
            // 
            this.btInicio.Location = new System.Drawing.Point(15, 209);
            this.btInicio.Name = "btInicio";
            this.btInicio.Size = new System.Drawing.Size(209, 23);
            this.btInicio.TabIndex = 25;
            this.btInicio.Text = "Iniciar";
            this.btInicio.UseVisualStyleBackColor = true;
            this.btInicio.Click += new System.EventHandler(this.btInicio_Click);
            // 
            // Temporizador
            // 
            this.Temporizador.Tick += new System.EventHandler(this.Temporizador_Tick);
            // 
            // lblMensagem
            // 
            this.lblMensagem.AutoSize = true;
            this.lblMensagem.Location = new System.Drawing.Point(16, 244);
            this.lblMensagem.Name = "lblMensagem";
            this.lblMensagem.Size = new System.Drawing.Size(0, 13);
            this.lblMensagem.TabIndex = 26;
            // 
            // txtSoma
            // 
            this.txtSoma.Location = new System.Drawing.Point(135, 58);
            this.txtSoma.Name = "txtSoma";
            this.txtSoma.Size = new System.Drawing.Size(51, 20);
            this.txtSoma.TabIndex = 27;
            // 
            // txtSub
            // 
            this.txtSub.Location = new System.Drawing.Point(135, 98);
            this.txtSub.Name = "txtSub";
            this.txtSub.Size = new System.Drawing.Size(51, 20);
            this.txtSub.TabIndex = 28;
            // 
            // txtMult
            // 
            this.txtMult.Location = new System.Drawing.Point(135, 136);
            this.txtMult.Name = "txtMult";
            this.txtMult.Size = new System.Drawing.Size(51, 20);
            this.txtMult.TabIndex = 29;
            // 
            // txtDiv
            // 
            this.txtDiv.Location = new System.Drawing.Point(135, 163);
            this.txtDiv.Name = "txtDiv";
            this.txtDiv.Size = new System.Drawing.Size(51, 20);
            this.txtDiv.TabIndex = 30;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 295);
            this.Controls.Add(this.txtDiv);
            this.Controls.Add(this.txtMult);
            this.Controls.Add(this.txtSub);
            this.Controls.Add(this.txtSoma);
            this.Controls.Add(this.lblMensagem);
            this.Controls.Add(this.btInicio);
            this.Controls.Add(this.lblResDiv);
            this.Controls.Add(this.lblResMult);
            this.Controls.Add(this.lblResSub);
            this.Controls.Add(this.lblResSoma);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lblDivVal2);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.lblDivVal1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblMultVal2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblMultVal1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblSubVal2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblSubVal1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblSomaVal2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblSomaVal1);
            this.Controls.Add(this.lblTempoDecorrido);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTempoDecorrido;
        private System.Windows.Forms.Label lblSomaVal1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblSomaVal2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblSubVal2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblSubVal1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblMultVal2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblMultVal1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblDivVal2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblDivVal1;
        private System.Windows.Forms.Label lblResDiv;
        private System.Windows.Forms.Label lblResMult;
        private System.Windows.Forms.Label lblResSub;
        private System.Windows.Forms.Label lblResSoma;
        private System.Windows.Forms.Button btInicio;
        private System.Windows.Forms.Timer Temporizador;
        private System.Windows.Forms.Label lblMensagem;
        private System.Windows.Forms.TextBox txtSoma;
        private System.Windows.Forms.TextBox txtSub;
        private System.Windows.Forms.TextBox txtMult;
        private System.Windows.Forms.TextBox txtDiv;
    }
}

