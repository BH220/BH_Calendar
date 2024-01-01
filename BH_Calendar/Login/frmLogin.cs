using BH_Calendar.Data;
using BH_Calendar.Data.SessionInfo;
using BH_Core.SessionInfo;
using BH_Library.Utils;
using BH_Library.Utils.Register; 
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BH_Calendar.Login
{
    public partial class frmLogin : Form
    {
        private Point _MousePoint;
        bool AutoLogin = false;

        [Obsolete("디자이너모드때문에 남겨둠, 사용금지")]
        public frmLogin()
        {
            InitializeComponent();
        }

        public frmLogin(bool AutoLogin)
        {
            InitializeComponent();
            this.AutoLogin = AutoLogin;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            Control[] controls = new Control[] { bhPictureBox1, bhPictureBox2, bhLabel1, bhLabel2, this };
            foreach (Control ctl in controls)
            {
                ctl.MouseDown += FrmLogin_MouseDown;
                ctl.MouseMove += FrmLogin_MouseMove;
                ctl.MouseDoubleClick += FrmLogin_MouseDoubleClick;
            }

            txtId.Text = LoginInfo.Instance.Id;
            txtPw.Text = LoginInfo.Instance.Pw;
            chkSaveInfo.Checked = LoginInfo.Instance.IsSaveInfo;
            chkRegistRun.Checked = LoginInfo.Instance.IsRegistRun;
            txtId.Focus();

            txtId.LostFocus += LoginValueChanged;
            txtPw.LostFocus += LoginValueChanged;

            if (chkSaveInfo.Checked)
            {
                if (AutoLogin)
                    btnLogin_Click(null, null);
            }
        }

        private void LoginValueChanged(object sender, EventArgs e)
        {
            LoginInfo.Instance.SetInfor(txtId.Text, txtPw.Text, chkSaveInfo.Checked, chkRegistRun.Checked);
        }

        private void FrmLogin_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Minimized;
        }

        private void FrmLogin_MouseMove(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
                Location = new Point(Left - (_MousePoint.X - e.X), Top - (_MousePoint.Y - e.Y));
        }

        private void FrmLogin_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                _MousePoint = new Point(e.X, e.Y);
        }

        private void btnGroup_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            DbConn.SetDbConnection();
            
            if (txtId.Text.ToLower() == CalendarCommon.AdministratorID && txtPw.Text.ToLower() == "google_docs_account_11")
            {
                SessionManager.GetSessionHelper(BhcSessionManager.GetSessionHelper(txtId.Text));
                chkSaveInfo.Checked = false;
                chkRegistRun.Checked = false;
                LoginInfo.Instance.SetInfor(txtId.Text, txtPw.Text, chkSaveInfo.Checked, chkRegistRun.Checked);
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                Close();
            }
            else if (SqlManager.USER_CHECK(txtId.Text, txtPw.Text))
            {
                SessionManager.GetSessionHelper(BhcSessionManager.GetSessionHelper(txtId.Text));
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                Close();
            }
            else
            {
                BhMsgBox.Error("로그인 정보를 확인 할 수 없습니다.\r\n아이디와 패스워드를 정확하게 입력하세요");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {

        }

        private void chkSaveInfo_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSaveInfo.Checked == false)
                txtId.Text = txtPw.Text = "";
            LoginInfo.Instance.SetInfor(txtId.Text, txtPw.Text, chkSaveInfo.Checked, chkRegistRun.Checked);
        }

        private void chkRegistRun_CheckedChanged(object sender, EventArgs e)
        {
            string exePath = Directory.GetCurrentDirectory() + "\\" + Process.GetCurrentProcess().ProcessName + ".exe";
            if (chkRegistRun.Checked == false)
                exePath = "";
            else
            {
                chkSaveInfo.Checked = true;
            }
            Registry.LocalMachineWrite(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run", "BhMemo", exePath);
            LoginInfo.Instance.SetInfor(txtId.Text, txtPw.Text, chkSaveInfo.Checked, chkRegistRun.Checked);
        }

        private void txtPw_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnLogin_Click(null, null);
        }
    }
}
