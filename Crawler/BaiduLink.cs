using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Web;

namespace Crawler
{
    class BaiduLink
    {
        private string keyword="";
        private string z="0", width="", height = "";
        private int lm = -100;
        private int st=-100,face=-100,s=-100;
        public void setKeyword(string keyword)
        {
            this.keyword = keyword;
        }
        public void setSize(string z, string width, string height)
        {
            this.z = z;
            this.width = width;
            this.height = height;
        }
        public void setType(int st, int face, int s)
        {
            this.st = st;
            this.face = face;
            this.s = s;
        }
        public void setMode(int lm)
        {
            this.lm = lm;
        }
        public string getLink()
        {
            string link = "http://image.baidu.com/i?tn=result_pageturn&word=" + HttpUtility.UrlEncode(keyword).ToUpper() + "&pn=0&cl=2&ie=utf-8&z=" + z + "&height=" + height + "&width=" + width;
            if (lm >= -1)
            {
                link += "&lm=" + lm.ToString();
            }
            if (st >= -1)
            {
                link += "&st=" + st.ToString() + "&face=" + face.ToString() + "&s=" + s.ToString() ;
            }
            return link;
        }
    }
}
