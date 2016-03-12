using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace ytDdownloader
{
    class ytProvider
    {
        private utVideoData m_videoData = null;

        public Tuple<string,List<string>> getVideoFormats(string videoId)
        {
            m_videoData = new utVideoData( videoId );

            WebRequest wr = WebRequest.Create(@"http://www.youtube.com/get_video_info?video_id=" + videoId);
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

                m_videoData.add( videoFormat, sURL );
            }
            m_videoData.Title = videoParams["title"];
            return new Tuple<string,List<string>>(videoId, m_videoData.getFormats());
        }

        public void downloadVideo(string videoId, string format, Action completionCallback)
        {
            string url = m_videoData[format];

            WebClient webClient = new WebClient();
            webClient.DownloadFileCompleted += (sender,e ) => 
            {
                completionCallback();

            };

            var filePath = Path.Combine( @"d:\", m_videoData.Title) + "." + format;
            webClient.DownloadFileAsync(new Uri(url), filePath); 
        }
 
    }
}
