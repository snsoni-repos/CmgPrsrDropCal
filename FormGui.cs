namespace CmgPrsrDropCal
{
    public partial class FormGui : Form
    {
        //private System.Windows.Forms.OpenFileDialog Form.openFileDia;  
        
        public FormGui()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnFileDialog_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.ShowDialog();
        }

        private void openFileDia_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

            


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}