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

namespace BH_Calendar.Data.Event.Group
{
    public static class SqlManager
    {
        public static DataTable LoadEventGroup()
        {
            DataTable dt = new DataTable();

            IBhCommandResult bhCommandResult = null;
            using (IBhCommandContext bhCommandContext = BhCommandManager.GetCommandContext())
            {
                bhCommandContext.CommandText = @"SELECT CD_GROUP
                                                       ,NM_GROUP
                                                       ,CD_RGB
                                                       ,TXT_NOTE
                                                       ,ID_INSERT
                                                       ,DT_INSERT
                                                       ,ID_UPDATE
                                                       ,DT_UPDATE
                                                 FROM EventGroupInfo
                                                 WHERE 
                                                     ISNULL(FL_DELETE,'0') = '0'
                                                     AND ID_USER = @ID_USER";
                bhCommandContext.AddParameter("@ID_USER", SessionManager.UserId);
                bhCommandResult = BhCommandManager.ExecuteQuery(BhConnectionManager.GetConnectionContext(), bhCommandContext);
                if (bhCommandResult.CommandResult)
                {
                    return bhCommandResult.ResultQuery.Tables[0];
                }
                else
                    return new DataTable();
            }
        }

        public static List<IEvent> GetEventList(List<string> groupCode)
        {
            List<IEvent> result = new List<IEvent>();
            IBhCommandResult bhCommandResult = null;
            using (IBhCommandContext bhCommandContext = BhCommandManager.GetCommandContext())
            {
                string query = @"SELECT 
                                    e.SQ_EVENT, 
                                    e.CD_GROUP, 
	                                g.CD_RGB,
                                    e.NM_EVENT, 
                                    e.TXT_DESC, 
                                    e.DT_START, 
                                    e.DT_END, 
                                    e.TY_ALLDAY, 
                                    e.TXT_NOTE, 
                                    e.ID_INSERT, 
                                    e.DT_INSERT, 
                                    e.ID_UPDATE, 
                                    e.DT_UPDATE
                                FROM 
	                                EventInfo(NOLOCK) AS e
	                                LEFT JOIN 
	                                EventGroupInfo(NOLOCK) as G
	                                ON e.CD_GROUP = g.CD_GROUP
                                WHERE 
                                    ISNULL(e.FL_DELETE,'0') = '0'
                                    AND CD_GROUP IN ({0})";
                string gc = "";
                groupCode.ForEach(x => gc += (x + ","));
                if (gc.Length > 0) gc = gc.Substring(0, gc.Length - 1);
                bhCommandContext.CommandText = string.Format(query, gc);
                bhCommandResult = BhCommandManager.ExecuteQuery(BhConnectionManager.GetConnectionContext(), bhCommandContext);
                if (bhCommandResult.CommandResult)
                {
                    CustomEvent ce = null;
                    foreach (DataRow row in bhCommandResult.ResultQuery.Tables[0].Rows)
                    {
                        ce = new CustomEvent();
                        ce.EventGroupCode = row["CD_GROUP"].ToStringEx();
                        var rgb = row["CD_RGB"].ToStringEx().Split(new char[] { ',' });
                        ce.EventColor = Color.FromArgb(rgb[0].ToIntEx(), rgb[1].ToIntEx(), rgb[2].ToIntEx());
                        ce.Date = row["DT_START"].ToDateTimeEx().Value;
                        ce.EventText = row["NM_EVENT"].ToStringEx();
                        result.Add(ce);
                    }
                } 
                return result;
            }
        }

        public static string CHECK_DELETE_GROUP(string CD_GROUP)
        {
            string result = null;
            IBhCommandResult bhResult = null;
            using (IBhCommandContext bhContext = BhCommandManager.GetCommandContext())
            {
                bhContext.CommandText = @"SELECT
	                                          NM_EVENT
                                          FROM 
	                                          EventInfo(NOLOCK)
                                          WHERE 
	                                          ISNULL(FL_DELETE,'0') = '0'
	                                          AND CD_GROUP = @CD_GROUP
                                          ORDER BY 
	                                          DT_START";
                bhContext.AddParameter("@CD_GROUP", CD_GROUP);
                bhResult = BhCommandManager.ExecuteQuery(BhConnectionManager.GetConnectionContext(), bhContext);
                if(bhResult.CommandResult)
                {
                    if(bhResult.ResultQuery.Tables[0].Rows.Count==1)
                    {
                        result = bhResult.ResultQuery.Tables[0].Rows[0][0].ToStringEx() + "이(가) 있어 삭제 할 수 없습니다";
                    }
                    else if(bhResult.ResultQuery.Tables[0].Rows.Count > 1)
                    {
                        result = string.Format("해당 그룹에는 [{0}]외 {1}건의 자료가 있어 삭제 할 수 없습니다.", bhResult.ResultQuery.Tables[0].Rows[0][0].ToStringEx(), bhResult.ResultQuery.Tables[0].Rows.Count - 1);
                    }
                }
            }
            return result;
        }

