namespace TMDb.WinFormsClient.Forms
{
    partial class SearchResults
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
            this._searchResultsDataGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this._searchResultsDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // _searchResultsDataGrid
            // 
            this._searchResultsDataGrid.AllowUserToAddRows = false;
            this._searchResultsDataGrid.AllowUserToDeleteRows = false;
            this._searchResultsDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this._searchResultsDataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this._searchResultsDataGrid.BackgroundColor = System.Drawing.Color.White;
            this._searchResultsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._searchResultsDataGrid.ColumnHeadersVisible = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this._searchResultsDataGrid.DefaultCellStyle = dataGridViewCellStyle1;
            this._searchResultsDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this._searchResultsDataGrid.Location = new System.Drawing.Point(0, 0);
            this._searchResultsDataGrid.MultiSelect = false;
            this._searchResultsDataGrid.Name = "_searchResultsDataGrid";
            this._searchResultsDataGrid.ReadOnly = true;
            this._searchResultsDataGrid.RowHeadersVisible = false;
            this._searchResultsDataGrid.RowTemplate.Height = 25;
            this._searchResultsDataGrid.Size = new System.Drawing.Size(705, 561);
            this._searchResultsDataGrid.TabIndex = 0;
            this._searchResultsDataGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MovieList_CellDoubleClicked);
            // 
            // SearchResults
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this._searchResultsDataGrid);
            this.Name = "SearchResults";
            this.Size = new System.Drawing.Size(705, 561);
            ((System.ComponentModel.ISupportInitialize)(this._searchResultsDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView _searchResultsDataGrid;
    }
}
