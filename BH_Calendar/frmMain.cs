using BH_Calendar.Data.Event.Group;
using BH_Core.Controls.BhCalrendar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BH_Calendar
{
    public partial class frmMain : RootForm
    {
        #region 이벤트, 델리게이트
        #endregion

        #region 변수
        #endregion

        #region 생성자
        public frmMain()
        {
            InitializeComponent();
        }
        #endregion

        #region 초기화 오버라이드
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            LoadEventGroup();
        }
        #endregion

        #region 데이터 조회/수정/삭제
        private void LoadEventGroup()
        {
            ctlEventGroup1.LoadEventGroup();
        }

        #endregion

        #region 클릭이벤트
        #endregion

        #region 기타이벤트
        private void splitContainer2_SplitterMoving(object sender, SplitterCancelEventArgs e)
        {
            bhCalendar.Refresh();
        }

        private void ctlEventGroup1_SelectGroupChangeEvent(object sender, List<GroupModel> groupCodes)
        {
            List<IEvent> listEvent = SqlManager.GetEventList(groupCodes.Select(x=>x.GroupCode).ToList());
            bhCalendar.SetEvent(listEvent);
        }

        private void bhCalendar_DateSelectChangedEvent(object sender, BH_Core.DateSelectChangedArgument e)
        {
            List<GroupModel> groups = ctlEventGroup1.GetSelectedGroupCodes();
            bhEventViwer1.LoadEvent(e.SelectedDate, groups.Select(x => x.GroupCode).ToList());
        }
        #endregion

        #region 사용자함수
        #endregion

    }
}
