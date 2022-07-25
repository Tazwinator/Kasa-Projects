﻿using TMDb.WinFormsClient.Pages;

namespace TMDb.WinFormsClient
{
    partial class Index
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
            this._sideBarSplitContainer = new System.Windows.Forms.SplitContainer();
            this._otherPageTestBtn = new System.Windows.Forms.Button();
            this._featuredPageBtn = new System.Windows.Forms.Button();
            this._mainContentSplitContainer = new System.Windows.Forms.SplitContainer();
            this._movieSearchBox = new System.Windows.Forms.TextBox();
            this._mainPage = new TMDb.WinFormsClient.Pages.MainPage();
            ((System.ComponentModel.ISupportInitialize)(this._sideBarSplitContainer)).BeginInit();
            this._sideBarSplitContainer.Panel1.SuspendLayout();
            this._sideBarSplitContainer.Panel2.SuspendLayout();
            this._sideBarSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._mainContentSplitContainer)).BeginInit();
            this._mainContentSplitContainer.Panel1.SuspendLayout();
            this._mainContentSplitContainer.Panel2.SuspendLayout();
            this._mainContentSplitContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // _sideBarSplitContainer
            // 
            this._sideBarSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this._sideBarSplitContainer.Location = new System.Drawing.Point(0, 0);
            this._sideBarSplitContainer.Name = "_sideBarSplitContainer";
            // 
            // _sideBarSplitContainer.Panel1
            // 
            this._sideBarSplitContainer.Panel1.BackColor = System.Drawing.Color.DarkOrchid;
            this._sideBarSplitContainer.Panel1.Controls.Add(this._otherPageTestBtn);
            this._sideBarSplitContainer.Panel1.Controls.Add(this._featuredPageBtn);
            // 
            // _sideBarSplitContainer.Panel2
            // 
            this._sideBarSplitContainer.Panel2.Controls.Add(this._mainContentSplitContainer);
            this._sideBarSplitContainer.Size = new System.Drawing.Size(804, 461);
            this._sideBarSplitContainer.SplitterDistance = 160;
            this._sideBarSplitContainer.TabIndex = 1;
            // 
            // _otherPageTestBtn
            // 
            this._otherPageTestBtn.Location = new System.Drawing.Point(44, 161);
            this._otherPageTestBtn.Name = "_otherPageTestBtn";
            this._otherPageTestBtn.Size = new System.Drawing.Size(101, 23);
            this._otherPageTestBtn.TabIndex = 1;
            this._otherPageTestBtn.Text = "OtherPageTest";
            this._otherPageTestBtn.UseVisualStyleBackColor = true;
            this._otherPageTestBtn.Click += new System.EventHandler(this.OtherPageTestBtn_Click);
            // 
            // _featuredPageBtn
            // 
            this._featuredPageBtn.Location = new System.Drawing.Point(44, 111);
            this._featuredPageBtn.Name = "_featuredPageBtn";
            this._featuredPageBtn.Size = new System.Drawing.Size(75, 23);
            this._featuredPageBtn.TabIndex = 0;
            this._featuredPageBtn.Text = "Featured";
            this._featuredPageBtn.UseVisualStyleBackColor = true;
            this._featuredPageBtn.Click += new System.EventHandler(this.FeaturedPageBtn_Click);
            // 
            // _mainContentSplitContainer
            // 
            this._mainContentSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this._mainContentSplitContainer.Location = new System.Drawing.Point(0, 0);
            this._mainContentSplitContainer.Name = "_topBarSplitContainer";
            this._mainContentSplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // _mainContentSplitContainer.Panel1
            // 
            this._mainContentSplitContainer.Panel1.BackColor = System.Drawing.Color.BlueViolet;
            this._mainContentSplitContainer.Panel1.Controls.Add(this._movieSearchBox);
            // 
            // _mainContentSplitContainer.Panel2
            // 
            this._mainContentSplitContainer.Panel2.Controls.Add(this._mainPage);
            this._mainContentSplitContainer.Size = new System.Drawing.Size(640, 461);
            this._mainContentSplitContainer.SplitterDistance = 60;
            this._mainContentSplitContainer.TabIndex = 0;
            // 
            // _movieSearchBox
            // 
            this._movieSearchBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._movieSearchBox.Location = new System.Drawing.Point(3, 12);
            this._movieSearchBox.Name = "_movieSearchBox";
            this._movieSearchBox.Size = new System.Drawing.Size(320, 23);
            this._movieSearchBox.TabIndex = 0;
            // 
            // _mainPage
            // 
            this._mainPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this._mainPage.Location = new System.Drawing.Point(0, 0);
            this._mainPage.Name = "_mainPage";
            this._mainPage.Size = new System.Drawing.Size(640, 397);
            this._mainPage.TabIndex = 0;
            // 
            // Index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 461);
            this.Controls.Add(this._sideBarSplitContainer);
            this.Name = "Index";
            this.Text = "TMDb";
            this._sideBarSplitContainer.Panel1.ResumeLayout(false);
            this._sideBarSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._sideBarSplitContainer)).EndInit();
            this._sideBarSplitContainer.ResumeLayout(false);
            this._mainContentSplitContainer.Panel1.ResumeLayout(false);
            this._mainContentSplitContainer.Panel1.PerformLayout();
            this._mainContentSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._mainContentSplitContainer)).EndInit();
            this._mainContentSplitContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private SplitContainer _sideBarSplitContainer;
        private SplitContainer _mainContentSplitContainer;
        private TextBox _movieSearchBox;
        private Button _otherPageTestBtn;
        private Button _featuredPageBtn;
        private MainPage _mainPage;
    }
}