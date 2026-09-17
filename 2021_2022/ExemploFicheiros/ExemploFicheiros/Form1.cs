using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExemploFicheiros
{
    public partial class frmFicheiro : Form
    {
        string CaminhoPasta=null;
        List<string> NomeFicheiros { get; set; } = new List<string>();
        string FicheiroSelecionado { get; set; } = null;
        public frmFicheiro()
        {
            InitializeComponent();
        }

        private void btAbrir_Click(object sender, EventArgs e)
        {
            if (fDDialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            CaminhoPasta = fDDialog.SelectedPath;
            lblPasta.Text = CaminhoPasta;

            ListarPasta(CaminhoPasta);

        }

        private void ListarPasta(string caminhoPasta)
        {
            List<string> ficheiros = System.IO.Directory.GetFiles(caminhoPasta, "*.txt").ToList();
            NomeFicheiros.Clear();
            lbFicheiros.Items.Clear();
            foreach(string nome in ficheiros)
            {
                string tmpNome = System.IO.Path.GetFileName(nome);
                NomeFicheiros.Add(tmpNome);
                lbFicheiros.Items.Add(tmpNome);
            }
            lbFicheiros.SelectedItem = NomeFicheiros.FirstOrDefault();
        }

        private void lbFicheiros_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox lb = sender as ListBox;
            if(lb is null || lb.SelectedIndex == -1)
            {
                return;
            }
            FicheiroSelecionado = lb.SelectedItem as string;
            CarregarFicheiro(CaminhoPasta, FicheiroSelecionado);
        }

        private void CarregarFicheiro(string CaminhoPasta, string ficheiroSelecionado)
        {
            string tmpFicheiro = CaminhoPasta + @"\" + ficheiroSelecionado;
            rbFicheiro.Clear();
            gbFicheiro.Text = "Detalhes ficheiro: " + ficheiroSelecionado;
            if (!System.IO.File.Exists(tmpFicheiro))//não pode ser acedido
            {
                return;
            }
            rbFicheiro.Text = System.IO.File.ReadAllText(CaminhoPasta + @"\" + ficheiroSelecionado);
            //rbFicheiro.LoadFile(ficheiroSelecionado, RichTextBoxStreamType.PlainText);
        }

        private void btAtualizar_Click(object sender, EventArgs e)
        {
            if (!System.IO.Directory.Exists(CaminhoPasta))
            {
                return;
            }
            ListarPasta(CaminhoPasta);
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            string tmpFicheiro = CaminhoPasta + @"\" + FicheiroSelecionado;
            if(!System.IO.File.Exists(tmpFicheiro))
            {
                return;
            }
            string LinhaAInserir="DateTime.Now \t OEE \t CiclosOK \t CiclosNOK\n";//contem o Data \t OEE \t \NCiclosOK \t NCiclosNOK\n
            StreamWriter fileStream = new StreamWriter(tmpFicheiro, true, Encoding.UTF8);
            fileStream.Write(LinhaAInserir);
            //System.IO.File.AppendText(LinhaAInserir);//serve para adicionar novas linhas no final do ficheiro
        }
    }
}
