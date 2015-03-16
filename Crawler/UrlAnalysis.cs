using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;

using System.Threading;




namespace Crawler
{
    class UrlAnalysis
    {
        private int STATE = 0;
        private string url;
        private Form1 father;
        private List<string> pics=new List<string>();
        public UrlAnalysis(string url,Form1 father)
        {
            this.url = url;
            this.father = father;
        }
        public List<string> getPicList()
        {
            if(STATE==1)
                return pics;
            return null;
        }
        public void StartRun()
        {
            analizeTag();
            analizePicUrl();
            STATE = 1;
        }
        private void analizeTag()
        {
            try
            {
                father.setStatus("请求百度服务器");
                HttpWebRequest request = System.Net.WebRequest.Create(url) as HttpWebRequest;
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                StreamReader responseReader = new StreamReader(response.GetResponseStream());
                string temp = responseReader.ReadToEnd();
                father.setStatus("分析地址中.");
                int st = temp.IndexOf("id=DivPost");
                int ed = temp.IndexOf("isRightData=", st);
                if (ed - st <= 0)
                {
                    father.setEnd();
                    father.setStatus("百度未能搜索到相关的图片");
                    Thread.CurrentThread.Abort();
                }
                temp = temp.Substring(st, ed - st);
                while (temp.IndexOf("objURL") >= 0)
                {
                    st = temp.IndexOf("objURL");
                    ed = temp.IndexOf("token");
                    pics.Add(temp.Substring(st, ed - st));
                    //这里+1避免截取后下一次搜索时候token位于位置0...
                    temp = temp.Substring(ed + 1);
                }
                father.setStatus("分析地址中..");
            }
            catch (Exception err)
            {
                father.setEnd();
                father.setStatus("请求失败,请检查网络连接");
                Thread.CurrentThread.Abort();
            }
        }
        private void clear()
        {
                pics.Clear();
        }
        private void analizePicUrl()
        {
            father.setStatus("分析地址中...");
            int ed;
            for(int i=0;i<pics.Count;i++){
                ed = pics[i].IndexOf("");
                pics[i] = pics[i].Substring(9, pics[i].IndexOf("fromURL") - 17);
            }
            father.setStatus("分析地址完毕");
        }
    }
}
