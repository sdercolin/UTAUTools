using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.IO;
using System.Collections;
using System.Windows.Forms;
using USTRESET;

namespace USTRESET
{
    public partial class USTRESET : Form
    {
        public USTRESET()
        {
            InitializeComponent();
        }

        //生成UTAU设置
        string ExtraVoiceDir = "";
        ArrayList VoiceNames = new ArrayList();
        ArrayList VoicePaths = new ArrayList();
        int VoiceNum = 0;
        bool VoiceLoaded = false;

        //主窗体载入
        private void USTRESET_Load(object sender, EventArgs e)
        {
            VoiceLoaded = VoiceLoad();
        }

        public bool VoiceLoad()
        {
            //读取外置音源路径
            try
            {
                StreamReader USTiniReader = new StreamReader(System.AppDomain.CurrentDomain.SetupInformation.ApplicationBase + "setting.ini", Encoding.GetEncoding("Shift-JIS"));
                for (string ReadBuf = "Starting"; ReadBuf != null; ReadBuf = USTiniReader.ReadLine())
                {
                    if (ReadBuf.Contains("VoiceRoot="))
                    {
                        ExtraVoiceDir = ReadBuf.Remove(0, 10);
                    }
                }
                USTiniReader.Close();
            }
            catch (System.IO.FileNotFoundException)
            {
                return false;
            }
            //读取音源列表
            DirectoryInfo VoiceRoot = new DirectoryInfo(System.AppDomain.CurrentDomain.SetupInformation.ApplicationBase + "voice");
            DirectoryInfo[] Voices = VoiceRoot.GetDirectories();
            foreach (DirectoryInfo Voice in Voices)
            {
                try
                {
                    StreamReader rd = new StreamReader(VoiceRoot.ToString() + "\\" + Voice.ToString() + "\\character.txt", Encoding.GetEncoding("Shift-JIS"));
                    for (string ReadBuf = "Starting"; ReadBuf != null; ReadBuf = rd.ReadLine())
                    {
                        if (ReadBuf.Contains("name="))
                        {
                            VoiceNames.Add(ReadBuf.Remove(0, 5));
                            VoicePaths.Add(VoiceRoot.ToString()+ "\\" + Voice.ToString());
                            VoiceNum++;
                        }
                    }
                    rd.Close();
                }
                catch (System.IO.FileNotFoundException)
                {

                }
            }
            
            //读取外置音源列表
            if (ExtraVoiceDir != "")
            {
                DirectoryInfo ExtraVoiceRoot = new DirectoryInfo(ExtraVoiceDir);
                DirectoryInfo[] ExtraVoices = ExtraVoiceRoot.GetDirectories();
                foreach (DirectoryInfo ExtraVoice in ExtraVoices)
                {
                    try
                    {
                        StreamReader rd = new StreamReader(ExtraVoiceDir + "\\" + ExtraVoice.ToString() + "\\character.txt", Encoding.GetEncoding("Shift-JIS"));
                        for (string ReadBuf = "Starting"; ReadBuf != null; ReadBuf = rd.ReadLine())
                        {
                            if (ReadBuf.Contains("name="))
                            {
                                VoiceNames.Add(ReadBuf.Remove(0, 5));
                                VoicePaths.Add(ExtraVoiceDir + "\\" + ExtraVoice.ToString());
                                VoiceNum++;
                            }
                        }
                        rd.Close();
                    }
                    catch (System.IO.FileNotFoundException)
                    {

                    }
                }
            }
            //显示在列表中
            VoiceSelBox.Items.AddRange(VoiceNames.ToArray());
            return true;
        }

        //生成UST空数据
        public UST ust = new UST(); 

