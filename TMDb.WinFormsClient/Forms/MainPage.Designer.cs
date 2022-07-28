namespace TMDb.WinFormsClient.Forms
{
    partial class MainPage
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this._highestRatedDataGrid = new System.Windows.Forms.DataGridView();
            this._latestReleasesDataGrid = new System.Windows.Forms.DataGridView();
            this._upAndComignDataGrid = new System.Windows.Forms.DataGridView();
            this._highestRatedlabel = new System.Windows.Forms.Label();
            this._latestReleasesLabel = new System.Windows.Forms.Label();
            this._upAndComingLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._highestRatedDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._latestReleasesDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._upAndComignDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.Controls.Add(this._highestRatedDataGrid, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this._latestReleasesDataGrid, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this._upAndComignDataGrid, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this._highestRatedlabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this._latestReleasesLabel, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this._upAndComingLabel, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 94F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(705, 561);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // _highestRatedDataGrid
            // 
            this._highestRatedDataGrid.AllowUserToAddRows = false;
            this._highestRatedDataGrid.AllowUserToDeleteRows = false;
            this._highestRatedDataGrid.AllowUserToOrderColumns = true;
            this._highestRatedDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this._highestRatedDataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this._highestRatedDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._highestRatedDataGrid.ColumnHeadersVisible = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this._highestRatedDataGrid.DefaultCellStyle = dataGridViewCellStyle1;
            this._highestRatedDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this._highestRatedDataGrid.Location = new System.Drawing.Point(3, 36);
            this._highestRatedDataGrid.MultiSelect = false;
            this._highestRatedDataGrid.Name = "_highestRatedDataGrid";
            this._highestRatedDataGrid.ReadOnly = true;
            this._highestRatedDataGrid.RowHeadersVisible = false;
            this._highestRatedDataGrid.RowTemplate.Height = 25;
            this._highestRatedDataGrid.Size = new System.Drawing.Size(228, 522);
            this._highestRatedDataGrid.TabIndex = 0;
            this._highestRatedDataGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MovieList_CellDoubleClicked);
            // 
            // _latestReleasesDataGrid
            // 
            this._latestReleasesDataGrid.AllowUserToAddRows = false;
            this._latestReleasesDataGrid.AllowUserToDeleteRows = false;
            this._latestReleasesDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this._latestReleasesDataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this._latestReleasesDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._latestReleasesDataGrid.ColumnHeadersVisible = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this._latestReleasesDataGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this._latestReleasesDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this._latestReleasesDataGrid.Location = new System.Drawing.Point(237, 36);
            this._latestReleasesDataGrid.MultiSelect = false;
            this._latestReleasesDataGrid.Name = "_latestReleasesDataGrid";
            this._latestReleasesDataGrid.ReadOnly = true;
            this._latestReleasesDataGrid.RowHeadersVisible = false;
            this._latestReleasesDataGrid.RowTemplate.Height = 25;
            this._latestReleasesDataGrid.Size = new System.Drawing.Size(229, 522);
            this._latestReleasesDataGrid.TabIndex = 1;
            this._latestReleasesDataGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MovieList_CellDoubleClicked);
            // 
            // _upAndComignDataGrid
            // 
            this._upAndComignDataGrid.AllowUserToAddRows = false;
            this._upAndComignDataGrid.AllowUserToDeleteRows = false;
            this._upAndComignDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this._upAndComignDataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this._upAndComignDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._upAndComignDataGrid.ColumnHeadersVisible = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this._upAndComignDataGrid.DefaultCellStyle = dataGridViewCellStyle3;
            this._upAndComignDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this._upAndComignDataGrid.Location = new System.Drawing.Point(472, 36);
            this._upAndComignDataGrid.MultiSelect = false;
            this._upAndComignDataGrid.Name = "_upAndComignDataGrid";
            this._upAndComignDataGrid.ReadOnly = true;
            this._upAndComignDataGrid.RowHeadersVisible = false;
            this._upAndComignDataGrid.RowTemplate.Height = 25;
            this._upAndComignDataGrid.Size = new System.Drawing.Size(230, 522);
            this._upAndComignDataGrid.TabIndex = 2;
            this._upAndComignDataGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MovieList_CellDoubleClicked);
            // 
            // _highestRatedlabel
            // 
            this._highestRatedlabel.AutoSize = true;
            this._highestRatedlabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this._highestRatedlabel.Location = new System.Drawing.Point(3, 18);
            this._highestRatedlabel.Name = "_highestRatedlabel";
            this._highestRatedlabel.Size = new System.Drawing.Size(228, 15);
            this._highestRatedlabel.TabIndex = 3;
            this._highestRatedlabel.Text = "Highest Rated Last Year";
            this._highestRatedlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _latestReleasesLabel
            // 
            this._latestReleasesLabel.AutoSize = true;
            this._latestReleasesLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this._latestReleasesLabel.Location = new System.Drawing.Point(237, 18);
            this._latestReleasesLabel.Name = "_latestReleasesLabel";
            this._latestReleasesLabel.Size = new System.Drawing.Size(229, 15);
            this._latestReleasesLabel.TabIndex = 4;
            this._latestReleasesLabel.Text = "Latest Releases";
            this._latestReleasesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _upAndComingLabel
            // 
            this._upAndComingLabel.AutoSize = true;
            this._upAndComingLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this._upAndComingLabel.Location = new System.Drawing.Point(472, 18);
            this._upAndComingLabel.Name = "_upAndComingLabel";
            this._upAndComingLabel.Size = new System.Drawing.Size(230, 15);
            this._upAndComingLabel.TabIndex = 5;
            this._upAndComingLabel.Text = "Up And Coming";
            this._upAndComingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "MainPage";
            this.Size = new System.Drawing.Size(705, 561);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._highestRatedDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._latestReleasesDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._upAndComignDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private DataGridView _highestRatedDataGrid;
        private DataGridView _latestReleasesDataGrid;
        private DataGridView _upAndComignDataGrid;
        private Label _highestRatedlabel;
        private Label _latestReleasesLabel;
        private Label _upAndComingLabel;
    }
}
