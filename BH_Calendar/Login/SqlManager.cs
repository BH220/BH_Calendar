using BH_DbConnect.Command;
using BH_DbConnect.Connection;
using BH_DbConnect.Interface;
using BH_Library.Utils;

namespace BH_Calendar.Login
{
    internal class SqlManager
    {
        public static bool USER_CHECK(string id, string pw)
        {
            bool result = false;

            IBhCommandResult bhCommandResult = null;
            using (IBhCommandContext bhCommandContext = BhCommandManager.GetCommandContext())
            {
                bhCommandContext.CommandText = "SELECT COUNT(*) FROM UserInfo WHERE ID_USER = @ID_USER AND PW_USER = @PW_USER";
                bhCommandContext.AddParameter("@ID_USER", id);
                bhCommandContext.AddParameter("@PW_USER", pw);
                bhCommandResult = BhCommandManager.ExecuteScala(BhConnectionManager.GetConnectionContext(), bhCommandContext);
                if (bhCommandResult.CommandResult)
                {
                    if (bhCommandResult.ResultScala.ToIntEx() == 1)
                        return true;
                    else
                        return false;
                }
            }
            return result;
        }

        public static IBhCommandResult UPDATE_USER(string userId, string pw, string name, string tel, string email)
        {
            IBhCommandResult bhCommandResult = null;
            using (IBhCommandContext bhCommandContext = BhCommandManager.GetCommandContext())
            {
                bhCommandContext.CommandText = @"UPDATE 
                                                     UserInfo
                                                 SET
                                                      PW_USER=@PW_USER
                                                     ,NM_USER=@NM_USER 
                                                 WHERE 
                                                     ID_USER = @ID_USER";
                bhCommandContext.AddParameter("@ID_USER", userId);
                bhCommandContext.AddParameter("@PW_USER", pw);
                bhCommandContext.AddParameter("@NM_USER", name);
                bhCommandContext.AddParameter("@NO_TEL", tel);
                bhCommandContext.AddParameter("@TXT_EMAIL", email);
                bhCommandResult = BhCommandManager.ExecuteNonQuery(BhConnectionManager.GetConnectionContext(), bhCommandContext);
                return bhCommandResult;
            }
        }

        public static bool PASSWORK_CHECK(string id, string pw)
        {
            IBhCommandResult bhCommandResult = null;
            using (IBhCommandContext bhCommandContext = BhCommandManager.GetCommandContext())
            {
                bhCommandContext.CommandText = "SELECT PW_USER FROM UserInfo WHERE ID_USER = @ID_USER";
                bhCommandContext.AddParameter("@ID_USER", id);
                bhCommandResult = BhCommandManager.ExecuteScala(BhConnectionManager.GetConnectionContext(), bhCommandContext);
                if (bhCommandResult.CommandResult)
                {
                    if (bhCommandResult.ResultScala.ToStringEx() == pw)
                        return true;
                    else
                        return false;
                }
            }
            return false;
        }
    }
}