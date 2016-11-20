namespace PilotEdgeToolbox
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
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
      this.richTextBoxInfo = new System.Windows.Forms.RichTextBox();
      this.dataGridViewATC = new System.Windows.Forms.DataGridView();
      this.tabControl1 = new System.Windows.Forms.TabControl();
      this.tabPage1 = new System.Windows.Forms.TabPage();
      this.tabPage2 = new System.Windows.Forms.TabPage();
      this.dataGridViewPilots = new System.Windows.Forms.DataGridView();
      this.tabPage3 = new System.Windows.Forms.TabPage();
      this.gMapControl1 = new GMap.NET.WindowsForms.GMapControl();
      this.pictureBox1 = new System.Windows.Forms.PictureBox();
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridViewATC)).BeginInit();
      this.tabControl1.SuspendLayout();
      this.tabPage1.SuspendLayout();
      this.tabPage2.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPilots)).BeginInit();
      this.tabPage3.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
      this.menuStrip1.SuspendLayout();
      this.SuspendLayout();
      // 
      // richTextBoxInfo
      // 
      this.richTextBoxInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.richTextBoxInfo.Location = new System.Drawing.Point(12, 396);
      this.richTextBoxInfo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.richTextBoxInfo.Name = "richTextBoxInfo";
      this.richTextBoxInfo.ReadOnly = true;
      this.richTextBoxInfo.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
      this.richTextBoxInfo.Size = new System.Drawing.Size(482, 97);
      this.richTextBoxInfo.TabIndex = 0;
      this.richTextBoxInfo.Text = "";
      this.richTextBoxInfo.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
      // 
      // dataGridViewATC
      // 
      this.dataGridViewATC.AllowUserToAddRows = false;
      this.dataGridViewATC.AllowUserToDeleteRows = false;
      this.dataGridViewATC.AllowUserToOrderColumns = true;
      this.dataGridViewATC.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.dataGridViewATC.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
      this.dataGridViewATC.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
      this.dataGridViewATC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridViewATC.Location = new System.Drawing.Point(5, 5);
      this.dataGridViewATC.Margin = new System.Windows.Forms.Padding(2);
      this.dataGridViewATC.Name = "dataGridViewATC";
      this.dataGridViewATC.ReadOnly = true;
      this.dataGridViewATC.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
      this.dataGridViewATC.Size = new System.Drawing.Size(714, 347);
      this.dataGridViewATC.TabIndex = 1;
      // 
      // tabControl1
      // 
      this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.tabControl1.Controls.Add(this.tabPage1);
      this.tabControl1.Controls.Add(this.tabPage2);
      this.tabControl1.Controls.Add(this.tabPage3);
      this.tabControl1.Location = new System.Drawing.Point(12, 4);
      this.tabControl1.Name = "tabControl1";
      this.tabControl1.SelectedIndex = 0;
      this.tabControl1.Size = new System.Drawing.Size(732, 390);
      this.tabControl1.TabIndex = 2;
      // 
      // tabPage1
      // 
      this.tabPage1.BackColor = System.Drawing.Color.Transparent;
      this.tabPage1.Controls.Add(this.dataGridViewATC);
      this.tabPage1.Location = new System.Drawing.Point(4, 29);
      this.tabPage1.Name = "tabPage1";
      this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
      this.tabPage1.Size = new System.Drawing.Size(724, 357);
      this.tabPage1.TabIndex = 0;
      this.tabPage1.Text = "Controllers";
      // 
      // tabPage2
      // 
      this.tabPage2.Controls.Add(this.dataGridViewPilots);
      this.tabPage2.Location = new System.Drawing.Point(4, 29);
      this.tabPage2.Name = "tabPage2";
      this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
      this.tabPage2.Size = new System.Drawing.Size(724, 357);
      this.tabPage2.TabIndex = 1;
      this.tabPage2.Text = "Pilots";
      this.tabPage2.UseVisualStyleBackColor = true;
      // 
      // dataGridViewPilots
      // 
      this.dataGridViewPilots.AllowUserToAddRows = false;
      this.dataGridViewPilots.AllowUserToDeleteRows = false;
      dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
      this.dataGridViewPilots.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
      this.dataGridViewPilots.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.dataGridViewPilots.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
      this.dataGridViewPilots.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
      this.dataGridViewPilots.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridViewPilots.Location = new System.Drawing.Point(6, 6);
      this.dataGridViewPilots.Name = "dataGridViewPilots";
      this.dataGridViewPilots.ReadOnly = true;
      this.dataGridViewPilots.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.dataGridViewPilots.Size = new System.Drawing.Size(712, 345);
      this.dataGridViewPilots.TabIndex = 0;
      // 
      // tabPage3
      // 
      this.tabPage3.Controls.Add(this.gMapControl1);
      this.tabPage3.Location = new System.Drawing.Point(4, 29);
      this.tabPage3.Name = "tabPage3";
      this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
      this.tabPage3.Size = new System.Drawing.Size(724, 357);
      this.tabPage3.TabIndex = 2;
      this.tabPage3.Text = "Map";
      this.tabPage3.UseVisualStyleBackColor = true;
      // 
      // gMapControl1
      // 
      this.gMapControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.gMapControl1.Bearing = 0F;
      this.gMapControl1.CanDragMap = true;
      this.gMapControl1.EmptyTileColor = System.Drawing.Color.Navy;
      this.gMapControl1.GrayScaleMode = false;
      this.gMapControl1.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
      this.gMapControl1.LevelsKeepInMemmory = 5;
      this.gMapControl1.Location = new System.Drawing.Point(6, 6);
      this.gMapControl1.MarkersEnabled = true;
      this.gMapControl1.MaxZoom = 18;
      this.gMapControl1.MinZoom = 2;
      this.gMapControl1.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
      this.gMapControl1.Name = "gMapControl1";
      this.gMapControl1.NegativeMode = false;
      this.gMapControl1.PolygonsEnabled = true;
      this.gMapControl1.RetryLoadTile = 0;
      this.gMapControl1.RoutesEnabled = true;
      this.gMapControl1.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
      this.gMapControl1.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
      this.gMapControl1.ShowTileGridLines = false;
      this.gMapControl1.Size = new System.Drawing.Size(712, 345);
      this.gMapControl1.TabIndex = 0;
      this.gMapControl1.Zoom = 6D;
      this.gMapControl1.Load += new System.EventHandler(this.gMapControl1_Load);
      // 
      // pictureBox1
      // 
      this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
      this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
      this.pictureBox1.InitialImage = null;
      this.pictureBox1.Location = new System.Drawing.Point(501, 396);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new System.Drawing.Size(239, 97);
      this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
      this.pictureBox1.TabIndex = 3;
      this.pictureBox1.TabStop = false;
      // 
      // menuStrip1
      // 
      this.menuStrip1.BackColor = System.Drawing.SystemColors.ButtonFace;
      this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
      this.menuStrip1.Location = new System.Drawing.Point(685, 4);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new System.Drawing.Size(60, 24);
      this.menuStrip1.TabIndex = 2;
      this.menuStrip1.Text = "menuStrip1";
      // 
      // toolStripMenuItem1
      // 
      this.toolStripMenuItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
      this.toolStripMenuItem1.Name = "toolStripMenuItem1";
      this.toolStripMenuItem1.Size = new System.Drawing.Size(52, 20);
      this.toolStripMenuItem1.Text = "About";
      this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.SystemColors.Control;
      this.ClientSize = new System.Drawing.Size(756, 498);
      this.Controls.Add(this.menuStrip1);
      this.Controls.Add(this.pictureBox1);
      this.Controls.Add(this.richTextBoxInfo);
      this.Controls.Add(this.tabControl1);
      this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.MainMenuStrip = this.menuStrip1;
      this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.Name = "Form1";
      this.Text = "Pilotedge Who\'s Online";
      ((System.ComponentModel.ISupportInitialize)(this.dataGridViewATC)).EndInit();
      this.tabControl1.ResumeLayout(false);
      this.tabPage1.ResumeLayout(false);
      this.tabPage2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPilots)).EndInit();
      this.tabPage3.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBoxInfo;
        private System.Windows.Forms.DataGridView dataGridViewATC;
    private System.Windows.Forms.TabControl tabControl1;
    private System.Windows.Forms.TabPage tabPage1;
    private System.Windows.Forms.TabPage tabPage2;
    private System.Windows.Forms.DataGridView dataGridViewPilots;
    private System.Windows.Forms.PictureBox pictureBox1;
    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
    private System.Windows.Forms.TabPage tabPage3;
    private GMap.NET.WindowsForms.GMapControl gMapControl1;
  }
}

