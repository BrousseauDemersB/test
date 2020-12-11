namespace File_Splitter
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gbSplitInfo = new System.Windows.Forms.GroupBox();
            this.txtLines = new System.Windows.Forms.NumericUpDown();
            this.lblLines = new System.Windows.Forms.Label();
            this.txtToken = new System.Windows.Forms.TextBox();
            this.lblToken = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.gbOutput = new System.Windows.Forms.GroupBox();
            this.btnDestination = new System.Windows.Forms.Button();
            this.lblDestination = new System.Windows.Forms.Label();
            this.txtDestination = new System.Windows.Forms.TextBox();
            this.gbFinalize = new System.Windows.Forms.GroupBox();
            this.btnSplitFile = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbSplitInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtLines)).BeginInit();
            this.gbOutput.SuspendLayout();
            this.gbFinalize.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbSplitInfo
            // 
            this.gbSplitInfo.Controls.Add(this.txtLines);
            this.gbSplitInfo.Controls.Add(this.lblLines);
            this.gbSplitInfo.Controls.Add(this.txtToken);
            this.gbSplitInfo.Controls.Add(this.lblToken);
            this.gbSplitInfo.Location = new System.Drawing.Point(12, 12);
            this.gbSplitInfo.Name = "gbSplitInfo";
            this.gbSplitInfo.Size = new System.Drawing.Size(200, 80);
            this.gbSplitInfo.TabIndex = 0;
            this.gbSplitInfo.TabStop = false;
            this.gbSplitInfo.Text = "Split info";
            // 
            // txtLines
            // 
            this.txtLines.Location = new System.Drawing.Point(55, 48);
            this.txtLines.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.txtLines.Name = "txtLines";
            this.txtLines.Size = new System.Drawing.Size(120, 20);
            this.txtLines.TabIndex = 3;
            // 
            // lblLines
            // 
            this.lblLines.AutoSize = true;
            this.lblLines.Location = new System.Drawing.Point(6, 50);
            this.lblLines.Name = "lblLines";
            this.lblLines.Size = new System.Drawing.Size(32, 13);
            this.lblLines.TabIndex = 3;
            this.lblLines.Text = "Lines";
            // 
            // txtToken
            // 
            this.txtToken.Location = new System.Drawing.Point(50, 21);
            this.txtToken.Name = "txtToken";
            this.txtToken.Size = new System.Drawing.Size(125, 20);
            this.txtToken.TabIndex = 2;
            // 
            // lblToken
            // 
            this.lblToken.AutoSize = true;
            this.lblToken.Location = new System.Drawing.Point(6, 24);
            this.lblToken.Name = "lblToken";
            this.lblToken.Size = new System.Drawing.Size(38, 13);
            this.lblToken.TabIndex = 1;
            this.lblToken.Text = "Token";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // gbOutput
            // 
            this.gbOutput.Controls.Add(this.btnDestination);
            this.gbOutput.Controls.Add(this.lblDestination);
            this.gbOutput.Controls.Add(this.txtDestination);
            this.gbOutput.Location = new System.Drawing.Point(218, 12);
            this.gbOutput.Name = "gbOutput";
            this.gbOutput.Size = new System.Drawing.Size(232, 53);
            this.gbOutput.TabIndex = 1;
            this.gbOutput.TabStop = false;
            this.gbOutput.Text = "Ouput";
            // 
            // btnDestination
            // 
            this.btnDestination.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDestination.Location = new System.Drawing.Point(193, 21);
            this.btnDestination.Name = "btnDestination";
            this.btnDestination.Size = new System.Drawing.Size(25, 20);
            this.btnDestination.TabIndex = 2;
            this.btnDestination.Text = "...";
            this.btnDestination.UseVisualStyleBackColor = true;
            this.btnDestination.Click += new System.EventHandler(this.btnDestination_Click);
            // 
            // lblDestination
            // 
            this.lblDestination.AutoSize = true;
            this.lblDestination.Location = new System.Drawing.Point(6, 24);
            this.lblDestination.Name = "lblDestination";
            this.lblDestination.Size = new System.Drawing.Size(60, 13);
            this.lblDestination.TabIndex = 1;
            this.lblDestination.Text = "Destination";
            // 
            // txtDestination
            // 
            this.txtDestination.Location = new System.Drawing.Point(94, 21);
            this.txtDestination.Name = "txtDestination";
            this.txtDestination.ReadOnly = true;
            this.txtDestination.Size = new System.Drawing.Size(100, 20);
            this.txtDestination.TabIndex = 0;
            // 
            // gbFinalize
            // 
            this.gbFinalize.Controls.Add(this.btnSplitFile);
            this.gbFinalize.Location = new System.Drawing.Point(456, 12);
            this.gbFinalize.Name = "gbFinalize";
            this.gbFinalize.Size = new System.Drawing.Size(200, 53);
            this.gbFinalize.TabIndex = 2;
            this.gbFinalize.TabStop = false;
            this.gbFinalize.Text = "Finalize";
            // 
            // btnSplitFile
            // 
            this.btnSplitFile.Location = new System.Drawing.Point(6, 19);
            this.btnSplitFile.Name = "btnSplitFile";
            this.btnSplitFile.Size = new System.Drawing.Size(188, 23);
            this.btnSplitFile.TabIndex = 0;
            this.btnSplitFile.Text = "Split file";
            this.btnSplitFile.UseVisualStyleBackColor = true;
            this.btnSplitFile.Click += new System.EventHandler(this.btnSplitFile_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 107);
            this.Controls.Add(this.gbFinalize);
            this.Controls.Add(this.gbOutput);
            this.Controls.Add(this.gbSplitInfo);
            this.Name = "Form1";
            this.Text = "File Splitter";
            this.gbSplitInfo.ResumeLayout(false);
            this.gbSplitInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtLines)).EndInit();
            this.gbOutput.ResumeLayout(false);
            this.gbOutput.PerformLayout();
            this.gbFinalize.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbSplitInfo;
        private System.Windows.Forms.TextBox txtToken;
        private System.Windows.Forms.Label lblToken;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.GroupBox gbOutput;
        private System.Windows.Forms.Button btnDestination;
        private System.Windows.Forms.Label lblDestination;
        private System.Windows.Forms.TextBox txtDestination;
        private System.Windows.Forms.GroupBox gbFinalize;
        private System.Windows.Forms.Button btnSplitFile;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.NumericUpDown txtLines;
        private System.Windows.Forms.Label lblLines;
    }
}

