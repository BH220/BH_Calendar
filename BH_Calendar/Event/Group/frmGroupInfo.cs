using BH_Calendar.Data.Event.Group;
using BH_Calendar.Properties;
using BH_Core;
using BH_Core.Forms;
using BH_Core.Util;
using BH_DbConnect.Interface;
using BH_Library.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BH_Calendar.Event.Group
{
    public partial class frmGroupInfo : BhSaveForm
    {
        #region 이벤트,델리게이트
        #endregion

        #region 변수, 프로퍼티 
        public string CD_GROUP = null;
        #endregion

        #region 생성자
        public frmGroupInfo()
        {
            InitializeComponent();
        }
        #endregion

        #region 초기화 오버라이드
        protected override void OnLoad(EventArgs e)
        {
            this.Icon = Resources.MainIcon;
            base.OnLoad(e);
            InitControl();
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
#if DEBUG
            pdpCD_RGB.Visible = true;
#endif
            pdpCD_GROUP.Focus();
        }

        private void InitControl()
        {
            List<Control> ctls = new List<Control>();
            foreach (Control ctl in bhPanel1.Controls)
            {
                if (ctl.Name.StartsWith("pdp"))
                {
                    ctls.Add(ctl);
                }
            }
            this.OnSetResetTargetControl(ctls.ToArray());
            LoadData();
        }
        #endregion

        #region 데이터 로드,저장,수정
        private void LoadData()
        {
            if (string.IsNullOrEmpty(CD_GROUP))
            { //데이터 추가
                Text = "그룹 정보 추가";
                pdpCD_GROUP.ReadOnly = false;
                pdpCD_GROUP.Focus();
            }
            else
            {//데이터 수정
                DataRow row = SqlManager.SELECT_GROUP(CD_GROUP);
                if (row == null)
                {
                    BhMsgBox.Error("그룹 정보를 불러오는데 실패 하엿습니다.");
                    return;
                }
                Utility.SetDataOnFormFromDataRow(this, row);
                Text = "그룹 정보 수정";
                pdpCD_GROUP.ReadOnly = true;
                pdpNM_GROUP.Focus();
            }
        }

        protected override bool OnSaveData(object sender = null, bool isSave = true, bool isRefresh = true)
        {
            if (this.IsFillOnRequireValue() == false)
                return false;
            IBhCommandResult ibResult = null;
            try
            {
                if (string.IsNullOrEmpty(CD_GROUP))
                {//인서트
                    DataRow row = this.GetParamRow(this, ParamType.Insert);
                    if (EnableInsert(row) == false) return false;
                    ibResult = SqlManager.INSERT_GROUP(row);
                }
                else
                {//업데이트
                    DataRow row = this.GetParamRow(this, ParamType.Update);
                    ibResult = SqlManager.UPDATE_GROUP(row);
                }
                base.OnSaveData(this, isSave, isRefresh);
                return ibResult.CommandResult;
            }
            catch (Exception ex)
            {
                isSave = false;
                Console.WriteLine(ex.Message);
            }
            return false;
        }

        public static bool EnableInsert(DataRow row)
        {
            string errMsg = "";
            if (string.IsNullOrEmpty(errMsg) == false)
            {
                BhMsgBox.Error(errMsg);
                return false;
            }
            return true;
        }
        #endregion

        #region 기타이벤트
        #endregion

        #region 버튼이벤트

        private void btnColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                pdpCD_RGB.Text = string.Format("{0},{1},{2}", colorDialog1.Color.R, colorDialog1.Color.G, colorDialog1.Color.B);
                txtNM_COLOR.BackColor = colorDialog1.Color;
                string name= pdpCD_RGB.Text;
                foreach (KnownColor kc in Enum.GetValues(typeof(KnownColor)))
                {
                    Color known = Color.FromKnownColor(kc);
                    if (colorDialog1.Color.ToArgb() == known.ToArgb())
                    {
                        name = known.Name;
                        break;// comes immediately out of loop
                    }
                }
                txtNM_COLOR.Text = name;
            }
        }

        protected override void OnContinueBtnClick()
        {
            if (OnSaveData())
            {
                this.ResetControl(pdpCD_GROUP);
            }
        }

        protected override void OnSaveBtnClick()
        {
            if (OnSaveData())
            {
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                Close();
            }
        }

        protected override bool OnCloseBtnClick()
        {
            this.DialogResult = System.Windows.Forms.DialogResult.No;
            return true;
        }


        #endregion

        #region 사용자함수

        #endregion
    }
}
