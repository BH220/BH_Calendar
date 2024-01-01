namespace BH_Calendar.Event.Group
{
    partial class ctlEventGroup
    {
        /// <summary> 
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.bhPanel1 = new BH_Core.Controls.Component.BhPanel();
            this.txtSearch = new BH_Core.Controls.Component.BhTextBox();
            this.btnSearch = new BH_Core.Controls.Component.BhButton();
            this.bhLabel1 = new BH_Core.Controls.Component.BhLabel();
            this.bhGrid = new BH_Core.Controls.BhGrid.BhGrid();
            this.chkAll = new BH_Core.Controls.Component.BhCheckBox();
            this.bhPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bhGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // bhPanel1
            // 
            this.bhPanel1.Controls.Add(this.txtSearch);
            this.bhPanel1.Controls.Add(this.btnSearch);
            this.bhPanel1.Controls.Add(this.bhLabel1);
            this.bhPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bhPanel1.Location = new System.Drawing.Point(0, 0);
            this.bhPanel1.Name = "bhPanel1";
            this.bhPanel1.Size = new System.Drawing.Size(347, 22);
            this.bhPanel1.TabIndex = 0;
            // 
            // txtSearch
            // 
            this.txtSearch.BhGroupName = null;
            this.txtSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSearch.EditValue = "";
            this.txtSearch.Location = new System.Drawing.Point(56, 0);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.RequireValueError = null;
            this.txtSearch.SearchButtonEnable = true;
            this.txtSearch.SearchButtonVisible = false;
            this.txtSearch.Size = new System.Drawing.Size(268, 21);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.WaterMarkColor = System.Drawing.Color.Gray;
            this.txtSearch.WaterMarkText = "";
            this.txtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyDown);
            // 
            // btnSearch
            // 
            this.btnSearch.BhGroupName = null;
            this.btnSearch.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSearch.EditValue = null;
            this.btnSearch.Image = global::BH_Calendar.Properties.Resources.검색;
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Location = new System.Drawing.Point(324, 0);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.RequireValueError = null;
            this.btnSearch.Size = new System.Drawing.Size(23, 22);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "    ";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // bhLabel1
            // 
            this.bhLabel1.BhGroupName = "";
            this.bhLabel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.bhLabel1.EditValue = "그룹검색";
            this.bhLabel1.IsRequireValue = false;
            this.bhLabel1.Location = new System.Drawing.Point(0, 0);
            this.bhLabel1.Name = "bhLabel1";
            this.bhLabel1.RequireValueError = "";
            this.bhLabel1.Size = new System.Drawing.Size(56, 22);
            this.bhLabel1.TabIndex = 1;
            this.bhLabel1.Text = "그룹검색";
            this.bhLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bhGrid
            // 
            this.bhGrid.AllowPopupMenu = true;
            this.bhGrid.AllowUserToAddRows = false;
            this.bhGrid.AllowUserToDeleteRows = false;
            this.bhGrid.AllowUserToResizeRows = false;
            this.bhGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.bhGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bhGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bhGrid.Location = new System.Drawing.Point(0, 48);
            this.bhGrid.MultiSelect = false;
            this.bhGrid.Name = "bhGrid";
            this.bhGrid.RowTemplate.Height = 23;
            this.bhGrid.SearchAfterLLastRowFocus = true;
            this.bhGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.bhGrid.Size = new System.Drawing.Size(347, 295);
            this.bhGrid.TabIndex = 0;
            // 
            // chkAll
            // 
            this.chkAll.AutoSize = true;
            this.chkAll.BhGroupName = null;
            this.chkAll.Dock = System.Windows.Forms.DockStyle.Top;
            this.chkAll.EditValue = false;
            this.chkAll.Location = new System.Drawing.Point(0, 22);
            this.chkAll.Name = "chkAll";
            this.chkAll.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.chkAll.RequireValueError = null;
            this.chkAll.Size = new System.Drawing.Size(347, 26);
            this.chkAll.TabIndex = 1;
            this.chkAll.Text = "모든 이벤트 그룹 보기";
            this.chkAll.UseVisualStyleBackColor = true;
            this.chkAll.CheckedChanged += new System.EventHandler(this.chkAll_CheckedChanged);
            // 
            // ctlEventGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bhGrid);
            this.Controls.Add(this.chkAll);
            this.Controls.Add(this.bhPanel1);
            this.Name = "ctlEventGroup";
            this.Size = new System.Drawing.Size(347, 343);
            this.bhPanel1.ResumeLayout(false);
            this.bhPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bhGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BH_Core.Controls.Component.BhPanel bhPanel1;
        private BH_Core.Controls.Component.BhLabel bhLabel1;
        private BH_Core.Controls.Component.BhTextBox txtSearch;
        private BH_Core.Controls.BhGrid.BhGrid bhGrid;
        private BH_Core.Controls.Component.BhButton btnSearch;
        private BH_Core.Controls.Component.BhCheckBox chkAll;
    }
}
