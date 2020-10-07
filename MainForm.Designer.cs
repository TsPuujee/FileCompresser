namespace FileExplorer
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsb_upLevel = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.tsl_path = new System.Windows.Forms.ToolStripLabel();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tv_files = new System.Windows.Forms.TreeView();
            this.il_ForTree = new System.Windows.Forms.ImageList(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.lv_files = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.il_DiscFoldersFilesIcons_Large = new System.Windows.Forms.ImageList(this.components);
            this.il_DiscFoldersFilesIcons_Small = new System.Windows.Forms.ImageList(this.components);
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsb_upLevel,
            this.toolStripLabel1,
            this.tsl_path,
            this.toolStripComboBox1,
            this.toolStripLabel2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(884, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsb_upLevel
            // 
            this.tsb_upLevel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_upLevel.Image = ((System.Drawing.Image)(resources.GetObject("tsb_upLevel.Image")));
            this.tsb_upLevel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_upLevel.Name = "tsb_upLevel";
            this.tsb_upLevel.Size = new System.Drawing.Size(23, 22);
            this.tsb_upLevel.Text = "Буцах";
            this.tsb_upLevel.Click += new System.EventHandler(this.tsb_upLevel_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(35, 22);
            this.toolStripLabel1.Text = "Зам: ";
            // 
            // tsl_path
            // 
            this.tsl_path.BackColor = System.Drawing.SystemColors.Control;
            this.tsl_path.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.tsl_path.Name = "tsl_path";
            this.tsl_path.Size = new System.Drawing.Size(111, 22);
            this.tsl_path.Text = "Зам энд харагдана.";
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(121, 25);
            this.toolStripComboBox1.Click += new System.EventHandler(this.toolStripComboBox1_Click);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(103, 22);
            this.toolStripLabel2.Text = "Харагдах байдал: ";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(12, 28);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.button2);
            this.splitContainer1.Panel1.Controls.Add(this.button1);
            this.splitContainer1.Panel1.Controls.Add(this.tv_files);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.lv_files);
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(860, 452);
            this.splitContainer1.SplitterDistance = 286;
            this.splitContainer1.TabIndex = 1;
            this.splitContainer1.TabStop = false;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(130, 401);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 48);
            this.button2.TabIndex = 1;
            this.button2.Text = "Задлах";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(3, 401);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 48);
            this.button1.TabIndex = 1;
            this.button1.Text = "Шахах";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tv_files
            // 
            this.tv_files.AllowDrop = true;
            this.tv_files.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tv_files.ImageIndex = 0;
            this.tv_files.ImageList = this.il_ForTree;
            this.tv_files.LabelEdit = true;
            this.tv_files.Location = new System.Drawing.Point(3, 3);
            this.tv_files.Name = "tv_files";
            this.tv_files.SelectedImageIndex = 0;
            this.tv_files.Size = new System.Drawing.Size(280, 391);
            this.tv_files.TabIndex = 0;
            this.tv_files.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tv_files_AfterSelect_1);
            // 
            // il_ForTree
            // 
            this.il_ForTree.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("il_ForTree.ImageStream")));
            this.il_ForTree.TransparentColor = System.Drawing.Color.Transparent;
            this.il_ForTree.Images.SetKeyName(0, "folder_tree.ico");
            this.il_ForTree.Images.SetKeyName(1, "folderopen_tree.png");
            this.il_ForTree.Images.SetKeyName(2, "drive.ico");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 418);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Сонгогдсон файл энд харагдана.";
            // 
            // lv_files
            // 
            this.lv_files.AllowDrop = true;
            this.lv_files.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lv_files.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lv_files.LargeImageList = this.il_DiscFoldersFilesIcons_Large;
            this.lv_files.Location = new System.Drawing.Point(3, 3);
            this.lv_files.MultiSelect = false;
            this.lv_files.Name = "lv_files";
            this.lv_files.Size = new System.Drawing.Size(564, 391);
            this.lv_files.SmallImageList = this.il_DiscFoldersFilesIcons_Small;
            this.lv_files.TabIndex = 0;
            this.lv_files.UseCompatibleStateImageBehavior = false;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Нэр";
            this.columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Размер";
            this.columnHeader2.Width = 120;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Дата создания";
            this.columnHeader3.Width = 120;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Дата изменения";
            this.columnHeader4.Width = 120;
            // 
            // il_DiscFoldersFilesIcons_Large
            // 
            this.il_DiscFoldersFilesIcons_Large.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("il_DiscFoldersFilesIcons_Large.ImageStream")));
            this.il_DiscFoldersFilesIcons_Large.TransparentColor = System.Drawing.Color.Transparent;
            this.il_DiscFoldersFilesIcons_Large.Images.SetKeyName(0, "drive.ico");
            this.il_DiscFoldersFilesIcons_Large.Images.SetKeyName(1, "folder.ico");
            this.il_DiscFoldersFilesIcons_Large.Images.SetKeyName(2, "column_down.png");
            this.il_DiscFoldersFilesIcons_Large.Images.SetKeyName(3, "column_up.png");
            // 
            // il_DiscFoldersFilesIcons_Small
            // 
            this.il_DiscFoldersFilesIcons_Small.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("il_DiscFoldersFilesIcons_Small.ImageStream")));
            this.il_DiscFoldersFilesIcons_Small.TransparentColor = System.Drawing.Color.Transparent;
            this.il_DiscFoldersFilesIcons_Small.Images.SetKeyName(0, "drive.ico");
            this.il_DiscFoldersFilesIcons_Small.Images.SetKeyName(1, "folder.ico");
            this.il_DiscFoldersFilesIcons_Small.Images.SetKeyName(2, "column_down.png");
            this.il_DiscFoldersFilesIcons_Small.Images.SetKeyName(3, "column_up.png");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 492);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(400, 300);
            this.Name = "Form1";
            this.Text = "Баримт шахагч";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListView lv_files;
        private System.Windows.Forms.ImageList il_DiscFoldersFilesIcons_Small;
        private System.Windows.Forms.ImageList il_DiscFoldersFilesIcons_Large;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ToolStripButton tsb_upLevel;
        private System.Windows.Forms.ToolStripLabel tsl_path;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.TreeView tv_files;
        private System.Windows.Forms.ImageList il_ForTree;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}

