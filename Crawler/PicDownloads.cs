using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Threading;
using System.Net;
namespace Crawler
{
    class PicDownloads
    {
        private string prefix="_Crawler";
        private int startNum = 1;
        private int incrementNum = 1;
        private Form1 father;
        private string savepath=".\\";
        private List<string> pics;
        public PicDownloads(Form1 father)
        {
            this.father = father;
        }
        public void StartRun()
        {
            if (pics != null)
            {
                int count = 0;
                string url;
                string filepath;
                WebClient mywebclient = new WebClient(); ;
                for (int i = 0; i < pics.Count; i++)
                {

                    father.setStatus("下载图片" + (i + 1));
                    try
                    {
                        url = pics[i];
                        filepath = savepath + '\\' + prefix + (startNum + i * incrementNum) + url.Substring(url.LastIndexOf('.'));
                        mywebclient.DownloadFile(url, filepath); 
                        count++;
                    }
                    catch (ThreadAbortException err) { }
                    catch (Exception err)
                    {
                        father.setStatus(err.Message);
                    }

                }
                father.setEnd();
                father.setStatus("下载完成,共下载" + count + "张");
                Thread.CurrentThread.Abort();
            }
        }
        public void setPrefix(string prefix)
        {
            this.prefix = prefix;
        }
        public void setStart(int start)
        {
            this.startNum = start;
        }
        public void setIncrement(int increment)
        {
            this.incrementNum = increment;
        }
        public void setPics(List<string> pics)
        {
            this.pics = pics;
        }
        public void setSavePath(string savepath)
        {
            this.savepath = savepath;
        }
    }
}
