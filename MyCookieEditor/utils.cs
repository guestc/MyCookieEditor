using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json;
namespace MyCookieEditor
{
    public class utils
    {
        public static List<MyCookie> getCookiesFromJson(string json)
        {
            try
            {
                List<MyCookie> cks = new List<MyCookie>();
                var cks_ar = JsonConvert.DeserializeObject<MyCookie[]>(json);
                foreach (var ck in cks_ar)
                {
                    cks.Add(ck);
                }
                return cks;
            }
            catch (Exception e)
            {
                MessageBox.Show(string.Format("Json input data Error\n{0}", e.Message));
                return null;
            }
        }

        public static List<MyCookie> getCookiesFromRaw(string raw) {
            try
            {
                List<MyCookie> cks = new List<MyCookie>();
                foreach (string a in raw.Split(new String[] { "; " }, StringSplitOptions.None)) {
                    string[] cache = a.Split('=');
                    cks.Add(new MyCookie(cache[0], cache[1]));
                }
                return cks;
            }
            catch (Exception e) {
                MessageBox.Show(string.Format("Raw input data Error\n{0}",e.Message));
                return null;
            }
        }

        public static string getRawFromCookies(List<MyCookie> cks) {
            try
            {
                StringBuilder sb = new StringBuilder();
                foreach (MyCookie ck in cks)
                {
                    if (sb.Length > 0)
                    {
                        sb.Append("; ");
                    }
                    sb.Append(String.Format("{0}={1}", ck.name, ck.value));
                }
                return sb.ToString();
            }
            catch (Exception e) {
                MessageBox.Show(string.Format("Raw output data Error\n{0}", e.Message));
                return null;
            }
        }

        public static string getJsonFromCookies(List<MyCookie> cks)
        {
            try
            {
                return JsonConvert.SerializeObject(cks.ToArray());
            }
            catch (Exception e)
            {
                MessageBox.Show(string.Format("Json output data Error\n{0}", e.Message));
                return null;
            }
        }
    }
    public class MyCookie
    {

        public string domain { get; set; }

        public string expirationDate { get; set; }

        public bool hostOnly { get; set; }

        public bool httpOnly { get; set; }

        public string name { get; set; }

        public string path { get; set; }

        public string sameSite { get; set; }

        public bool secure { get; set; }

        public bool session { get; set; }

        public string storeId { get; set; }

        public string value { get; set; }
        void clear() {
            domain = "";
            expirationDate = "0";
            hostOnly = false;
            httpOnly = false;
            name = "";
            path = "/";
            sameSite = "";
            secure = false;
            session = false;
            storeId = "0";
            value = "";
        }
        public MyCookie(string _name, string _value) {
            clear();
            name = _name;
            value = _value;
        }
    }
}
