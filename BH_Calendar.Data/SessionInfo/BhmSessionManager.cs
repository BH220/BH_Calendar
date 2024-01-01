using BH_Calendar.Data;
using BH_Core;
using BH_Core.SessionInfo;
using BH_DbConnect.Command;
using BH_DbConnect.Connection;
using BH_DbConnect.Interface;
using BH_Library.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BH_Calendar.Data.SessionInfo
{
    public class BhcSessionManager
    {
        public static SessionModel GetSessionHelper(string userID)
        {
            SessionModel model = new SessionModel();
            BhcSessionManager manager = new BhcSessionManager();
            if (userID.ToLower() == CalendarCommon.AdministratorID)
            {
                //관리자아이디로 접속했음, 정보 안채워도 알아서 코어에서 해줄꺼임
            }
            else
            {
                model.UserModel = manager.GetUserModel(userID);
                model.OptionModel = new OptionInfo();
            }

            return model;
        }

        private SessionModel sessionModel = null;
        public SessionModel SessionModel { get { return sessionModel; } }

        private UserModel GetUserModel(string userId)
        {
            UserModel model = new UserModel();
            IBhCommandResult bhCommandResult = null;
            using (IBhCommandContext bhCommandContext = BhCommandManager.GetCommandContext())
            {
                bhCommandContext.CommandText = "SELECT ID_USER, PW_USER, NM_USER, NO_TEL, TXT_EMAIL FROM UserInfo WHERE ID_USER = @ID_USER";
                bhCommandContext.AddParameter("@ID_USER", userId);
                bhCommandResult = BhCommandManager.ExecuteQuery(BhConnectionManager.GetConnectionContext(), bhCommandContext);
                if (bhCommandResult.CommandResult && bhCommandResult.ResultQuery.Tables[0].Rows.Count > 0)
                {
                    model.UserId = userId;
                    model.UserName = bhCommandResult.ResultQuery.Tables[0].Rows[0]["NM_USER"].ToStringEx();
                    model.UserMobile = bhCommandResult.ResultQuery.Tables[0].Rows[0]["NO_TEL"].ToStringEx();
                    model.UserEmail = bhCommandResult.ResultQuery.Tables[0].Rows[0]["TXT_EMAIL"].ToStringEx();
                    model.IsAdmin = true;
                    model.UserType = UserTypes.관리자;
                }
            }
            return model;
        }
    }
}
