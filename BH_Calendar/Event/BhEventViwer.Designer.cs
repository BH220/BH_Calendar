namespace BhCalrendar.Event
{
    partial class BhEventViwer
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
            this.components = new System.ComponentModel.Container();
            this.bhSearchBox1 = new BH_Core.Controls.Component.BhSearchBox();
            this.bhGrid = new BH_Core.Controls.BhGrid.BhGrid();
            this.btnAdd = new BH_Core.Controls.Component.BhButton();
            this.btnEdit = new BH_Core.Controls.Component.BhButton();
            this.btnDel = new BH_Core.Controls.Component.BhButton();
            ((System.ComponentModel.ISupportInitialize)(this.bhGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // bhSearchBox1
            // 
            this.bhSearchBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bhSearchBox1.Location = new System.Drawing.Point(0, 0);
            this.bhSearchBox1.MaximumSize = new System.Drawing.Size(2000, 27);
            this.bhSearchBox1.MinimumSize = new System.Drawing.Size(550, 27);
            this.bhSearchBox1.Name = "bhSearchBox1";
            this.bhSearchBox1.Size = new System.Drawing.Size(560, 27);
            this.bhSearchBox1.TabIndex = 2;
            this.bhSearchBox1.VisibleDateSearch = false;
            this.bhSearchBox1.SearchEvent += new BH_Core.Controls.Component.BhSearchBox.SearchEventHandler(this.bhSearchBox1_SearchEvent);
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
            this.bhGrid.Location = new System.Drawing.Point(0, 27);
            this.bhGrid.MultiSelect = false;
            this.bhGrid.Name = "bhGrid";
            this.bhGrid.RowTemplate.Height = 23;
            this.bhGrid.SearchAfterLLastRowFocus = true;
            this.bhGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.bhGrid.Size = new System.Drawing.Size(560, 273);
            this.bhGrid.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.BhGroupName = null;
            this.btnAdd.EditValue = null;
            this.btnAdd.Image = global::BH_Calendar.Properties.Resources.AddRow;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(0, 1);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.RequireValueError = null;
            this.btnAdd.Size = new System.Drawing.Size(69, 25);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "    추 가";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BhGroupName = null;
            this.btnEdit.EditValue = null;
            this.btnEdit.Image = global::BH_Calendar.Properties.Resources.EditRow;
            this.btnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEdit.Location = new System.Drawing.Point(69, 1);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.RequireValueError = null;
            this.btnEdit.Size = new System.Drawing.Size(69, 25);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Text = "    수 정";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDel
            // 
            this.btnDel.BhGroupName = null;
            this.btnDel.EditValue = null;
            this.btnDel.Image = global::BH_Calendar.Properties.Resources.DeleteRow;
            this.btnDel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDel.Location = new System.Drawing.Point(138, 1);
            this.btnDel.Name = "btnDel";
            this.btnDel.RequireValueError = null;
            this.btnDel.Size = new System.Drawing.Size(69, 25);
            this.btnDel.TabIndex = 3;
            this.btnDel.Text = "    삭 제";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // BhEventViwer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.bhGrid);
            this.Controls.Add(this.bhSearchBox1);
            this.MinimumSize = new System.Drawing.Size(560, 300);
            this.Name = "BhEventViwer";
            this.Size = new System.Drawing.Size(560, 300);
            ((System.ComponentModel.ISupportInitialize)(this.bhGrid)).EndInit();
            this.ResumeLayout(false);

        }

        private void BhSearchBox1_SearchEvent(object sender, BH_Core.SearchDataEventAgrs e)
        {
            throw new System.NotImplementedException();
        }

        #endregion

        private BH_Core.Controls.Component.BhSearchBox bhSearchBox1;
        private BH_Core.Controls.BhGrid.BhGrid bhGrid;
        private BH_Core.Controls.Component.BhButton btnAdd;
        private BH_Core.Controls.Component.BhButton btnEdit;
        private BH_Core.Controls.Component.BhButton btnDel;
    }
}
