using BH_Core.DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace BH_Calendar.Data
{
    public class DbConn
    {
        public static void SetDbConnection()
        {
            DataBaseSettingInfo.Instance.ReadInfor();
            DataBaseSettingInfo.Instance.SqlIp = "127.0.0.1";
            DataBaseSettingInfo.Instance.SqlPort = "1234";
            DataBaseSettingInfo.Instance.SqlPassword = "bhzkfpsek!@#";
            DataBaseSettingInfo.Instance.SqlService = "BHDB_SERVER";
            DataBaseSettingInfo.Instance.SqlId = "CalendarUser";
            DataBaseSettingInfo.Instance.SqlDataBase = "BH_Calendar";
            DataBaseConnection dbc = new DataBaseConnection();
            dbc.IsJustConnected(DataBaseSettingInfo.Instance.SqlIp, DataBaseSettingInfo.Instance.SqlService, DataBaseSettingInfo.Instance.SqlPort, DataBaseSettingInfo.Instance.SqlId, DataBaseSettingInfo.Instance.SqlPassword, DataBaseSettingInfo.Instance.SqlDataBase);
        }
    }
}
