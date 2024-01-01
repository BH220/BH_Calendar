using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BH_Core;
using BH_Core.SessionInfo;
using BH_Calendar.Data.Event.Group;
using BH_Library.Utils;
using BH_Core.Controls.BhCalrendar;
using BH_Library.Utils.Log.BhLogger;
using BH_Library.Utils.Log;

namespace BH_Calendar.Event.Group
{
    [DefaultEvent("SelectGroupChangeEvent")]
    public partial class ctlEventGroup : UserControl
    {
        public delegate void SelectGroupChangeEventHandler(object sender, List<GroupModel> groupCodes);
        public event SelectGroupChangeEventHandler SelectGroupChangeEvent;

        public ctlEventGroup()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            InitGrid();
        }

        private void InitGrid()
        {
            bhGrid.RowHeadersVisible = false;
            bhGrid.SetPopupMenuVisible(PopupMenuTypeValue.엑셀, false);
            bhGrid.SetPopupMenuVisible(PopupMenuTypeValue.인쇄, false);
            bhGrid.SetPopupMenuVisible(PopupMenuTypeValue.복사, false);
            bhGrid.AddCheckColumn();
            bhGrid.AddColumn("코드", "CD_GROUP", 50, FieldType.Text, FieldAlign.Center, true);
            bhGrid.AddColumn("색상", "CD_RGB_EX", 40, FieldType.Text, FieldAlign.Near, true);
            bhGrid.AddColumn("내용", "NM_GROUP", 100, FieldType.Text, FieldAlign.Near, false);
            bhGrid.CellFormatting += BhGrid_CellFormatting; 
            bhGrid.CheckedChangedEvent += BhGrid_CheckedChangedEvent;
            bhGrid.PopupMenuClick += BhGrid_PopupMenuClick;
        }

        private void BhGrid_PopupMenuClick(PopupMenuTypeValue PopupMenuType)
        {
            string cd_group = null;
            DataRow row = bhGrid.GetFocusedDataRow();

            if (row != null) cd_group = row["CD_GROUP"].ToStringEx();
            else
            {
                if(PopupMenuType == PopupMenuTypeValue.수정 || PopupMenuType == PopupMenuTypeValue.삭제)
                {
                    BhMsgBox.Warning(PopupMenuType.ToStringEx() + "할 데이터가 선택되지 않았습니다.");
                    return;
                }
            }


            if (PopupMenuType == PopupMenuTypeValue.추가 || PopupMenuType == PopupMenuTypeValue.수정)
            {
                if (PopupMenuType == PopupMenuTypeValue.수정)
                    cd_group = row["CD_GROUP"].ToStringEx();
                using (frmGroupInfo frm = new frmGroupInfo())
                {
                    frm.CD_GROUP = cd_group;
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        LoadEventGroup();
                    }
                }
            }
            else if(PopupMenuType == PopupMenuTypeValue.삭제)
            {
                string errMsg = SqlManager.CHECK_DELETE_GROUP(cd_group);
                if (string.IsNullOrEmpty(errMsg))
                {
                    if (Common.DeleteConfirm())
                    {
                        if (SqlManager.DELETE_GROUP(cd_group))
                            LoadEventGroup();
                    }
                }
                else
                {
                    BhMsgBox.Error(errMsg);
                }
            }
        }

        private void BhGrid_CheckedChangedEvent(object sender, BhGridCheckedChangedArgs args)
        {
            if (SelectGroupChangeEvent != null && bhGrid.GetFocusedDataRow() != null)
                SelectGroupChangeEvent(sender, GetSelectedGroupCodes());
        }

        private void BhGrid_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            string fieldName = bhGrid.Columns[e.ColumnIndex].DataPropertyName;
            switch (fieldName)
            {
                case "CD_RGB_EX":
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

        public void LoadEventGroup()
        {
            DataTable dt = SqlManager.LoadEventGroup(); 
            bhGrid.SetDataSource(dt);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            bhGrid.SearchText(txtSearch.Text);
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
                btnSearch_Click(null, null);
        }

        private void chkAll_CheckedChanged(object sender, EventArgs e)
        {
            DataTable dt = bhGrid.GetDataSource();
            foreach(DataRow row in dt.Rows)
            {
                row[dt.Columns.Count - 1] = chkAll.Checked ? "True" : "False";
            }
            bhGrid.SetDataSource(dt);
        }

        public List<GroupModel> GetSelectedGroupCodes()
        {
            List<GroupModel> groupCodes = new List<GroupModel>();
            GroupModel gm = null;
            DataTable dt = bhGrid.GetDataSource();
            foreach (DataRow row in dt.Rows)
            {
                if (row[bhGrid.CheckColDefualtName].ToStringEx() == "True")
                {
                    gm = new GroupModel()
                    {
                        GroupCode = row["CD_GROUP"].ToStringEx(),
                        GroupName = row["NM_GROUP"].ToStringEx()
                    };
                    groupCodes.Add(gm);
                }
            }
            return groupCodes;
        }
    }
}
