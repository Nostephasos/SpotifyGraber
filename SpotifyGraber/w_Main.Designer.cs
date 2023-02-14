namespace SpotifyGraber
{
    partial class w_Main
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(w_Main));
            this.loop = new System.Windows.Forms.Timer(this.components);
            this.notifyIcon_app = new System.Windows.Forms.NotifyIcon(this.components);
            this.menu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.item_Start = new System.Windows.Forms.ToolStripMenuItem();
            this.item_Stop = new System.Windows.Forms.ToolStripMenuItem();
            this.item_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // loop
            // 
            this.loop.Interval = 5000;
            this.loop.Tick += new System.EventHandler(this.loop_Tick);
            // 
            // notifyIcon_app
            // 
            this.notifyIcon_app.ContextMenuStrip = this.menu;
            this.notifyIcon_app.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon_app.Icon")));
            this.notifyIcon_app.Text = "SpotifyGraber";
            this.notifyIcon_app.Visible = true;
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.item_Start,
            this.item_Stop,
            this.item_Exit});
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(181, 92);
            // 
            // item_Start
            // 
            this.item_Start.Name = "item_Start";
            this.item_Start.Size = new System.Drawing.Size(180, 22);
            this.item_Start.Text = "Start";
            this.item_Start.Click += new System.EventHandler(this.item_Start_Click);
            // 
            // item_Stop
            // 
            this.item_Stop.Enabled = false;
            this.item_Stop.Name = "item_Stop";
            this.item_Stop.Size = new System.Drawing.Size(180, 22);
            this.item_Stop.Text = "Stop";
            this.item_Stop.Click += new System.EventHandler(this.item_Stop_Click);
            // 
            // item_Exit
            // 
            this.item_Exit.Name = "item_Exit";
            this.item_Exit.Size = new System.Drawing.Size(180, 22);
            this.item_Exit.Text = "Exit";
            this.item_Exit.Click += new System.EventHandler(this.item_Exit_Click);
            // 
            // w_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 145);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "w_Main";
            this.ShowInTaskbar = false;
            this.Text = "SpotifyGraber";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.menu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer loop;
        private NotifyIcon notifyIcon_app;
        private ContextMenuStrip menu;
        private ToolStripMenuItem item_Start;
        private ToolStripMenuItem item_Stop;
        private ToolStripMenuItem item_Exit;
    }
}