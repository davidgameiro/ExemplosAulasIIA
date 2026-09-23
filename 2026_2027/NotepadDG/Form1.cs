namespace Notepad2026
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var boxDialog=openFileDialog1.ShowDialog();

            if (boxDialog == DialogResult.OK)
            {
                var filePath = openFileDialog1.FileName;
                var fileContent = File.ReadAllText(filePath);
                richTextBox1.Text = fileContent;
                //temios que escrever qualquer coisa para salvar o arquivo
                this.Text = filePath;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
           var boxDialog = saveFileDialog1.ShowDialog();

            if (boxDialog == DialogResult.OK)
            {
                var filePath = saveFileDialog1.FileName;
                File.WriteAllText(filePath, richTextBox1.Text);
                this.Text = filePath;
            }
        }
    }
}
