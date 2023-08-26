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
            textBox1 = new TextBox();
            btnFileDialog = new Button();
            openFileDia = new OpenFileDialog();
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
            // textBox1
            // 
            textBox1.Location = new Point(60, 34);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(465, 27);
            textBox1.TabIndex = 1;
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
            openFileDia.FileOk += openFileDia_FileOk;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(880, 524);
            Controls.Add(btnFileDialog);
            Controls.Add(textBox1);
            Controls.Add(btnRun);
            Name = "Form1";
            Text = "Pressure Drop Calculator";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRun;
        private TextBox textBox1;
        private Button btnFileDialog;
        private OpenFileDialog openFileDia;
    }
}