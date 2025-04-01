namespace MyGarage
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
            this.imagenesDrawerMenu = new System.Windows.Forms.ImageList(this.components);
            this.drawerMenu = new MaterialSkin.Controls.MaterialTabControl();
            this.iniciPage = new System.Windows.Forms.TabPage();
            this.clientsPage = new System.Windows.Forms.TabPage();
            this.drawerMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // imagenesDrawerMenu
            // 
            this.imagenesDrawerMenu.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imagenesDrawerMenu.ImageStream")));
            this.imagenesDrawerMenu.TransparentColor = System.Drawing.Color.Transparent;
            this.imagenesDrawerMenu.Images.SetKeyName(0, "client.png");
            this.imagenesDrawerMenu.Images.SetKeyName(1, "home.jpg");
            // 
            // drawerMenu
            // 
            this.drawerMenu.Controls.Add(this.iniciPage);
            this.drawerMenu.Controls.Add(this.clientsPage);
            this.drawerMenu.Depth = 0;
            this.drawerMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.drawerMenu.ImageList = this.imagenesDrawerMenu;
            this.drawerMenu.Location = new System.Drawing.Point(3, 64);
            this.drawerMenu.Margin = new System.Windows.Forms.Padding(0);
            this.drawerMenu.MouseState = MaterialSkin.MouseState.HOVER;
            this.drawerMenu.Multiline = true;
            this.drawerMenu.Name = "drawerMenu";
            this.drawerMenu.Padding = new System.Drawing.Point(0, 0);
            this.drawerMenu.SelectedIndex = 0;
            this.drawerMenu.Size = new System.Drawing.Size(1072, 683);
            this.drawerMenu.TabIndex = 0;
            // 
            // iniciPage
            // 
            this.iniciPage.BackColor = System.Drawing.Color.DimGray;
            this.iniciPage.ImageKey = "home.jpg";
            this.iniciPage.Location = new System.Drawing.Point(4, 39);
            this.iniciPage.Name = "iniciPage";
            this.iniciPage.Size = new System.Drawing.Size(1064, 640);
            this.iniciPage.TabIndex = 0;
            this.iniciPage.Text = "Inici";
            // 
            // clientsPage
            // 
            this.clientsPage.BackColor = System.Drawing.Color.DimGray;
            this.clientsPage.ImageKey = "client.png";
            this.clientsPage.Location = new System.Drawing.Point(4, 39);
            this.clientsPage.Name = "clientsPage";
            this.clientsPage.Size = new System.Drawing.Size(1064, 640);
            this.clientsPage.TabIndex = 1;
            this.clientsPage.Text = "Clients";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1078, 750);
            this.Controls.Add(this.drawerMenu);
            this.DrawerIsOpen = true;
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.drawerMenu;
            this.Name = "Form1";
            this.Sizable = false;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.drawerMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.TabPage iniciPage;
        public MaterialSkin.Controls.MaterialTabControl drawerMenu;
        public System.Windows.Forms.TabPage clientsPage;
        public System.Windows.Forms.ImageList imagenesDrawerMenu;
    }
}

