namespace TMDb.WinFormsClient.Forms
{
    partial class ShowMovie
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
            this._posterImageBox = new System.Windows.Forms.PictureBox();
            this._movieInfoPanel = new System.Windows.Forms.Panel();
            this._synopsisTextBox = new System.Windows.Forms.TextBox();
            this._titleLabel = new System.Windows.Forms.Label();
            this._runtimeLabel = new System.Windows.Forms.Label();
            this._releaseDateLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this._posterImageBox)).BeginInit();
            this._movieInfoPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // _posterImageBox
            // 
            this._posterImageBox.Dock = System.Windows.Forms.DockStyle.Left;
            this._posterImageBox.Location = new System.Drawing.Point(0, 0);
            this._posterImageBox.Name = "_posterImageBox";
            this._posterImageBox.Size = new System.Drawing.Size(336, 561);
            this._posterImageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this._posterImageBox.TabIndex = 0;
            this._posterImageBox.TabStop = false;
            // 
            // _movieInfoPanel
            // 
            this._movieInfoPanel.Controls.Add(this._synopsisTextBox);
            this._movieInfoPanel.Controls.Add(this._titleLabel);
            this._movieInfoPanel.Controls.Add(this._runtimeLabel);
            this._movieInfoPanel.Controls.Add(this._releaseDateLabel);
            this._movieInfoPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._movieInfoPanel.Location = new System.Drawing.Point(336, 0);
            this._movieInfoPanel.Name = "_movieInfoPanel";
            this._movieInfoPanel.Size = new System.Drawing.Size(369, 561);
            this._movieInfoPanel.TabIndex = 1;
            // 
            // _synopsisTextBox
            // 
            this._synopsisTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._synopsisTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._synopsisTextBox.Location = new System.Drawing.Point(6, 238);
            this._synopsisTextBox.Multiline = true;
            this._synopsisTextBox.Name = "_synopsisTextBox";
            this._synopsisTextBox.ReadOnly = true;
            this._synopsisTextBox.Size = new System.Drawing.Size(360, 323);
            this._synopsisTextBox.TabIndex = 5;
            // 
            // _titleLabel
            // 
            this._titleLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._titleLabel.AutoSize = true;
            this._titleLabel.Location = new System.Drawing.Point(6, 187);
            this._titleLabel.Name = "_titleLabel";
            this._titleLabel.Size = new System.Drawing.Size(38, 15);
            this._titleLabel.TabIndex = 3;
            this._titleLabel.Text = "label4";
            // 
            // _runtimeLabel
            // 
            this._runtimeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._runtimeLabel.AutoSize = true;
            this._runtimeLabel.Location = new System.Drawing.Point(328, 22);
            this._runtimeLabel.Name = "_runtimeLabel";
            this._runtimeLabel.Size = new System.Drawing.Size(38, 15);
            this._runtimeLabel.TabIndex = 1;
            this._runtimeLabel.Text = "label2";
            // 
            // _releaseDateLabel
            // 
            this._releaseDateLabel.AutoSize = true;
            this._releaseDateLabel.Location = new System.Drawing.Point(6, 22);
            this._releaseDateLabel.Name = "_releaseDateLabel";
            this._releaseDateLabel.Size = new System.Drawing.Size(38, 15);
            this._releaseDateLabel.TabIndex = 0;
            this._releaseDateLabel.Text = "label1";
            // 
            // ShowMovie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this._movieInfoPanel);
            this.Controls.Add(this._posterImageBox);
            this.Name = "ShowMovie";
            this.Size = new System.Drawing.Size(705, 561);
            ((System.ComponentModel.ISupportInitialize)(this._posterImageBox)).EndInit();
            this._movieInfoPanel.ResumeLayout(false);
            this._movieInfoPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox _posterImageBox;
        private Panel _movieInfoPanel;
        private Label _titleLabel;
        private Label _runtimeLabel;
        private Label _releaseDateLabel;
        private TextBox _synopsisTextBox;
    }
}