        public static bool DELETE_GROUP(string CD_GROUP)
        {
            IBhCommandResult bhCommandResult = null;
            using (IBhCommandContext bhCommandContext = BhCommandManager.GetCommandContext())
            {
                bhCommandContext.CommandText = @"UPDATE 
                                                     EventGroupInfo
                                                 SET	
                                                      FL_DELETE = '1'
                                                     ,ID_DELETE = @ID_DELETE
                                                     ,DT_DELETE = GETDATE()
                                                 WHERE 
	                                                 CD_GROUP = @CD_GROUP";
                bhCommandContext.AddParameter("@ID_DELETE", SessionManager.UserId);
                bhCommandContext.AddParameter("@CD_GROUP", CD_GROUP);
                bhCommandResult = BhCommandManager.ExecuteNonQuery(BhConnectionManager.GetConnectionContext(), bhCommandContext);
                return bhCommandResult.CommandResult;
            }
        }

        public static IBhCommandResult INSERT_GROUP(DataRow row)
        {
            IBhCommandResult bhCommandResult = null;
            using (IBhCommandContext bhCommandContext = BhCommandManager.GetCommandContext())
            {
                bhCommandContext.CommandText = @"INSERT INTO EventGroupInfo (
                                                     CD_GROUP, ID_USER,
                                                     NM_GROUP, CD_RGB, 
                                                     TXT_NOTE, FL_DELETE, 
                                                     ID_INSERT, DT_INSERT)
                                                 VALUES(
                                                     @CD_GROUP, @ID_USER, 
                                                     @NM_GROUP, @CD_RGB, 
                                                     @TXT_NOTE, '0', 
                                                     @ID_INSERT, @DT_INSERT)";
                bhCommandContext.AddParameter(row);
                bhCommandContext.AddParameter("@ID_USER", SessionManager.UserId);
                bhCommandResult = BhCommandManager.ExecuteNonQuery(BhConnectionManager.GetConnectionContext(), bhCommandContext);
                return bhCommandResult;
            }
        }

        public static IBhCommandResult UPDATE_GROUP(DataRow row)
        {
            IBhCommandResult bhCommandResult = null;
            using (IBhCommandContext bhCommandContext = BhCommandManager.GetCommandContext())
            {
                bhCommandContext.CommandText = @"UPDATE EventGroupInfo
                                                 SET CD_GROUP  = @CD_GROUP
                                                     ,NM_GROUP  = @NM_GROUP
                                                     ,CD_RGB    = @CD_RGB
                                                     ,TXT_NOTE  = @TXT_NOTE
                                                     ,ID_UPDATE = @ID_UPDATE
                                                     ,DT_UPDATE = @DT_UPDATE
                                                WHERE 
                                                    ID_USER = @ID_USER
                                                    AND CD_GROUP = @CD_GROUP";
                bhCommandContext.AddParameter("@ID_USER", SessionManager.UserId);
                bhCommandResult = BhCommandManager.ExecuteNonQuery(BhConnectionManager.GetConnectionContext(), bhCommandContext);
                return bhCommandResult;
            }
        }

        public static DataRow SELECT_GROUP(string CD_GROUP)
        {
            IBhCommandResult bhCommandResult = null;
            using (IBhCommandContext bhCommandContext = BhCommandManager.GetCommandContext())
            {
                bhCommandContext.CommandText = @"SELECT TOP 1
                                                    CD_GROUP, ID_USER, NM_GROUP, CD_RGB, 
                                                    TXT_NOTE, FL_DELETE, ID_INSERT, DT_INSERT, 
                                                    ID_UPDATE, DT_UPDATE, ID_DELETE, DT_DELETE
                                                FROM 
                                                    EventGroupInfo(NOLOCK)
                                                WHERE 
                                                    ID_USER = @ID_USER
                                                    AND CD_GROUP = @CD_GROUP";
                bhCommandContext.AddParameter("@ID_USER", SessionManager.UserId);
                bhCommandContext.AddParameter("@CD_GROUP", CD_GROUP);
                bhCommandResult = BhCommandManager.ExecuteQuery(BhConnectionManager.GetConnectionContext(), bhCommandContext);
                if (bhCommandResult.CommandResult)
                {
                    DataTable dt = bhCommandResult.ResultQuery.Tables[0];
                    if (dt.Rows.Count > 0)
                        return dt.Rows[0];
                }
            }
            return null;
        }
    }
}
