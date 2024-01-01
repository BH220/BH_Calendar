using BH_Core.Controls.BhCalrendar;
using BH_Core.SessionInfo;
using BH_DbConnect.Command;
using BH_DbConnect.Connection;
using BH_DbConnect.Interface;
using BH_Library.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BH_Calendar.Data.Event
{
    public static class SqlManager
    {
        public static string CHECK_DELETE_EVENT(int SQ_EVENT)
        {
            string result = null;

            return result;
        }

        public static bool DELETE_EVENT(int SQ_EVENT)
        {
            IBhCommandResult bhCommandResult = null;
            using (IBhCommandContext bhCommandContext = BhCommandManager.GetCommandContext())
            {
                bhCommandContext.CommandText = @"UPDATE 
                                                     EventInfo
                                                 SET	
                                                      FL_DELETE = '1'
                                                     ,ID_DELETE = @ID_DELETE
                                                     ,DT_DELETE = GETDATE()
                                                 WHERE 
	                                                 SQ_EVENT = @SQ_EVENT";
                bhCommandContext.AddParameter("@ID_DELETE", SessionManager.UserId);
                bhCommandContext.AddParameter("@CD_GROUP", SQ_EVENT);
                bhCommandResult = BhCommandManager.ExecuteNonQuery(BhConnectionManager.GetConnectionContext(), bhCommandContext);
                return bhCommandResult.CommandResult;
            }
        }

        public static DataTable LoadEvent(DateTime selectDate, List<string> groupCodes)
        {
            DataTable dt = new DataTable();

            IBhCommandResult bhCommandResult = null;
            using (IBhCommandContext bhCommandContext = BhCommandManager.GetCommandContext())
            {
                string queryFat = @"SELECT
                                        e.SQ_EVENT, 
                                        ,e.CD_GROUP, 
                                        ,g.NM_GROUP
                                        ,e.NM_EVENT, 
                                        ,e.TXT_DESC, 
                                        ,e.DT_START, 
                                        ,e.DT_END, 
                                        ,e.TY_ALLDAY, 
                                        ,e.TXT_NOTE, 
                                        ,g.CD_RGB
                                        ,e.ID_INSERT, 
                                        ,e.DT_INSERT, 
                                        ,e.ID_UPDATE, 
                                        ,e.DT_UPDATE
                                    FROM 
                                        EventInfo as e
                                        LEFT JOIN 
                                        EventGroupInfo as g
                                        ON e.CD_GROUP IN ({0})
                                    WHERE 
                                        ISNULL(FL_DELETE,'0') = '0'
                                        AND g.ID_USER = @ID_USER
                                        AND   (DT_START BETWEEN @DT_START_START AND @DT_START_END OR 
                                            DT_END BETWEEN @DT_START_START AND @DT_START_END
                                    ORDER BY 
                                        e.DT_START";
                string addQuery = "";
                foreach(string gCode in groupCodes)
                {
                    addQuery += string.Format("'{0}',", gCode.Trim());
                }
                if (addQuery.Length <= 0)
                    addQuery = "''";
                else
                    addQuery = addQuery.Substring(0, addQuery.Length - 1);
                bhCommandContext.CommandText = string.Format(queryFat, addQuery);
                bhCommandContext.AddParameter("@ID_USER", SessionManager.UserId);
                bhCommandContext.AddParameter("@DT_START_START", selectDate.ToString("yyyy-MM-dd") + " 00:00:00");
                bhCommandContext.AddParameter("@DT_START_END", selectDate.ToString("yyyy-MM-dd") + " 23:59:59");
                bhCommandResult = BhCommandManager.ExecuteQuery(BhConnectionManager.GetConnectionContext(), bhCommandContext);
                if (bhCommandResult.CommandResult)
                {
                    return bhCommandResult.ResultQuery.Tables[0];
                }
                else
                    return new DataTable();
            }
        }
    }
} 