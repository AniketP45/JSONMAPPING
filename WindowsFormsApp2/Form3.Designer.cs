namespace WindowsFormsApp2
{
    partial class Form3
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
            this.AutoMap = new System.Windows.Forms.Button();
            this.btnUndo = new System.Windows.Forms.Button();
            this.btnSaveMappedTitles = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnOpenFile1 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnOpenFile2 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44F));
            this.tableLayoutPanel1.Controls.Add(this.txtJsonData1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtJsonData2, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // txtJsonData1
            // 
            this.txtJsonData1.AllowDrop = true;
            this.txtJsonData1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtJsonData1.Location = new System.Drawing.Point(3, 48);
            this.txtJsonData1.Name = "txtJsonData1";
            this.txtJsonData1.Size = new System.Drawing.Size(346, 399);
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
            this.txtJsonData2.Location = new System.Drawing.Point(451, 48);
            this.txtJsonData2.Name = "txtJsonData2";
            this.txtJsonData2.Size = new System.Drawing.Size(346, 399);
            this.txtJsonData2.TabIndex = 1;
            this.txtJsonData2.AfterExpand += new System.Windows.Forms.TreeViewEventHandler(this.treeView2_AfterExpand);
            this.txtJsonData2.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.treeView2_ItemDrag);
            this.txtJsonData2.DragDrop += new System.Windows.Forms.DragEventHandler(this.treeView2_DragDrop);
            this.txtJsonData2.DragEnter += new System.Windows.Forms.DragEventHandler(this.treeView2_DragEnter);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.AutoMap);
            this.panel1.Controls.Add(this.btnUndo);
            this.panel1.Controls.Add(this.btnSaveMappedTitles);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(355, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(90, 399);
            this.panel1.TabIndex = 7;
            // 
            // AutoMap
            // 
            this.AutoMap.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.AutoMap.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.AutoMap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AutoMap.Location = new System.Drawing.Point(0, 60);
            this.AutoMap.Name = "AutoMap";
            this.AutoMap.Size = new System.Drawing.Size(68, 32);
            this.AutoMap.TabIndex = 7;
            this.AutoMap.Text = "AutoMap";
            this.AutoMap.UseVisualStyleBackColor = false;
            this.AutoMap.Click += new System.EventHandler(this.AutoMap_Click);
            // 
            // btnUndo
            // 
            this.btnUndo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnUndo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnUndo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUndo.Location = new System.Drawing.Point(0, 115);
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Size = new System.Drawing.Size(65, 34);
            this.btnUndo.TabIndex = 5;
            this.btnUndo.Text = "Undo";
            this.btnUndo.UseVisualStyleBackColor = false;
            this.btnUndo.Click += new System.EventHandler(this.btnUndo_Click);
            // 
            // btnSaveMappedTitles
            // 
            this.btnSaveMappedTitles.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnSaveMappedTitles.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSaveMappedTitles.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveMappedTitles.Location = new System.Drawing.Point(0, 183);
            this.btnSaveMappedTitles.Name = "btnSaveMappedTitles";
            this.btnSaveMappedTitles.Size = new System.Drawing.Size(68, 28);
            this.btnSaveMappedTitles.TabIndex = 6;
            this.btnSaveMappedTitles.Text = "Map";
            this.btnSaveMappedTitles.UseVisualStyleBackColor = false;
            this.btnSaveMappedTitles.Click += new System.EventHandler(this.btnSaveMappedTitles_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnOpenFile1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(346, 39);
            this.panel2.TabIndex = 8;
            // 
            // btnOpenFile1
            // 
            this.btnOpenFile1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpenFile1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnOpenFile1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenFile1.Location = new System.Drawing.Point(259, 0);
            this.btnOpenFile1.Name = "btnOpenFile1";
            this.btnOpenFile1.Size = new System.Drawing.Size(87, 39);
            this.btnOpenFile1.TabIndex = 4;
            this.btnOpenFile1.Text = "Load";
            this.btnOpenFile1.UseVisualStyleBackColor = false;
            this.btnOpenFile1.Click += new System.EventHandler(this.btnOpenFile1_Click_1);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnOpenFile2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(451, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(346, 39);
            this.panel3.TabIndex = 9;
            // 
            // btnOpenFile2
            // 
            this.btnOpenFile2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpenFile2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnOpenFile2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenFile2.Location = new System.Drawing.Point(259, 0);
            this.btnOpenFile2.Name = "btnOpenFile2";
            this.btnOpenFile2.Size = new System.Drawing.Size(87, 39);
            this.btnOpenFile2.TabIndex = 4;
            this.btnOpenFile2.Text = "Load";
            this.btnOpenFile2.UseVisualStyleBackColor = false;
            this.btnOpenFile2.Click += new System.EventHandler(this.btnOpenFile2_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TreeView txtJsonData1;
        private System.Windows.Forms.TreeView txtJsonData2;
        private System.Windows.Forms.Button btnUndo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSaveMappedTitles;
        private System.Windows.Forms.Button btnOpenFile1;
        private System.Windows.Forms.Button btnOpenFile2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button AutoMap;
    }
}