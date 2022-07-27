

namespace TMDb.WinFormsClient.Forms
{
    public partial class IndexForm
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
            this._showMovieBtn = new System.Windows.Forms.Button();
            this._mainPageBtn = new System.Windows.Forms.Button();
            this._mainContentSplitContainer = new System.Windows.Forms.SplitContainer();
            this._movieSearchBox = new System.Windows.Forms.TextBox();
            this._mainPage = new TMDb.WinFormsClient.Forms.MainPage();
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
            this._sideBarSplitContainer.Panel1.Controls.Add(this._showMovieBtn);
            this._sideBarSplitContainer.Panel1.Controls.Add(this._mainPageBtn);
            // 
            // _sideBarSplitContainer.Panel2
            // 
            this._sideBarSplitContainer.Panel2.Controls.Add(this._mainContentSplitContainer);
            this._sideBarSplitContainer.Size = new System.Drawing.Size(884, 561);
            this._sideBarSplitContainer.SplitterDistance = 175;
            this._sideBarSplitContainer.TabIndex = 1;
            // 
            // _showMovieBtn
            // 
            this._showMovieBtn.Location = new System.Drawing.Point(44, 161);
            this._showMovieBtn.Name = "_showMovieBtn";
            this._showMovieBtn.Size = new System.Drawing.Size(101, 23);
            this._showMovieBtn.TabIndex = 1;
            this._showMovieBtn.Text = "OtherPageTest";
            this._showMovieBtn.UseVisualStyleBackColor = true;
            this._showMovieBtn.Click += new System.EventHandler(this.NavBtn_Click);
            // 
            // _mainPageBtn
            // 
            this._mainPageBtn.Location = new System.Drawing.Point(44, 111);
            this._mainPageBtn.Name = "_mainPageBtn";
            this._mainPageBtn.Size = new System.Drawing.Size(75, 23);
            this._mainPageBtn.TabIndex = 0;
            this._mainPageBtn.Text = "Featured";
            this._mainPageBtn.UseVisualStyleBackColor = true;
            this._mainPageBtn.Click += new System.EventHandler(this.NavBtn_Click);
            // 
            // _mainContentSplitContainer
            // 
            this._mainContentSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this._mainContentSplitContainer.Location = new System.Drawing.Point(0, 0);
            this._mainContentSplitContainer.Name = "_mainContentSplitContainer";
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
            this._mainContentSplitContainer.Size = new System.Drawing.Size(705, 561);
            this._mainContentSplitContainer.SplitterDistance = 73;
            this._mainContentSplitContainer.TabIndex = 0;
            // 
            // _movieSearchBox
            // 
            this._movieSearchBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._movieSearchBox.Location = new System.Drawing.Point(3, 12);
            this._movieSearchBox.Name = "_movieSearchBox";
            this._movieSearchBox.Size = new System.Drawing.Size(385, 23);
            this._movieSearchBox.TabIndex = 0;
            // 
            // _mainPage
            // 
            this._mainPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this._mainPage.Location = new System.Drawing.Point(0, 0);
            this._mainPage.Name = "_mainPage";
            this._mainPage.Size = new System.Drawing.Size(705, 484);
            this._mainPage.TabIndex = 0;
            // 
            // IndexForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this._sideBarSplitContainer);
            this.Name = "IndexForm";
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
        private Button _showMovieBtn;
        private Button _mainPageBtn;
        private MainPage _mainPage;
    }
}