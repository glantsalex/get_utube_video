using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace yt_test
{
    class Program
    {
        static void Main(string[] args)
        {
            WebRequest wr = WebRequest.Create(@"http://www.youtube.com/get_video_info?video_id=tFVWjh8zyS8");
            var response = wr.GetResponse();

            var responseData = new StreamReader(response.GetResponseStream()).ReadToEnd();
            var videoInfo = HttpUtility.HtmlDecode(responseData);
            NameValueCollection videoParams = HttpUtility.ParseQueryString(videoInfo); 

            string[] videoURLs = videoParams["url_encoded_fmt_stream_map"].Split(',');
            List<Tuple<string, string>> listOfUrls = new List<Tuple<string, string>>();
            foreach (string vURL in videoURLs)
            {
                string sURL = HttpUtility.HtmlDecode(vURL);
 
                NameValueCollection urlParams = HttpUtility.ParseQueryString(sURL);
                string videoFormat = HttpUtility.HtmlDecode(urlParams["type"]);
 
                sURL = HttpUtility.HtmlDecode(urlParams["url"]);
                sURL += "&signature=" + HttpUtility.HtmlDecode(urlParams["sig"]);
                sURL += "&type=" + videoFormat;
                sURL += "&title=" + HttpUtility.HtmlDecode(videoParams["title"]);
                videoFormat = urlParams["quality"] + " - " + videoFormat.Split(';')[0].Split('/')[1];

                listOfUrls.Add(new Tuple<string, string>(videoFormat,sURL ));
            }
            
            WebClient webClient = new WebClient();
            webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(Completed);
            
            webClient.DownloadFileAsync(new Uri(sURL), sFilePath); 
        }
    }
}
