using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeDataAnalyzerApp.Model
{
    class DataLoader
    {
        public string[] LoadFromWebsite()
        {
            string url = ConfigurationManager.AppSettings["Url"].ToString();

            HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);
            HttpWebResponse resp = (HttpWebResponse)req.GetResponse();

            StreamReader stream = new StreamReader(resp.GetResponseStream());
            string result = stream.ReadToEnd();
            stream.Close();

            return result.Split('\n');
        }

        public string[] LoadFromDisk()
        {
            string filePath = ConfigurationManager.AppSettings["DataFile"].ToString();
            string fileText = File.ReadAllText(filePath);

            string[] lines = fileText.Split('\n');

            return lines;
        }
    }
}
