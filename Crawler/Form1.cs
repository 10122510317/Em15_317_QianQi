using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace Crawler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        private BaiduLink mBaiduLink = new BaiduLink();
        private PicDownloads mPicDownloads;
        private UrlAnalysis mUrlAnalysis;
        private Thread mThread;
        private void Form1_Load(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;
            folderBrowserDialog1.SelectedPath = Application.StartupPath;
            SavePath.Text = Application.StartupPath;
            TimeLabel.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            timer1.Enabled = true;
            PhotoSizeCustomWidth.Text = Screen.PrimaryScreen.Bounds.Width.ToString();
            PhotoSizeCustomHeight.Text = Screen.PrimaryScreen.Bounds.Height.ToString();
            mPicDownloads = new PicDownloads(this);
        }
        private bool CheckInt(string str)
        {
            if (String.IsNullOrWhiteSpace(str))
                return false;
            int i;
            if (Int32.TryParse(str, out i) == false)
                return false;
            return true;
        }
        private void SavePathBrowse_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                SavePath.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeLabel.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        }

        private void MoreSettingButton_Click(object sender, EventArgs e)
        {
            if (MoreSettingButton.Text == "收起更多")
            {
                MoreSettingButton.Text = "展开更多";
                this.Height = 110;
                this.Width = 600;
                MoreSetting.Enabled = false;
            }
            else
            {
                MoreSettingButton.Text = "收起更多";
                this.Height = 340;
                this.Width = 600;
                MoreSetting.Enabled = true;
            }
        }

        private void PhotoSizeCustom_CheckedChanged(object sender, EventArgs e)
        {
            PhotoSizeCustomWidth.Enabled = !PhotoSizeCustomWidth.Enabled;
            PhotoSizeCustomHeight.Enabled = !PhotoSizeCustomHeight.Enabled;
            if (PhotoSizeCustom.Checked)
            {
                if (!CheckInt(PhotoSizeCustomWidth.Text))
                {
                    PhotoSizeCustomWidth.Focus();
                }
                else if (!CheckInt(PhotoSizeCustomHeight.Text))
                {
                    PhotoSizeCustomHeight.Focus();
                }
                else
                    mBaiduLink.setSize("", PhotoSizeCustomWidth.Text, PhotoSizeCustomHeight.Text);
            }
        }

        private void CustomPrefix_CheckedChanged(object sender, EventArgs e)
        {
            CustomPrefixName.Enabled = !CustomPrefixName.Enabled;
            mPicDownloads.setPrefix(CustomPrefixName.Text);
        }

        private void NeedPrefix_CheckedChanged(object sender, EventArgs e)
        {
            CustomPrefix.Enabled = !CustomPrefix.Enabled;
            KeyWordPrefix.Enabled = !KeyWordPrefix.Enabled;
            if (!NeedPrefix.Checked)
            {
                mPicDownloads.setPrefix("");
            }
        }

        private void PhotoSizeNone_CheckedChanged(object sender, EventArgs e)
        {
            mBaiduLink.setSize("0", "", "");
        }

        private void PhotoSizeSmall_CheckedChanged(object sender, EventArgs e)
        {
            mBaiduLink.setSize("1", "", "");
        }

        private void PhotoSizeMedium_CheckedChanged(object sender, EventArgs e)
        {
            mBaiduLink.setSize("2", "", "");
        }

        private void PhotoSizeLarge_CheckedChanged(object sender, EventArgs e)
        {
            mBaiduLink.setSize("9", "", "");
        }

        private void PhotoSizeCustomWidth_Leave(object sender, EventArgs e)
        {
            if (!CheckInt(PhotoSizeCustomWidth.Text))
            {
                if (MessageBox.Show(null, "宽度不能为空或不是数字", "错误", MessageBoxButtons.OKCancel, MessageBoxIcon.Error) == DialogResult.OK)
                {
                    PhotoSizeCustomWidth.Focus();
                }
                else
                {
                    PhotoSizeCustomWidth.Text = Screen.PrimaryScreen.Bounds.Width.ToString();
                    PhotoSizeCustom.Checked = false;
                    PhotoSizeNone.Checked = true;
                }
            }
            else if (!CheckInt(PhotoSizeCustomHeight.Text))
            {
                PhotoSizeCustomHeight.Focus();
            }
            else
            {
                mBaiduLink.setSize("", PhotoSizeCustomWidth.Text, PhotoSizeCustomHeight.Text);
            }
        }

        private void PhotoSizeCustomHeight_Leave(object sender, EventArgs e)
        {
            if (!CheckInt(PhotoSizeCustomHeight.Text))
            {
                if (MessageBox.Show(null, "高度不能为空或不是数字", "错误", MessageBoxButtons.OKCancel, MessageBoxIcon.Error) == DialogResult.OK)
                {
                    PhotoSizeCustomHeight.Focus();
                }
                else
                {
                    PhotoSizeCustomHeight.Text = Screen.PrimaryScreen.Bounds.Height.ToString();
                    PhotoSizeCustom.Checked = false;
                    PhotoSizeNone.Checked = true;

                }
            }
            else
            {
                mBaiduLink.setSize("", PhotoSizeCustomWidth.Text, PhotoSizeCustomHeight.Text);
            }
        }

        private void CustomPrefixName_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(CustomPrefixName.Text))
            {
                if (MessageBox.Show(null, "前缀不能为空", "错误", MessageBoxButtons.OKCancel, MessageBoxIcon.Error) == DialogResult.OK)
                {
                    CustomPrefixName.Focus();
                }
                else
                {
                    CustomPrefixName.Text = "_Crawler";
                    CustomPrefix.Checked = false;
                    KeyWordPrefix.Checked = true;
                }
            }
        }

        private void IncrementStart_Leave(object sender, EventArgs e)
        {

        }

        private void IncrementAmount_Leave(object sender, EventArgs e)
        {

        }

        private void PhotoTypeAll_CheckedChanged(object sender, EventArgs e)
        {
            if (PhotoTypeAll.Checked)
                mBaiduLink.setType(-100, -100, -100);
        }

        private void PhotoTypeHead_CheckedChanged(object sender, EventArgs e)
        {
            if (PhotoTypeHead.Checked)
                mBaiduLink.setType(-1, 0, 3);
        }

        private void PhotoFomatAll_CheckedChanged(object sender, EventArgs e)
        {
            if (PhotoFomatAll.Checked)
                mBaiduLink.setMode(-100);
        }

        private void PhotoFomatStatic_CheckedChanged(object sender, EventArgs e)
        {
            if (PhotoFomatStatic.Checked)
                mBaiduLink.setMode(7);
        }

        private void PhotoFomatDynamic_CheckedChanged(object sender, EventArgs e)
        {
            if (PhotoFomatDynamic.Checked)
                mBaiduLink.setMode(6);
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(KeyWord.Text))
            {
                MessageBox.Show(null, "关键词不能为空", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                KeyWord.Focus();
            }
            else
            {
                if (StartButton.Text == "开始")
                {
                    toolStripStatusLabel2.Text = "状态:生成百度链接";
                    toolStripStatusLabel1.Text = "关键词:" + KeyWord.Text;
                    MoreSettingButton.Enabled = false;
                    MoreSetting.Enabled = false;
                    SavePathButton.Enabled = false;
                    StartButton.Text = "停止";
                    mBaiduLink.setKeyword(KeyWord.Text);
                    if (NeedPrefix.Checked && KeyWordPrefix.Checked)
                    {
                        mPicDownloads.setPrefix(KeyWord.Text);
                    }
                    mPicDownloads.setSavePath(folderBrowserDialog1.SelectedPath);
                    mUrlAnalysis = new UrlAnalysis(mBaiduLink.getLink(), this);
                    mThread = new Thread(new ThreadStart(StartRun));
                    mThread.Start();
                }
                else
                {
                    mThread.Abort();
                    while (mThread.ThreadState == ThreadState.Running) { }
                    toolStripStatusLabel2.Text = "状态:已停止";
                    StartButton.Text = "开始";
                    MoreSettingButton.Enabled = true;
                    MoreSetting.Enabled = true;
                    SavePathButton.Enabled = true;
                }
            }
        }

        public void setEnd()
        {
            if (StartButton.Text == "停止")
            {
//                mThread.Abort();
//                while (mThread.ThreadState == ThreadState.Running) { }
                StartButton.Text = "开始";
                MoreSettingButton.Enabled = true;
                MoreSetting.Enabled = true;
                SavePathButton.Enabled = true;
            }
        }
        private void PhotoTypeExpression_CheckedChanged(object sender, EventArgs e)
        {
            if (PhotoTypeExpression.Checked)
                mBaiduLink.setType(-1, 0, 2);
        }

        private void PhotoTypeCloseUp_CheckedChanged(object sender, EventArgs e)
        {
            if (PhotoTypeCloseUp.Checked)
                mBaiduLink.setType(-1, 1, 0);
        }

        private void PhotoTypeNews_CheckedChanged(object sender, EventArgs e)
        {
            if (PhotoTypeNews.Checked)
                mBaiduLink.setType(-1, 0, 4);
        }

        private void PhotoTypeCartoon_CheckedChanged(object sender, EventArgs e)
        {
            if (PhotoTypeCartoon.Checked)
                mBaiduLink.setType(1, 0, 0);
        }

        private void PhotoTypeBlackWhite_CheckedChanged(object sender, EventArgs e)
        {
            if (PhotoTypeBlackWhite.Checked)
                mBaiduLink.setType(2, 0, 0);
        }
        public void setStatus(string status)
        {
            toolStripStatusLabel2.Text = "状态:" + status;
        }

        private void CustomPrefixName_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(CustomPrefixName.Text))
                mPicDownloads.setPrefix(CustomPrefixName.Text);
        }

        private void IncrementStart_TextChanged(object sender, EventArgs e)
        {
            if (!CheckInt(IncrementStart.Text))
            {
                if (MessageBox.Show(null, "起始值不能为空或不是数字", "错误", MessageBoxButtons.OKCancel, MessageBoxIcon.Error) == DialogResult.OK)
                {
                    IncrementStart.Focus();
                }
                else
                {
                    IncrementStart.Text = "1";
                }
            }
            else
            {
                mPicDownloads.setStart(Convert.ToInt32(IncrementStart.Text));
            }
        }

        private void IncrementAmount_TextChanged(object sender, EventArgs e)
        {
            if (!CheckInt(IncrementAmount.Text))
            {
                if (MessageBox.Show(null, "增量不能为空或不是数字", "错误", MessageBoxButtons.OKCancel, MessageBoxIcon.Error) == DialogResult.OK)
                {
                    IncrementAmount.Focus();
                }
                else
                {
                    IncrementAmount.Text = "1";
                }
            }
            else
            {
                mPicDownloads.setIncrement(Convert.ToInt32(IncrementAmount.Text));
            }
        }
        private void StartRun()
        {
            mUrlAnalysis.StartRun();
            mPicDownloads.setPics(mUrlAnalysis.getPicList());
            mPicDownloads.StartRun();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            mThread.Abort();
        }
    }
}
