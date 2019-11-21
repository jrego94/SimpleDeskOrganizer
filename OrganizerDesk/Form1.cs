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
            backgroundWorker1.DoWork += backgroundWorker1_DoWork;
            backgroundWorker1.ProgressChanged += backgroundWorker1_ProgressChanged;
            backgroundWorker1.RunWorkerCompleted += backgroundWorker1_RunWorkerCompleted;  //Tell the user how the process went
            backgroundWorker1.WorkerReportsProgress = true;
            backgroundWorker1.WorkerSupportsCancellation = true;
        }

        public string PathFrom { get; private set; }
        public string PathTo { get; private set; }
        private static readonly Regex r = new Regex(":");

        private void BtnSelectFrom_Click(object sender, EventArgs e)
        {
            PathFrom = getPath();
            TxtPathFrom.Text = PathFrom;
        }

        private void BtnSelectTo_Click(object sender, EventArgs e)
        {
            PathTo = getPath();
            TxtPathTo.Text = PathTo;
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
                //PathTo = Path.GetDirectoryName(folderBrowser.FileName);
                //TxtPathTo.Text = PathTo;

                //int fCount = Directory.GetFiles(PathTo, "*", SearchOption.AllDirectories).Length;
                //int dCount = Directory.GetDirectories(PathTo, "*", SearchOption.AllDirectories).Length;

                //TxtConsole.AppendText("Path To: " + PathFrom + Environment.NewLine +
                //    fCount + " Files" + Environment.NewLine +
                //    dCount + " Directories" + Environment.NewLine
                //    );
                
            }
            return null;
        }

        private void BtnRun_Click(object sender, EventArgs e)
        {
            setEnableOnOff(false);//disable groupbox,btn and txt
            backgroundWorker1.RunWorkerAsync();
        }

        void DirSearch(string sDir)
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
                backgroundWorker1.ReportProgress(0, String.Format("Catch # {0}", ex));
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
                    catch { }
                    if (propItem != null)
                    {
                        string dateTaken = r.Replace(Encoding.UTF8.GetString(propItem.Value), "-", 2);
                        return DateTime.Parse(dateTaken);
                    }
                    else
                        return new FileInfo(path).CreationTime;
                }
            }
            catch (Exception)
            {
                return new FileInfo(path).CreationTime;
            }

        }


        private void MovFiles(string filePath, string name, DateTime date)
        {
            string pathyear = PathTo + "/" + date.Year;
            string pathmouth = pathyear + "/" + date.Month;
            string pathday = pathmouth + "/" + date.Day;
            try
            {
                if (!Directory.Exists(pathyear))
                {
                    Directory.CreateDirectory(pathyear);
                }

                if (!Directory.Exists(pathmouth))
                {
                    Directory.CreateDirectory(pathmouth);
                }

                if (!Directory.Exists(pathday))
                {
                    Directory.CreateDirectory(pathday);
                }

                if (RBtnCopy.Checked)
                {
                    if (!File.Exists(pathday + "/" + name))
                    {
                        File.Copy(filePath, pathday + "/" + name);
                        backgroundWorker1.ReportProgress(0, String.Format("Copied # {0}", filePath));
                    }
                    else
                    {
                        backgroundWorker1.ReportProgress(0, String.Format("Not copied # {0}", filePath));
                    }

                }
                else if (RBtnMove.Checked)
                {
                    if (!File.Exists(pathday + "/" + name))
                    {
                        File.Move(filePath, pathday + "/" + name);
                        backgroundWorker1.ReportProgress(0, String.Format("Moved # {0}", filePath));
                    }
                    else
                    {
                        backgroundWorker1.ReportProgress(0, String.Format("Not moved # {0}", filePath));
                    }
                }

            }
            catch (Exception ex)
            {
                backgroundWorker1.ReportProgress(0, String.Format("Error # {0}", ex));
            }

        }

        private void BtnClearConsole_Click(object sender, EventArgs e)
        {
            TxtConsole.Text = "";
        }

        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            if (PathFrom != null && PathTo != null)
            {
                DirSearch(PathFrom);
            }
        }

        private void backgroundWorker1_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
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

        private void setEnableOnOff(Boolean b)
        {
            GBoxFrom.Enabled = b;
            GBoxTo.Enabled = b;
            GBoxFrom.Enabled = b;
            RBtnCopy.Enabled = b;
            RBtnMove.Enabled = b;
            BtnClearConsole.Enabled = b;
            BtnRun.Enabled = b;
        }

    }
}
