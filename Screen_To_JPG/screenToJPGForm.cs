using System;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.IO;
using System.Threading;

namespace Screen_To_JPG
{
    public partial class screenToJPGForm : Form
    {
        private int suffixNumber = 0;
        public screenToJPGForm()
        {
            InitializeComponent();
            _choosePathDir.SelectedPath = Directory.GetCurrentDirectory();
        }
       
        //Functions
        private void TakeSnapshot()
        {
            Bitmap img = CaptureWindow();
            //Store in diclocation(to get the correct number do fileexist for N up until it returns false store said value!!)
            while(File.Exists(_choosePathDir.SelectedPath + "/" + _prefix.Text + suffixNumber.ToString("00000") + ".jpg"))
                suffixNumber++;
            img.Save(_choosePathDir.SelectedPath + "/" + _prefix.Text + suffixNumber.ToString("00000") + ".jpg", ImageFormat.Jpeg);
            suffixNumber++;
        }
        private Bitmap CaptureWindow()
        {
            Bitmap bitmap = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
            Graphics graphics = Graphics.FromImage(bitmap as Image);
            graphics.CopyFromScreen(0, 0, 0, 0, bitmap.Size);
            return bitmap;
        }
        //Window actions
        private void _prefix_TextChanged(object sender, EventArgs e)
        {
            if(_prefix.Text.Trim() == "")
                _prefix.Text = "img";
        }
        private void screenToJPGForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
            WindowState = FormWindowState.Minimized;
            notifyIcon.Visible = true;
        }
        private void _choosePathBut_Click(object sender, EventArgs e)
        {
            _choosePathDir.ShowDialog();
            suffixNumber = 0;
        }
        private void _takeSnapBut_Click(object sender, EventArgs e)
        {
            Hide();
            notifyIcon.Visible = false;
            Thread.Sleep(150);
            TakeSnapshot();
            Show();
            notifyIcon.Visible = true;
        }
        private void _openFileDir_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(_choosePathDir.SelectedPath);
        }
        //Context menu actions
        private void takeSnapshotToolStripMenuItem_Click(object sender, EventArgs e)
        {
            notifyIcon.Visible = false;
            Thread.Sleep(50);
            TakeSnapshot();
            notifyIcon.Visible = true;
        }
        private void openWindowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
            notifyIcon.Visible = false;
        }
        private void openImageDirectoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(_choosePathDir.SelectedPath);
        }
        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            notifyIcon.Visible = false;
            notifyIcon.Dispose();
            Close();
            Application.Exit();
            System.Environment.Exit(1);
        }
    }
}
