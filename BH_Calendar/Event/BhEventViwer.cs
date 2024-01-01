using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BH_Library.Utils;
using BH_Core;
using BH_Calendar.Event;
using BH_Calendar.Data.Event;

namespace BhCalrendar.Event
{
    public partial class BhEventViwer : UserControl
    {
        public DateTime SelectDate { get; set; }
        List<string> GroupCodes { get; set; }

        public BhEventViwer()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            InitGrid();
            base.OnLoad(e);
        }

        private void InitGrid()
        {
            bhGrid.SetPopupMenuVisible(PopupMenuTypeValue.복사, false);
            bhGrid.SetPopupMenuVisible(PopupMenuTypeValue.엑셀, false);
            bhGrid.SetPopupMenuVisible(PopupMenuTypeValue.인쇄, false);
            bhGrid.AddColumn("시작", "DT_START", 100, FieldType.Text, FieldAlign.Near, true);
            bhGrid.AddColumn("종료", "DT_END", 100, FieldType.Text, FieldAlign.Near, true);
            bhGrid.AddColumn("그룹", "NM_GROUP", 50, FieldType.ShortDate, FieldAlign.Center, true);
            bhGrid.AddColumn("색상", "GROUP_COLOR", 40, FieldType.Text, FieldAlign.Near, true);
            bhGrid.AddColumn("이벤트명", "NM_EVENT", 250, FieldType.Number, FieldAlign.Far, true);
            bhGrid.AddColumn("비고", "TXT_DESC", 70, FieldType.Money, FieldAlign.Far,false);
            bhGrid.CellFormatting += BhGrid_CellFormatting; 
            bhGrid.PopupMenuClick += BhGrid_PopupMenuClick;
        }

        private void BhGrid_PopupMenuClick(PopupMenuTypeValue PopupMenuType)
        {
            int sq_event = -1;
            DataRow row = bhGrid.GetFocusedDataRow();

            if (row != null) sq_event = row["SQ_EVENT"].ToIntEx();
            else
            {
                if (PopupMenuType == PopupMenuTypeValue.수정 || PopupMenuType == PopupMenuTypeValue.삭제)
                {
                    BhMsgBox.Warning(PopupMenuType.ToStringEx() + "할 데이터가 선택되지 않았습니다.");
                    return;
                }
            }


            if (PopupMenuType == PopupMenuTypeValue.추가 || PopupMenuType == PopupMenuTypeValue.수정)
            {
                if (PopupMenuType == PopupMenuTypeValue.수정)
                    sq_event = row["SQ_EVENT"].ToIntEx();
                using (frmEventInfo frm = new frmEventInfo())
                {
                    frm.SQ_EVENT = sq_event;
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        LoadEvent(SelectDate, GroupCodes);
                    }
                }
            }
            else if (PopupMenuType == PopupMenuTypeValue.삭제)
            {
                string errMsg = SqlManager.CHECK_DELETE_EVENT(sq_event);
                if (string.IsNullOrEmpty(errMsg))
                {
                    if (Common.DeleteConfirm())
                    {
                        if (SqlManager.DELETE_EVENT(sq_event))
                            LoadEvent(SelectDate, GroupCodes);
                    }
                }
                else
                {
                    BhMsgBox.Error(errMsg);
                }
            }
        } 

        private void BhGrid_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            string fieldName = bhGrid.Columns[e.ColumnIndex].DataPropertyName;
            switch (fieldName)
            {
                case "GROUP_COLOR":
                    string strValue = bhGrid.Rows[e.RowIndex].Cells["CD_RGB"].Value.ToStringEx();
                    if (strValue == "-1")
                    {
                        e.CellStyle.BackColor =
                        e.CellStyle.ForeColor =
                        e.CellStyle.SelectionBackColor =
                        e.CellStyle.SelectionForeColor = SystemColors.Control;
                    }
                    else
                    {
                        var tmp = strValue.Split(new char[] { ',' });
                        if (tmp.Length >= 3)
                        {
                            e.CellStyle.BackColor =
                            e.CellStyle.ForeColor =
                            e.CellStyle.SelectionBackColor =
                            e.CellStyle.SelectionForeColor = Color.FromArgb(tmp[0].ToIntEx(), tmp[1].ToIntEx(), tmp[2].ToIntEx());
                        }
                    }
                    break;
            }
        }

        public void LoadEvent(DateTime selectDate, List<string> groupCodes)
        {
            DataTable dt = SqlManager.LoadEvent(selectDate, groupCodes);
            bhGrid.SetDataSource(dt);
        }

        private void bhSearchBox1_SearchEvent(object sender, SearchDataEventAgrs e)
        {
            bhGrid.SearchText(e.SearchText);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }

        private void btnDel_Click(object sender, EventArgs e)
        {

        }
    }
}