        //打开文件
        private void LoadUST_Click(object sender, EventArgs e)
        {
            UST ust_load = new UST();
            OpenFileDialog Open = new OpenFileDialog();
            Open.Filter = "UTAU工程文件|*.ust";
            Open.ShowDialog();
            if (Open.FileName != "")
            {
                ust_load.FileName = Open.FileName;
                ust_load.SafeFileName = Open.SafeFileName;
                StreamReader USTReader = new StreamReader(Open.OpenFile(), Encoding.GetEncoding("Shift-JIS"));
                bool USTValid = ust_load.USTLoad(USTReader);
                USTReader.Close();
                if (Encoding.Default != Encoding.GetEncoding("Shift-JIS"))
                {
                    string buffer = File.ReadAllText(Open.FileName, Encoding.Default);
                    int Start = buffer.IndexOf("VoiceDir=");
                    int End = buffer.IndexOf("\r\n", Start);
                    ust_load.VoiceDir = buffer.Substring(Start, End - Start).Remove(0, 9);
                }
                if (USTValid)
                {
                    ust = ust_load;
                    groupBox_USTProperties.Enabled = true;
                    groupBox_SongProperties.Enabled = true;
                    groupBox_LyricsType.Enabled = true;
                    groupBox_NoteProperties.Enabled = true;
                    DoLyricTrans.Enabled = true;
                    textBox_ProjectName.Text = ust.ProjectName;
                    textBox_OutFile.Text = ust.OutFile;
                    string VoiceDirBuf = ust.VoiceDir;
                    try
                    {
                        if (ust.VoiceDir.Substring(0, 7) == "%VOICE%")
                        {
                            VoiceDirBuf = System.AppDomain.CurrentDomain.SetupInformation.ApplicationBase.Substring(0, System.AppDomain.CurrentDomain.SetupInformation.ApplicationBase.Length - 1) + "\\voice\\" + ust.VoiceDir.Remove(0, 7);
                            if (VoicePaths.IndexOf(VoiceDirBuf) == -1)
                            {
                                VoiceDirBuf = ExtraVoiceDir + "\\" + ust.VoiceDir.Remove(0, 7);
                            }
                        }
                    }
                    catch { }
                    VoiceSelBox.SelectedIndex = VoicePaths.IndexOf(VoiceDirBuf);
                    textBox_VoiceDir.Text = ust.VoiceDir;
                    textBox_Tool1.Text = ust.Tool1;
                    textBox_Tool2.Text = ust.Tool2;
                    textBox_Flags.Text = ust.Flags;
                    textBox_BPM.Text = ust.BPM;
                    textBox_PitchShift.Text = ust.PitchShift.ToString();
                    PitchModeBox.SelectedIndex = ust.PitchMode - 1;
                    VibratoBox.SelectedIndex = 0;
                    Save.Enabled = true;
                    SaveAs.Enabled = true;
                    SetDefault.Enabled = true;
                }
                else
                {
                    LoadingFailed LoadingFailedDlg = new LoadingFailed();
                    LoadingFailedDlg.Show();
                    ust_load = null;
                    GC.Collect();
                }
                USTReader.Close();
            }
        }

        private void textBox_ProjectName_TextChanged(object sender, EventArgs e)
        {
        }

        private void Tool1Select_Click(object sender, EventArgs e)
        {
            OpenFileDialog Tool1Sel = new OpenFileDialog();
            Tool1Sel.InitialDirectory = System.AppDomain.CurrentDomain.SetupInformation.ApplicationBase;
            Tool1Sel.ShowDialog();
            textBox_Tool1.Text = Tool1Sel.FileName;
            ust.Tool1 = textBox_Tool1.Text;
        }

        private void Tool2Select_Click(object sender, EventArgs e)
        {
            OpenFileDialog Tool2Sel = new OpenFileDialog();
            Tool2Sel.InitialDirectory = System.AppDomain.CurrentDomain.SetupInformation.ApplicationBase;
            Tool2Sel.ShowDialog();
            textBox_Tool2.Text = Tool2Sel.FileName;
            ust.Tool2 = textBox_Tool2.Text;
        }

        private void VoiceSelect_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog VoiceSel = new FolderBrowserDialog();
            VoiceSel.ShowNewFolderButton = false;
            VoiceSel.ShowDialog();
            if (VoiceSel.SelectedPath != "")
            {
                ust.VoiceDir = VoiceSel.SelectedPath;
                textBox_VoiceDir.Text = ust.VoiceDir;
                VoiceSelBox.SelectedIndex = VoicePaths.IndexOf(ust.VoiceDir);
            }
        }

