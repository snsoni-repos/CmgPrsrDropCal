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
            PrsrDrop pdClass = new PrsrDrop();
            dal dalCls = new dal();

            // Read the file 

            Indata mIndata = dalCls.ReadDataFromTextFile();


            // set the user input properties

            pdClass.getDefaultInputData();



            // Call the pressure drop calculation method

           Outdata mOutdata =  pdClass.RunPressDropCal();

            //pdClass.GetLiquidHoldup(10000, 10, 1.197, 0.0091, 281, 6);

            //------------- Get the results and  write it to the file 
            dalCls.WriteDataToTextFile(mOutdata);




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