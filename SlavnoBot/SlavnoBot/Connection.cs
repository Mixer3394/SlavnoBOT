using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace SlavnoBot
{
    public class Connection
    {
        public static string connectionXml(string url)
        {
            try
            {
                using (var client = new WebClient())
                {
                    var data = client.DownloadString(url);
                    return data;
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
