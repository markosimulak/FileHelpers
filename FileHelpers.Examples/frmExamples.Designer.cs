﻿using ExamplesFramework.Properties;
using FileHelpers;
namespace ExamplesFramework
{
    partial class frmExamples
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmExamples));
            Devoo.WinForms.TextShape textShape1 = new Devoo.WinForms.TextShape();
            this.reflectionHeader1 = new Devoo.WinForms.ReflectionHeader();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.extracthtml = new System.Windows.Forms.ToolStripButton();
            this.cmdHistory = new System.Windows.Forms.ToolStripButton();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.imgTreeView = new System.Windows.Forms.ImageList(this.components);
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.InfoSheet = new System.Windows.Forms.WebBrowser();
            this.txtCode = new ICSharpCode.TextEditor.TextEditorControl();
            this.tcCodeFiles = new System.Windows.Forms.TabControl();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.cmdRunDemo = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.lblTestDescription = new System.Windows.Forms.ToolStripLabel();
            this.treeViewDemos1 = new ExamplesFramework.TreeViewExamples();
            this.txtSearch = new System.Windows.Forms.ToolStripTextBox();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // reflectionHeader1
            // 
            this.reflectionHeader1.BandDown.Color.Color1 = System.Drawing.Color.Black;
            this.reflectionHeader1.BandDown.Color.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.reflectionHeader1.BandDown.Color.Direction = Devoo.WinForms.GradientDirection.Horizontal;
            this.reflectionHeader1.BandDown.Height = 18;
            this.reflectionHeader1.BandUp.Color.Color1 = System.Drawing.Color.Black;
            this.reflectionHeader1.BandUp.Color.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.reflectionHeader1.BandUp.Color.Direction = Devoo.WinForms.GradientDirection.Horizontal;
            this.reflectionHeader1.BandUp.Height = 0;
            this.reflectionHeader1.Dock = System.Windows.Forms.DockStyle.Top;
            this.reflectionHeader1.GradientBack.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(1)))), ((int)(((byte)(74)))));
            this.reflectionHeader1.GradientBack.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(0)))), ((int)(((byte)(107)))));
            this.reflectionHeader1.GradientBack.Direction = Devoo.WinForms.GradientDirection.Vertical;
            this.reflectionHeader1.Header.Color.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.reflectionHeader1.Header.Color.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.reflectionHeader1.Header.Color.Direction = Devoo.WinForms.GradientDirection.Vertical;
            this.reflectionHeader1.Header.Font = new System.Drawing.Font("Trebuchet MS", 27.75F, System.Drawing.FontStyle.Bold);
            this.reflectionHeader1.Header.Position = new System.Drawing.Point(80, 17);
            this.reflectionHeader1.Header.ReflectionLevel = ((byte)(100));
            this.reflectionHeader1.Header.ReflectionOpacity = ((byte)(200));
            this.reflectionHeader1.Header.Text = "FileHelpers Examples";
            this.reflectionHeader1.Images.AddRange(new Devoo.WinForms.ImageShape[] {
            new Devoo.WinForms.ImageShape(((System.Drawing.Bitmap)(resources.GetObject("reflectionHeader1.Images"))), true, ((byte)(255)), new System.Drawing.Point(3, 1), ((byte)(0)), 0)});
            this.reflectionHeader1.Location = new System.Drawing.Point(0, 0);
            this.reflectionHeader1.Name = "reflectionHeader1";
            this.reflectionHeader1.Size = new System.Drawing.Size(854, 85);
            this.reflectionHeader1.Text = "FileHelpers Examples";
            textShape1.Color.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            textShape1.Color.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            textShape1.Color.Direction = Devoo.WinForms.GradientDirection.Vertical;
            textShape1.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            textShape1.Position = new System.Drawing.Point(615, 67);
            textShape1.ReflectionLevel = ((byte)(100));
            textShape1.ReflectionOpacity = ((byte)(0));
            textShape1.Text = "All FileHelpers Demos in one place";
            this.reflectionHeader1.Texts.AddRange(new Devoo.WinForms.TextShape[] {
            textShape1});
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.txtSearch,
            this.toolStripSeparator2,
            this.extracthtml,
            this.toolStripSeparator1,
            this.cmdHistory});
            this.toolStrip1.Location = new System.Drawing.Point(0, 85);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(854, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // extracthtml
            // 
            this.extracthtml.Image = global::ExamplesFramework.Properties.Resources.arrow_right;
            this.extracthtml.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.extracthtml.Name = "extracthtml";
            this.extracthtml.Size = new System.Drawing.Size(98, 22);
            this.extracthtml.Text = "Extract HTML";
            this.extracthtml.Click += new System.EventHandler(this.extracthtml_Click);
            // 
            // cmdHistory
            // 
            this.cmdHistory.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdHistory.Name = "cmdHistory";
            this.cmdHistory.Size = new System.Drawing.Size(120, 22);
            this.cmdHistory.Text = "Show Library History";
            this.cmdHistory.Click += new System.EventHandler(this.cmdHistory_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 110);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.treeViewDemos1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(854, 425);
            this.splitContainer1.SplitterDistance = 284;
            this.splitContainer1.TabIndex = 2;
            // 
            // imgTreeView
            // 
            this.imgTreeView.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgTreeView.ImageStream")));
            this.imgTreeView.TransparentColor = System.Drawing.Color.Transparent;
            this.imgTreeView.Images.SetKeyName(0, "application_cascade.png");
            this.imgTreeView.Images.SetKeyName(1, "application_double.png");
            this.imgTreeView.Images.SetKeyName(2, "application_form.png");
            this.imgTreeView.Images.SetKeyName(3, "application_osx_terminal.png");
            this.imgTreeView.Images.SetKeyName(4, "demo");
            this.imgTreeView.Images.SetKeyName(5, "application_view_xp_terminal.png");
            this.imgTreeView.Images.SetKeyName(6, "application2.png");
            this.imgTreeView.Images.SetKeyName(7, "folder.png");
            this.imgTreeView.Images.SetKeyName(8, "folder");
            this.imgTreeView.Images.SetKeyName(9, "note.png");
            this.imgTreeView.Images.SetKeyName(10, "projection_screen.png");
            this.imgTreeView.Images.SetKeyName(11, "projection_screen_present.png");
            this.imgTreeView.Images.SetKeyName(12, "wand.png");
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.txtCode);
            this.splitContainer2.Panel1.Controls.Add(this.tcCodeFiles);
            this.splitContainer2.Panel1.Controls.Add(this.toolStrip2);
            this.splitContainer2.Panel1.Controls.Add(this.InfoSheet);
            this.splitContainer2.Size = new System.Drawing.Size(566, 425);
            this.splitContainer2.SplitterDistance = 358;
            this.splitContainer2.TabIndex = 0;
            // 
            // InfoSheet
            // 
            this.InfoSheet.Location = new System.Drawing.Point(88, 6);
            this.InfoSheet.MinimumSize = new System.Drawing.Size(20, 20);
            this.InfoSheet.Name = "InfoSheet";
            this.InfoSheet.Size = new System.Drawing.Size(572, 367);
            this.InfoSheet.TabIndex = 6;
            // 
            // txtCode
            // 
            this.txtCode.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCode.IndentStyle = ICSharpCode.TextEditor.Document.IndentStyle.None;
            this.txtCode.IsReadOnly = false;
            this.txtCode.Location = new System.Drawing.Point(7, 49);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(552, 302);
            this.txtCode.TabIndex = 0;
            this.txtCode.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.txtCode.Visible = false;
            this.txtCode.VRulerRow = 0;
            // 
            // tcCodeFiles
            // 
            this.tcCodeFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcCodeFiles.Location = new System.Drawing.Point(0, 25);
            this.tcCodeFiles.Name = "tcCodeFiles";
            this.tcCodeFiles.SelectedIndex = 0;
            this.tcCodeFiles.Size = new System.Drawing.Size(566, 333);
            this.tcCodeFiles.TabIndex = 0;
            this.tcCodeFiles.SelectedIndexChanged += new System.EventHandler(this.tcCodeFiles_SelectedIndexChanged);
            // 
            // toolStrip2
            // 
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmdRunDemo,
            this.lblTestDescription});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(566, 25);
            this.toolStrip2.TabIndex = 1;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // cmdRunDemo
            // 
            this.cmdRunDemo.Image = global::ExamplesFramework.Properties.Resources.arrow_right;
            this.cmdRunDemo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdRunDemo.Name = "cmdRunDemo";
            this.cmdRunDemo.Size = new System.Drawing.Size(83, 22);
            this.cmdRunDemo.Text = "Run Demo";
            this.cmdRunDemo.Visible = false;
            this.cmdRunDemo.Click += new System.EventHandler(this.cmdRunDemo_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(45, 22);
            this.toolStripLabel1.Text = "Search:";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // lblTestDescription
            // 
            this.lblTestDescription.Name = "lblTestDescription";
            this.lblTestDescription.Size = new System.Drawing.Size(0, 22);
            // 
            // treeViewDemos1
            // 
            this.treeViewDemos1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeViewDemos1.ImageIndex = 0;
            this.treeViewDemos1.ImageList = this.imgTreeView;
            this.treeViewDemos1.Location = new System.Drawing.Point(0, 0);
            this.treeViewDemos1.Name = "treeViewDemos1";
            this.treeViewDemos1.SelectedImageIndex = 0;
            this.treeViewDemos1.Size = new System.Drawing.Size(284, 425);
            this.treeViewDemos1.TabIndex = 0;
            this.treeViewDemos1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewDemos1_AfterSelect);
            // 
            // txtSearch
            // 
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(121, 25);
            // 
            // frmExamples
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 535);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.reflectionHeader1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmExamples";
            this.Text = "FileHelpers Examples";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmExamples_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Devoo.WinForms.ReflectionHeader reflectionHeader1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private TreeViewExamples treeViewDemos1;
        private System.Windows.Forms.TabControl tcCodeFiles;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton cmdRunDemo;
        private System.Windows.Forms.ImageList imgTreeView;
        private ICSharpCode.TextEditor.TextEditorControl txtCode;
        private System.Windows.Forms.WebBrowser InfoSheet;
        private System.Windows.Forms.ToolStripButton extracthtml;
        private System.Windows.Forms.ToolStripButton cmdHistory;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel lblTestDescription;
        private System.Windows.Forms.ToolStripTextBox txtSearch;
    }
}