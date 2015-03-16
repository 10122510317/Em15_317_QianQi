namespace Crawler
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.KeyWord = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.SavePath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.StartButton = new System.Windows.Forms.Button();
            this.SavePathButton = new System.Windows.Forms.Button();
            this.MoreSettingButton = new System.Windows.Forms.Button();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.MoreSetting = new System.Windows.Forms.GroupBox();
            this.PhotoType = new System.Windows.Forms.GroupBox();
            this.PhotoTypeNews = new System.Windows.Forms.RadioButton();
            this.PhotoTypeBlackWhite = new System.Windows.Forms.RadioButton();
            this.PhotoTypeCartoon = new System.Windows.Forms.RadioButton();
            this.PhotoTypeCloseUp = new System.Windows.Forms.RadioButton();
            this.PhotoTypeExpression = new System.Windows.Forms.RadioButton();
            this.PhotoTypeHead = new System.Windows.Forms.RadioButton();
            this.PhotoTypeAll = new System.Windows.Forms.RadioButton();
            this.PhotoFomat = new System.Windows.Forms.GroupBox();
            this.PhotoFomatDynamic = new System.Windows.Forms.RadioButton();
            this.PhotoFomatStatic = new System.Windows.Forms.RadioButton();
            this.PhotoFomatAll = new System.Windows.Forms.RadioButton();
            this.AutoIncrement = new System.Windows.Forms.GroupBox();
            this.IncrementAmount = new System.Windows.Forms.TextBox();
            this.IncrementStart = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Prefix = new System.Windows.Forms.GroupBox();
            this.CustomPrefixName = new System.Windows.Forms.TextBox();
            this.CustomPrefix = new System.Windows.Forms.RadioButton();
            this.KeyWordPrefix = new System.Windows.Forms.RadioButton();
            this.NeedPrefix = new System.Windows.Forms.CheckBox();
            this.PhotoSize = new System.Windows.Forms.GroupBox();
            this.PhotoSizeCustomHeight = new System.Windows.Forms.TextBox();
            this.PhotoSizeCustomWidth = new System.Windows.Forms.TextBox();
            this.PhotoSizeCustom = new System.Windows.Forms.RadioButton();
            this.PhotoSizeLarge = new System.Windows.Forms.RadioButton();
            this.PhotoSizeMedium = new System.Windows.Forms.RadioButton();
            this.PhotoSizeSmall = new System.Windows.Forms.RadioButton();
            this.PhotoSizeNone = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.SearchEngine = new System.Windows.Forms.GroupBox();
            this.SearchEngineGoogle = new System.Windows.Forms.RadioButton();
            this.SearchEngineBaidu = new System.Windows.Forms.RadioButton();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.MoreSetting.SuspendLayout();
            this.PhotoType.SuspendLayout();
            this.PhotoFomat.SuspendLayout();
            this.AutoIncrement.SuspendLayout();
            this.Prefix.SuspendLayout();
            this.PhotoSize.SuspendLayout();
            this.SearchEngine.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // KeyWord
            // 
            this.KeyWord.Location = new System.Drawing.Point(71, 6);
            this.KeyWord.Name = "KeyWord";
            this.KeyWord.Size = new System.Drawing.Size(257, 21);
            this.KeyWord.TabIndex = 0;
            // 
            // SavePath
            // 
            this.SavePath.Location = new System.Drawing.Point(71, 32);
            this.SavePath.Name = "SavePath";
            this.SavePath.ReadOnly = true;
            this.SavePath.Size = new System.Drawing.Size(191, 21);
            this.SavePath.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "关键词";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "储存路径";
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(334, 6);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(113, 47);
            this.StartButton.TabIndex = 4;
            this.StartButton.Text = "开始";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // SavePathButton
            // 
            this.SavePathButton.Location = new System.Drawing.Point(268, 32);
            this.SavePathButton.Name = "SavePathButton";
            this.SavePathButton.Size = new System.Drawing.Size(60, 21);
            this.SavePathButton.TabIndex = 5;
            this.SavePathButton.Text = "浏览";
            this.SavePathButton.UseVisualStyleBackColor = true;
            this.SavePathButton.Click += new System.EventHandler(this.SavePathBrowse_Click);
            // 
            // MoreSettingButton
            // 
            this.MoreSettingButton.Location = new System.Drawing.Point(455, 32);
            this.MoreSettingButton.Name = "MoreSettingButton";
            this.MoreSettingButton.Size = new System.Drawing.Size(117, 21);
            this.MoreSettingButton.TabIndex = 6;
            this.MoreSettingButton.Text = "展开更多";
            this.MoreSettingButton.UseVisualStyleBackColor = true;
            this.MoreSettingButton.Click += new System.EventHandler(this.MoreSettingButton_Click);
            // 
            // TimeLabel
            // 
            this.TimeLabel.AutoSize = true;
            this.TimeLabel.Location = new System.Drawing.Point(453, 9);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(119, 12);
            this.TimeLabel.TabIndex = 7;
            this.TimeLabel.Text = "9999-99-99 99:99:99";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MoreSetting
            // 
            this.MoreSetting.Controls.Add(this.PhotoType);
            this.MoreSetting.Controls.Add(this.PhotoFomat);
            this.MoreSetting.Controls.Add(this.AutoIncrement);
            this.MoreSetting.Controls.Add(this.Prefix);
            this.MoreSetting.Controls.Add(this.PhotoSize);
            this.MoreSetting.Controls.Add(this.SearchEngine);
            this.MoreSetting.Enabled = false;
            this.MoreSetting.Location = new System.Drawing.Point(14, 67);
            this.MoreSetting.Name = "MoreSetting";
            this.MoreSetting.Size = new System.Drawing.Size(558, 216);
            this.MoreSetting.TabIndex = 8;
            this.MoreSetting.TabStop = false;
            this.MoreSetting.Text = "更多设置";
            // 
            // PhotoType
            // 
            this.PhotoType.Controls.Add(this.PhotoTypeNews);
            this.PhotoType.Controls.Add(this.PhotoTypeBlackWhite);
            this.PhotoType.Controls.Add(this.PhotoTypeCartoon);
            this.PhotoType.Controls.Add(this.PhotoTypeCloseUp);
            this.PhotoType.Controls.Add(this.PhotoTypeExpression);
            this.PhotoType.Controls.Add(this.PhotoTypeHead);
            this.PhotoType.Controls.Add(this.PhotoTypeAll);
            this.PhotoType.Location = new System.Drawing.Point(439, 20);
            this.PhotoType.Name = "PhotoType";
            this.PhotoType.Size = new System.Drawing.Size(113, 181);
            this.PhotoType.TabIndex = 7;
            this.PhotoType.TabStop = false;
            this.PhotoType.Text = "图片类型";
            // 
            // PhotoTypeNews
            // 
            this.PhotoTypeNews.AutoSize = true;
            this.PhotoTypeNews.Location = new System.Drawing.Point(6, 152);
            this.PhotoTypeNews.Name = "PhotoTypeNews";
            this.PhotoTypeNews.Size = new System.Drawing.Size(71, 16);
            this.PhotoTypeNews.TabIndex = 6;
            this.PhotoTypeNews.Text = "新闻图片";
            this.PhotoTypeNews.UseVisualStyleBackColor = true;
            this.PhotoTypeNews.CheckedChanged += new System.EventHandler(this.PhotoTypeNews_CheckedChanged);
            // 
            // PhotoTypeBlackWhite
            // 
            this.PhotoTypeBlackWhite.AutoSize = true;
            this.PhotoTypeBlackWhite.Location = new System.Drawing.Point(6, 130);
            this.PhotoTypeBlackWhite.Name = "PhotoTypeBlackWhite";
            this.PhotoTypeBlackWhite.Size = new System.Drawing.Size(83, 16);
            this.PhotoTypeBlackWhite.TabIndex = 5;
            this.PhotoTypeBlackWhite.Text = "黑白简笔画";
            this.PhotoTypeBlackWhite.UseVisualStyleBackColor = true;
            this.PhotoTypeBlackWhite.CheckedChanged += new System.EventHandler(this.PhotoTypeBlackWhite_CheckedChanged);
            // 
            // PhotoTypeCartoon
            // 
            this.PhotoTypeCartoon.AutoSize = true;
            this.PhotoTypeCartoon.Location = new System.Drawing.Point(6, 108);
            this.PhotoTypeCartoon.Name = "PhotoTypeCartoon";
            this.PhotoTypeCartoon.Size = new System.Drawing.Size(83, 16);
            this.PhotoTypeCartoon.TabIndex = 4;
            this.PhotoTypeCartoon.Text = "彩色卡通画";
            this.PhotoTypeCartoon.UseVisualStyleBackColor = true;
            this.PhotoTypeCartoon.CheckedChanged += new System.EventHandler(this.PhotoTypeCartoon_CheckedChanged);
            // 
            // PhotoTypeCloseUp
            // 
            this.PhotoTypeCloseUp.AutoSize = true;
            this.PhotoTypeCloseUp.Location = new System.Drawing.Point(6, 86);
            this.PhotoTypeCloseUp.Name = "PhotoTypeCloseUp";
            this.PhotoTypeCloseUp.Size = new System.Drawing.Size(71, 16);
            this.PhotoTypeCloseUp.TabIndex = 3;
            this.PhotoTypeCloseUp.Text = "面部特写";
            this.PhotoTypeCloseUp.UseVisualStyleBackColor = true;
            this.PhotoTypeCloseUp.CheckedChanged += new System.EventHandler(this.PhotoTypeCloseUp_CheckedChanged);
            // 
            // PhotoTypeExpression
            // 
            this.PhotoTypeExpression.AutoSize = true;
            this.PhotoTypeExpression.Location = new System.Drawing.Point(6, 64);
            this.PhotoTypeExpression.Name = "PhotoTypeExpression";
            this.PhotoTypeExpression.Size = new System.Drawing.Size(71, 16);
            this.PhotoTypeExpression.TabIndex = 2;
            this.PhotoTypeExpression.Text = "表情图片";
            this.PhotoTypeExpression.UseVisualStyleBackColor = true;
            this.PhotoTypeExpression.CheckedChanged += new System.EventHandler(this.PhotoTypeExpression_CheckedChanged);
            // 
            // PhotoTypeHead
            // 
            this.PhotoTypeHead.AutoSize = true;
            this.PhotoTypeHead.Location = new System.Drawing.Point(6, 42);
            this.PhotoTypeHead.Name = "PhotoTypeHead";
            this.PhotoTypeHead.Size = new System.Drawing.Size(71, 16);
            this.PhotoTypeHead.TabIndex = 1;
            this.PhotoTypeHead.Text = "头像图片";
            this.PhotoTypeHead.UseVisualStyleBackColor = true;
            this.PhotoTypeHead.CheckedChanged += new System.EventHandler(this.PhotoTypeHead_CheckedChanged);
            // 
            // PhotoTypeAll
            // 
            this.PhotoTypeAll.AutoSize = true;
            this.PhotoTypeAll.Checked = true;
            this.PhotoTypeAll.Location = new System.Drawing.Point(6, 20);
            this.PhotoTypeAll.Name = "PhotoTypeAll";
            this.PhotoTypeAll.Size = new System.Drawing.Size(71, 16);
            this.PhotoTypeAll.TabIndex = 0;
            this.PhotoTypeAll.TabStop = true;
            this.PhotoTypeAll.Text = "全部类型";
            this.PhotoTypeAll.UseVisualStyleBackColor = true;
            this.PhotoTypeAll.CheckedChanged += new System.EventHandler(this.PhotoTypeAll_CheckedChanged);
            // 
            // PhotoFomat
            // 
            this.PhotoFomat.Controls.Add(this.PhotoFomatDynamic);
            this.PhotoFomat.Controls.Add(this.PhotoFomatStatic);
            this.PhotoFomat.Controls.Add(this.PhotoFomatAll);
            this.PhotoFomat.Location = new System.Drawing.Point(166, 145);
            this.PhotoFomat.Name = "PhotoFomat";
            this.PhotoFomat.Size = new System.Drawing.Size(267, 46);
            this.PhotoFomat.TabIndex = 6;
            this.PhotoFomat.TabStop = false;
            this.PhotoFomat.Text = "图片格式";
            // 
            // PhotoFomatDynamic
            // 
            this.PhotoFomatDynamic.AutoSize = true;
            this.PhotoFomatDynamic.Location = new System.Drawing.Point(160, 20);
            this.PhotoFomatDynamic.Name = "PhotoFomatDynamic";
            this.PhotoFomatDynamic.Size = new System.Drawing.Size(71, 16);
            this.PhotoFomatDynamic.TabIndex = 2;
            this.PhotoFomatDynamic.Text = "动态图片";
            this.PhotoFomatDynamic.UseVisualStyleBackColor = true;
            this.PhotoFomatDynamic.CheckedChanged += new System.EventHandler(this.PhotoFomatDynamic_CheckedChanged);
            // 
            // PhotoFomatStatic
            // 
            this.PhotoFomatStatic.AutoSize = true;
            this.PhotoFomatStatic.Location = new System.Drawing.Point(83, 20);
            this.PhotoFomatStatic.Name = "PhotoFomatStatic";
            this.PhotoFomatStatic.Size = new System.Drawing.Size(71, 16);
            this.PhotoFomatStatic.TabIndex = 1;
            this.PhotoFomatStatic.Text = "静态图片";
            this.PhotoFomatStatic.UseVisualStyleBackColor = true;
            this.PhotoFomatStatic.CheckedChanged += new System.EventHandler(this.PhotoFomatStatic_CheckedChanged);
            // 
            // PhotoFomatAll
            // 
            this.PhotoFomatAll.AutoSize = true;
            this.PhotoFomatAll.Checked = true;
            this.PhotoFomatAll.Location = new System.Drawing.Point(6, 20);
            this.PhotoFomatAll.Name = "PhotoFomatAll";
            this.PhotoFomatAll.Size = new System.Drawing.Size(71, 16);
            this.PhotoFomatAll.TabIndex = 0;
            this.PhotoFomatAll.TabStop = true;
            this.PhotoFomatAll.Text = "全部图片";
            this.PhotoFomatAll.UseVisualStyleBackColor = true;
            this.PhotoFomatAll.CheckedChanged += new System.EventHandler(this.PhotoFomatAll_CheckedChanged);
            // 
            // AutoIncrement
            // 
            this.AutoIncrement.Controls.Add(this.IncrementAmount);
            this.AutoIncrement.Controls.Add(this.IncrementStart);
            this.AutoIncrement.Controls.Add(this.label5);
            this.AutoIncrement.Controls.Add(this.label4);
            this.AutoIncrement.Location = new System.Drawing.Point(166, 93);
            this.AutoIncrement.Name = "AutoIncrement";
            this.AutoIncrement.Size = new System.Drawing.Size(267, 46);
            this.AutoIncrement.TabIndex = 5;
            this.AutoIncrement.TabStop = false;
            this.AutoIncrement.Text = "编号";
            // 
            // IncrementAmount
            // 
            this.IncrementAmount.Location = new System.Drawing.Point(204, 14);
            this.IncrementAmount.Name = "IncrementAmount";
            this.IncrementAmount.Size = new System.Drawing.Size(30, 21);
            this.IncrementAmount.TabIndex = 3;
            this.IncrementAmount.Text = "1";
            this.IncrementAmount.TextChanged += new System.EventHandler(this.IncrementAmount_TextChanged);
            this.IncrementAmount.Leave += new System.EventHandler(this.IncrementAmount_Leave);
            // 
            // IncrementStart
            // 
            this.IncrementStart.Location = new System.Drawing.Point(77, 14);
            this.IncrementStart.MaxLength = 4;
            this.IncrementStart.Name = "IncrementStart";
            this.IncrementStart.Size = new System.Drawing.Size(30, 21);
            this.IncrementStart.TabIndex = 2;
            this.IncrementStart.Text = "1";
            this.IncrementStart.TextChanged += new System.EventHandler(this.IncrementStart_TextChanged);
            this.IncrementStart.Leave += new System.EventHandler(this.IncrementStart_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(133, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 1;
            this.label5.Text = "编号增量";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "编号起始值";
            // 
            // Prefix
            // 
            this.Prefix.Controls.Add(this.CustomPrefixName);
            this.Prefix.Controls.Add(this.CustomPrefix);
            this.Prefix.Controls.Add(this.KeyWordPrefix);
            this.Prefix.Controls.Add(this.NeedPrefix);
            this.Prefix.Location = new System.Drawing.Point(166, 20);
            this.Prefix.Name = "Prefix";
            this.Prefix.Size = new System.Drawing.Size(267, 66);
            this.Prefix.TabIndex = 3;
            this.Prefix.TabStop = false;
            this.Prefix.Text = "前缀";
            // 
            // CustomPrefixName
            // 
            this.CustomPrefixName.Location = new System.Drawing.Point(149, 40);
            this.CustomPrefixName.MaxLength = 13;
            this.CustomPrefixName.Name = "CustomPrefixName";
            this.CustomPrefixName.Size = new System.Drawing.Size(85, 21);
            this.CustomPrefixName.TabIndex = 4;
            this.CustomPrefixName.Text = "_Crawler";
            this.CustomPrefixName.TextChanged += new System.EventHandler(this.CustomPrefixName_TextChanged);
            this.CustomPrefixName.Leave += new System.EventHandler(this.CustomPrefixName_Leave);
            // 
            // CustomPrefix
            // 
            this.CustomPrefix.AutoSize = true;
            this.CustomPrefix.Checked = true;
            this.CustomPrefix.Location = new System.Drawing.Point(84, 41);
            this.CustomPrefix.Name = "CustomPrefix";
            this.CustomPrefix.Size = new System.Drawing.Size(59, 16);
            this.CustomPrefix.TabIndex = 2;
            this.CustomPrefix.TabStop = true;
            this.CustomPrefix.Text = "自定义";
            this.CustomPrefix.UseVisualStyleBackColor = true;
            this.CustomPrefix.CheckedChanged += new System.EventHandler(this.CustomPrefix_CheckedChanged);
            // 
            // KeyWordPrefix
            // 
            this.KeyWordPrefix.AutoSize = true;
            this.KeyWordPrefix.Location = new System.Drawing.Point(84, 19);
            this.KeyWordPrefix.Name = "KeyWordPrefix";
            this.KeyWordPrefix.Size = new System.Drawing.Size(107, 16);
            this.KeyWordPrefix.TabIndex = 1;
            this.KeyWordPrefix.Text = "关键词作为前缀";
            this.KeyWordPrefix.UseVisualStyleBackColor = true;
            // 
            // NeedPrefix
            // 
            this.NeedPrefix.AutoSize = true;
            this.NeedPrefix.Checked = true;
            this.NeedPrefix.CheckState = System.Windows.Forms.CheckState.Checked;
            this.NeedPrefix.Location = new System.Drawing.Point(6, 20);
            this.NeedPrefix.Name = "NeedPrefix";
            this.NeedPrefix.Size = new System.Drawing.Size(72, 16);
            this.NeedPrefix.TabIndex = 0;
            this.NeedPrefix.Text = "需要前缀";
            this.NeedPrefix.UseVisualStyleBackColor = true;
            this.NeedPrefix.CheckedChanged += new System.EventHandler(this.NeedPrefix_CheckedChanged);
            // 
            // PhotoSize
            // 
            this.PhotoSize.Controls.Add(this.PhotoSizeCustomHeight);
            this.PhotoSize.Controls.Add(this.PhotoSizeCustomWidth);
            this.PhotoSize.Controls.Add(this.PhotoSizeCustom);
            this.PhotoSize.Controls.Add(this.PhotoSizeLarge);
            this.PhotoSize.Controls.Add(this.PhotoSizeMedium);
            this.PhotoSize.Controls.Add(this.PhotoSizeSmall);
            this.PhotoSize.Controls.Add(this.PhotoSizeNone);
            this.PhotoSize.Controls.Add(this.label3);
            this.PhotoSize.Location = new System.Drawing.Point(6, 73);
            this.PhotoSize.Name = "PhotoSize";
            this.PhotoSize.Size = new System.Drawing.Size(154, 136);
            this.PhotoSize.TabIndex = 2;
            this.PhotoSize.TabStop = false;
            this.PhotoSize.Text = "图片尺寸";
            // 
            // PhotoSizeCustomHeight
            // 
            this.PhotoSizeCustomHeight.Enabled = false;
            this.PhotoSizeCustomHeight.Location = new System.Drawing.Point(105, 107);
            this.PhotoSizeCustomHeight.MaxLength = 4;
            this.PhotoSizeCustomHeight.Name = "PhotoSizeCustomHeight";
            this.PhotoSizeCustomHeight.Size = new System.Drawing.Size(30, 21);
            this.PhotoSizeCustomHeight.TabIndex = 6;
            this.PhotoSizeCustomHeight.Leave += new System.EventHandler(this.PhotoSizeCustomHeight_Leave);
            // 
            // PhotoSizeCustomWidth
            // 
            this.PhotoSizeCustomWidth.Enabled = false;
            this.PhotoSizeCustomWidth.Location = new System.Drawing.Point(65, 107);
            this.PhotoSizeCustomWidth.MaxLength = 4;
            this.PhotoSizeCustomWidth.Name = "PhotoSizeCustomWidth";
            this.PhotoSizeCustomWidth.Size = new System.Drawing.Size(30, 21);
            this.PhotoSizeCustomWidth.TabIndex = 5;
            this.PhotoSizeCustomWidth.Leave += new System.EventHandler(this.PhotoSizeCustomWidth_Leave);
            // 
            // PhotoSizeCustom
            // 
            this.PhotoSizeCustom.AutoSize = true;
            this.PhotoSizeCustom.Location = new System.Drawing.Point(6, 108);
            this.PhotoSizeCustom.Name = "PhotoSizeCustom";
            this.PhotoSizeCustom.Size = new System.Drawing.Size(59, 16);
            this.PhotoSizeCustom.TabIndex = 4;
            this.PhotoSizeCustom.Text = "自定义";
            this.PhotoSizeCustom.UseVisualStyleBackColor = true;
            this.PhotoSizeCustom.CheckedChanged += new System.EventHandler(this.PhotoSizeCustom_CheckedChanged);
            // 
            // PhotoSizeLarge
            // 
            this.PhotoSizeLarge.AutoSize = true;
            this.PhotoSizeLarge.Location = new System.Drawing.Point(6, 86);
            this.PhotoSizeLarge.Name = "PhotoSizeLarge";
            this.PhotoSizeLarge.Size = new System.Drawing.Size(59, 16);
            this.PhotoSizeLarge.TabIndex = 3;
            this.PhotoSizeLarge.Text = "大尺寸";
            this.PhotoSizeLarge.UseVisualStyleBackColor = true;
            this.PhotoSizeLarge.CheckedChanged += new System.EventHandler(this.PhotoSizeLarge_CheckedChanged);
            // 
            // PhotoSizeMedium
            // 
            this.PhotoSizeMedium.AutoSize = true;
            this.PhotoSizeMedium.Location = new System.Drawing.Point(6, 64);
            this.PhotoSizeMedium.Name = "PhotoSizeMedium";
            this.PhotoSizeMedium.Size = new System.Drawing.Size(59, 16);
            this.PhotoSizeMedium.TabIndex = 2;
            this.PhotoSizeMedium.Text = "中尺寸";
            this.PhotoSizeMedium.UseVisualStyleBackColor = true;
            this.PhotoSizeMedium.CheckedChanged += new System.EventHandler(this.PhotoSizeMedium_CheckedChanged);
            // 
            // PhotoSizeSmall
            // 
            this.PhotoSizeSmall.AutoSize = true;
            this.PhotoSizeSmall.Location = new System.Drawing.Point(6, 42);
            this.PhotoSizeSmall.Name = "PhotoSizeSmall";
            this.PhotoSizeSmall.Size = new System.Drawing.Size(59, 16);
            this.PhotoSizeSmall.TabIndex = 1;
            this.PhotoSizeSmall.Text = "小尺寸";
            this.PhotoSizeSmall.UseVisualStyleBackColor = true;
            this.PhotoSizeSmall.CheckedChanged += new System.EventHandler(this.PhotoSizeSmall_CheckedChanged);
            // 
            // PhotoSizeNone
            // 
            this.PhotoSizeNone.AutoSize = true;
            this.PhotoSizeNone.Checked = true;
            this.PhotoSizeNone.Location = new System.Drawing.Point(6, 20);
            this.PhotoSizeNone.Name = "PhotoSizeNone";
            this.PhotoSizeNone.Size = new System.Drawing.Size(71, 16);
            this.PhotoSizeNone.TabIndex = 0;
            this.PhotoSizeNone.TabStop = true;
            this.PhotoSizeNone.Text = "全部尺寸";
            this.PhotoSizeNone.UseVisualStyleBackColor = true;
            this.PhotoSizeNone.CheckedChanged += new System.EventHandler(this.PhotoSizeNone_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(95, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(11, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "x";
            // 
            // SearchEngine
            // 
            this.SearchEngine.Controls.Add(this.SearchEngineGoogle);
            this.SearchEngine.Controls.Add(this.SearchEngineBaidu);
            this.SearchEngine.Location = new System.Drawing.Point(6, 20);
            this.SearchEngine.Name = "SearchEngine";
            this.SearchEngine.Size = new System.Drawing.Size(154, 47);
            this.SearchEngine.TabIndex = 0;
            this.SearchEngine.TabStop = false;
            this.SearchEngine.Text = "搜索引擎";
            // 
            // SearchEngineGoogle
            // 
            this.SearchEngineGoogle.AutoSize = true;
            this.SearchEngineGoogle.Enabled = false;
            this.SearchEngineGoogle.Location = new System.Drawing.Point(89, 20);
            this.SearchEngineGoogle.Name = "SearchEngineGoogle";
            this.SearchEngineGoogle.Size = new System.Drawing.Size(59, 16);
            this.SearchEngineGoogle.TabIndex = 1;
            this.SearchEngineGoogle.Text = "Google";
            this.SearchEngineGoogle.UseVisualStyleBackColor = true;
            // 
            // SearchEngineBaidu
            // 
            this.SearchEngineBaidu.AutoSize = true;
            this.SearchEngineBaidu.Checked = true;
            this.SearchEngineBaidu.Location = new System.Drawing.Point(6, 20);
            this.SearchEngineBaidu.Name = "SearchEngineBaidu";
            this.SearchEngineBaidu.Size = new System.Drawing.Size(47, 16);
            this.SearchEngineBaidu.TabIndex = 0;
            this.SearchEngineBaidu.TabStop = true;
            this.SearchEngineBaidu.Text = "百度";
            this.SearchEngineBaidu.UseVisualStyleBackColor = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(71, 17);
            this.toolStripStatusLabel2.Text = "状态:未开始";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(47, 17);
            this.toolStripStatusLabel1.Text = "关键词:";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 66);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(594, 22);
            this.statusStrip1.TabIndex = 10;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 88);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.MoreSetting);
            this.Controls.Add(this.TimeLabel);
            this.Controls.Add(this.MoreSettingButton);
            this.Controls.Add(this.SavePathButton);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SavePath);
            this.Controls.Add(this.KeyWord);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(600, 340);
            this.MinimumSize = new System.Drawing.Size(600, 110);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crawler";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MoreSetting.ResumeLayout(false);
            this.PhotoType.ResumeLayout(false);
            this.PhotoType.PerformLayout();
            this.PhotoFomat.ResumeLayout(false);
            this.PhotoFomat.PerformLayout();
            this.AutoIncrement.ResumeLayout(false);
            this.AutoIncrement.PerformLayout();
            this.Prefix.ResumeLayout(false);
            this.Prefix.PerformLayout();
            this.PhotoSize.ResumeLayout(false);
            this.PhotoSize.PerformLayout();
            this.SearchEngine.ResumeLayout(false);
            this.SearchEngine.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox KeyWord;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TextBox SavePath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Button SavePathButton;
        private System.Windows.Forms.Button MoreSettingButton;
        private System.Windows.Forms.Label TimeLabel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox MoreSetting;
        private System.Windows.Forms.GroupBox SearchEngine;
        private System.Windows.Forms.RadioButton SearchEngineGoogle;
        private System.Windows.Forms.RadioButton SearchEngineBaidu;
        private System.Windows.Forms.GroupBox PhotoSize;
        private System.Windows.Forms.TextBox PhotoSizeCustomHeight;
        private System.Windows.Forms.TextBox PhotoSizeCustomWidth;
        private System.Windows.Forms.RadioButton PhotoSizeCustom;
        private System.Windows.Forms.RadioButton PhotoSizeLarge;
        private System.Windows.Forms.RadioButton PhotoSizeMedium;
        private System.Windows.Forms.RadioButton PhotoSizeSmall;
        private System.Windows.Forms.RadioButton PhotoSizeNone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.GroupBox Prefix;
        private System.Windows.Forms.RadioButton CustomPrefix;
        private System.Windows.Forms.RadioButton KeyWordPrefix;
        private System.Windows.Forms.CheckBox NeedPrefix;
        private System.Windows.Forms.TextBox CustomPrefixName;
        private System.Windows.Forms.GroupBox AutoIncrement;
        private System.Windows.Forms.TextBox IncrementAmount;
        private System.Windows.Forms.TextBox IncrementStart;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton PhotoTypeNews;
        private System.Windows.Forms.RadioButton PhotoTypeBlackWhite;
        private System.Windows.Forms.RadioButton PhotoTypeCartoon;
        private System.Windows.Forms.RadioButton PhotoTypeCloseUp;
        private System.Windows.Forms.RadioButton PhotoTypeExpression;
        private System.Windows.Forms.RadioButton PhotoTypeHead;
        private System.Windows.Forms.RadioButton PhotoTypeAll;
        private System.Windows.Forms.GroupBox PhotoFomat;
        private System.Windows.Forms.RadioButton PhotoFomatDynamic;
        private System.Windows.Forms.RadioButton PhotoFomatStatic;
        private System.Windows.Forms.RadioButton PhotoFomatAll;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        public System.Windows.Forms.GroupBox PhotoType;
    }
}

