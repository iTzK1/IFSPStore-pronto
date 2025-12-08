namespace IFSPStore.App
{
    partial class MainForm
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
            ReaLTaiizor.ControlRenderer controlRenderer1 = new ReaLTaiizor.ControlRenderer();
            ReaLTaiizor.MSColorTable msColorTable1 = new ReaLTaiizor.MSColorTable();
            formMenuStrip = new ReaLTaiizor.Controls.FormMenuStrip();
            registerToolStripMenuItem = new ToolStripMenuItem();
            userToolStripMenuItem = new ToolStripMenuItem();
            categoryToolStripMenuItem = new ToolStripMenuItem();
            productToolStripMenuItem = new ToolStripMenuItem();
            cityToolStripMenuItem = new ToolStripMenuItem();
            customerToolStripMenuItem = new ToolStripMenuItem();
            saleToolStripMenuItem = new ToolStripMenuItem();
            reportToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            closeToolStripMenuItem = new ToolStripMenuItem();
            lblUser = new Label();
            formMenuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // formMenuStrip
            // 
            formMenuStrip.ImageScalingSize = new Size(20, 20);
            formMenuStrip.Items.AddRange(new ToolStripItem[] { registerToolStripMenuItem, reportToolStripMenuItem, helpToolStripMenuItem, closeToolStripMenuItem });
            formMenuStrip.Location = new Point(3, 48);
            formMenuStrip.Name = "formMenuStrip";
            formMenuStrip.Padding = new Padding(5, 2, 0, 2);
            controlRenderer1.ColorTable = msColorTable1;
            controlRenderer1.RoundedEdges = true;
            formMenuStrip.Renderer = controlRenderer1;
            formMenuStrip.Size = new Size(736, 24);
            formMenuStrip.TabIndex = 1;
            formMenuStrip.Text = "formMenuStrip1";
            // 
            // registerToolStripMenuItem
            // 
            registerToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { userToolStripMenuItem, categoryToolStripMenuItem, productToolStripMenuItem, cityToolStripMenuItem, customerToolStripMenuItem, saleToolStripMenuItem });
            registerToolStripMenuItem.ForeColor = Color.FromArgb(80, 80, 80);
            registerToolStripMenuItem.Name = "registerToolStripMenuItem";
            registerToolStripMenuItem.Size = new Size(61, 20);
            registerToolStripMenuItem.Text = "Register";
            // 
            // userToolStripMenuItem
            // 
            userToolStripMenuItem.ForeColor = Color.FromArgb(80, 80, 80);
            userToolStripMenuItem.Name = "userToolStripMenuItem";
            userToolStripMenuItem.Size = new Size(126, 22);
            userToolStripMenuItem.Text = "User";
            userToolStripMenuItem.Click += userToolStripMenuItem_Click;
            // 
            // categoryToolStripMenuItem
            // 
            categoryToolStripMenuItem.ForeColor = Color.FromArgb(80, 80, 80);
            categoryToolStripMenuItem.Name = "categoryToolStripMenuItem";
            categoryToolStripMenuItem.Size = new Size(126, 22);
            categoryToolStripMenuItem.Text = "Category";
            categoryToolStripMenuItem.Click += categoryToolStripMenuItem_Click;
            // 
            // productToolStripMenuItem
            // 
            productToolStripMenuItem.ForeColor = Color.FromArgb(80, 80, 80);
            productToolStripMenuItem.Name = "productToolStripMenuItem";
            productToolStripMenuItem.Size = new Size(126, 22);
            productToolStripMenuItem.Text = "Product";
            productToolStripMenuItem.Click += productToolStripMenuItem_Click;
            // 
            // cityToolStripMenuItem
            // 
            cityToolStripMenuItem.ForeColor = Color.FromArgb(80, 80, 80);
            cityToolStripMenuItem.Name = "cityToolStripMenuItem";
            cityToolStripMenuItem.Size = new Size(126, 22);
            cityToolStripMenuItem.Text = "City";
            cityToolStripMenuItem.Click += cityToolStripMenuItem_Click;
            // 
            // customerToolStripMenuItem
            // 
            customerToolStripMenuItem.ForeColor = Color.FromArgb(80, 80, 80);
            customerToolStripMenuItem.Name = "customerToolStripMenuItem";
            customerToolStripMenuItem.Size = new Size(126, 22);
            customerToolStripMenuItem.Text = "Customer";
            customerToolStripMenuItem.Click += customerToolStripMenuItem_Click;
            // 
            // saleToolStripMenuItem
            // 
            saleToolStripMenuItem.ForeColor = Color.FromArgb(80, 80, 80);
            saleToolStripMenuItem.Name = "saleToolStripMenuItem";
            saleToolStripMenuItem.Size = new Size(126, 22);
            saleToolStripMenuItem.Text = "Sale";
            saleToolStripMenuItem.Click += saleToolStripMenuItem_Click;
            // 
            // reportToolStripMenuItem
            // 
            reportToolStripMenuItem.ForeColor = Color.FromArgb(80, 80, 80);
            reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            reportToolStripMenuItem.Size = new Size(54, 20);
            reportToolStripMenuItem.Text = "Report";
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.ForeColor = Color.FromArgb(80, 80, 80);
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(44, 20);
            helpToolStripMenuItem.Text = "Help";
            // 
            // closeToolStripMenuItem
            // 
            closeToolStripMenuItem.ForeColor = Color.FromArgb(80, 80, 80);
            closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            closeToolStripMenuItem.Size = new Size(48, 20);
            closeToolStripMenuItem.Text = "Close";
            closeToolStripMenuItem.Click += closeToolStripMenuItem_Click;
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Dock = DockStyle.Bottom;
            lblUser.Location = new Point(3, 394);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(33, 15);
            lblUser.TabIndex = 3;
            lblUser.Text = "User:";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(742, 411);
            Controls.Add(lblUser);
            Controls.Add(formMenuStrip);
            IsMdiContainer = true;
            MainMenuStrip = formMenuStrip;
            Margin = new Padding(3, 2, 3, 2);
            Name = "MainForm";
            Padding = new Padding(3, 48, 3, 2);
            Text = "IFSP Store";
            WindowState = FormWindowState.Maximized;
            formMenuStrip.ResumeLayout(false);
            formMenuStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ReaLTaiizor.Controls.FormMenuStrip formMenuStrip;
        private ToolStripMenuItem registerToolStripMenuItem;
        private ToolStripMenuItem userToolStripMenuItem;
        private ToolStripMenuItem categoryToolStripMenuItem;
        private ToolStripMenuItem productToolStripMenuItem;
        private ToolStripMenuItem cityToolStripMenuItem;
        private ToolStripMenuItem customerToolStripMenuItem;
        private ToolStripMenuItem saleToolStripMenuItem;
        private ToolStripMenuItem reportToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem closeToolStripMenuItem;
        private Label lblUser;
    }
}
