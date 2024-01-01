namespace BH_Calendar.Event.Group
{
    partial class frmGroupInfo
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
            this.groupBox1 = new BH_Core.Controls.Component.BhGroupBoxEx();
            this.bhPanel1 = new BH_Core.Controls.Component.BhPanel();
            this.pdpCD_RGB = new BH_Core.Controls.Component.BhTextBox();
            this.btnColor = new System.Windows.Forms.Button();
            this.pdpNM_GROUP = new BH_Core.Controls.Component.BhTextBox();
            this.bhLabel4 = new BH_Core.Controls.Component.BhLabel();
            this.txtNM_COLOR = new BH_Core.Controls.Component.BhTextBox();
            this.bhLabel3 = new BH_Core.Controls.Component.BhLabel();
            this.bhLabel1 = new BH_Core.Controls.Component.BhLabel();
            this.bhLabel2 = new BH_Core.Controls.Component.BhLabel();
            this.pdpCD_GROUP = new BH_Core.Controls.Component.BhTextBox();
            this.pdpTXT_NOTE = new BH_Core.Controls.Component.BhTextBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.groupBox1.SuspendLayout();
            this.bhPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // actionButtons1
            // 
            this.actionButtons1.Location = new System.Drawing.Point(0, 155);
            this.actionButtons1.Size = new System.Drawing.Size(434, 29);
            this.actionButtons1.TabIndex = 1;
            this.actionButtons1.VisibleBtnClose = true;
            this.actionButtons1.VisibleBtnSave = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bhPanel1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(0);
            this.groupBox1.Size = new System.Drawing.Size(434, 155);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " 그룹 정보 ";
            // 
            // bhPanel1
            // 
            this.bhPanel1.Controls.Add(this.pdpCD_RGB);
            this.bhPanel1.Controls.Add(this.btnColor);
            this.bhPanel1.Controls.Add(this.pdpNM_GROUP);
            this.bhPanel1.Controls.Add(this.bhLabel4);
            this.bhPanel1.Controls.Add(this.txtNM_COLOR);
            this.bhPanel1.Controls.Add(this.bhLabel3);
            this.bhPanel1.Controls.Add(this.bhLabel1);
            this.bhPanel1.Controls.Add(this.bhLabel2);
            this.bhPanel1.Controls.Add(this.pdpCD_GROUP);
            this.bhPanel1.Controls.Add(this.pdpTXT_NOTE);
            this.bhPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bhPanel1.Location = new System.Drawing.Point(0, 14);
            this.bhPanel1.Name = "bhPanel1";
            this.bhPanel1.Size = new System.Drawing.Size(434, 141);
            this.bhPanel1.TabIndex = 0;
            // 
            // pdpCD_RGB
            // 
            this.pdpCD_RGB.BhGroupName = null;
            this.pdpCD_RGB.EditValue = "";
            this.pdpCD_RGB.IsRequireValue = true;
            this.pdpCD_RGB.Location = new System.Drawing.Point(3, 114);
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
            // btnColor
            // 
            this.btnColor.Image = global::BH_Calendar.Properties.Resources.colormixer_16x16;
            this.btnColor.Location = new System.Drawing.Point(404, 4);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(26, 23);
            this.btnColor.TabIndex = 4;
            this.btnColor.UseVisualStyleBackColor = true;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
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
            this.pdpNM_GROUP.Size = new System.Drawing.Size(343, 21);
            this.pdpNM_GROUP.TabIndex = 6;
            this.pdpNM_GROUP.WaterMarkColor = System.Drawing.Color.Gray;
            this.pdpNM_GROUP.WaterMarkText = "";
            // 
            // bhLabel4
            // 
            this.bhLabel4.BhGroupName = "";
            this.bhLabel4.EditValue = "설명";
            this.bhLabel4.IsRequireValue = false;
            this.bhLabel4.Location = new System.Drawing.Point(2, 31);
            this.bhLabel4.Name = "bhLabel4";
            this.bhLabel4.RequireValueError = "";
            this.bhLabel4.Size = new System.Drawing.Size(80, 21);
            this.bhLabel4.TabIndex = 5;
            this.bhLabel4.Text = "설명";
            this.bhLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtNM_COLOR
            // 
            this.txtNM_COLOR.BhGroupName = null;
            this.txtNM_COLOR.EditValue = "";
            this.txtNM_COLOR.Location = new System.Drawing.Point(307, 5);
            this.txtNM_COLOR.MaxLength = 50;
            this.txtNM_COLOR.Name = "txtNM_COLOR";
            this.txtNM_COLOR.ReadOnly = true;
            this.txtNM_COLOR.RequireValueError = "";
            this.txtNM_COLOR.SearchButtonEnable = true;
            this.txtNM_COLOR.SearchButtonVisible = false;
            this.txtNM_COLOR.Size = new System.Drawing.Size(94, 21);
            this.txtNM_COLOR.TabIndex = 3;
            this.txtNM_COLOR.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNM_COLOR.WaterMarkColor = System.Drawing.Color.Gray;
            this.txtNM_COLOR.WaterMarkText = "";
            // 
            // bhLabel3
            // 
            this.bhLabel3.BhGroupName = "";
            this.bhLabel3.EditValue = "비고";
            this.bhLabel3.IsRequireValue = false;
            this.bhLabel3.Location = new System.Drawing.Point(2, 58);
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
            this.bhLabel1.EditValue = "그룹코드";
            this.bhLabel1.IsRequireValue = false;
            this.bhLabel1.Location = new System.Drawing.Point(2, 5);
            this.bhLabel1.Name = "bhLabel1";
            this.bhLabel1.RequireValueError = "";
            this.bhLabel1.Size = new System.Drawing.Size(81, 21);
            this.bhLabel1.TabIndex = 0;
            this.bhLabel1.Text = "그룹코드";
            this.bhLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // bhLabel2
            // 
            this.bhLabel2.BhGroupName = "";
            this.bhLabel2.EditValue = "색상";
            this.bhLabel2.IsRequireValue = false;
            this.bhLabel2.Location = new System.Drawing.Point(221, 5);
            this.bhLabel2.Name = "bhLabel2";
            this.bhLabel2.RequireValueError = "";
            this.bhLabel2.Size = new System.Drawing.Size(80, 21);
            this.bhLabel2.TabIndex = 2;
            this.bhLabel2.Text = "색상";
            this.bhLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.pdpCD_GROUP.Size = new System.Drawing.Size(124, 21);
            this.pdpCD_GROUP.TabIndex = 1;
            this.pdpCD_GROUP.WaterMarkColor = System.Drawing.Color.Gray;
            this.pdpCD_GROUP.WaterMarkText = "";
            // 
            // pdpTXT_NOTE
            // 
            this.pdpTXT_NOTE.BhGroupName = null;
            this.pdpTXT_NOTE.EditValue = "";
            this.pdpTXT_NOTE.Location = new System.Drawing.Point(88, 58);
            this.pdpTXT_NOTE.MaxLength = 200;
            this.pdpTXT_NOTE.Multiline = true;
            this.pdpTXT_NOTE.Name = "pdpTXT_NOTE";
            this.pdpTXT_NOTE.OnEnterKeyNextFocusing = false;
            this.pdpTXT_NOTE.RequireValueError = null;
            this.pdpTXT_NOTE.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.pdpTXT_NOTE.SearchButtonEnable = true;
            this.pdpTXT_NOTE.SearchButtonVisible = false;
            this.pdpTXT_NOTE.Size = new System.Drawing.Size(343, 77);
            this.pdpTXT_NOTE.TabIndex = 8;
            this.pdpTXT_NOTE.WaterMarkColor = System.Drawing.Color.Gray;
            this.pdpTXT_NOTE.WaterMarkText = "";
            // 
            // frmGroupInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 184);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmGroupInfo";
            this.Text = "Category";
            this.Controls.SetChildIndex(this.actionButtons1, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.groupBox1.ResumeLayout(false);
            this.bhPanel1.ResumeLayout(false);
            this.bhPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private BH_Core.Controls.Component.BhGroupBoxEx groupBox1;
        private BH_Core.Controls.Component.BhPanel bhPanel1;
        private BH_Core.Controls.Component.BhLabel bhLabel4;
        private BH_Core.Controls.Component.BhLabel bhLabel3;
        private BH_Core.Controls.Component.BhLabel bhLabel1;
        private BH_Core.Controls.Component.BhTextBox pdpCD_GROUP;
        private BH_Core.Controls.Component.BhTextBox pdpTXT_NOTE;
        private BH_Core.Controls.Component.BhTextBox pdpNM_GROUP;
        private BH_Core.Controls.Component.BhTextBox txtNM_COLOR;
        private BH_Core.Controls.Component.BhLabel bhLabel2;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private BH_Core.Controls.Component.BhTextBox pdpCD_RGB;
    }
}