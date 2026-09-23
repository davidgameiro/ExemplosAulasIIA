namespace Ex2_CarregarImagem
{
    public partial class Form1 : Form
    {

        
        public Form1()
        {
            InitializeComponent();
        }

        private void rbChanged(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;
            try
            {
                pictureBox1.BackgroundImage = Image.FromFile(@".\imgs\" + rb.Text + ".jpg");
            }
            catch
            {
                pictureBox1.BackgroundImage = null;
                rb.BackColor = Color.Red;
                rb.Enabled = false;
            }
        }
    }
}
