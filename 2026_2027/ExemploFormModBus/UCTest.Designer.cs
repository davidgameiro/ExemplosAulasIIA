namespace ExemploFormModBus
{
    partial class UCTest
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            gbName = new GroupBox();
            lbEntrada = new Label();
            lbSaida = new Label();
            gbName.SuspendLayout();
            SuspendLayout();
            // 
            // gbName
            // 
            gbName.Controls.Add(lbSaida);
            gbName.Controls.Add(lbEntrada);
            gbName.Dock = DockStyle.Fill;
            gbName.Location = new Point(0, 0);
            gbName.Name = "gbName";
            gbName.Size = new Size(150, 150);
            gbName.TabIndex = 0;
            gbName.TabStop = false;
            gbName.Text = "groupBox1";
            // 
            // lbEntrada
            // 
            lbEntrada.AutoSize = true;
            lbEntrada.Location = new Point(16, 45);
            lbEntrada.Name = "lbEntrada";
            lbEntrada.Size = new Size(47, 15);
            lbEntrada.TabIndex = 0;
            lbEntrada.Text = "Entrada";
            // 
            // lbSaida
            // 
            lbSaida.AutoSize = true;
            lbSaida.Location = new Point(16, 84);
            lbSaida.Name = "lbSaida";
            lbSaida.Size = new Size(35, 15);
            lbSaida.TabIndex = 1;
            lbSaida.Text = "Saida";
            // 
            // UCTest
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(gbName);
            Name = "UCTest";
            gbName.ResumeLayout(false);
            gbName.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbName;
        private Label lbSaida;
        private Label lbEntrada;
    }
}