        private void Save_Click(object sender, EventArgs e)
        {
            File.Copy(ust.FileName, ust.FileName.Replace(".ust", ".temp"),true);
            SaveFileDialog Save = new SaveFileDialog();
            Save.FileName = ust.FileName.Replace(".ust", ".temp");
            SetInputToUST();
            StreamWriter USTWriter = new StreamWriter(Save.OpenFile(), Encoding.GetEncoding("Shift-JIS"));
            StreamReader USTReader = new StreamReader(ust.FileName, Encoding.GetEncoding("Shift-JIS"));
            if (!ust.USTSave(USTReader, USTWriter))
            {
                USTWriter.Close();
                USTReader.Close();
                Save.OpenFile().Close();
                File.Delete(Save.FileName);
            }
            else
            {
                USTWriter.Close();
                USTReader.Close();
                File.Copy(ust.FileName.Replace(".ust", ".temp"), ust.FileName,true);
                File.Delete(ust.FileName.Replace(".ust", ".temp"));
                if (Encoding.Default != Encoding.GetEncoding("Shift-JIS"))
                {
                    string buffer = File.ReadAllText(ust.FileName, Encoding.Default);
                    int Start = buffer.IndexOf("VoiceDir=");
                    int End = buffer.IndexOf("\n", Start);
                    buffer = buffer.Substring(0, Start - 1) + "VoiceDir=" + ust.VoiceDir + buffer.Substring(End);
                    File.WriteAllText(ust.FileName, buffer, Encoding.Default);
                }
            }
        }

        private void SaveAs_Click(object sender, EventArgs e)
        {
            File.Copy(ust.FileName, ust.FileName.Replace(".ust", ".temp"), true);
            SaveFileDialog Save = new SaveFileDialog();
            Save.Filter = "UTAU工程文件|*.ust";
            Save.FilterIndex = 2;
            Save.RestoreDirectory = true;
            Save.ShowDialog();
            if (Save.FileName != "")
            {
                SetInputToUST(); 
                StreamWriter USTWriter = new StreamWriter(Save.OpenFile(), Encoding.GetEncoding("Shift-JIS"));
                StreamReader USTReader = new StreamReader(ust.FileName.Replace(".ust", ".temp"), Encoding.GetEncoding("Shift-JIS"));
                if (!ust.USTSave(USTReader, USTWriter))
                {
                    USTWriter.Close();
                    USTReader.Close();
                    Save.OpenFile().Close();
                    File.Delete(Save.FileName);
                    if (Save.FileName == ust.FileName)
                    {
                        File.Copy(ust.FileName.Replace(".ust", ".temp"), ust.FileName);
                    }
                    File.Delete(ust.FileName.Replace(".ust", ".temp"));
                }
                else
                {
                    USTWriter.Close();
                    USTReader.Close();
                    File.Delete(ust.FileName.Replace(".ust", ".temp"));
                    if (Encoding.Default != Encoding.GetEncoding("Shift-JIS"))
                    {
                        string buffer = File.ReadAllText(Save.FileName, Encoding.Default);
                        int Start = buffer.IndexOf("VoiceDir=");
                        int End = buffer.IndexOf("\n", Start);
                        buffer = buffer.Substring(0, Start - 1) + "VoiceDir=" + ust.VoiceDir + buffer.Substring(End);
                        File.WriteAllText(Save.FileName, buffer, Encoding.Default);
                    }
                }
            }
        }

