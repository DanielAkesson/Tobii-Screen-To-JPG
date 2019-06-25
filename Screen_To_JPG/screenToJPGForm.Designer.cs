namespace Screen_To_JPG
{
    partial class screenToJPGForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(screenToJPGForm));
            this._choosePathBut = new System.Windows.Forms.Button();
            this._takeSnapBut = new System.Windows.Forms.Button();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this._contextActions = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.takeSnapshotToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openWindowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openImageDirectoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._prefix = new System.Windows.Forms.TextBox();
            this._choosePathDir = new System.Windows.Forms.FolderBrowserDialog();
            this._openFileDir = new System.Windows.Forms.Button();
            this.comboScale = new System.Windows.Forms.ComboBox();
            this._contextActions.SuspendLayout();
            this.SuspendLayout();
            // 
            // _choosePathBut
            // 
            this._choosePathBut.BackColor = System.Drawing.Color.Moccasin;
            resources.ApplyResources(this._choosePathBut, "_choosePathBut");
            this._choosePathBut.Name = "_choosePathBut";
            this._choosePathBut.UseVisualStyleBackColor = false;
            this._choosePathBut.Click += new System.EventHandler(this._choosePathBut_Click);
            // 
            // _takeSnapBut
            // 
            this._takeSnapBut.BackColor = System.Drawing.Color.Salmon;
            resources.ApplyResources(this._takeSnapBut, "_takeSnapBut");
            this._takeSnapBut.Name = "_takeSnapBut";
            this._takeSnapBut.UseMnemonic = false;
            this._takeSnapBut.UseVisualStyleBackColor = false;
            this._takeSnapBut.Click += new System.EventHandler(this._takeSnapBut_Click);
            // 
            // notifyIcon
            // 
            resources.ApplyResources(this.notifyIcon, "notifyIcon");
            this.notifyIcon.ContextMenuStrip = this._contextActions;
            // 
            // _contextActions
            // 
            this._contextActions.ImageScalingSize = new System.Drawing.Size(20, 20);
            this._contextActions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.takeSnapshotToolStripMenuItem,
            this.openWindowToolStripMenuItem,
            this.openImageDirectoryToolStripMenuItem,
            this.quitToolStripMenuItem});
            this._contextActions.Name = "_contextActions";
            resources.ApplyResources(this._contextActions, "_contextActions");
            // 
            // takeSnapshotToolStripMenuItem
            // 
            this.takeSnapshotToolStripMenuItem.Name = "takeSnapshotToolStripMenuItem";
            resources.ApplyResources(this.takeSnapshotToolStripMenuItem, "takeSnapshotToolStripMenuItem");
            this.takeSnapshotToolStripMenuItem.Click += new System.EventHandler(this.takeSnapshotToolStripMenuItem_Click);
            // 
            // openWindowToolStripMenuItem
            // 
            this.openWindowToolStripMenuItem.Name = "openWindowToolStripMenuItem";
            resources.ApplyResources(this.openWindowToolStripMenuItem, "openWindowToolStripMenuItem");
            this.openWindowToolStripMenuItem.Click += new System.EventHandler(this.openWindowToolStripMenuItem_Click);
            // 
            // openImageDirectoryToolStripMenuItem
            // 
            this.openImageDirectoryToolStripMenuItem.Name = "openImageDirectoryToolStripMenuItem";
            resources.ApplyResources(this.openImageDirectoryToolStripMenuItem, "openImageDirectoryToolStripMenuItem");
            this.openImageDirectoryToolStripMenuItem.Click += new System.EventHandler(this.openImageDirectoryToolStripMenuItem_Click);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            resources.ApplyResources(this.quitToolStripMenuItem, "quitToolStripMenuItem");
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // _prefix
            // 
            resources.ApplyResources(this._prefix, "_prefix");
            this._prefix.Name = "_prefix";
            this._prefix.TextChanged += new System.EventHandler(this._prefix_TextChanged);
            // 
            // _choosePathDir
            // 
            resources.ApplyResources(this._choosePathDir, "_choosePathDir");
            // 
            // _openFileDir
            // 
            this._openFileDir.BackColor = System.Drawing.Color.Moccasin;
            resources.ApplyResources(this._openFileDir, "_openFileDir");
            this._openFileDir.Name = "_openFileDir";
            this._openFileDir.UseVisualStyleBackColor = false;
            this._openFileDir.Click += new System.EventHandler(this._openFileDir_Click);
            // 
            // comboScale
            // 
            this.comboScale.DisplayMember = "0";
            this.comboScale.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboScale.Items.AddRange(new object[] {
            resources.GetString("comboScale.Items"),
            resources.GetString("comboScale.Items1"),
            resources.GetString("comboScale.Items2"),
            resources.GetString("comboScale.Items3")});
            resources.ApplyResources(this.comboScale, "comboScale");
            this.comboScale.Name = "comboScale";
            this.comboScale.ValueMember = "0";
            this.comboScale.SelectedValueChanged += new System.EventHandler(this.ComboScale_SelectedValueChanged);
            // 
            // screenToJPGForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.comboScale);
            this.Controls.Add(this._openFileDir);
            this.Controls.Add(this._prefix);
            this.Controls.Add(this._takeSnapBut);
            this.Controls.Add(this._choosePathBut);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "screenToJPGForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.screenToJPGForm_FormClosing);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ScreenToJPGForm_KeyPress);
            this._contextActions.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button _choosePathBut;
        private System.Windows.Forms.Button _takeSnapBut;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.TextBox _prefix;
        private System.Windows.Forms.FolderBrowserDialog _choosePathDir;
        private System.Windows.Forms.ContextMenuStrip _contextActions;
        private System.Windows.Forms.ToolStripMenuItem takeSnapshotToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openWindowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.Button _openFileDir;
        private System.Windows.Forms.ToolStripMenuItem openImageDirectoryToolStripMenuItem;
        private System.Windows.Forms.ComboBox comboScale;
    }
}

