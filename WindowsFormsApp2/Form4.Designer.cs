namespace WindowsFormsApp2
{
    partial class Form4
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtJsonData1 = new System.Windows.Forms.TreeView();
            this.txtJsonData2 = new System.Windows.Forms.TreeView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnOpenFile1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnOpenFile2 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnSaveMappedTitles = new System.Windows.Forms.Button();
            this.btnUndo = new System.Windows.Forms.Button();
            this.AutoMap = new System.Windows.Forms.Button();
            this.listBoxMappedRecords = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.txtJsonData1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtJsonData2, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.listBoxMappedRecords, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 3, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.88889F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 89.11111F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // txtJsonData1
            // 
            this.txtJsonData1.AllowDrop = true;
            this.txtJsonData1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtJsonData1.Location = new System.Drawing.Point(10, 59);
            this.txtJsonData1.Margin = new System.Windows.Forms.Padding(10);
            this.txtJsonData1.Name = "txtJsonData1";
            this.txtJsonData1.Size = new System.Drawing.Size(260, 381);
            this.txtJsonData1.TabIndex = 0;
            this.txtJsonData1.AfterExpand += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterExpand);
            this.txtJsonData1.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.treeView1_ItemDrag);
            this.txtJsonData1.DragDrop += new System.Windows.Forms.DragEventHandler(this.treeView1_DragDrop);
            this.txtJsonData1.DragEnter += new System.Windows.Forms.DragEventHandler(this.treeView1_DragEnter);
            // 
            // txtJsonData2
            // 
            this.txtJsonData2.AllowDrop = true;
            this.txtJsonData2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtJsonData2.Location = new System.Drawing.Point(370, 59);
            this.txtJsonData2.Margin = new System.Windows.Forms.Padding(10);
            this.txtJsonData2.Name = "txtJsonData2";
            this.txtJsonData2.Size = new System.Drawing.Size(260, 381);
            this.txtJsonData2.TabIndex = 1;
            this.txtJsonData2.AfterExpand += new System.Windows.Forms.TreeViewEventHandler(this.treeView2_AfterExpand);
            this.txtJsonData2.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.treeView2_ItemDrag);
            this.txtJsonData2.DragDrop += new System.Windows.Forms.DragEventHandler(this.treeView2_DragDrop);
            this.txtJsonData2.DragEnter += new System.Windows.Forms.DragEventHandler(this.treeView2_DragEnter);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnOpenFile1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(274, 43);
            this.panel1.TabIndex = 3;
            // 
            // btnOpenFile1
            // 
            this.btnOpenFile1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpenFile1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnOpenFile1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenFile1.Location = new System.Drawing.Point(187, 3);
            this.btnOpenFile1.Name = "btnOpenFile1";
            this.btnOpenFile1.Size = new System.Drawing.Size(87, 39);
            this.btnOpenFile1.TabIndex = 5;
            this.btnOpenFile1.Text = "Load";
            this.btnOpenFile1.UseVisualStyleBackColor = false;
            this.btnOpenFile1.Click += new System.EventHandler(this.btnOpenFile1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnOpenFile2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(363, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(274, 43);
            this.panel2.TabIndex = 4;
            // 
            // btnOpenFile2
            // 
            this.btnOpenFile2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpenFile2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnOpenFile2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenFile2.Location = new System.Drawing.Point(184, 3);
            this.btnOpenFile2.Name = "btnOpenFile2";
            this.btnOpenFile2.Size = new System.Drawing.Size(87, 39);
            this.btnOpenFile2.TabIndex = 5;
            this.btnOpenFile2.Text = "Load";
            this.btnOpenFile2.UseVisualStyleBackColor = false;
            this.btnOpenFile2.Click += new System.EventHandler(this.btnOpenFile2_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnSaveMappedTitles);
            this.panel3.Controls.Add(this.btnUndo);
            this.panel3.Controls.Add(this.AutoMap);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(283, 52);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(74, 395);
            this.panel3.TabIndex = 5;
            // 
            // btnSaveMappedTitles
            // 
            this.btnSaveMappedTitles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveMappedTitles.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSaveMappedTitles.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveMappedTitles.Location = new System.Drawing.Point(0, 179);
            this.btnSaveMappedTitles.Name = "btnSaveMappedTitles";
            this.btnSaveMappedTitles.Size = new System.Drawing.Size(74, 31);
            this.btnSaveMappedTitles.TabIndex = 10;
            this.btnSaveMappedTitles.Text = "Map";
            this.btnSaveMappedTitles.UseVisualStyleBackColor = false;
            this.btnSaveMappedTitles.Click += new System.EventHandler(this.btnSaveMappedTitles_Click);
            // 
            // btnUndo
            // 
            this.btnUndo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUndo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnUndo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUndo.Location = new System.Drawing.Point(0, 139);
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Size = new System.Drawing.Size(74, 34);
            this.btnUndo.TabIndex = 9;
            this.btnUndo.Text = "Undo";
            this.btnUndo.UseVisualStyleBackColor = false;
            this.btnUndo.Click += new System.EventHandler(this.btnUndo_Click);
            // 
            // AutoMap
            // 
            this.AutoMap.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.AutoMap.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.AutoMap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AutoMap.Location = new System.Drawing.Point(0, 102);
            this.AutoMap.Name = "AutoMap";
            this.AutoMap.Size = new System.Drawing.Size(74, 31);
            this.AutoMap.TabIndex = 8;
            this.AutoMap.Text = "AutoMap";
            this.AutoMap.UseVisualStyleBackColor = false;
            this.AutoMap.Click += new System.EventHandler(this.AutoMap_Click);
            // 
            // listBoxMappedRecords
            // 
            this.listBoxMappedRecords.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxMappedRecords.FormattingEnabled = true;
            this.listBoxMappedRecords.Location = new System.Drawing.Point(650, 59);
            this.listBoxMappedRecords.Margin = new System.Windows.Forms.Padding(10);
            this.listBoxMappedRecords.Name = "listBoxMappedRecords";
            this.listBoxMappedRecords.Size = new System.Drawing.Size(140, 381);
            this.listBoxMappedRecords.TabIndex = 6;
            this.listBoxMappedRecords.SelectedIndexChanged += new System.EventHandler(this.listBoxMappedRecords_SelectedIndexChanged);
            this.listBoxMappedRecords.DoubleClick += new System.EventHandler(this.ListBoxMappedRecords_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(643, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Mapped Records";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnOpenFile1;
        private System.Windows.Forms.Button btnOpenFile2;
        private System.Windows.Forms.Button AutoMap;
        private System.Windows.Forms.Button btnUndo;
        private System.Windows.Forms.Button btnSaveMappedTitles;
        private System.Windows.Forms.TreeView txtJsonData1;
        private System.Windows.Forms.TreeView txtJsonData2;
        private System.Windows.Forms.ListBox listBoxMappedRecords;
        private System.Windows.Forms.Label label1;
    }
}