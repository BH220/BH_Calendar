namespace BH_Calendar.Event
{
    partial class frmEventInfo
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
            this.bhGroupBoxEx1 = new BH_Core.Controls.Component.BhGroupBoxEx();
            this.bhGroupBoxEx2 = new BH_Core.Controls.Component.BhGroupBoxEx();
            this.ctlSelectGroup1 = new BH_Calendar.Event.ctlSelectGroup();
            this.bhPanel1 = new BH_Core.Controls.Component.BhPanel();
            this.pdpCD_RGB = new BH_Core.Controls.Component.BhTextBox();
            this.pdpNM_GROUP = new BH_Core.Controls.Component.BhTextBox();
            this.bhLabel4 = new BH_Core.Controls.Component.BhLabel();
            this.bhLabel3 = new BH_Core.Controls.Component.BhLabel();
            this.bhLabel1 = new BH_Core.Controls.Component.BhLabel();
            this.pdpCD_GROUP = new BH_Core.Controls.Component.BhTextBox();
            this.pdpTXT_NOTE = new BH_Core.Controls.Component.BhTextBox();
            this.bhDateBox1 = new BH_Core.Controls.Component.BhDateBox();
            this.bhDateBox2 = new BH_Core.Controls.Component.BhDateBox();
            this.bhLabel2 = new BH_Core.Controls.Component.BhLabel();
            this.bhLabel5 = new BH_Core.Controls.Component.BhLabel();
            this.bhGroupBoxEx3 = new BH_Core.Controls.Component.BhGroupBoxEx();
            this.ctlSelectGroup2 = new BH_Calendar.Event.ctlSelectGroup();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bhGroupBoxEx1.SuspendLayout();
            this.bhGroupBoxEx2.SuspendLayout();
            this.bhPanel1.SuspendLayout();
            this.bhGroupBoxEx3.SuspendLayout();
            this.SuspendLayout();
            // 
            // actionButtons1
            // 
            this.actionButtons1.Location = new System.Drawing.Point(0, 425);
            this.actionButtons1.Size = new System.Drawing.Size(434, 29);
            this.actionButtons1.VisibleBtnClose = true;
            this.actionButtons1.VisibleBtnSave = true;
            // 
            // bhGroupBoxEx1
            // 
            this.bhGroupBoxEx1.Controls.Add(this.ctlSelectGroup1);
            this.bhGroupBoxEx1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bhGroupBoxEx1.Location = new System.Drawing.Point(0, 0);
            this.bhGroupBoxEx1.Name = "bhGroupBoxEx1";
            this.bhGroupBoxEx1.Size = new System.Drawing.Size(434, 45);
            this.bhGroupBoxEx1.TabIndex = 1;
            this.bhGroupBoxEx1.TabStop = false;
            this.bhGroupBoxEx1.Text = " 카테고리 정보 ";
            // 
            // bhGroupBoxEx2
            // 
            this.bhGroupBoxEx2.Controls.Add(this.bhPanel1);
            this.bhGroupBoxEx2.Dock = System.Windows.Forms.DockStyle.Top;
            this.bhGroupBoxEx2.Location = new System.Drawing.Point(0, 55);
            this.bhGroupBoxEx2.Name = "bhGroupBoxEx2";
            this.bhGroupBoxEx2.Size = new System.Drawing.Size(434, 213);
            this.bhGroupBoxEx2.TabIndex = 1;
            this.bhGroupBoxEx2.TabStop = false;
            this.bhGroupBoxEx2.Text = " 이벤트 상세 정보 ";
            // 
            // ctlSelectGroup1
            // 
            this.ctlSelectGroup1.BhGroupName = null;
            this.ctlSelectGroup1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ctlSelectGroup1.EditValue = "";
            this.ctlSelectGroup1.FormattingEnabled = true;
            this.ctlSelectGroup1.Items.AddRange(new object[] {
            "그룹을 선택하세요"});
            this.ctlSelectGroup1.Location = new System.Drawing.Point(3, 17);
            this.ctlSelectGroup1.Name = "ctlSelectGroup1";
            this.ctlSelectGroup1.RequireValueError = null;
            this.ctlSelectGroup1.Size = new System.Drawing.Size(428, 20);
            this.ctlSelectGroup1.TabIndex = 0;
            // 
            // bhPanel1
            // 
            this.bhPanel1.Controls.Add(this.bhDateBox2);
            this.bhPanel1.Controls.Add(this.bhDateBox1);
            this.bhPanel1.Controls.Add(this.pdpCD_RGB);
            this.bhPanel1.Controls.Add(this.pdpNM_GROUP);
            this.bhPanel1.Controls.Add(this.bhLabel5);
            this.bhPanel1.Controls.Add(this.bhLabel2);
            this.bhPanel1.Controls.Add(this.bhLabel4);
            this.bhPanel1.Controls.Add(this.bhLabel3);
            this.bhPanel1.Controls.Add(this.bhLabel1);
            this.bhPanel1.Controls.Add(this.pdpCD_GROUP);
            this.bhPanel1.Controls.Add(this.pdpTXT_NOTE);
            this.bhPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bhPanel1.Location = new System.Drawing.Point(3, 17);
            this.bhPanel1.Name = "bhPanel1";
            this.bhPanel1.Size = new System.Drawing.Size(428, 193);
            this.bhPanel1.TabIndex = 1;
            // 
            // pdpCD_RGB
            // 
            this.pdpCD_RGB.BhGroupName = null;
            this.pdpCD_RGB.EditValue = "";
            this.pdpCD_RGB.IsRequireValue = true;
            this.pdpCD_RGB.Location = new System.Drawing.Point(3, 169);
            this.pdpCD_RGB.MaxLength = 9;
            this.pdpCD_RGB.Name = "pdpCD_RGB";
            this.pdpCD_RGB.ReadOnly = true;
            this.pdpCD_RGB.RequireValueError = "색상";
            this.pdpCD_RGB.SearchButtonEnable = true;
            this.pdpCD_RGB.SearchButtonVisible = false;
            this.pdpCD_RGB.Size = new System.Drawing.Size(79, 21);
            this.pdpCD_RGB.TabIndex = 9;
            this.pdpCD_RGB.WaterMarkColor = System.Drawing.Color.Gray;
            this.pdpCD_RGB.WaterMarkText = "";
            // 
            // pdpNM_GROUP
            // 
            this.pdpNM_GROUP.BhGroupName = null;
            this.pdpNM_GROUP.EditValue = "";
            this.pdpNM_GROUP.Location = new System.Drawing.Point(88, 32);
            this.pdpNM_GROUP.MaxLength = 50;
            this.pdpNM_GROUP.Name = "pdpNM_GROUP";
            this.pdpNM_GROUP.RequireValueError = "";
            this.pdpNM_GROUP.SearchButtonEnable = true;
            this.pdpNM_GROUP.SearchButtonVisible = false;
            this.pdpNM_GROUP.Size = new System.Drawing.Size(337, 21);
            this.pdpNM_GROUP.TabIndex = 6;
            this.pdpNM_GROUP.WaterMarkColor = System.Drawing.Color.Gray;
            this.pdpNM_GROUP.WaterMarkText = "";
            // 
            // bhLabel4
            // 
            this.bhLabel4.BhGroupName = "";
            this.bhLabel4.EditValue = "시작시간";
            this.bhLabel4.IsRequireValue = false;
            this.bhLabel4.Location = new System.Drawing.Point(2, 31);
            this.bhLabel4.Name = "bhLabel4";
            this.bhLabel4.RequireValueError = "";
            this.bhLabel4.Size = new System.Drawing.Size(80, 21);
            this.bhLabel4.TabIndex = 5;
            this.bhLabel4.Text = "시작시간";
            this.bhLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // bhLabel3
            // 
            this.bhLabel3.BhGroupName = "";
            this.bhLabel3.EditValue = "비고";
            this.bhLabel3.IsRequireValue = false;
            this.bhLabel3.Location = new System.Drawing.Point(2, 113);
            this.bhLabel3.Name = "bhLabel3";
            this.bhLabel3.RequireValueError = "";
            this.bhLabel3.Size = new System.Drawing.Size(80, 21);
            this.bhLabel3.TabIndex = 7;
            this.bhLabel3.Text = "비고";
            this.bhLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // bhLabel1
            // 
            this.bhLabel1.BhGroupName = "";
            this.bhLabel1.EditValue = "이벤트 제목";
            this.bhLabel1.IsRequireValue = false;
            this.bhLabel1.Location = new System.Drawing.Point(2, 5);
            this.bhLabel1.Name = "bhLabel1";
            this.bhLabel1.RequireValueError = "";
            this.bhLabel1.Size = new System.Drawing.Size(81, 21);
            this.bhLabel1.TabIndex = 0;
            this.bhLabel1.Text = "이벤트 제목";
            this.bhLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pdpCD_GROUP
            // 
            this.pdpCD_GROUP.BhGroupName = null;
            this.pdpCD_GROUP.EditValue = "";
            this.pdpCD_GROUP.IsRequireValue = true;
            this.pdpCD_GROUP.Location = new System.Drawing.Point(88, 5);
            this.pdpCD_GROUP.MaxLength = 9;
            this.pdpCD_GROUP.Name = "pdpCD_GROUP";
            this.pdpCD_GROUP.RequireValueError = "그룹코드";
            this.pdpCD_GROUP.SearchButtonEnable = true;
            this.pdpCD_GROUP.SearchButtonVisible = false;
            this.pdpCD_GROUP.Size = new System.Drawing.Size(337, 21);
            this.pdpCD_GROUP.TabIndex = 1;
            this.pdpCD_GROUP.WaterMarkColor = System.Drawing.Color.Gray;
            this.pdpCD_GROUP.WaterMarkText = "";
            // 
            // pdpTXT_NOTE
            // 
            this.pdpTXT_NOTE.BhGroupName = null;
            this.pdpTXT_NOTE.EditValue = "";
            this.pdpTXT_NOTE.Location = new System.Drawing.Point(88, 113);
            this.pdpTXT_NOTE.MaxLength = 200;
            this.pdpTXT_NOTE.Multiline = true;
            this.pdpTXT_NOTE.Name = "pdpTXT_NOTE";
            this.pdpTXT_NOTE.OnEnterKeyNextFocusing = false;
            this.pdpTXT_NOTE.RequireValueError = null;
            this.pdpTXT_NOTE.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.pdpTXT_NOTE.SearchButtonEnable = true;
            this.pdpTXT_NOTE.SearchButtonVisible = false;
            this.pdpTXT_NOTE.Size = new System.Drawing.Size(337, 77);
            this.pdpTXT_NOTE.TabIndex = 8;
            this.pdpTXT_NOTE.WaterMarkColor = System.Drawing.Color.Gray;
            this.pdpTXT_NOTE.WaterMarkText = "";
            // 
            // bhDateBox1
            // 
            this.bhDateBox1.BhGroupName = null;
            this.bhDateBox1.CustomFormat = "yyyy-MM-dd hh:mm";
            this.bhDateBox1.EditValue = "20180727";
            this.bhDateBox1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.bhDateBox1.Location = new System.Drawing.Point(88, 59);
            this.bhDateBox1.Name = "bhDateBox1";
            this.bhDateBox1.RequireValueError = null;
            this.bhDateBox1.Size = new System.Drawing.Size(116, 21);
            this.bhDateBox1.TabIndex = 10;
            // 
            // bhDateBox2
            // 
            this.bhDateBox2.BhGroupName = null;
            this.bhDateBox2.CustomFormat = "yyyy-MM-dd hh:mm";
            this.bhDateBox2.EditValue = "20180727";
            this.bhDateBox2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.bhDateBox2.Location = new System.Drawing.Point(88, 86);
            this.bhDateBox2.Name = "bhDateBox2";
            this.bhDateBox2.RequireValueError = null;
            this.bhDateBox2.Size = new System.Drawing.Size(116, 21);
            this.bhDateBox2.TabIndex = 10;
            // 
            // bhLabel2
            // 
            this.bhLabel2.BhGroupName = "";
            this.bhLabel2.EditValue = "시작시간";
            this.bhLabel2.IsRequireValue = false;
            this.bhLabel2.Location = new System.Drawing.Point(2, 59);
            this.bhLabel2.Name = "bhLabel2";
            this.bhLabel2.RequireValueError = "";
            this.bhLabel2.Size = new System.Drawing.Size(80, 21);
            this.bhLabel2.TabIndex = 5;
            this.bhLabel2.Text = "시작시간";
            this.bhLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // bhLabel5
            // 
            this.bhLabel5.BhGroupName = "";
            this.bhLabel5.EditValue = "시작시간";
            this.bhLabel5.IsRequireValue = false;
            this.bhLabel5.Location = new System.Drawing.Point(2, 86);
            this.bhLabel5.Name = "bhLabel5";
            this.bhLabel5.RequireValueError = "";
            this.bhLabel5.Size = new System.Drawing.Size(80, 21);
            this.bhLabel5.TabIndex = 5;
            this.bhLabel5.Text = "시작시간";
            this.bhLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // bhGroupBoxEx3
            // 
            this.bhGroupBoxEx3.Controls.Add(this.ctlSelectGroup2);
            this.bhGroupBoxEx3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bhGroupBoxEx3.Location = new System.Drawing.Point(0, 278);
            this.bhGroupBoxEx3.Name = "bhGroupBoxEx3";
            this.bhGroupBoxEx3.Size = new System.Drawing.Size(434, 147);
            this.bhGroupBoxEx3.TabIndex = 2;
            this.bhGroupBoxEx3.TabStop = false;
            this.bhGroupBoxEx3.Text = " 첨부파일 ";
            // 
            // ctlSelectGroup2
            // 
            this.ctlSelectGroup2.BhGroupName = null;
            this.ctlSelectGroup2.Dock = System.Windows.Forms.DockStyle.Top;
            this.ctlSelectGroup2.EditValue = "";
            this.ctlSelectGroup2.FormattingEnabled = true;
            this.ctlSelectGroup2.Items.AddRange(new object[] {
            "그룹을 선택하세요",
            "그룹을 선택하세요"});
            this.ctlSelectGroup2.Location = new System.Drawing.Point(3, 17);
            this.ctlSelectGroup2.Name = "ctlSelectGroup2";
            this.ctlSelectGroup2.RequireValueError = null;
            this.ctlSelectGroup2.Size = new System.Drawing.Size(428, 20);
            this.ctlSelectGroup2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(0, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(434, 10);
            this.label1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Location = new System.Drawing.Point(0, 268);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(434, 10);
            this.label2.TabIndex = 4;
            // 
            // frmEventInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 454);
            this.Controls.Add(this.bhGroupBoxEx3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bhGroupBoxEx2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bhGroupBoxEx1);
            this.Name = "frmEventInfo";
            this.Text = "frmEventInfo";
            this.Controls.SetChildIndex(this.bhGroupBoxEx1, 0);
            this.Controls.SetChildIndex(this.actionButtons1, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.bhGroupBoxEx2, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.bhGroupBoxEx3, 0);
            this.bhGroupBoxEx1.ResumeLayout(false);
            this.bhGroupBoxEx2.ResumeLayout(false);
            this.bhPanel1.ResumeLayout(false);
            this.bhPanel1.PerformLayout();
            this.bhGroupBoxEx3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private BH_Core.Controls.Component.BhGroupBoxEx bhGroupBoxEx1;
        private BH_Core.Controls.Component.BhGroupBoxEx bhGroupBoxEx2;
        private ctlSelectGroup ctlSelectGroup1;
        private BH_Core.Controls.Component.BhPanel bhPanel1;
        private BH_Core.Controls.Component.BhDateBox bhDateBox2;
        private BH_Core.Controls.Component.BhDateBox bhDateBox1;
        private BH_Core.Controls.Component.BhTextBox pdpCD_RGB;
        private BH_Core.Controls.Component.BhTextBox pdpNM_GROUP;
        private BH_Core.Controls.Component.BhLabel bhLabel5;
        private BH_Core.Controls.Component.BhLabel bhLabel2;
        private BH_Core.Controls.Component.BhLabel bhLabel4;
        private BH_Core.Controls.Component.BhLabel bhLabel3;
        private BH_Core.Controls.Component.BhLabel bhLabel1;
        private BH_Core.Controls.Component.BhTextBox pdpCD_GROUP;
        private BH_Core.Controls.Component.BhTextBox pdpTXT_NOTE;
        private BH_Core.Controls.Component.BhGroupBoxEx bhGroupBoxEx3;
        private ctlSelectGroup ctlSelectGroup2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}