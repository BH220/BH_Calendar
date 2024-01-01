namespace BH_Calendar.Login
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.btnLogin = new BH_Core.Controls.Component.BhButton();
            this.btnClose = new BH_Core.Controls.Component.BhButton();
            this.chkSaveInfo = new BH_Core.Controls.Component.BhCheckBox();
            this.chkRegistRun = new BH_Core.Controls.Component.BhCheckBox();
            this.txtPw = new BH_Core.Controls.Component.BhTextBox();
            this.txtId = new BH_Core.Controls.Component.BhTextBox();
            this.bhLabel2 = new BH_Core.Controls.Component.BhLabel();
            this.bhLabel1 = new BH_Core.Controls.Component.BhLabel();
            this.bhPictureBox2 = new BH_Core.Controls.Component.BhPictureBox();
            this.bhPictureBox1 = new BH_Core.Controls.Component.BhPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.bhPictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bhPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.BhGroupName = null;
            this.btnLogin.EditValue = null;
            this.btnLogin.Image = global::BH_Calendar.Properties.Resources.Login;
            this.btnLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogin.Location = new System.Drawing.Point(99, 139);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.RequireValueError = null;
            this.btnLogin.Size = new System.Drawing.Size(66, 23);
            this.btnLogin.TabIndex = 12;
            this.btnLogin.Text = "    로그인";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnClose
            // 
            this.btnClose.BhGroupName = null;
            this.btnClose.EditValue = null;
            this.btnClose.Image = global::BH_Calendar.Properties.Resources.닫기_16;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(171, 139);
            this.btnClose.Name = "btnClose";
            this.btnClose.RequireValueError = null;
            this.btnClose.Size = new System.Drawing.Size(66, 23);
            this.btnClose.TabIndex = 12;
            this.btnClose.Text = "    닫 기";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // chkSaveInfo
            // 
            this.chkSaveInfo.AutoSize = true;
            this.chkSaveInfo.BackColor = System.Drawing.Color.Transparent;
            this.chkSaveInfo.BhGroupName = null;
            this.chkSaveInfo.EditValue = false;
            this.chkSaveInfo.Location = new System.Drawing.Point(19, 113);
            this.chkSaveInfo.Name = "chkSaveInfo";
            this.chkSaveInfo.RequireValueError = null;
            this.chkSaveInfo.Size = new System.Drawing.Size(88, 16);
            this.chkSaveInfo.TabIndex = 11;
            this.chkSaveInfo.Text = "자동 로그인";
            this.chkSaveInfo.UseVisualStyleBackColor = false;
            this.chkSaveInfo.CheckedChanged += new System.EventHandler(this.chkSaveInfo_CheckedChanged);
            // 
            // chkRegistRun
            // 
            this.chkRegistRun.AutoSize = true;
            this.chkRegistRun.BackColor = System.Drawing.Color.Transparent;
            this.chkRegistRun.BhGroupName = null;
            this.chkRegistRun.EditValue = false;
            this.chkRegistRun.Location = new System.Drawing.Point(113, 113);
            this.chkRegistRun.Name = "chkRegistRun";
            this.chkRegistRun.RequireValueError = null;
            this.chkRegistRun.Size = new System.Drawing.Size(124, 16);
            this.chkRegistRun.TabIndex = 10;
            this.chkRegistRun.Text = "부팅시 자동로그인";
            this.chkRegistRun.UseVisualStyleBackColor = false;
            this.chkRegistRun.CheckedChanged += new System.EventHandler(this.chkRegistRun_CheckedChanged);
            // 
            // txtPw
            // 
            this.txtPw.BhGroupName = null;
            this.txtPw.EditValue = "";
            this.txtPw.Location = new System.Drawing.Point(126, 80);
            this.txtPw.Name = "txtPw";
            this.txtPw.PasswordChar = '*';
            this.txtPw.RequireValueError = null;
            this.txtPw.SearchButtonEnable = true;
            this.txtPw.SearchButtonVisible = false;
            this.txtPw.Size = new System.Drawing.Size(111, 21);
            this.txtPw.TabIndex = 8;
            this.txtPw.WaterMarkColor = System.Drawing.Color.Gray;
            this.txtPw.WaterMarkText = "";
            this.txtPw.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPw_KeyDown);
            // 
            // txtId
            // 
            this.txtId.BhGroupName = null;
            this.txtId.EditValue = "";
            this.txtId.Location = new System.Drawing.Point(126, 51);
            this.txtId.Name = "txtId";
            this.txtId.RequireValueError = null;
            this.txtId.SearchButtonEnable = true;
            this.txtId.SearchButtonVisible = false;
            this.txtId.Size = new System.Drawing.Size(111, 21);
            this.txtId.TabIndex = 6;
            this.txtId.WaterMarkColor = System.Drawing.Color.Gray;
            this.txtId.WaterMarkText = "";
            // 
            // bhLabel2
            // 
            this.bhLabel2.AutoSize = true;
            this.bhLabel2.BackColor = System.Drawing.Color.Transparent;
            this.bhLabel2.BhGroupName = "";
            this.bhLabel2.EditValue = "PW";
            this.bhLabel2.IsRequireValue = false;
            this.bhLabel2.Location = new System.Drawing.Point(97, 84);
            this.bhLabel2.Name = "bhLabel2";
            this.bhLabel2.RequireValueError = "";
            this.bhLabel2.Size = new System.Drawing.Size(23, 12);
            this.bhLabel2.TabIndex = 4;
            this.bhLabel2.Text = "PW";
            this.bhLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // bhLabel1
            // 
            this.bhLabel1.AutoSize = true;
            this.bhLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bhLabel1.BhGroupName = "";
            this.bhLabel1.EditValue = "ID";
            this.bhLabel1.IsRequireValue = false;
            this.bhLabel1.Location = new System.Drawing.Point(97, 55);
            this.bhLabel1.Name = "bhLabel1";
            this.bhLabel1.RequireValueError = "";
            this.bhLabel1.Size = new System.Drawing.Size(16, 12);
            this.bhLabel1.TabIndex = 3;
            this.bhLabel1.Text = "ID";
            this.bhLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // bhPictureBox2
            // 
            this.bhPictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.bhPictureBox2.BhGroupName = null;
            this.bhPictureBox2.EditValue = null;
            this.bhPictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("bhPictureBox2.Image")));
            this.bhPictureBox2.ImagePath = null;
            this.bhPictureBox2.Location = new System.Drawing.Point(19, 49);
            this.bhPictureBox2.Name = "bhPictureBox2";
            this.bhPictureBox2.RequireValueError = null;
            this.bhPictureBox2.Size = new System.Drawing.Size(57, 55);
            this.bhPictureBox2.TabIndex = 1;
            this.bhPictureBox2.TabStop = false;
            // 
            // bhPictureBox1
            // 
            this.bhPictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.bhPictureBox1.BhGroupName = null;
            this.bhPictureBox1.EditValue = null;
            this.bhPictureBox1.Image = global::BH_Calendar.Properties.Resources.DrawingPin2_Blue;
            this.bhPictureBox1.ImagePath = null;
            this.bhPictureBox1.Location = new System.Drawing.Point(110, 8);
            this.bhPictureBox1.Name = "bhPictureBox1";
            this.bhPictureBox1.RequireValueError = null;
            this.bhPictureBox1.Size = new System.Drawing.Size(28, 27);
            this.bhPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.bhPictureBox1.TabIndex = 13;
            this.bhPictureBox1.TabStop = false;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(249, 182);
            this.Controls.Add(this.bhPictureBox1);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.chkSaveInfo);
            this.Controls.Add(this.chkRegistRun);
            this.Controls.Add(this.txtPw);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.bhLabel2);
            this.Controls.Add(this.bhLabel1);
            this.Controls.Add(this.bhPictureBox2);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLogin";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BH Memo 로그인";
            ((System.ComponentModel.ISupportInitialize)(this.bhPictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bhPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private BH_Core.Controls.Component.BhPictureBox bhPictureBox2;
        private BH_Core.Controls.Component.BhLabel bhLabel1;
        private BH_Core.Controls.Component.BhTextBox txtId;
        private BH_Core.Controls.Component.BhTextBox txtPw;
        private BH_Core.Controls.Component.BhLabel bhLabel2;
        private BH_Core.Controls.Component.BhCheckBox chkRegistRun;
        private BH_Core.Controls.Component.BhCheckBox chkSaveInfo;
        private BH_Core.Controls.Component.BhButton btnClose;
        private BH_Core.Controls.Component.BhButton btnLogin;
        private BH_Core.Controls.Component.BhPictureBox bhPictureBox1;
    }
}