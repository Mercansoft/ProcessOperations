
namespace VISsessionControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.GlobalTimer = new System.Windows.Forms.Timer(this.components);
            this.LocalTimer = new System.Windows.Forms.Timer(this.components);
            this._btnClose = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gösterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gizleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // GlobalTimer
            // 
            this.GlobalTimer.Tick += new System.EventHandler(this.GlobalTimer_Tick);
            // 
            // LocalTimer
            // 
            this.LocalTimer.Tick += new System.EventHandler(this.LocalTimer_Tick);
            // 
            // _btnClose
            // 
            this._btnClose.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnClose.Location = new System.Drawing.Point(96, 18);
            this._btnClose.Name = "_btnClose";
            this._btnClose.Size = new System.Drawing.Size(97, 68);
            this._btnClose.TabIndex = 2;
            this._btnClose.Text = "KAPAT";
            this._btnClose.UseVisualStyleBackColor = true;
            this._btnClose.Click += new System.EventHandler(this._btnClose_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gösterToolStripMenuItem,
            this.gizleToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(90, 45);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::VISsessionControl.Properties.Resources.remote_control;
            this.pictureBox1.Location = new System.Drawing.Point(12, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(69, 68);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // gösterToolStripMenuItem
            // 
            this.gösterToolStripMenuItem.Image = global::VISsessionControl.Properties.Resources.ico_show_32;
            this.gösterToolStripMenuItem.Name = "gösterToolStripMenuItem";
            this.gösterToolStripMenuItem.Size = new System.Drawing.Size(112, 26);
            this.gösterToolStripMenuItem.Text = "Göster";
            this.gösterToolStripMenuItem.Click += new System.EventHandler(this.gösterToolStripMenuItem_Click);
            // 
            // gizleToolStripMenuItem
            // 
            this.gizleToolStripMenuItem.Image = global::VISsessionControl.Properties.Resources.hide;
            this.gizleToolStripMenuItem.Name = "gizleToolStripMenuItem";
            this.gizleToolStripMenuItem.Size = new System.Drawing.Size(112, 26);
            this.gizleToolStripMenuItem.Text = "Gizle";
            this.gizleToolStripMenuItem.Click += new System.EventHandler(this.gizleToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(211, 98);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this._btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bez Bakım Qeye Session Control";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer GlobalTimer;
        private System.Windows.Forms.Timer LocalTimer;
        private System.Windows.Forms.Button _btnClose;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gösterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gizleToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

