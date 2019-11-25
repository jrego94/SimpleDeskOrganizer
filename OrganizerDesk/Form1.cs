using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace OrganizerDesk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            backgroundWorker1.RunWorkerCompleted += backgroundWorker1_RunWorkerCompleted;  //Tell the user how the process went
            backgroundWorker1.ProgressChanged += backgroundWorker1_ProgressChanged;
            backgroundWorker1.WorkerReportsProgress = true;
            backgroundWorker1.WorkerSupportsCancellation = true;
        }

        public string PathFrom { get; private set; }
        public string PathTo { get; private set; }
        public bool boolYear { get; private set; }
        public bool boolMonth { get; private set; }
        public bool boolDay { get; private set; }

        private const string V = "/";
        private static readonly Regex r = new Regex(":");

        private void BtnSelectFrom_Click(object sender, EventArgs e)
        {
            PathFrom = getPath();

            if (PathFrom != null)
            {
                TxtPathFrom.Text = PathFrom;
                progressBar1.Maximum = countFiles(PathFrom);
                writeDetailsOnConsole("Path from:", countFiles(PathFrom), countDir(PathFrom));
            }
            else
            {
                TxtPathFrom.Text = "Need to choose a fodler";
            }
        }

        private void BtnSelectTo_Click(object sender, EventArgs e)
        {
            PathTo = getPath();
            if (PathTo != null)
            {
                TxtPathTo.Text = PathTo;
                writeDetailsOnConsole("Path to:", countFiles(PathTo), countDir(PathTo));
            }
            else
            {
                TxtPathTo.Text = "Need to choose a fodler";
            }
        }

        private string getPath()
        {
            OpenFileDialog folderBrowser = new OpenFileDialog
            {
                // Set validate names and check file exists to false otherwise windows will
                // not let you select "Folder Selection."
                ValidateNames = false,
                CheckFileExists = false,
                CheckPathExists = true,
                // Always default to Folder Selection.
                FileName = "Folder Selection."
            };
            if (folderBrowser.ShowDialog() == DialogResult.OK)
            {
                return Path.GetDirectoryName(folderBrowser.FileName);
            }
            return null;
        }

        private int countFiles(string path)
        {
            return Directory.GetFiles(path, "*", SearchOption.AllDirectories).Length;
        }

        private int countDir(string path)
        {
            return Directory.GetDirectories(path, "*", SearchOption.AllDirectories).Length;
        }

        private void writeDetailsOnConsole(string description, int nFiles, int nDir)
        {
            TxtConsole.AppendText(description + PathFrom + Environment.NewLine +
                nFiles + " Files" + Environment.NewLine +
                nDir + " Directories" + Environment.NewLine
                );
        }


        private void BtnRun_Click(object sender, EventArgs e)
        {
            if (PathFrom != null && PathTo != null)
            {
                setEnableOnOff(false);//disable groupbox,btn and txt
                backgroundWorker1.RunWorkerAsync();
            }
            else
            {
                TxtConsole.AppendText("You need to choose the folders" + Environment.NewLine);
            }
        }

        private void DirSearch(string sDir)
        {
            try
            {
                // get the directories of the chosen path.
                // If there is any directory, enter the cycle and call it itself until there is no directory.
                foreach (string d in Directory.GetDirectories(sDir))
                {
                    DirSearch(d);
                }

                //then goes through all the files in the directory you are in
                foreach (string g in Directory.GetFiles(sDir, "*.*"))
                {
                    FileInfo i = new FileInfo(g);
                    MovFiles(i.FullName, i.Name, GetDateTakenFromImage(g));
                }

            }
            catch (Exception ex)
            {
                backgroundWorker1.ReportProgress(0, string.Format("Catch # {0}", ex));
            }

        }

        //https://stackoverflow.com/questions/180030/how-can-i-find-out-when-a-picture-was-actually-taken-in-c-sharp-running-on-vista
        public static DateTime GetDateTakenFromImage(string path)
        {
            try
            {
                using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read))
                using (Image myImage = Image.FromStream(fs, false, false))
                {
                    PropertyItem propItem = null;
                    try
                    {
                        propItem = myImage.GetPropertyItem(36867);
                    }
                    catch (Exception e)
                    {
                        _ = e;
                    }
                    if (propItem != null)
                    {
                        string dateTaken = r.Replace(Encoding.UTF8.GetString(propItem.Value), "-", 2);
                        return DateTime.Parse(dateTaken);
                    }
                    else
                    {
                        return new FileInfo(path).CreationTime;
                    }
                }
            }
            catch (Exception)
            {
                return new FileInfo(path).CreationTime;
            }
        }

        private void MovFiles(string filePath, string name, DateTime date)
        {
            string lastPath = PathTo;
            try
            {
                if (boolYear)
                {
                    lastPath += V + date.Year;
                    if (!Directory.Exists(lastPath))
                    {
                        Directory.CreateDirectory(lastPath);
                    }
                }

                if (boolMonth)
                {
                    lastPath += V + date.ToString("yyyy-MM");
                    if (!Directory.Exists(lastPath))
                    {
                        Directory.CreateDirectory(lastPath);
                    }
                }

                if (boolDay)
                {
                    lastPath += V + date.ToString("yyyy-MM-dd");
                    if (!Directory.Exists(lastPath))
                    {
                        Directory.CreateDirectory(lastPath);
                    }
                }


                if (RBtnCopy.Checked)
                {
                    if (!File.Exists(lastPath + V + name))
                    {
                        File.Copy(filePath, lastPath + V + name);
                        backgroundWorker1.ReportProgress(0, string.Format("Copied # {0}", filePath));
                    }
                    else
                    {
                        backgroundWorker1.ReportProgress(0, string.Format("Not copied # {0}", filePath));
                    }

                }
                else if (RBtnMove.Checked)
                {
                    if (!File.Exists(lastPath + V + name))
                    {
                        File.Move(filePath, lastPath + V + name);
                        backgroundWorker1.ReportProgress(0, string.Format("Moved # {0}", filePath));
                    }
                    else
                    {
                        backgroundWorker1.ReportProgress(0, string.Format("Not moved # {0}", filePath));
                    }
                }

            }
            catch (Exception ex)
            {
                backgroundWorker1.ReportProgress(0, string.Format("Error # {0}", ex));
            }

        }

        private void BtnClearConsole_Click(object sender, EventArgs e)
        {
            TxtConsole.Text = "";
        }

        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            DirSearch(PathFrom);
        }

        private void backgroundWorker1_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {
            progressBar1.Value += 1;
            TxtConsole.AppendText(e.UserState as string + Environment.NewLine);
            TxtConsole.SelectionStart = TxtConsole.Text.Length;
            TxtConsole.ScrollToCaret();
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                TxtConsole.AppendText("Process was cancelled" + Environment.NewLine);
            }
            else if (e.Error != null)
            {
                TxtConsole.AppendText("There was an error running the process. The thread aborted" + Environment.NewLine);
            }
            else
            {
                TxtConsole.AppendText("Process was completed" + Environment.NewLine);

            }
            setEnableOnOff(true);

            TxtConsole.SelectionStart = TxtConsole.Text.Length;
            TxtConsole.ScrollToCaret();
        }

        private void setEnableOnOff(bool b)
        {
            GBoxFrom.Enabled = b;
            GBoxTo.Enabled = b;
            GBoxFrom.Enabled = b;
            RBtnCopy.Enabled = b;
            RBtnMove.Enabled = b;
            BtnClearConsole.Enabled = b;
            BtnRun.Enabled = b;
        }

        private void CB_Yeay_CheckedChanged(object sender, EventArgs e)
        {
            boolYear = CB_Yeay.Checked;
        }

        private void CB_Month_CheckedChanged(object sender, EventArgs e)
        {
            boolMonth = CB_Month.Checked;
        }

        private void CB_Day_CheckedChanged(object sender, EventArgs e)
        {
            boolDay = CB_Day.Checked;
        }
    }
}
