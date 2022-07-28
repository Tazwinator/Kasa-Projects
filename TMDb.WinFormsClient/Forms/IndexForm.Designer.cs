

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
            this._searchButton = new System.Windows.Forms.Button();
            this._movieSearchBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this._sideBarSplitContainer)).BeginInit();
            this._sideBarSplitContainer.Panel1.SuspendLayout();
            this._sideBarSplitContainer.Panel2.SuspendLayout();
            this._sideBarSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._mainContentSplitContainer)).BeginInit();
            this._mainContentSplitContainer.Panel1.SuspendLayout();
            this._mainContentSplitContainer.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
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
            this._sideBarSplitContainer.Panel1.BackColor = System.Drawing.Color.SteelBlue;
            this._sideBarSplitContainer.Panel1.Controls.Add(this.tableLayoutPanel1);
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
            this._showMovieBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this._showMovieBtn.Location = new System.Drawing.Point(3, 199);
            this._showMovieBtn.Name = "_showMovieBtn";
            this._showMovieBtn.Size = new System.Drawing.Size(169, 22);
            this._showMovieBtn.TabIndex = 1;
            this._showMovieBtn.Text = "Current Movie";
            this._showMovieBtn.UseVisualStyleBackColor = true;
            this._showMovieBtn.Click += new System.EventHandler(this.NavBtn_Click);
            // 
            // _mainPageBtn
            // 
            this._mainPageBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this._mainPageBtn.Location = new System.Drawing.Point(3, 171);
            this._mainPageBtn.Name = "_mainPageBtn";
            this._mainPageBtn.Size = new System.Drawing.Size(169, 22);
            this._mainPageBtn.TabIndex = 0;
            this._mainPageBtn.Text = "Featured Movies";
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
            this._mainContentSplitContainer.Panel1.BackColor = System.Drawing.Color.SteelBlue;
            this._mainContentSplitContainer.Panel1.Controls.Add(this._searchButton);
            this._mainContentSplitContainer.Panel1.Controls.Add(this._movieSearchBox);
            this._mainContentSplitContainer.Size = new System.Drawing.Size(705, 561);
            this._mainContentSplitContainer.SplitterDistance = 73;
            this._mainContentSplitContainer.TabIndex = 0;
            // 
            // _searchButton
            // 
            this._searchButton.Location = new System.Drawing.Point(394, 12);
            this._searchButton.Name = "_searchButton";
            this._searchButton.Size = new System.Drawing.Size(75, 23);
            this._searchButton.TabIndex = 1;
            this._searchButton.Text = "Search";
            this._searchButton.UseVisualStyleBackColor = true;
            this._searchButton.Click += new System.EventHandler(this._searchButton_Click);
            // 
            // _movieSearchBox
            // 
            this._movieSearchBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._movieSearchBox.Location = new System.Drawing.Point(3, 12);
            this._movieSearchBox.Name = "_movieSearchBox";
            this._movieSearchBox.Size = new System.Drawing.Size(385, 23);
            this._movieSearchBox.TabIndex = 0;
            this._movieSearchBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this._movieSearchBox_KeyDown);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this._mainPageBtn, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this._showMovieBtn, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(175, 561);
            this.tableLayoutPanel1.TabIndex = 2;
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
            ((System.ComponentModel.ISupportInitialize)(this._mainContentSplitContainer)).EndInit();
            this._mainContentSplitContainer.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private SplitContainer _sideBarSplitContainer;
        private SplitContainer _mainContentSplitContainer;
        private TextBox _movieSearchBox;
        private Button _showMovieBtn;
        private Button _mainPageBtn;
        private Button _searchButton;
        private TableLayoutPanel tableLayoutPanel1;
    }
}