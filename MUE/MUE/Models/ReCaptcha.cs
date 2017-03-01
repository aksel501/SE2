using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;

namespace MUE.Models
{


    public class ReCaptcha
    {
        private string m_success;
        [JsonProperty("success")]
        public string Success
        {
            get { return m_success; }
            set { m_success = value; }
        }

        private List<string> m_ErrorCodes;
        [JsonProperty("error-codes")]
        public List<string> ErrorCodes
        {
            get { return m_ErrorCodes; }
            set { m_ErrorCodes = value; }

        }

        public static string Validate(string EncodedResponse)
        {
            var client = new System.Net.WebClient();
            string PrivateKey = "6LeLbRYUAAAAAF1hI8AseIrwFpxkGpjPapEqjhpk";
            var reply = client.DownloadString(string.Format("https://www.google.com/recaptchasiteverify?secret={0}&response={1}", PrivateKey, EncodedResponse));
            var captchaRespoonse = JsonConvert.DeserializeObject<ReCaptcha>(reply);
            return captchaRespoonse.Success;
        }
    }
}