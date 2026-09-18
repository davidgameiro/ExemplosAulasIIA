namespace Calculadora
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
            btSoma = new Button();
            btDivisao = new Button();
            btSubtracao = new Button();
            btMultiplicacao = new Button();
            lbValor1 = new Label();
            lbValor2 = new Label();
            lbResultado = new Label();
            txtValor1 = new TextBox();
            txtValor2 = new TextBox();
            txtResultado = new TextBox();
            groupBox1 = new GroupBox();
            rtbHistorico = new RichTextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btSoma
            // 
            btSoma.Location = new Point(175, 86);
            btSoma.Name = "btSoma";
            btSoma.Size = new Size(75, 23);
            btSoma.TabIndex = 0;
            btSoma.Tag = "+";
            btSoma.Text = "+";
            btSoma.UseVisualStyleBackColor = true;
            btSoma.Click += btSoma_Click;
            // 
            // btDivisao
            // 
            btDivisao.Location = new Point(268, 86);
            btDivisao.Name = "btDivisao";
            btDivisao.Size = new Size(75, 23);
            btDivisao.TabIndex = 0;
            btDivisao.Tag = "/";
            btDivisao.Text = "/";
            btDivisao.UseVisualStyleBackColor = true;
            btDivisao.Click += btDivisao_Click;
            // 
            // btSubtracao
            // 
            btSubtracao.Location = new Point(175, 152);
            btSubtracao.Name = "btSubtracao";
            btSubtracao.Size = new Size(75, 23);
            btSubtracao.TabIndex = 0;
            btSubtracao.Tag = "-";
            btSubtracao.Text = "-";
            btSubtracao.UseVisualStyleBackColor = true;
            btSubtracao.Click += btSubtracao_Click;
            // 
            // btMultiplicacao
            // 
            btMultiplicacao.Location = new Point(268, 152);
            btMultiplicacao.Name = "btMultiplicacao";
            btMultiplicacao.Size = new Size(75, 23);
            btMultiplicacao.TabIndex = 0;
            btMultiplicacao.Tag = "*";
            btMultiplicacao.Text = "x";
            btMultiplicacao.UseVisualStyleBackColor = true;
            btMultiplicacao.Click += btMultiplicacao_Click;
            // 
            // lbValor1
            // 
            lbValor1.AutoSize = true;
            lbValor1.Location = new Point(38, 30);
            lbValor1.Name = "lbValor1";
            lbValor1.Size = new Size(42, 15);
            lbValor1.TabIndex = 1;
            lbValor1.Text = "Valor 1";
            // 
            // lbValor2
            // 
            lbValor2.AutoSize = true;
            lbValor2.Location = new Point(38, 170);
            lbValor2.Name = "lbValor2";
            lbValor2.Size = new Size(42, 15);
            lbValor2.TabIndex = 1;
            lbValor2.Text = "Valor 2";
            // 
            // lbResultado
            // 
            lbResultado.AutoSize = true;
            lbResultado.Location = new Point(482, 90);
            lbResultado.Name = "lbResultado";
            lbResultado.Size = new Size(59, 15);
            lbResultado.TabIndex = 1;
            lbResultado.Text = "Resultado";
            // 
            // txtValor1
            // 
            txtValor1.Location = new Point(15, 68);
            txtValor1.Name = "txtValor1";
            txtValor1.Size = new Size(100, 23);
            txtValor1.TabIndex = 2;
            txtValor1.TextChanged += txtValor_TextChanged;
            // 
            // txtValor2
            // 
            txtValor2.Location = new Point(15, 214);
            txtValor2.Name = "txtValor2";
            txtValor2.Size = new Size(100, 23);
            txtValor2.TabIndex = 2;
            txtValor2.TextChanged += txtValor_TextChanged;
            // 
            // txtResultado
            // 
            txtResultado.Location = new Point(453, 137);
            txtResultado.Name = "txtResultado";
            txtResultado.Size = new Size(100, 23);
            txtResultado.TabIndex = 2;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rtbHistorico);
            groupBox1.Location = new Point(317, 220);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(471, 218);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Historico";
            // 
            // rtbHistorico
            // 
            rtbHistorico.Dock = DockStyle.Fill;
            rtbHistorico.Location = new Point(3, 19);
            rtbHistorico.Name = "rtbHistorico";
            rtbHistorico.Size = new Size(465, 196);
            rtbHistorico.TabIndex = 0;
            rtbHistorico.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Controls.Add(txtResultado);
            Controls.Add(txtValor2);
            Controls.Add(txtValor1);
            Controls.Add(lbResultado);
            Controls.Add(lbValor2);
            Controls.Add(lbValor1);
            Controls.Add(btMultiplicacao);
            Controls.Add(btSubtracao);
            Controls.Add(btDivisao);
            Controls.Add(btSoma);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btSoma;
        private Button btDivisao;
        private Button btSubtracao;
        private Button btMultiplicacao;
        private Label lbValor1;
        private Label lbValor2;
        private Label lbResultado;
        private TextBox txtValor1;
        private TextBox txtValor2;
        private TextBox txtResultado;
        private GroupBox groupBox1;
        private RichTextBox rtbHistorico;
    }
}
