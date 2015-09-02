using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace oto2ust
{
    public partial class main : Form
    {
        public string oto;
        public string dir;
        public int NoteNum(string note)
        {
            string NoteName1 = "";
            string NoteName2 = "";
            if (note.Length >= 2)
            {
                NoteName1 = note.Substring(0, 1);
                NoteName2 = note.Substring(1, 1);
            }
            int NoteNum1 = -1;
            int NoteNum2;
            try
            {
                NoteNum2 = Convert.ToInt32(NoteName2);
            }
            catch
            {
                NoteNum2 = -1;
            }
            string[] Tonality_Type = { "C", "C#", "D", "Eb", "E", "F", "F#", "G", "G#", "A", "Bb", "B"};
            string[] Tonality_Type2 = { "B#", "Db", "D", "D#", "Fb", "E#", "Gb", "G", "Ab", "A", "A#", "Cb" };
            for (int i = 0; i < 12; i++)
            {
                if (NoteName1 == Tonality_Type[i])
                {
                    NoteNum1 = i;
                }
            }
            if (NoteNum1 == -1)
            {
                for (int i = 0; i < 12; i++)
                {
                    if (NoteName1 == Tonality_Type[i])
                    {
                        NoteNum1 = i;
                    }
                }
            }
            if (NoteNum1 == -1 || NoteNum2 == -1 || NoteNum1 + (NoteNum2 + 1) * 12 < 0 || NoteNum1 + (NoteNum2 + 1) * 12 > 83)
            {
                MessageBox.Show("The notekey you entered is wrong. It will be set to C4");
                return 60;
            }
            else
            {
                return NoteNum1 + (NoteNum2 + 1) * 12;
            }
        }
        public main()
        {
            InitializeComponent();
        }

        private void main_Load(object sender, EventArgs e)
        {
            OpenFileDialog Open = new OpenFileDialog();
            Open.Filter = "Configration File(*.ini)|*.ini";
            Open.ShowDialog();
            if (Open.FileName != "")
            {
                oto = File.ReadAllText(Open.FileName, Encoding.GetEncoding("Shift-JIS"));
               dir = Open.FileName.Replace(Open.SafeFileName, "");
            }
            else
            {
                this.Close();
            }
        }
        private string NoteID(int Number)
        {
            if (Number == 0)
            {
                return "[#0000]";
            }
            else if (Number < 10)
            {
                return "[#000" + Number.ToString() + "]";
            }
            else if (Number < 100)
            {
                return "[#00" + Number.ToString() + "]";
            }
            else if (Number < 1000)
            {
                return "[#0" + Number.ToString() + "]";
            }
            else if (Number < 10000)
            {
                return "[#" + Number.ToString() + "]";
            }
            else
            {
                throw new Exception();
            }
        }
        private void button_generate_Click(object sender, EventArgs e)
        {
            if (textBox_BPM.Text == "" || textBox_key.Text == "")
            {
                MessageBox.Show("Please fill in BPM and key for your ust.");
            }
            else
            {
                string ust = "[#VERSION]\r\nUST Version1.2\r\n[#SETTING]\r\nTempo="+textBox_BPM.Text+"\r\nTracks=1\r\nProjectName=oto_test\r\nVoiceDir=voice\\uta"+"\r\nOutFile=\r\nCacheDir=oto_test.cache\r\nTool1=wavtool.exe\r\nTool2=resampler.exe\r\nMode2=True\r\n";
                int pos = 0;
                int pos2 = 0;
                int Number = 0;
                string Notekey = NoteNum(textBox_key.Text).ToString();
                while (true)
                {
                    string lyric;
                    if (Number % 2 == 1)
                    {
                        pos = oto.IndexOf('=', pos);
                        if (pos == -1)
                        {
                            ust += "[#TRACKEND]";
                            break;
                        }
                        pos2 = oto.IndexOf(',', pos);
                        lyric = oto.Substring(pos + 1, pos2 - pos - 1);
                    }
                    else
                    {
                        lyric = "R";
                    }
                    try
                    {
                        ust += NoteID(Number) + "\r\n";
                    }
                    catch
                    {
                        MessageBox.Show("The total number of notes is larger than the limit of a single ust file.");
                        this.Close();
                    }
                    ust += "Length=480\r\n";
                    ust += "Lyric=" + lyric + "\r\n";
                    ust += "NoteNum=" + Notekey + "\r\n";
                    ust += "PreUtterance=\r\nIntensity=100\r\nModulation=0\r\n";
                    Number++;
                    pos++;
                }
                SaveFileDialog Save = new SaveFileDialog();
                Save.Filter = "UTAUスクリプト形式(*.ust)|*.ust";
                Save.ShowDialog();
                File.WriteAllText(Save.FileName, ust, Encoding.GetEncoding("Shift-JIS"));
                MessageBox.Show("Generation succeeded.");
                this.Close();
            }
        }
    }
}
