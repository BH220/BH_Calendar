using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BH_Calendar.Data.Event.Group
{
    public class GroupModel
    {
        public string GroupCode { get; set; }
        public string GroupName { get; set; }
        public string GroupNameEx
        {
            get
            {
                return string.Format("[{0}]{1}", GroupCode, GroupName);
            }
        }
    }
}
