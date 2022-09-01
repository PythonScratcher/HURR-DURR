namespace HURRDURR
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.hURRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dURRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hURRToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.dURRToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.hURRToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.hURRToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.webBrowser2 = new System.Windows.Forms.WebBrowser();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hURRToolStripMenuItem,
            this.hURRToolStripMenuItem1,
            this.hURRToolStripMenuItem2});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(106, 70);
            // 
            // hURRToolStripMenuItem
            // 
            this.hURRToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dURRToolStripMenuItem});
            this.hURRToolStripMenuItem.Name = "hURRToolStripMenuItem";
            this.hURRToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.hURRToolStripMenuItem.Text = "HURR";
            // 
            // dURRToolStripMenuItem
            // 
            this.dURRToolStripMenuItem.Name = "dURRToolStripMenuItem";
            this.dURRToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.dURRToolStripMenuItem.Text = "DURR";
            // 
            // hURRToolStripMenuItem1
            // 
            this.hURRToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dURRToolStripMenuItem1});
            this.hURRToolStripMenuItem1.Name = "hURRToolStripMenuItem1";
            this.hURRToolStripMenuItem1.Size = new System.Drawing.Size(105, 22);
            this.hURRToolStripMenuItem1.Text = "HURR";
            // 
            // dURRToolStripMenuItem1
            // 
            this.dURRToolStripMenuItem1.Name = "dURRToolStripMenuItem1";
            this.dURRToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.dURRToolStripMenuItem1.Text = "DURR";
            // 
            // hURRToolStripMenuItem2
            // 
            this.hURRToolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hURRToolStripMenuItem3});
            this.hURRToolStripMenuItem2.Name = "hURRToolStripMenuItem2";
            this.hURRToolStripMenuItem2.Size = new System.Drawing.Size(105, 22);
            this.hURRToolStripMenuItem2.Text = "HURR";
            // 
            // hURRToolStripMenuItem3
            // 
            this.hURRToolStripMenuItem3.Name = "hURRToolStripMenuItem3";
            this.hURRToolStripMenuItem3.Size = new System.Drawing.Size(180, 22);
            this.hURRToolStripMenuItem3.Text = "HURR";
            // 
            // webBrowser2
            // 
            this.webBrowser2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser2.Location = new System.Drawing.Point(0, 0);
            this.webBrowser2.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser2.Name = "webBrowser2";
            this.webBrowser2.Size = new System.Drawing.Size(800, 450);
            this.webBrowser2.TabIndex = 2;
            this.webBrowser2.Url = new System.Uri("http://fl.hurr-durr.cc", System.UriKind.Absolute);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.webBrowser2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "HURR DURR";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hURRToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dURRToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hURRToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem dURRToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem hURRToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem hURRToolStripMenuItem3;
        private System.Windows.Forms.WebBrowser webBrowser2;
    }
}