        private void VoiceSelBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (VoiceSelBox.SelectedIndex != -1)
            {
                string[] Paths = (string[])VoicePaths.ToArray(typeof(string));
                textBox_VoiceDir.Text = Paths[VoiceSelBox.SelectedIndex];
            }
        }

        private void USTRESET_Activated(object sender, EventArgs e)
        {
            if (!VoiceLoaded)
            {
                UTAUSettingError UTAUSettingErrorDlg = new UTAUSettingError();
                UTAUSettingErrorDlg.TopMost = true;
                this.Hide();
                UTAUSettingErrorDlg.Show();
            }
        }

        private void textBox_VoiceDir_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton_RK_0_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ResetPitch_CheckedChanged(object sender, EventArgs e)
        {
            if (ResetPitch.Checked && PitchModeBox.SelectedIndex == 1)
            {
                label_PitchPt.Enabled = true;
                PitchPtBox.Enabled = true;
                PitchPtBox.SelectedIndex = 0;
            }
            else
            {
                label_PitchPt.Enabled = false;
                PitchPtBox.Enabled = false;
                PitchPtBox.SelectedIndex = -1;
            }
        }

        private void PitchModeBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (PitchModeBox.SelectedIndex == 1 && ResetPitch.Checked)
            {
                label_PitchPt.Enabled = true;
                PitchPtBox.Enabled = true;
                PitchPtBox.SelectedIndex = 0;
            }
            else
            {
                label_PitchPt.Enabled = false;
                PitchPtBox.Enabled = false;
                PitchPtBox.SelectedIndex = -1;
            }
        }

        private void ResetFlags_CheckedChanged(object sender, EventArgs e)
        {
            if (!ResetFlags.Checked)
            {
                textBox_BRE.Enabled = false;
                label_BRE.Enabled = false;
            }
            else
            {
                textBox_BRE.Enabled = true;
                label_BRE.Enabled = true;
            }
        }

        private void SetDefault_Click(object sender, EventArgs e)
        {
            textBox_ProjectName.Text = ust.SafeFileName.Replace(".ust", "");
            textBox_OutFile.Text = ust.SafeFileName.Replace(".ust", ".wav");
            textBox_Tool1.Text = "wavtool.exe";
            textBox_Tool2.Text = "resampler.exe";
            try
            {
                VoiceSelBox.SelectedIndex = 0;
            }
            catch
            {
                VoiceSelBox.SelectedIndex = -1;
                textBox_VoiceDir.Text = "";
            }
            textBox_Flags.Text = "";
            textBox_PitchShift.Text = "0";
            PitchModeBox.SelectedIndex = 1;
            SplitR.Checked = true;
            ClearOverlap.Checked = true;
            ClearSTP.Checked = true;
            ResetPitch.Checked = true;
            PitchPtBox.SelectedIndex = 0;
            ResetFlags.Checked = true;
            ResetEnvelope.Checked = true;
            textBox_BRE.Text = "";
            textBox_Vel.Text = "";
            VibratoBox.SelectedIndex = 1;
        }

        public void SetInputToUST()
        {
            ust.ProjectName = textBox_ProjectName.Text;
            ust.OutFile = textBox_OutFile.Text;
            ust.VoiceDir = textBox_VoiceDir.Text;
            ust.Tool1 = textBox_Tool1.Text;
            ust.Tool2 = textBox_Tool2.Text;
            ust.Flags = textBox_Flags.Text;
            ust.BPM = textBox_BPM.Text;            
            if (textBox_PitchShift.Text != "")
            {
                if (!int.TryParse(textBox_PitchShift.Text, out ust.PitchShift))
                {
                    ust.PitchShift = 0;
                }
            }
            ust.PitchMode = PitchModeBox.SelectedIndex + 1;
            ust.DoLyricTrans = DoLyricTrans.Checked;
            ust.FromLyricType = FromLyricType.SelectedIndex + 1;
            ust.ToLyricType = ToLyricType.SelectedIndex + 1;
            ust.DoSplitR = SplitR.Checked;
            ust.DoResetEnvelope = ResetEnvelope.Checked;
            ust.DoClearOverlap = ClearOverlap.Checked;
            ust.DoClearSTP = ClearSTP.Checked;
            ust.DoResetPitch = ResetPitch.Checked;
            ust.ResetPitchPt = PitchPtBox.SelectedIndex + 2;
            ust.DoResetFlags = ResetFlags.Checked;
            if (textBox_BRE.Text != "")
            {
                if (!int.TryParse(textBox_BRE.Text, out ust.BRE))
                {
                    ust.BRE = 50;
                }
                else if (ust.BRE > 100)
                {
                    ust.BRE = 100;
                }
                else if (ust.BRE < 0)
                {
                    ust.BRE = 0;
                }
            }
            if (textBox_Vel.Text != "")
            {
                if (!int.TryParse(textBox_Vel.Text, out ust.Vel))
                {
                    ust.Vel = -1;
                }
            }
            ust.VibratoMode = VibratoBox.SelectedIndex;
        }

        private void DoLyricTrans_CheckedChanged(object sender, EventArgs e)
        {
            if (DoLyricTrans.Checked)
            {
                label_FromLyricType.Enabled = true;
                FromLyricType.Enabled = true;
                FromLyricType.SelectedIndex = 0;
                label_ToLyricType.Enabled = true;
                ToLyricType.Enabled = true;
                ToLyricType.SelectedIndex = 0;
            }
            else
            {
                label_FromLyricType.Enabled = false;
                FromLyricType.SelectedIndex = -1;
                FromLyricType.Enabled = false;
                label_ToLyricType.Enabled = false;
                ToLyricType.SelectedIndex = -1;
                ToLyricType.Enabled = false;
            }
        }

        
    }
}
