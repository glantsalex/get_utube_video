using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ytDdownloader
{
    class utVideoData
    {
        private string m_id = string.Empty;
        private string m_title = string.Empty;
        private readonly IDictionary<string, string> formatsToUrlsMap = new Dictionary<string, string>();

        public utVideoData( string id  )
        {
            m_id = id;
        }

        public string Title
        {
            set { m_title = value; }
            get { return m_title; }
        }
        public List<string> getFormats()
        {
            return formatsToUrlsMap.Keys.ToList();
        }

        public void add(string format, string url )
        {
            if (!formatsToUrlsMap.ContainsKey( format ))
                formatsToUrlsMap.Add( format,url );
        }

        public string this[string format]
        {
            get { return formatsToUrlsMap[format]; }
        }
    }
}
