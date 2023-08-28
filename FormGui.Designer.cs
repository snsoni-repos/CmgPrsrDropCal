namespace CmgPrsrDropCal
{
    partial class FormGui
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
            btnRun = new Button();
            txbFilepath = new TextBox();
            btnFileDialog = new Button();
            openFileDia = new OpenFileDialog();
            grpbxIndata = new GroupBox();
            txbVisWater = new TextBox();
            label9 = new Label();
            txbVisGas = new TextBox();
            label8 = new Label();
            txbVisOil = new TextBox();
            label7 = new Label();
            txbInclination = new TextBox();
            label6 = new Label();
            txbPipeLength = new TextBox();
            label5 = new Label();
            txbPipeId = new TextBox();
            label4 = new Label();
            txbGasRate = new TextBox();
            label3 = new Label();
            txbWaterRate = new TextBox();
            label2 = new Label();
            txbOilRate = new TextBox();
            label1 = new Label();
            grpbxOut = new GroupBox();
            label15 = new Label();
            txbErrorMsg = new RichTextBox();
            txbOutletPrsr = new TextBox();
            label14 = new Label();
            txbTotalPrsrDrop = new TextBox();
            label13 = new Label();
            txbGradTotal = new TextBox();
            label12 = new Label();
            txbGradGravity = new TextBox();
            label11 = new Label();
            txbGradFric = new TextBox();
            label10 = new Label();
            grpbxIndata.SuspendLayout();
            grpbxOut.SuspendLayout();
            SuspendLayout();
            // 
            // btnRun
            // 
            btnRun.Location = new Point(754, 32);
            btnRun.Name = "btnRun";
            btnRun.Size = new Size(94, 29);
            btnRun.TabIndex = 0;
            btnRun.Text = "Run";
            btnRun.UseVisualStyleBackColor = true;
            btnRun.Click += button1_Click;
            // 
            // txbFilepath
            // 
            txbFilepath.Location = new Point(60, 34);
            txbFilepath.Name = "txbFilepath";
            txbFilepath.Size = new Size(465, 27);
            txbFilepath.TabIndex = 1;
            // 
            // btnFileDialog
            // 
            btnFileDialog.Location = new Point(531, 34);
            btnFileDialog.Name = "btnFileDialog";
            btnFileDialog.Size = new Size(94, 29);
            btnFileDialog.TabIndex = 2;
            btnFileDialog.Text = "Find";
            btnFileDialog.UseVisualStyleBackColor = true;
            btnFileDialog.Click += btnFileDialog_Click;
            // 
            // openFileDia
            // 
            openFileDia.FileName = "openFileDia";
            // 
            // grpbxIndata
            // 
            grpbxIndata.Controls.Add(txbVisWater);
            grpbxIndata.Controls.Add(label9);
            grpbxIndata.Controls.Add(txbVisGas);
            grpbxIndata.Controls.Add(label8);
            grpbxIndata.Controls.Add(txbVisOil);
            grpbxIndata.Controls.Add(label7);
            grpbxIndata.Controls.Add(txbInclination);
            grpbxIndata.Controls.Add(label6);
            grpbxIndata.Controls.Add(txbPipeLength);
            grpbxIndata.Controls.Add(label5);
            grpbxIndata.Controls.Add(txbPipeId);
            grpbxIndata.Controls.Add(label4);
            grpbxIndata.Controls.Add(txbGasRate);
            grpbxIndata.Controls.Add(label3);
            grpbxIndata.Controls.Add(txbWaterRate);
            grpbxIndata.Controls.Add(label2);
            grpbxIndata.Controls.Add(txbOilRate);
            grpbxIndata.Controls.Add(label1);
            grpbxIndata.Location = new Point(12, 69);
            grpbxIndata.Name = "grpbxIndata";
            grpbxIndata.Size = new Size(436, 445);
            grpbxIndata.TabIndex = 3;
            grpbxIndata.TabStop = false;
            grpbxIndata.Text = "Input Data  ( Field Unit)";
            
            // 
            // txbVisWater
            // 
            txbVisWater.Location = new Point(242, 306);
            txbVisWater.Name = "txbVisWater";
            txbVisWater.Size = new Size(125, 27);
            txbVisWater.TabIndex = 17;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(16, 309);
            label9.Name = "label9";
            label9.Size = new Size(139, 20);
            label9.TabIndex = 16;
            label9.Text = "Water Viscosity (cp)";
            
            // 
            // txbVisGas
            // 
            txbVisGas.Location = new Point(242, 273);
            txbVisGas.Name = "txbVisGas";
            txbVisGas.Size = new Size(125, 27);
            txbVisGas.TabIndex = 15;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(16, 276);
            label8.Name = "label8";
            label8.Size = new Size(124, 20);
            label8.TabIndex = 14;
            label8.Text = "Gas Viscosity (cp)";
            
            // 
            // txbVisOil
            // 
            txbVisOil.Location = new Point(242, 240);
            txbVisOil.Name = "txbVisOil";
            txbVisOil.Size = new Size(125, 27);
            txbVisOil.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(16, 243);
            label7.Name = "label7";
            label7.Size = new Size(119, 20);
            label7.TabIndex = 12;
            label7.Text = "Oil Viscosity (cp)";
            
            // 
            // txbInclination
            // 
            txbInclination.Location = new Point(242, 207);
            txbInclination.Name = "txbInclination";
            txbInclination.Size = new Size(125, 27);
            txbInclination.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(16, 210);
            label6.Name = "label6";
            label6.Size = new Size(172, 20);
            label6.TabIndex = 10;
            label6.Text = "Pipe Inclination (degree)";
            
            // 
            // txbPipeLength
            // 
            txbPipeLength.Location = new Point(242, 174);
            txbPipeLength.Name = "txbPipeLength";
            txbPipeLength.Size = new Size(124, 27);
            txbPipeLength.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(16, 177);
            label5.Name = "label5";
            label5.Size = new Size(127, 20);
            label5.TabIndex = 8;
            label5.Text = "Pipe Length (feet)";
            
            // 
            // txbPipeId
            // 
            txbPipeId.Location = new Point(242, 141);
            txbPipeId.Name = "txbPipeId";
            txbPipeId.Size = new Size(125, 27);
            txbPipeId.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(16, 144);
            label4.Name = "label4";
            label4.Size = new Size(98, 20);
            label4.TabIndex = 6;
            label4.Text = "Pipe ID (Inch)";
            
            // 
            // txbGasRate
            // 
            txbGasRate.Location = new Point(242, 108);
            txbGasRate.Name = "txbGasRate";
            txbGasRate.Size = new Size(125, 27);
            txbGasRate.TabIndex = 5;
           
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 111);
            label3.Name = "label3";
            label3.Size = new Size(190, 20);
            label3.TabIndex = 4;
            label3.Text = "Inlet Gas Rate (MMScf/day)";
            
            // 
            // txbWaterRate
            // 
            txbWaterRate.Location = new Point(242, 75);
            txbWaterRate.Name = "txbWaterRate";
            txbWaterRate.Size = new Size(123, 27);
            txbWaterRate.TabIndex = 3;
           
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 78);
            label2.Name = "label2";
            label2.Size = new Size(179, 20);
            label2.TabIndex = 2;
            label2.Text = "Inlet Water Rate (stb/day)";
            
            // 
            // txbOilRate
            // 
            txbOilRate.Location = new Point(242, 42);
            txbOilRate.Name = "txbOilRate";
            txbOilRate.Size = new Size(125, 27);
            txbOilRate.TabIndex = 1;
            
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 45);
            label1.Name = "label1";
            label1.Size = new Size(159, 20);
            label1.TabIndex = 0;
            label1.Text = "Inlet Oil Rate (stb/day)";
            
            // 
            // grpbxOut
            // 
            grpbxOut.Controls.Add(label15);
            grpbxOut.Controls.Add(txbErrorMsg);
            grpbxOut.Controls.Add(txbOutletPrsr);
            grpbxOut.Controls.Add(label14);
            grpbxOut.Controls.Add(txbTotalPrsrDrop);
            grpbxOut.Controls.Add(label13);
            grpbxOut.Controls.Add(txbGradTotal);
            grpbxOut.Controls.Add(label12);
            grpbxOut.Controls.Add(txbGradGravity);
            grpbxOut.Controls.Add(label11);
            grpbxOut.Controls.Add(txbGradFric);
            grpbxOut.Controls.Add(label10);
            grpbxOut.Location = new Point(454, 69);
            grpbxOut.Name = "grpbxOut";
            grpbxOut.Size = new Size(414, 443);
            grpbxOut.TabIndex = 4;
            grpbxOut.TabStop = false;
            grpbxOut.Text = "Output Data  ( Field Unit)";
            
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(42, 256);
            label15.Name = "label15";
            label15.Size = new Size(107, 20);
            label15.TabIndex = 11;
            label15.Text = "Run Time Error";
            
            // 
            // txbErrorMsg
            // 
            txbErrorMsg.Location = new Point(39, 288);
            txbErrorMsg.Name = "txbErrorMsg";
            txbErrorMsg.Size = new Size(357, 125);
            txbErrorMsg.TabIndex = 10;
            txbErrorMsg.Text = "";
            // 
            // txbOutletPrsr
            // 
            txbOutletPrsr.Location = new Point(269, 208);
            txbOutletPrsr.Name = "txbOutletPrsr";
            txbOutletPrsr.Size = new Size(125, 27);
            txbOutletPrsr.TabIndex = 9;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(37, 211);
            label14.Name = "label14";
            label14.Size = new Size(141, 20);
            label14.TabIndex = 8;
            label14.Text = "Outlet Pressure (psi)";
            // 
            // txbTotalPrsrDrop
            // 
            txbTotalPrsrDrop.Location = new Point(269, 164);
            txbTotalPrsrDrop.Name = "txbTotalPrsrDrop";
            txbTotalPrsrDrop.Size = new Size(125, 27);
            txbTotalPrsrDrop.TabIndex = 7;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(37, 167);
            label13.Name = "label13";
            label13.Size = new Size(169, 20);
            label13.TabIndex = 6;
            label13.Text = "Total Pressure drop (psi)";
            // 
            // txbGradTotal
            // 
            txbGradTotal.Location = new Point(269, 120);
            txbGradTotal.Name = "txbGradTotal";
            txbGradTotal.Size = new Size(125, 27);
            txbGradTotal.TabIndex = 5;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(37, 123);
            label12.Name = "label12";
            label12.Size = new Size(168, 20);
            label12.TabIndex = 4;
            label12.Text = "Total Gradient (psi/feet)";
            // 
            // txbGradGravity
            // 
            txbGradGravity.Location = new Point(269, 84);
            txbGradGravity.Name = "txbGradGravity";
            txbGradGravity.Size = new Size(125, 27);
            txbGradGravity.TabIndex = 3;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(37, 87);
            label11.Name = "label11";
            label11.Size = new Size(181, 20);
            label11.TabIndex = 2;
            label11.Text = "Gravity Gradient (psi/feet)";
            
            // 
            // txbGradFric
            // 
            txbGradFric.Location = new Point(269, 45);
            txbGradFric.Name = "txbGradFric";
            txbGradFric.Size = new Size(125, 27);
            txbGradFric.TabIndex = 1;
            
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(37, 48);
            label10.Name = "label10";
            label10.Size = new Size(184, 20);
            label10.TabIndex = 0;
            label10.Text = "Friction Gradient (psi/feet)";
            
            // 
            // FormGui
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(880, 524);
            Controls.Add(grpbxOut);
            Controls.Add(grpbxIndata);
            Controls.Add(btnFileDialog);
            Controls.Add(txbFilepath);
            Controls.Add(btnRun);
            Name = "FormGui";
            Text = "Pressure Drop Calculator (Homogeneous Model)";
            Load += Form1_Load;
            grpbxIndata.ResumeLayout(false);
            grpbxIndata.PerformLayout();
            grpbxOut.ResumeLayout(false);
            grpbxOut.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRun;
        private TextBox txbFilepath;
        private Button btnFileDialog;
        private OpenFileDialog openFileDia;
        private GroupBox grpbxIndata;
        private GroupBox grpbxOut;
        private Label label1;
        private TextBox txbOilRate;
        private TextBox txbWaterRate;
        private Label label2;
        private TextBox txbVisOil;
        private Label label7;
        private TextBox txbInclination;
        private Label label6;
        private TextBox txbPipeLength;
        private Label label5;
        private TextBox txbPipeId;
        private Label label4;
        private TextBox txbGasRate;
        private Label label3;
        private TextBox txbVisWater;
        private Label label9;
        private TextBox txbVisGas;
        private Label label8;
        private TextBox txbGradFric;
        private Label label10;
        private TextBox txbOutletPrsr;
        private Label label14;
        private TextBox txbTotalPrsrDrop;
        private Label label13;
        private TextBox txbGradTotal;
        private Label label12;
        private TextBox txbGradGravity;
        private Label label11;
        private RichTextBox txbErrorMsg;
        private Label label15;
    }
}