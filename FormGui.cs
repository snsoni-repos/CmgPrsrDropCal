namespace CmgPrsrDropCal
{
    public partial class FormGui : Form
    {
        

        private string mFilePath = string.Empty;
        private string mFileOutpath = string.Empty;

        public FormGui()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            PrsrDrop pdClass = new PrsrDrop();
            dal dalCls = new dal();

            //SS: ----------------- Read the file ---------------- 
            if(mFilePath != string.Empty)
            {
                Indata mIndata = dalCls.ReadDataFromTextFile(mFilePath);

                //SS: ---------- set the user input properties into field units -----

                mIndata.inletPrsr = mIndata.inletPrsr * 0.000145; // in psi
                mIndata.inletOilRate = mIndata.inletOilRate * 6.2898106;// in stb/d
                mIndata.inletWaterRate = mIndata.inletWaterRate * 6.2898106; // in stb/d
                mIndata.inletGasRate = mIndata.inletGasRate * 35.3147248 / 1000000;  ///28316.85; in MMscf/d
                mIndata.pipeId = mIndata.pipeId * 39.3700787; // in inch
                mIndata.pipeLength = mIndata.pipeLength * 3.2808399; // in feet            
                mIndata.oilVis = mIndata.oilVis * 1000; // in Cp
                mIndata.gasVis = mIndata.gasVis * 1000;// in Cp
                mIndata.waterVis = mIndata.waterVis * 1000;// in Cp            



                //SS:----------- Call the pressure drop calculation method

                Outdata mOutdata = pdClass.RunPressDropCal(mIndata);

                //SS:------------- Get the results and  write it to the file 

                mFileOutpath = Path.Combine(Path.GetDirectoryName(mFilePath),"outData.txt");

                dalCls.WriteDataToTextFile(mFileOutpath, mOutdata);

            }       

        }

        private void btnFileDialog_Click(object sender, EventArgs e)
        {
            
            using (OpenFileDialog openFileDialog1 = new OpenFileDialog())
            {
                //SS:-- Set initial directory (optional)
                openFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

                //SS:--- Set filter for file types
                openFileDialog1.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";

                //SS:----- Display the file dialog
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    //SS:----- Get the selected file path
                    string selectedFilePath = openFileDialog1.FileName;

                    //SS:----- Update the TextBox with the selected file path
                    txbFilepath.Text = selectedFilePath;
                    mFilePath = txbFilepath.Text;
                }
            }


        }

        

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        
    }
}