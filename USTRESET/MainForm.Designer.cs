namespace USTRESET
{
    partial class USTRESET
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
            this.LoadUST = new System.Windows.Forms.Button();
            this.groupBox_USTProperties = new System.Windows.Forms.GroupBox();
            this.VoiceSelBox = new System.Windows.Forms.ComboBox();
            this.VoiceSelect = new System.Windows.Forms.Button();
            this.Tool2Select = new System.Windows.Forms.Button();
            this.textBox_Flags = new System.Windows.Forms.TextBox();
            this.Tool1Select = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_Tool2 = new System.Windows.Forms.TextBox();
            this.textBox_Tool1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_VoiceDir = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_OutFile = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_ProjectName = new System.Windows.Forms.TextBox();
            this.SaveAs = new System.Windows.Forms.Button();
            this.groupBox_SongProperties = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.PitchModeBox = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_PitchShift = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_BPM = new System.Windows.Forms.TextBox();
            this.groupBox_LyricsType = new System.Windows.Forms.GroupBox();
            this.label_ToLyricType = new System.Windows.Forms.Label();
            this.ToLyricType = new System.Windows.Forms.ComboBox();
            this.label_FromLyricType = new System.Windows.Forms.Label();
            this.FromLyricType = new System.Windows.Forms.ComboBox();
            this.DoLyricTrans = new System.Windows.Forms.CheckBox();
            this.groupBox_NoteProperties = new System.Windows.Forms.GroupBox();
            this.ResetFlags = new System.Windows.Forms.CheckBox();
            this.label_PitchPt = new System.Windows.Forms.Label();
            this.PitchPtBox = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.VibratoBox = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox_Vel = new System.Windows.Forms.TextBox();
            this.label_BRE = new System.Windows.Forms.Label();
            this.textBox_BRE = new System.Windows.Forms.TextBox();
            this.ResetPitch = new System.Windows.Forms.CheckBox();
            this.ResetEnvelope = new System.Windows.Forms.CheckBox();
            this.SplitR = new System.Windows.Forms.CheckBox();
            this.ClearSTP = new System.Windows.Forms.CheckBox();
            this.ClearOverlap = new System.Windows.Forms.CheckBox();
            this.SetDefault = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.groupBox_USTProperties.SuspendLayout();
            this.groupBox_SongProperties.SuspendLayout();
            this.groupBox_LyricsType.SuspendLayout();
            this.groupBox_NoteProperties.SuspendLayout();
            this.SuspendLayout();
            // 
            // LoadUST
            // 
            this.LoadUST.Location = new System.Drawing.Point(12, 481);
            this.LoadUST.Name = "LoadUST";
            this.LoadUST.Size = new System.Drawing.Size(127, 40);
            this.LoadUST.TabIndex = 0;
            this.LoadUST.Text = "载入UST";
            this.LoadUST.UseVisualStyleBackColor = true;
            this.LoadUST.Click += new System.EventHandler(this.LoadUST_Click);
            // 
            // groupBox_USTProperties
            // 
            this.groupBox_USTProperties.Controls.Add(this.VoiceSelBox);
            this.groupBox_USTProperties.Controls.Add(this.VoiceSelect);
            this.groupBox_USTProperties.Controls.Add(this.Tool2Select);
            this.groupBox_USTProperties.Controls.Add(this.textBox_Flags);
            this.groupBox_USTProperties.Controls.Add(this.Tool1Select);
            this.groupBox_USTProperties.Controls.Add(this.label7);
            this.groupBox_USTProperties.Controls.Add(this.textBox_Tool2);
            this.groupBox_USTProperties.Controls.Add(this.textBox_Tool1);
            this.groupBox_USTProperties.Controls.Add(this.label6);
            this.groupBox_USTProperties.Controls.Add(this.label5);
            this.groupBox_USTProperties.Controls.Add(this.textBox_VoiceDir);
            this.groupBox_USTProperties.Controls.Add(this.label3);
            this.groupBox_USTProperties.Controls.Add(this.label2);
            this.groupBox_USTProperties.Controls.Add(this.textBox_OutFile);
            this.groupBox_USTProperties.Controls.Add(this.label1);
            this.groupBox_USTProperties.Controls.Add(this.textBox_ProjectName);
            this.groupBox_USTProperties.Enabled = false;
            this.groupBox_USTProperties.Location = new System.Drawing.Point(12, 12);
            this.groupBox_USTProperties.Name = "groupBox_USTProperties";
            this.groupBox_USTProperties.Size = new System.Drawing.Size(618, 166);
            this.groupBox_USTProperties.TabIndex = 1;
            this.groupBox_USTProperties.TabStop = false;
            this.groupBox_USTProperties.Text = "UST属性设置";
            // 
            // VoiceSelBox
            // 
            this.VoiceSelBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.VoiceSelBox.FormattingEnabled = true;
            this.VoiceSelBox.Location = new System.Drawing.Point(102, 93);
            this.VoiceSelBox.Name = "VoiceSelBox";
            this.VoiceSelBox.Size = new System.Drawing.Size(149, 23);
            this.VoiceSelBox.TabIndex = 3;
            this.VoiceSelBox.SelectedIndexChanged += new System.EventHandler(this.VoiceSelBox_SelectedIndexChanged);
            // 
            // VoiceSelect
            // 
            this.VoiceSelect.Location = new System.Drawing.Point(578, 127);
            this.VoiceSelect.Name = "VoiceSelect";
            this.VoiceSelect.Size = new System.Drawing.Size(24, 23);
            this.VoiceSelect.TabIndex = 15;
            this.VoiceSelect.Text = "…";
            this.VoiceSelect.UseVisualStyleBackColor = true;
            this.VoiceSelect.Click += new System.EventHandler(this.VoiceSelect_Click);
            // 
            // Tool2Select
            // 
            this.Tool2Select.Location = new System.Drawing.Point(578, 57);
            this.Tool2Select.Name = "Tool2Select";
            this.Tool2Select.Size = new System.Drawing.Size(24, 23);
            this.Tool2Select.TabIndex = 14;
            this.Tool2Select.Text = "…";
            this.Tool2Select.UseVisualStyleBackColor = true;
            this.Tool2Select.Click += new System.EventHandler(this.Tool2Select_Click);
            // 
            // textBox_Flags
            // 
            this.textBox_Flags.Location = new System.Drawing.Point(371, 91);
            this.textBox_Flags.Name = "textBox_Flags";
            this.textBox_Flags.Size = new System.Drawing.Size(231, 25);
            this.textBox_Flags.TabIndex = 12;
            // 
            // Tool1Select
            // 
            this.Tool1Select.Location = new System.Drawing.Point(578, 22);
            this.Tool1Select.Name = "Tool1Select";
            this.Tool1Select.Size = new System.Drawing.Size(24, 23);
            this.Tool1Select.TabIndex = 13;
            this.Tool1Select.Text = "…";
            this.Tool1Select.UseVisualStyleBackColor = true;
            this.Tool1Select.Click += new System.EventHandler(this.Tool1Select_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(292, 97);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 15);
            this.label7.TabIndex = 9;
            this.label7.Text = "Flags";
            // 
            // textBox_Tool2
            // 
            this.textBox_Tool2.Location = new System.Drawing.Point(371, 57);
            this.textBox_Tool2.Name = "textBox_Tool2";
            this.textBox_Tool2.Size = new System.Drawing.Size(201, 25);
            this.textBox_Tool2.TabIndex = 11;
            // 
            // textBox_Tool1
            // 
            this.textBox_Tool1.Location = new System.Drawing.Point(371, 22);
            this.textBox_Tool1.Name = "textBox_Tool1";
            this.textBox_Tool1.Size = new System.Drawing.Size(201, 25);
            this.textBox_Tool1.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(276, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 15);
            this.label6.TabIndex = 8;
            this.label6.Text = "合成器选择";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(276, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "采样器选择";
            // 
            // textBox_VoiceDir
            // 
            this.textBox_VoiceDir.Location = new System.Drawing.Point(102, 126);
            this.textBox_VoiceDir.Name = "textBox_VoiceDir";
            this.textBox_VoiceDir.Size = new System.Drawing.Size(470, 25);
            this.textBox_VoiceDir.TabIndex = 5;
            this.textBox_VoiceDir.TextChanged += new System.EventHandler(this.textBox_VoiceDir_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "音源选择";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "输出文件名";
            // 
            // textBox_OutFile
            // 
            this.textBox_OutFile.Location = new System.Drawing.Point(102, 57);
            this.textBox_OutFile.Name = "textBox_OutFile";
            this.textBox_OutFile.Size = new System.Drawing.Size(149, 25);
            this.textBox_OutFile.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "UST工程名";
            // 
            // textBox_ProjectName
            // 
            this.textBox_ProjectName.Location = new System.Drawing.Point(102, 22);
            this.textBox_ProjectName.Name = "textBox_ProjectName";
            this.textBox_ProjectName.Size = new System.Drawing.Size(149, 25);
            this.textBox_ProjectName.TabIndex = 0;
            this.textBox_ProjectName.TextChanged += new System.EventHandler(this.textBox_ProjectName_TextChanged);
            // 
            // SaveAs
            // 
            this.SaveAs.Enabled = false;
            this.SaveAs.Location = new System.Drawing.Point(503, 481);
            this.SaveAs.Name = "SaveAs";
            this.SaveAs.Size = new System.Drawing.Size(127, 40);
            this.SaveAs.TabIndex = 2;
            this.SaveAs.Text = "另存为";
            this.SaveAs.UseVisualStyleBackColor = true;
            this.SaveAs.Click += new System.EventHandler(this.SaveAs_Click);
            // 
            // groupBox_SongProperties
            // 
            this.groupBox_SongProperties.Controls.Add(this.label9);
            this.groupBox_SongProperties.Controls.Add(this.PitchModeBox);
            this.groupBox_SongProperties.Controls.Add(this.label8);
            this.groupBox_SongProperties.Controls.Add(this.textBox_PitchShift);
            this.groupBox_SongProperties.Controls.Add(this.label4);
            this.groupBox_SongProperties.Controls.Add(this.textBox_BPM);
            this.groupBox_SongProperties.Enabled = false;
            this.groupBox_SongProperties.Location = new System.Drawing.Point(12, 195);
            this.groupBox_SongProperties.Name = "groupBox_SongProperties";
            this.groupBox_SongProperties.Size = new System.Drawing.Size(280, 129);
            this.groupBox_SongProperties.TabIndex = 3;
            this.groupBox_SongProperties.TabStop = false;
            this.groupBox_SongProperties.Text = "歌曲属性设置";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(26, 95);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 15);
            this.label9.TabIndex = 17;
            this.label9.Text = "调声Mode";
            // 
            // PitchModeBox
            // 
            this.PitchModeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PitchModeBox.FormattingEnabled = true;
            this.PitchModeBox.Items.AddRange(new object[] {
            "Mode1",
            "Mode2"});
            this.PitchModeBox.Location = new System.Drawing.Point(110, 90);
            this.PitchModeBox.Name = "PitchModeBox";
            this.PitchModeBox.Size = new System.Drawing.Size(149, 23);
            this.PitchModeBox.TabIndex = 16;
            this.PitchModeBox.SelectedIndexChanged += new System.EventHandler(this.PitchModeBox_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 61);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 15);
            this.label8.TabIndex = 5;
            this.label8.Text = "升/降半音数";
            // 
            // textBox_PitchShift
            // 
            this.textBox_PitchShift.Location = new System.Drawing.Point(110, 55);
            this.textBox_PitchShift.Name = "textBox_PitchShift";
            this.textBox_PitchShift.Size = new System.Drawing.Size(149, 25);
            this.textBox_PitchShift.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "BPM";
            // 
            // textBox_BPM
            // 
            this.textBox_BPM.Location = new System.Drawing.Point(110, 21);
            this.textBox_BPM.Name = "textBox_BPM";
            this.textBox_BPM.Size = new System.Drawing.Size(149, 25);
            this.textBox_BPM.TabIndex = 2;
            // 
            // groupBox_LyricsType
            // 
            this.groupBox_LyricsType.Controls.Add(this.label_ToLyricType);
            this.groupBox_LyricsType.Controls.Add(this.ToLyricType);
            this.groupBox_LyricsType.Controls.Add(this.label_FromLyricType);
            this.groupBox_LyricsType.Controls.Add(this.FromLyricType);
            this.groupBox_LyricsType.Controls.Add(this.DoLyricTrans);
            this.groupBox_LyricsType.Enabled = false;
            this.groupBox_LyricsType.Location = new System.Drawing.Point(322, 195);
            this.groupBox_LyricsType.Name = "groupBox_LyricsType";
            this.groupBox_LyricsType.Size = new System.Drawing.Size(292, 129);
            this.groupBox_LyricsType.TabIndex = 4;
            this.groupBox_LyricsType.TabStop = false;
            this.groupBox_LyricsType.Text = "歌词格式转换";
            // 
            // label_ToLyricType
            // 
            this.label_ToLyricType.AutoSize = true;
            this.label_ToLyricType.Enabled = false;
            this.label_ToLyricType.Location = new System.Drawing.Point(44, 93);
            this.label_ToLyricType.Name = "label_ToLyricType";
            this.label_ToLyricType.Size = new System.Drawing.Size(97, 15);
            this.label_ToLyricType.TabIndex = 27;
            this.label_ToLyricType.Text = "目标歌词种类";
            // 
            // ToLyricType
            // 
            this.ToLyricType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ToLyricType.Enabled = false;
            this.ToLyricType.FormattingEnabled = true;
            this.ToLyricType.Items.AddRange(new object[] {
            "罗马单独音",
            "罗马连续音",
            "假名单独音",
            "假名连续音"});
            this.ToLyricType.Location = new System.Drawing.Point(154, 87);
            this.ToLyricType.Name = "ToLyricType";
            this.ToLyricType.Size = new System.Drawing.Size(117, 23);
            this.ToLyricType.TabIndex = 26;
            // 
            // label_FromLyricType
            // 
            this.label_FromLyricType.AutoSize = true;
            this.label_FromLyricType.Enabled = false;
            this.label_FromLyricType.Location = new System.Drawing.Point(44, 61);
            this.label_FromLyricType.Name = "label_FromLyricType";
            this.label_FromLyricType.Size = new System.Drawing.Size(82, 15);
            this.label_FromLyricType.TabIndex = 25;
            this.label_FromLyricType.Text = "原歌词种类";
            // 
            // FromLyricType
            // 
            this.FromLyricType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FromLyricType.Enabled = false;
            this.FromLyricType.FormattingEnabled = true;
            this.FromLyricType.Items.AddRange(new object[] {
            "罗马单独音",
            "罗马连续音",
            "假名单独音",
            "假名连续音"});
            this.FromLyricType.Location = new System.Drawing.Point(154, 55);
            this.FromLyricType.Name = "FromLyricType";
            this.FromLyricType.Size = new System.Drawing.Size(117, 23);
            this.FromLyricType.TabIndex = 24;
            // 
            // DoLyricTrans
            // 
            this.DoLyricTrans.AutoSize = true;
            this.DoLyricTrans.Enabled = false;
            this.DoLyricTrans.Location = new System.Drawing.Point(26, 27);
            this.DoLyricTrans.Name = "DoLyricTrans";
            this.DoLyricTrans.Size = new System.Drawing.Size(224, 19);
            this.DoLyricTrans.TabIndex = 23;
            this.DoLyricTrans.Text = "转换歌词（自动清除前后缀）";
            this.DoLyricTrans.UseVisualStyleBackColor = true;
            this.DoLyricTrans.CheckedChanged += new System.EventHandler(this.DoLyricTrans_CheckedChanged);
            // 
            // groupBox_NoteProperties
            // 
            this.groupBox_NoteProperties.Controls.Add(this.ResetFlags);
            this.groupBox_NoteProperties.Controls.Add(this.label_PitchPt);
            this.groupBox_NoteProperties.Controls.Add(this.PitchPtBox);
            this.groupBox_NoteProperties.Controls.Add(this.label12);
            this.groupBox_NoteProperties.Controls.Add(this.VibratoBox);
            this.groupBox_NoteProperties.Controls.Add(this.label11);
            this.groupBox_NoteProperties.Controls.Add(this.textBox_Vel);
            this.groupBox_NoteProperties.Controls.Add(this.label_BRE);
            this.groupBox_NoteProperties.Controls.Add(this.textBox_BRE);
            this.groupBox_NoteProperties.Controls.Add(this.ResetPitch);
            this.groupBox_NoteProperties.Controls.Add(this.ResetEnvelope);
            this.groupBox_NoteProperties.Controls.Add(this.SplitR);
            this.groupBox_NoteProperties.Controls.Add(this.ClearSTP);
            this.groupBox_NoteProperties.Controls.Add(this.ClearOverlap);
            this.groupBox_NoteProperties.Enabled = false;
            this.groupBox_NoteProperties.Location = new System.Drawing.Point(12, 338);
            this.groupBox_NoteProperties.Name = "groupBox_NoteProperties";
            this.groupBox_NoteProperties.Size = new System.Drawing.Size(602, 120);
            this.groupBox_NoteProperties.TabIndex = 5;
            this.groupBox_NoteProperties.TabStop = false;
            this.groupBox_NoteProperties.Text = "音符属性设置";
            // 
            // ResetFlags
            // 
            this.ResetFlags.AutoSize = true;
            this.ResetFlags.Location = new System.Drawing.Point(273, 25);
            this.ResetFlags.Name = "ResetFlags";
            this.ResetFlags.Size = new System.Drawing.Size(99, 19);
            this.ResetFlags.TabIndex = 22;
            this.ResetFlags.Text = "默认Flags";
            this.ResetFlags.UseVisualStyleBackColor = true;
            this.ResetFlags.CheckedChanged += new System.EventHandler(this.ResetFlags_CheckedChanged);
            // 
            // label_PitchPt
            // 
            this.label_PitchPt.AutoSize = true;
            this.label_PitchPt.Enabled = false;
            this.label_PitchPt.Location = new System.Drawing.Point(122, 88);
            this.label_PitchPt.Name = "label_PitchPt";
            this.label_PitchPt.Size = new System.Drawing.Size(67, 15);
            this.label_PitchPt.TabIndex = 21;
            this.label_PitchPt.Text = "锚点个数";
            // 
            // PitchPtBox
            // 
            this.PitchPtBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PitchPtBox.Enabled = false;
            this.PitchPtBox.FormattingEnabled = true;
            this.PitchPtBox.Items.AddRange(new object[] {
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.PitchPtBox.Location = new System.Drawing.Point(195, 84);
            this.PitchPtBox.Name = "PitchPtBox";
            this.PitchPtBox.Size = new System.Drawing.Size(56, 23);
            this.PitchPtBox.TabIndex = 19;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(416, 88);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(67, 15);
            this.label12.TabIndex = 18;
            this.label12.Text = "颤音曲线";
            // 
            // VibratoBox
            // 
            this.VibratoBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.VibratoBox.FormattingEnabled = true;
            this.VibratoBox.Items.AddRange(new object[] {
            "不更改",
            "清空",
            "预设"});
            this.VibratoBox.Location = new System.Drawing.Point(485, 84);
            this.VibratoBox.Name = "VibratoBox";
            this.VibratoBox.Size = new System.Drawing.Size(98, 23);
            this.VibratoBox.TabIndex = 17;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(416, 57);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 15);
            this.label11.TabIndex = 14;
            this.label11.Text = "子音速度";
            // 
            // textBox_Vel
            // 
            this.textBox_Vel.Location = new System.Drawing.Point(485, 53);
            this.textBox_Vel.Name = "textBox_Vel";
            this.textBox_Vel.Size = new System.Drawing.Size(98, 25);
            this.textBox_Vel.TabIndex = 13;
            // 
            // label_BRE
            // 
            this.label_BRE.AutoSize = true;
            this.label_BRE.Enabled = false;
            this.label_BRE.Location = new System.Drawing.Point(416, 26);
            this.label_BRE.Name = "label_BRE";
            this.label_BRE.Size = new System.Drawing.Size(61, 15);
            this.label_BRE.TabIndex = 12;
            this.label_BRE.Text = "默认BRE";
            // 
            // textBox_BRE
            // 
            this.textBox_BRE.Enabled = false;
            this.textBox_BRE.Location = new System.Drawing.Point(485, 22);
            this.textBox_BRE.Name = "textBox_BRE";
            this.textBox_BRE.Size = new System.Drawing.Size(98, 25);
            this.textBox_BRE.TabIndex = 11;
            // 
            // ResetPitch
            // 
            this.ResetPitch.AutoSize = true;
            this.ResetPitch.Location = new System.Drawing.Point(21, 87);
            this.ResetPitch.Name = "ResetPitch";
            this.ResetPitch.Size = new System.Drawing.Size(99, 19);
            this.ResetPitch.TabIndex = 10;
            this.ResetPitch.Text = "重置Pitch";
            this.ResetPitch.UseVisualStyleBackColor = true;
            this.ResetPitch.CheckedChanged += new System.EventHandler(this.ResetPitch_CheckedChanged);
            // 
            // ResetEnvelope
            // 
            this.ResetEnvelope.AutoSize = true;
            this.ResetEnvelope.Location = new System.Drawing.Point(273, 86);
            this.ResetEnvelope.Name = "ResetEnvelope";
            this.ResetEnvelope.Size = new System.Drawing.Size(104, 19);
            this.ResetEnvelope.TabIndex = 9;
            this.ResetEnvelope.Text = "重置包络线";
            this.ResetEnvelope.UseVisualStyleBackColor = true;
            // 
            // SplitR
            // 
            this.SplitR.AutoSize = true;
            this.SplitR.Location = new System.Drawing.Point(21, 26);
            this.SplitR.Name = "SplitR";
            this.SplitR.Size = new System.Drawing.Size(119, 19);
            this.SplitR.TabIndex = 8;
            this.SplitR.Text = "切割长休止符";
            this.SplitR.UseVisualStyleBackColor = true;
            // 
            // ClearSTP
            // 
            this.ClearSTP.AutoSize = true;
            this.ClearSTP.Location = new System.Drawing.Point(273, 55);
            this.ClearSTP.Name = "ClearSTP";
            this.ClearSTP.Size = new System.Drawing.Size(83, 19);
            this.ClearSTP.TabIndex = 7;
            this.ClearSTP.Text = "清空STP";
            this.ClearSTP.UseVisualStyleBackColor = true;
            // 
            // ClearOverlap
            // 
            this.ClearOverlap.AutoSize = true;
            this.ClearOverlap.Location = new System.Drawing.Point(21, 57);
            this.ClearOverlap.Name = "ClearOverlap";
            this.ClearOverlap.Size = new System.Drawing.Size(183, 19);
            this.ClearOverlap.TabIndex = 6;
            this.ClearOverlap.Text = "清空先行发声/Overlap";
            this.ClearOverlap.UseVisualStyleBackColor = true;
            // 
            // SetDefault
            // 
            this.SetDefault.Enabled = false;
            this.SetDefault.Location = new System.Drawing.Point(176, 481);
            this.SetDefault.Name = "SetDefault";
            this.SetDefault.Size = new System.Drawing.Size(127, 40);
            this.SetDefault.TabIndex = 6;
            this.SetDefault.Text = "载入默认设置";
            this.SetDefault.UseVisualStyleBackColor = true;
            this.SetDefault.Click += new System.EventHandler(this.SetDefault_Click);
            // 
            // Save
            // 
            this.Save.Enabled = false;
            this.Save.Location = new System.Drawing.Point(343, 481);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(127, 40);
            this.Save.TabIndex = 7;
            this.Save.Text = "保存";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // USTRESET
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 534);
            this.Controls.Add(this.groupBox_LyricsType);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.SetDefault);
            this.Controls.Add(this.groupBox_NoteProperties);
            this.Controls.Add(this.groupBox_SongProperties);
            this.Controls.Add(this.SaveAs);
            this.Controls.Add(this.groupBox_USTProperties);
            this.Controls.Add(this.LoadUST);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "USTRESET";
            this.Text = "USTRESET v1.1";
            this.Activated += new System.EventHandler(this.USTRESET_Activated);
            this.Load += new System.EventHandler(this.USTRESET_Load);
            this.groupBox_USTProperties.ResumeLayout(false);
            this.groupBox_USTProperties.PerformLayout();
            this.groupBox_SongProperties.ResumeLayout(false);
            this.groupBox_SongProperties.PerformLayout();
            this.groupBox_LyricsType.ResumeLayout(false);
            this.groupBox_LyricsType.PerformLayout();
            this.groupBox_NoteProperties.ResumeLayout(false);
            this.groupBox_NoteProperties.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button LoadUST;
        private System.Windows.Forms.GroupBox groupBox_USTProperties;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_OutFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_ProjectName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_Tool1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_VoiceDir;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button VoiceSelect;
        private System.Windows.Forms.Button Tool2Select;
        private System.Windows.Forms.Button Tool1Select;
        private System.Windows.Forms.TextBox textBox_Flags;
        private System.Windows.Forms.TextBox textBox_Tool2;
        private System.Windows.Forms.Button SaveAs;
        private System.Windows.Forms.ComboBox VoiceSelBox;
        private System.Windows.Forms.GroupBox groupBox_SongProperties;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox PitchModeBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox_PitchShift;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_BPM;
        private System.Windows.Forms.GroupBox groupBox_LyricsType;
        private System.Windows.Forms.GroupBox groupBox_NoteProperties;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox VibratoBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox_Vel;
        private System.Windows.Forms.Label label_BRE;
        private System.Windows.Forms.TextBox textBox_BRE;
        private System.Windows.Forms.CheckBox ResetPitch;
        private System.Windows.Forms.CheckBox ResetEnvelope;
        private System.Windows.Forms.CheckBox SplitR;
        private System.Windows.Forms.CheckBox ClearSTP;
        private System.Windows.Forms.CheckBox ClearOverlap;
        private System.Windows.Forms.Button SetDefault;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Label label_PitchPt;
        private System.Windows.Forms.ComboBox PitchPtBox;
        private System.Windows.Forms.CheckBox ResetFlags;
        private System.Windows.Forms.Label label_ToLyricType;
        private System.Windows.Forms.ComboBox ToLyricType;
        private System.Windows.Forms.Label label_FromLyricType;
        private System.Windows.Forms.ComboBox FromLyricType;
        private System.Windows.Forms.CheckBox DoLyricTrans;
    }
}

