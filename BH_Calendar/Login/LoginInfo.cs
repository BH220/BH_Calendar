using BH_Core.Config;
using BH_Library.Utils;
using BH_Library.Utils.Cryptograph;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BH_Calendar.Login
{
    [JsonObject]
    public class LoginInfo
    {
        private readonly string _fileName;

        private static LoginInfo _instance;

        public static LoginInfo Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new LoginInfo();
                    _instance.ReadInfor();
                }
                return _instance;
            }
        }

        private LoginInfo()
        {
            _fileName = Application.StartupPath + @"\LoginOption.txt";
            this.DefaultValueToProperty();
        }

        public void ReadInfor()
        {
            try
            {
                if (File.Exists(_fileName))
                {
                    string readAllText = AES.Decrypt(File.ReadAllText(_fileName), Config.AES_KEY);
                    JsonConvert.PopulateObject(readAllText, this);
                }
            }
            catch (Exception ex)
            {
                if (File.Exists(_fileName))
                    File.Delete(_fileName);
#if DEBUG
                BhMsgBox.ShowError(ex.Message);
#else
                Console.WriteLine(ex.Message);
#endif
            }
        }

        public void SetInfor(string id, string pw, bool saveInfo, bool registRun)
        {
            Id = id;
            Pw = pw;
            IsSaveInfo = saveInfo;
            IsRegistRun = registRun;
            if (saveInfo == false)
            {
                Id = string.Empty;
                Pw = string.Empty;
            }
            try
            {
                string json = JsonConvert.SerializeObject(this, Formatting.Indented);
                json = AES.Encrypt(json, Config.AES_KEY);
                File.WriteAllText(_fileName, json);
            }
            catch (Exception ex)
            {
#if DEBUG
                BhMsgBox.ShowError(ex.Message);
#else
                Console.WriteLine(ex.Message);
#endif
            }
        }


        [JsonProperty]
        [DefaultValue("")]
        public string Id { get; set; }

        [JsonProperty]
        [DefaultValue("")]
        public string Pw { get; set; } 

        [JsonProperty]
        [DefaultValue(false)]
        public bool IsSaveInfo { get; set; }

        [JsonProperty]
        [DefaultValue(false)]
        public bool IsRegistRun { get; set; }
    }
}
