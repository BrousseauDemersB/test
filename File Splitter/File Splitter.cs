using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace File_Splitter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDestination_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                txtDestination.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void btnSplitFile_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (txtToken.Text.Length == 0 && txtLines.Value == 0)
            {
                errorProvider1.SetError(txtToken, "A token is required");
            }
            else if (txtDestination.Text.Length == 0)
            {
                if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
                {
                    txtDestination.Text = folderBrowserDialog1.SelectedPath;
                    if (txtLines.Value > 0)
                    {
                        SplitOnLines();
                    }
                    else
                    {
                        StartSplit();
                    }
                }
            }
            else
            {
                if (txtLines.Value > 0)
                {
                    SplitOnLines();
                }
                else
                {
                    StartSplit();
                }
            }
        }

        private void StartSplit()
        {
            openFileDialog1.Filter = "All files (*.*)|*.*";
            openFileDialog1.FileName = "";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string FileText = File.ReadAllText(openFileDialog1.FileName);
                string[] SplitFile = FileText.Split(new string[] { txtToken.Text }, StringSplitOptions.RemoveEmptyEntries);

                for (int F = 0; F < SplitFile.Length; ++F)
                {
                    File.WriteAllText(txtDestination.Text + "\\Output-" + F + "-" + openFileDialog1.SafeFileName, SplitFile[F]);
                }
            }
        }

        private void SplitOnLines()
        {
            openFileDialog1.Filter = "All files (*.*)|*.*";
            openFileDialog1.FileName = "";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (StreamReader sr = new StreamReader(openFileDialog1.FileName))
                {
                    StringBuilder Builder = new StringBuilder();
                    int Counter = 0;
                    int MaxCounter = (int)txtLines.Value;
                    int OutputIndex = 0;

                    while (sr.Peek() >= 0)
                    {
                        Builder.Append(sr.ReadLine() + "\r\n");
                        ++Counter;

                        if (Counter == MaxCounter)
                        {
                            File.WriteAllText(txtDestination.Text + "\\Output-" + OutputIndex + "-" + openFileDialog1.SafeFileName, Builder.ToString());
                            Builder.Clear();
                            Counter = 0;
                            ++OutputIndex;
                        }
                    }

                    if (Builder.Length > 0)
                    {
                        File.WriteAllText(txtDestination.Text + "\\Output-" + OutputIndex + "-" + openFileDialog1.SafeFileName, Builder.ToString());
                    }
                }
            }
        }
    }
}
