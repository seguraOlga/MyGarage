namespace Clients.View
{
    partial class clientsUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialTextBox1 = new MaterialSkin.Controls.MaterialTextBox();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialComboBox1 = new MaterialSkin.Controls.MaterialComboBox();
            this.materialComboBox2 = new MaterialSkin.Controls.MaterialComboBox();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialListView1 = new MaterialSkin.Controls.MaterialListView();
            this.dni = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cognoms = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.email = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.telefon = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.data_naixement = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonAfegir = new MaterialSkin.Controls.MaterialButton();
            this.buttonEliminar = new MaterialSkin.Controls.MaterialButton();
            this.buttonModificar = new MaterialSkin.Controls.MaterialButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.materialLabel4);
            this.panel1.Controls.Add(this.materialComboBox2);
            this.panel1.Controls.Add(this.materialComboBox1);
            this.panel1.Controls.Add(this.materialLabel3);
            this.panel1.Controls.Add(this.materialLabel2);
            this.panel1.Controls.Add(this.materialButton1);
            this.panel1.Controls.Add(this.materialTextBox1);
            this.panel1.Controls.Add(this.materialLabel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1064, 100);
            this.panel1.TabIndex = 0;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel1.Location = new System.Drawing.Point(30, 15);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(114, 24);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Cercar client";
            // 
            // materialTextBox1
            // 
            this.materialTextBox1.AnimateReadOnly = false;
            this.materialTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBox1.Depth = 0;
            this.materialTextBox1.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBox1.LeadingIcon = null;
            this.materialTextBox1.Location = new System.Drawing.Point(17, 39);
            this.materialTextBox1.MaxLength = 50;
            this.materialTextBox1.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox1.Multiline = false;
            this.materialTextBox1.Name = "materialTextBox1";
            this.materialTextBox1.Size = new System.Drawing.Size(250, 50);
            this.materialTextBox1.TabIndex = 1;
            this.materialTextBox1.Text = "";
            this.materialTextBox1.TrailingIcon = null;
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1.Depth = 0;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(274, 45);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton1.Size = new System.Drawing.Size(77, 36);
            this.materialButton1.TabIndex = 2;
            this.materialButton1.Text = "Cercar";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel2.Location = new System.Drawing.Point(451, 15);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(88, 24);
            this.materialLabel2.TabIndex = 3;
            this.materialLabel2.Text = "Filtrar per";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.materialLabel3.Location = new System.Drawing.Point(450, 48);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(53, 29);
            this.materialLabel3.TabIndex = 4;
            this.materialLabel3.Text = "Nom";
            // 
            // materialComboBox1
            // 
            this.materialComboBox1.AutoResize = false;
            this.materialComboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialComboBox1.Depth = 0;
            this.materialComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.materialComboBox1.DropDownHeight = 174;
            this.materialComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.materialComboBox1.DropDownWidth = 121;
            this.materialComboBox1.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialComboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialComboBox1.FormattingEnabled = true;
            this.materialComboBox1.IntegralHeight = false;
            this.materialComboBox1.ItemHeight = 43;
            this.materialComboBox1.Location = new System.Drawing.Point(509, 40);
            this.materialComboBox1.MaxDropDownItems = 4;
            this.materialComboBox1.MouseState = MaterialSkin.MouseState.OUT;
            this.materialComboBox1.Name = "materialComboBox1";
            this.materialComboBox1.Size = new System.Drawing.Size(161, 49);
            this.materialComboBox1.StartIndex = 0;
            this.materialComboBox1.TabIndex = 5;
            // 
            // materialComboBox2
            // 
            this.materialComboBox2.AutoResize = false;
            this.materialComboBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialComboBox2.Depth = 0;
            this.materialComboBox2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.materialComboBox2.DropDownHeight = 174;
            this.materialComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.materialComboBox2.DropDownWidth = 121;
            this.materialComboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialComboBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialComboBox2.FormattingEnabled = true;
            this.materialComboBox2.IntegralHeight = false;
            this.materialComboBox2.ItemHeight = 43;
            this.materialComboBox2.Location = new System.Drawing.Point(802, 40);
            this.materialComboBox2.MaxDropDownItems = 4;
            this.materialComboBox2.MouseState = MaterialSkin.MouseState.OUT;
            this.materialComboBox2.Name = "materialComboBox2";
            this.materialComboBox2.Size = new System.Drawing.Size(161, 49);
            this.materialComboBox2.StartIndex = 0;
            this.materialComboBox2.TabIndex = 6;
            this.materialComboBox2.SelectedIndexChanged += new System.EventHandler(this.materialComboBox2_SelectedIndexChanged);
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.materialLabel4.Location = new System.Drawing.Point(716, 48);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(80, 29);
            this.materialLabel4.TabIndex = 7;
            this.materialLabel4.Text = "Vehicle";
            // 
            // materialListView1
            // 
            this.materialListView1.AutoSizeTable = false;
            this.materialListView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialListView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.dni,
            this.nom,
            this.cognoms,
            this.email,
            this.telefon,
            this.data_naixement});
            this.materialListView1.Depth = 0;
            this.materialListView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialListView1.FullRowSelect = true;
            this.materialListView1.HideSelection = false;
            this.materialListView1.Location = new System.Drawing.Point(0, 100);
            this.materialListView1.MinimumSize = new System.Drawing.Size(200, 100);
            this.materialListView1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialListView1.MouseState = MaterialSkin.MouseState.OUT;
            this.materialListView1.Name = "materialListView1";
            this.materialListView1.OwnerDraw = true;
            this.materialListView1.Size = new System.Drawing.Size(1064, 557);
            this.materialListView1.TabIndex = 1;
            this.materialListView1.UseCompatibleStateImageBehavior = false;
            this.materialListView1.View = System.Windows.Forms.View.Details;
            // 
            // dni
            // 
            this.dni.Text = "DNI";
            // 
            // nom
            // 
            this.nom.Text = "Nom";
            this.nom.Width = 89;
            // 
            // cognoms
            // 
            this.cognoms.Text = "Cognoms";
            this.cognoms.Width = 163;
            // 
            // email
            // 
            this.email.Text = "Email";
            this.email.Width = 214;
            // 
            // telefon
            // 
            this.telefon.Text = "Telefon";
            this.telefon.Width = 104;
            // 
            // data_naixement
            // 
            this.data_naixement.Text = "Data naixement";
            this.data_naixement.Width = 148;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel2.Controls.Add(this.buttonModificar);
            this.panel2.Controls.Add(this.buttonEliminar);
            this.panel2.Controls.Add(this.buttonAfegir);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 557);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1064, 100);
            this.panel2.TabIndex = 2;
            // 
            // buttonAfegir
            // 
            this.buttonAfegir.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonAfegir.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.buttonAfegir.Depth = 0;
            this.buttonAfegir.HighEmphasis = true;
            this.buttonAfegir.Icon = null;
            this.buttonAfegir.Location = new System.Drawing.Point(72, 33);
            this.buttonAfegir.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonAfegir.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonAfegir.Name = "buttonAfegir";
            this.buttonAfegir.NoAccentTextColor = System.Drawing.Color.Empty;
            this.buttonAfegir.Size = new System.Drawing.Size(159, 36);
            this.buttonAfegir.TabIndex = 0;
            this.buttonAfegir.Text = "Afegir nou client";
            this.buttonAfegir.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.buttonAfegir.UseAccentColor = false;
            this.buttonAfegir.UseVisualStyleBackColor = true;
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonEliminar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.buttonEliminar.Depth = 0;
            this.buttonEliminar.HighEmphasis = true;
            this.buttonEliminar.Icon = null;
            this.buttonEliminar.Location = new System.Drawing.Point(419, 33);
            this.buttonEliminar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonEliminar.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.buttonEliminar.Size = new System.Drawing.Size(142, 36);
            this.buttonEliminar.TabIndex = 1;
            this.buttonEliminar.Text = "Eliminar client";
            this.buttonEliminar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.buttonEliminar.UseAccentColor = false;
            this.buttonEliminar.UseVisualStyleBackColor = true;
            // 
            // buttonModificar
            // 
            this.buttonModificar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonModificar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.buttonModificar.Depth = 0;
            this.buttonModificar.HighEmphasis = true;
            this.buttonModificar.Icon = null;
            this.buttonModificar.Location = new System.Drawing.Point(759, 33);
            this.buttonModificar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonModificar.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonModificar.Name = "buttonModificar";
            this.buttonModificar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.buttonModificar.Size = new System.Drawing.Size(153, 36);
            this.buttonModificar.TabIndex = 3;
            this.buttonModificar.Text = "Modificar client";
            this.buttonModificar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.buttonModificar.UseAccentColor = false;
            this.buttonModificar.UseVisualStyleBackColor = true;
            // 
            // clientsUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.materialListView1);
            this.Controls.Add(this.panel1);
            this.Name = "clientsUserControl";
            this.Size = new System.Drawing.Size(1064, 657);
            this.Load += new System.EventHandler(this.clientsUserControl_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox1;
        public MaterialSkin.Controls.MaterialButton materialButton1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        public MaterialSkin.Controls.MaterialComboBox materialComboBox1;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        public MaterialSkin.Controls.MaterialComboBox materialComboBox2;
        public System.Windows.Forms.ColumnHeader dni;
        public System.Windows.Forms.ColumnHeader nom;
        public System.Windows.Forms.ColumnHeader cognoms;
        public System.Windows.Forms.ColumnHeader email;
        public System.Windows.Forms.ColumnHeader telefon;
        public System.Windows.Forms.ColumnHeader data_naixement;
        private System.Windows.Forms.Panel panel2;
        public MaterialSkin.Controls.MaterialButton buttonModificar;
        public MaterialSkin.Controls.MaterialButton buttonEliminar;
        public MaterialSkin.Controls.MaterialButton buttonAfegir;
        public MaterialSkin.Controls.MaterialListView materialListView1;
        public System.Windows.Forms.Panel panel1;
    }
}
