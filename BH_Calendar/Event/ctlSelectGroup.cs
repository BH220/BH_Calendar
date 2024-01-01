using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BH_Core.Controls.Component;
using BH_Calendar.Data.Event.Group;

namespace BH_Calendar.Event
{
    [DefaultEvent("SelectedGroupEvent")]
    public partial class ctlSelectGroup : BhComboBox
    {
        public delegate void SelectedGroupEventHandler(object sender, GroupModel groupData);
        public event SelectedGroupEventHandler SelectedGroupEvent;

        List<GroupModel> GroupCodes = new List<GroupModel>();
        public ctlSelectGroup()
        {
            InitializeComponent();
            LoadData(null);
        }

        public void LoadData(List<GroupModel> groups)
        {
            this.Items.Clear();
            GroupCodes = groups;
            this.Items.Add("그룹을 선택하세요");
            if (groups == null) return;
            if (groups.Count <= 0) return;
            foreach (var code in groups)
            {
                Items.Add(code.GroupNameEx);
            }
        }

        private void ctlSelectGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            GroupModel gm = new GroupModel();
            if (this.SelectedIndex > 0) gm = GroupCodes[this.SelectedIndex - 1];
            SelectedGroupEvent?.Invoke(null, gm);
        }
    }
}
