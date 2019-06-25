using System;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.IO;
using System.Threading;
using System.Windows.Input;

namespace Screen_To_JPG
{
    public partial class screenToJPGForm : Form
    {
        private int suffixNumber = 0;
        private float scale = 1f;
        private GlobalHotkey snapHotkey;
        public screenToJPGForm()
        {
            InitializeComponent();
            _choosePathDir.SelectedPath = Directory.GetCurrentDirectory();
            snapHotkey = new GlobalHotkey(Constants.ALT, Keys.S, this);
            snapHotkey.Register();
        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == Constants.WM_HOTKEY_MSG_ID)
                TakeSnapshot();
            base.WndProc(ref m);
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
            Bitmap bitmap = new Bitmap((int)(Screen.PrimaryScreen.Bounds.Width * scale), (int)(Screen.PrimaryScreen.Bounds.Height * scale));
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
            Thread.Sleep(200);
            TakeSnapshot();
            Show();
            notifyIcon.Visible = true;
        }
        private void _openFileDir_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(_choosePathDir.SelectedPath);
        }
        private void ScreenToJPGForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 's')
                TakeSnapshot();
        }
        private void ComboScale_SelectedValueChanged(object sender, EventArgs e)
        {
            scale = 1f + ((float)comboScale.SelectedIndex / 4f);
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
            snapHotkey.Unregiser();
            System.Environment.Exit(1);
        }
    }
}
