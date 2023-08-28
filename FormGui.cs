namespace CmgPrsrDropCal
{
    public partial class FormGui : Form
    {


        private string mFilePath = string.Empty;
        private string mFileOutpath = string.Empty;
        private Indata mIndata = null;
        private Outdata mOutdata = null;
        private dal mDalCls = new dal();

        public FormGui()
        {
            InitializeComponent();

        }


        private bool LoadInputData()
        {
            bool isRunOk = true;

            try
            {
                if (mIndata != null)
                {
                    txbOilRate.Text = mIndata?.inletOilRate.ToString();
                    txbWaterRate.Text = mIndata?.inletWaterRate.ToString();
                    txbGasRate.Text = mIndata?.inletGasRate.ToString();
                    txbPipeId.Text = mIndata?.pipeId.ToString();
                    txbPipeLength.Text = mIndata?.pipeLength.ToString();
                    txbInclination.Text = mIndata?.incliantion.ToString();
                    txbVisOil.Text = mIndata?.oilVis.ToString();
                    txbVisGas.Text = mIndata?.gasVis.ToString();
                    txbVisWater.Text = mIndata?.waterVis.ToString();

                }


            }
            catch (Exception)
            {

                isRunOk = false;
            }

            return isRunOk;

        }

        private bool LoadOutData()
        {
            bool isRunOk = true;

            try
            {
                if (mOutdata != null)
                {
                    txbGradFric.Text = mOutdata?.FrictionGradient.ToString();
                    txbGradGravity.Text = mOutdata?.GraivityGradient.ToString();
                    txbGradTotal.Text = mOutdata?.TotaPressureGradient.ToString();
                    txbTotalPrsrDrop.Text = mOutdata?.TotalPressureDrop.ToString();
                    txbOutletPrsr.Text = mOutdata?.OutletPressure.ToString();
                    txbErrorMsg.Text = mOutdata?.ErrorMessage.ToString();
                }


            }
            catch (Exception)
            {

                isRunOk = false;
            }

            return isRunOk;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            PrsrDrop pdClass = new PrsrDrop();

            //SS: ----------------- Read the file ---------------- 
            if (mFilePath != string.Empty)
            {

                //SS:----------- Call the pressure drop calculation method
                mOutdata = pdClass.RunPressDropCal(mIndata);

                //SS:------------- Get the results and  write it to the file 
                if (mFilePath != null)
                {
                    mFileOutpath = Path.Combine(Path.GetDirectoryName(mFilePath), "outData.txt");
                    mDalCls.WriteDataToTextFile(mFileOutpath, mOutdata);
                    LoadOutData();
                }


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


                    //SS:--- Read and Load data in GUI
                    mIndata = mDalCls.ReadDataFromTextFile(mFilePath);

                    //SS:--- Convert data into the field units and load them in GUI
                    mIndata.inletPrsr = Math.Round(mIndata.inletPrsr * 0.000145, 2); // in psi
                    mIndata.inletOilRate = Math.Round(mIndata.inletOilRate * 6.2898106, 2);// in stb/d
                    mIndata.inletWaterRate = Math.Round(mIndata.inletWaterRate * 6.2898106, 2); // in stb/d
                    mIndata.inletGasRate = Math.Round(mIndata.inletGasRate * 35.3147248 / 1000000, 4);  ///28316.85; in MMscf/d
                    mIndata.pipeId = Math.Round(mIndata.pipeId * 39.3700787, 4); // in inch
                    mIndata.pipeLength = Math.Round(mIndata.pipeLength * 3.2808399, 2); // in feet            
                    mIndata.oilVis = Math.Round(mIndata.oilVis * 1000, 4); // in Cp
                    mIndata.gasVis = Math.Round(mIndata.gasVis * 1000, 4);// in Cp
                    mIndata.waterVis = Math.Round(mIndata.waterVis * 1000, 4);// in Cp  

                    LoadInputData();
                }
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

    }
}