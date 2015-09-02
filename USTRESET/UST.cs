using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Collections;

namespace USTRESET
{
    public class Note
    {
        public Note() { }
        public int Num;
        public int Length;
        public string Lyric = "";
        public int Key;
        public string PreUtterance = "";
        public string VoiceOverlap = "";
        public string Vel = "";
        public string Envelope = "";
        public string PBS = "";
        public string PBW = "";
        public string PBY = "";
        public string PBType = "";
        public string PitchBend = "";
        public string PBStart = "";
        public string STP = "";
        public string Flags = "";
        public string VBR = "";
    }

    public class UST
    {
        public UST()
        {
            NoteList = new Note[10000];
        }
        public string FileName;
        public string SafeFileName;
        public string ProjectName;
        public string OutFile;
        public string VoiceDir;
        public string Flags;
        public string Tool1;
        public string Tool2;
        public string BPM;
        public int PitchShift = 0;
        public int PitchMode = 1;
        public bool DoLyricTrans = false;
        public int FromLyricType = 0;
        public int ToLyricType = 0;
        public bool DoSplitR = false;
        public bool DoResetEnvelope = false;
        public bool DoClearOverlap = false;
        public bool DoClearSTP = false;
        public bool DoResetPitch = false;
        public bool DoResetFlags = false;
        public int ResetPitchPt = 2;
        public int BRE = 50; 
        public int Vel = -1; // -1为清空
        public int VibratoMode; // 0: 不更改，1: 清空， 2: 预设
        public Note[] NoteList;
        public int NoteNumTotal;

        public bool USTLoad(StreamReader USTReader)
        {
            bool USTValid = false;
            for (string ReadBuf = "Starting"; ReadBuf != null; ReadBuf = USTReader.ReadLine())
            {
                if (ReadBuf.Contains("ProjectName="))
                {
                    this.ProjectName = ReadBuf.Remove(0, 12);
                    USTValid = true;
                }
                if (ReadBuf.Contains("OutFile="))
                {
                    this.OutFile = ReadBuf.Remove(0, 8);
                }
                if (ReadBuf.Contains("VoiceDir="))
                {
                    this.VoiceDir = ReadBuf.Remove(0, 9);
                }
                if (ReadBuf.Contains("Tool1="))
                {
                    this.Tool1 = ReadBuf.Remove(0, 6);
                }
                if (ReadBuf.Contains("Tool2="))
                {
                    this.Tool2 = ReadBuf.Remove(0, 6);
                }
                if (ReadBuf.Contains("Flags="))
                {
                    this.Flags = ReadBuf.Remove(0, 6);
                }
                if (ReadBuf.Contains("Tempo="))
                {
                    this.BPM = ReadBuf.Remove(0, 6);
                }
                if (ReadBuf.Contains("Mode2=True"))
                {
                    this.PitchMode = 2;
                }
            }
            return USTValid;
        }
        public bool USTSave(StreamReader USTReader, StreamWriter USTWriter)
        {
            string ReadBuf = "";
            //文件头
            for (; ReadBuf != null; ReadBuf = USTReader.ReadLine())
            {
                string WriteBuf = ReadBuf;
                if (ReadBuf.Contains("Tempo="))
                {
                    WriteBuf = "Tempo=" + this.BPM;
                }
                if (ReadBuf.Contains("ProjectName="))
                {
                    WriteBuf = "ProjectName=" + this.ProjectName;
                }
                if (ReadBuf.Contains("OutFile="))
                {
                    WriteBuf = "OutFile=" + this.OutFile;
                }
                if (ReadBuf.Contains("CacheDir="))
                {
                    WriteBuf = "CacheDir=" + this.SafeFileName.Replace(".ust",".cache");
                }
                if (ReadBuf.Contains("VoiceDir="))
                {
                    WriteBuf = "VoiceDir=" + this.VoiceDir;           
                }
                if (ReadBuf.Contains("Tool1="))
                {
                    WriteBuf = "Tool1=" + this.Tool1;
                }
                if (ReadBuf.Contains("Tool2="))
                {
                    WriteBuf = "Tool2=" + this.Tool2;
                    USTWriter.WriteLine(WriteBuf);
                    //写入是否为Mode2
                    if (this.PitchMode == 2)
                    {
                        WriteBuf = "Mode2=True";
                    }
                    else
                    {
                        WriteBuf = "";
                    }
                }
                if (ReadBuf.Contains("Mode2"))
                {
                    WriteBuf = "";
                }
                if (ReadBuf.Contains("Flags="))
                {
                    WriteBuf = "Flags=" + this.Flags;
                }
                if (ReadBuf.Contains("[#0000]"))
                {
                    break;
                }
                if (WriteBuf != "")
                {
                    USTWriter.WriteLine(WriteBuf);
                }
            }
            if (ReadBuf.Contains("[#0000]"))
            {
                //读取音符
                int count = 0;
                NoteList[count] = new Note();
                NoteList[count].Num = count;
                for (; ReadBuf != "[#TRACKEND]"; ReadBuf = USTReader.ReadLine())
                {
                    if (ReadBuf.Contains("[#"))
                    {
                        count++;
                        NoteList[count] = new Note();
                        NoteList[count].Num = count;
                    }
                    if (ReadBuf.Contains("Length="))
                    {
                        int.TryParse(ReadBuf.Remove(0, 7), out NoteList[count].Length);
                    }
                    if (ReadBuf.Contains("Lyric="))
                    {
                        NoteList[count].Lyric = ReadBuf.Remove(0, 6);
                    }
                    if (ReadBuf.Contains("NoteNum="))
                    {
                        int.TryParse(ReadBuf.Remove(0, 8), out NoteList[count].Key);
                    }
                    if (ReadBuf.Contains("PreUtterance="))
                    {
                        NoteList[count].PreUtterance = ReadBuf.Remove(0, 13);
                    }
                    if (ReadBuf.Contains("VoiceOverlap="))
                    {
                        NoteList[count].VoiceOverlap = ReadBuf.Remove(0, 13);
                    }
                    if (ReadBuf.Contains("Velocity="))
                    {
                        NoteList[count].Vel = ReadBuf.Remove(0, 9);
                    }
                    if (ReadBuf.Contains("Envelope="))
                    {
                        NoteList[count].Envelope = ReadBuf.Remove(0, 9);
                    }
                    if (ReadBuf.Contains("PBS="))
                    {
                        NoteList[count].PBS = ReadBuf.Remove(0, 4);
                    }
                    if (ReadBuf.Contains("PBW="))
                    {
                        NoteList[count].PBW = ReadBuf.Remove(0, 4);
                    }
                    if (ReadBuf.Contains("PBY="))
                    {
                        NoteList[count].PBY = ReadBuf.Remove(0, 4);
                    }
                    if (ReadBuf.Contains("PBType="))
                    {
                        NoteList[count].PBType = ReadBuf.Remove(0, 7);
                    }
                    if (ReadBuf.Contains("PitchBend="))
                    {
                        NoteList[count].PitchBend = ReadBuf.Remove(0, 10);
                    }
                    if (ReadBuf.Contains("PBStart="))
                    {
                        NoteList[count].PBStart = ReadBuf.Remove(0, 8);
                    }
                    if (ReadBuf.Contains("StartPoint="))
                    {
                        NoteList[count].STP = ReadBuf.Remove(0, 11);
                    }
                    if (ReadBuf.Contains("Flags="))
                    {
                        NoteList[count].Flags = ReadBuf.Remove(0, 6);
                    }
                    if (ReadBuf.Contains("VBR="))
                    {
                        NoteList[count].VBR = ReadBuf.Remove(0, 4);
                    }
                }
                NoteNumTotal = count + 1;
                //长休止符切割
                if (DoSplitR)
                {
                    if (!SplitR())
                    {
                        SplitError SplitErrorDlg = new SplitError();
                        SplitErrorDlg.Show();
                        return false;
                    }
                }
                //歌词转换
                if (this.DoLyricTrans)
                {
                    CleanLyric(this.FromLyricType);
                    switch (FromLyricType - ToLyricType)
                    {
                        case 0: break;
                        case 1:
                            {
                                if (FromLyricType != 3)
                                {
                                    TransLyricsTR(2);
                                }
                                else
                                {
                                    TransLyricsRK(2);
                                    TransLyricsTR(1);
                                }
                                break;
                            }
                        case 2:
                            {
                                TransLyricsRK(2);
                                break;
                            }
                        case 3:
                            {
                                TransLyricsRK(2);
                                TransLyricsTR(2);
                                break;
                            }
                        case -1:
                            {
                                if (FromLyricType != 2)
                                {
                                    TransLyricsTR(1);
                                }
                                else
                                {
                                    TransLyricsRK(1);
                                    TransLyricsTR(2);
                                }
                                break;
                            }
                        case -2:
                            {
                                TransLyricsRK(1);
                                break;
                            }
                        case -3:
                            {
                                TransLyricsRK(1);
                                TransLyricsTR(1);
                                break;
                            }
                    }
                }
                //移调
                for (int i = 0; i < NoteNumTotal; i++)
                {
                    NoteList[i].Key += this.PitchShift;
                }

                //写入音符
                for (int i = 0; i < NoteNumTotal; i++)
                {
                    USTWriter.WriteLine(ToNoteTitle(i));
                    USTWriter.WriteLine("Length="+NoteList[i].Length.ToString());
                    USTWriter.WriteLine("Lyric=" + NoteList[i].Lyric);
                    USTWriter.WriteLine("NoteNum=" + NoteList[i].Key.ToString());
                    USTWriter.WriteLine("Modulation=0");
                    if (!this.DoClearOverlap)
                    {
                        USTWriter.WriteLine("PreUtterance=" + NoteList[i].PreUtterance);
                        USTWriter.WriteLine("VoiceOverlap=" + NoteList[i].VoiceOverlap);
                    }
                    else
                    {
                        USTWriter.WriteLine("PreUtterance=");
                    }
                    if (this.Vel!=-1)
                    {
                        USTWriter.WriteLine("Velocity=" + NoteList[i].Vel);
                    }
                    if (!this.DoResetEnvelope)
                    {
                        USTWriter.WriteLine("Envelope=" + NoteList[i].Envelope);
                    }
                    if (!this.DoResetPitch)
                    {
                        USTWriter.WriteLine("PBS=" + NoteList[i].PBS);
                        USTWriter.WriteLine("PBW=" + NoteList[i].PBW);
                        USTWriter.WriteLine("PBY=" + NoteList[i].PBY);
                        USTWriter.WriteLine("PBType=" + NoteList[i].PBType);
                        USTWriter.WriteLine("PitchBend=" + NoteList[i].PitchBend);
                        USTWriter.WriteLine("PBStart=" + NoteList[i].PBStart);
                    }
                    else if (this.PitchMode == 2)
                    {
                        if (NoteList[i].Lyric != "R")
                        {
                            if (this.ResetPitchPt > 2)
                            {
                                NoteList[i].PBW = "";
                                int PBWtime = (int)(NoteList[i].Length / (1.6 * (this.ResetPitchPt - 1)));
                                for (int j = 0; j < this.ResetPitchPt - 1; j++)
                                {
                                    if (j != 0)
                                    {
                                        NoteList[i].PBW += ",";
                                    }
                                    NoteList[i].PBW += PBWtime.ToString();
                                }
                                USTWriter.WriteLine("PBW=" + NoteList[i].PBW);
                                USTWriter.WriteLine("PBS=0");
                            }
                            else
                            {
                                USTWriter.WriteLine("PBW=50");
                                USTWriter.WriteLine("PBS=-25");
                            }
                        }
                    }
                    if (!this.DoClearSTP)
                    {
                        USTWriter.WriteLine("StartPoint=" + NoteList[i].STP);
                    }
                    if (!this.DoResetFlags)
                    {
                        USTWriter.WriteLine("Flags=" + NoteList[i].Flags);
                    }
                    else
                    {
                        USTWriter.WriteLine("Flags=B" +this.BRE+"Y0L5");
                    }
                    if (this.VibratoMode == 0)
                    {
                        USTWriter.WriteLine("VBR=" + NoteList[i].VBR);
                    }
                    else if (this.VibratoMode == 2)
                    {
                        USTWriter.WriteLine("VBR=65,180,35,20,20,0,0,0");
                    }
                }
            }
            USTWriter.WriteLine("[#TRACKEND]");
            return true;
        }
        public bool SplitR()
        {
            try
            {
                for (int i = 0; i < NoteNumTotal; i++)
                {
                    if (NoteList[i].Lyric == "R" && NoteList[i].Length >= 960)
                    {
                        NoteList[NoteNumTotal] = new Note();
                        for (int j = NoteNumTotal - 1; j > i; j--)
                        {
                            NoteList[j + 1] = NoteList[j];
                        }
                        NoteList[i + 1] = NoteList[i];
                        NoteList[i + 1].Length = NoteList[i].Length - 480;
                        NoteList[i].Length = 480;
                        NoteNumTotal++;
                    }
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
        public void CleanLyric(int type)
        {
            switch (type)
            {
                case 0: break;//do nothing
                case 1: //Romaji TanDoku
                    {
                        for (int i = 0; i < NoteNumTotal; i++)
                        {
                            if (NoteList[i].Lyric != "")
                            {
                                if (NoteList[i].Lyric.Substring(0, 1) == "?")
                                {
                                    NoteList[i].Lyric = NoteList[i].Lyric.Remove(0, 1);
                                }
                                try
                                {
                                    for (int j = 3; j >= 1; j--)
                                    {
                                        if (FindRomaji(NoteList[i].Lyric.Substring(0, j)) != -1)
                                        {
                                            NoteList[i].Lyric = NoteList[i].Lyric.Substring(0, j);
                                            break;
                                        }
                                    }
                                }
                                catch { }
                            }
                        }
                        break;
                    }//未考虑罗马音单独音除“?”以外的前缀
                case 2: //Romaji RenZoku
                    {
                        for (int i = 0; i < NoteNumTotal; i++)
                        {
                            if (NoteList[i].Lyric != "" && NoteList[i].Lyric.Contains(" "))
                            {
                                int blank_pos = NoteList[i].Lyric.IndexOf(" ");
                                string body = "";
                                try
                                {
                                    for (int j = 1; j <= 3; j++)
                                    {
                                        if (FindRomaji(NoteList[i].Lyric.Substring(blank_pos + 1, j)) != -1)
                                        {
                                            body = NoteList[i].Lyric.Substring(blank_pos + 1, j);
                                        }
                                    }
                                }
                                catch { }
                                if (body != "" && IsGobi(NoteList[i].Lyric.Substring(blank_pos - 1, 1)))
                                {
                                    NoteList[i].Lyric = NoteList[i].Lyric.Substring(blank_pos - 1, 1) + " " + body;
                                }
                            }
                        }
                        break;
                    }
                case 3: //Kana TanDoku
                    {
                        for (int i = 0; i < NoteNumTotal; i++)
                        {
                            if (NoteList[i].Lyric != "")
                            {
                                string buf = "";
                                for (int j = 0; j < NoteList[i].Lyric.Length; j++)
                                {
                                    try
                                    {
                                        buf = NoteList[i].Lyric.Substring(j, 2);
                                        if (FindKana(buf) == -1)
                                        {
                                            buf = NoteList[i].Lyric.Substring(j, 1);
                                        }
                                    }
                                    catch
                                    {
                                        buf = NoteList[i].Lyric.Substring(j, 1);
                                    }
                                    if (FindKana(buf) != -1)
                                    {
                                        NoteList[i].Lyric = buf;
                                        break;
                                    }
                                }
                            }
                        }
                        break;
                    }
                case 4: //Kana RenZoku
                    {
                        for (int i = 0; i < NoteNumTotal; i++)
                        {
                            if (NoteList[i].Lyric != "" && NoteList[i].Lyric.Contains(" "))
                            {
                                int blank_pos = NoteList[i].Lyric.IndexOf(" ");
                                string body;
                                try
                                {
                                    body = NoteList[i].Lyric.Substring(blank_pos + 1, 2);
                                    if (FindKana(body) == -1)
                                    {
                                        body = NoteList[i].Lyric.Substring(blank_pos + 1, 1);
                                    }
                                }
                                catch
                                {
                                    body = NoteList[i].Lyric.Substring(blank_pos + 1, 1);
                                }
                                if (FindKana(body) != -1 && IsGobi(NoteList[i].Lyric.Substring(blank_pos - 1, 1)))
                                {
                                    NoteList[i].Lyric = NoteList[i].Lyric.Substring(blank_pos - 1, 1) + " " + body;
                                }
                            }
                        }
                        break;
                    }
            }
        }
        public void TransLyricsRK(int mode)
        {
            switch (mode)
            {
                case 0:  //Do nothing 
                    break;
                case 1:  //Romaji to Kana
                    for (int i = 0; i < NoteNumTotal; i++)
                    {
                        if (NoteList[i].Lyric.Contains(" ")) //is RenZokuOn
                        {
                            string head = NoteList[i].Lyric.Substring(0, 1);
                            string body = NoteList[i].Lyric.Remove(0, 2);
                            NoteList[i].Lyric = head + " " + ConvertRomajiToKana(body);
                        }
                        else //is TanDokuOn
                        {
                            NoteList[i].Lyric = ConvertRomajiToKana(NoteList[i].Lyric);
                        }
                    }
                    break;
                case 2:  //Kana to Romaji 
                    for (int i = 0; i < NoteNumTotal; i++)
                    {
                        if (NoteList[i].Lyric.Contains(" ")) //is RenZokuOn
                        {
                            string head = NoteList[i].Lyric.Substring(0, 1);
                            string body = NoteList[i].Lyric.Remove(0, 2);
                            NoteList[i].Lyric = head + " " + ConvertKanaToRomaji(body);
                        }
                        else //is TanDokuOn
                        {
                            NoteList[i].Lyric = ConvertKanaToRomaji(NoteList[i].Lyric);
                        }
                    }
                    break;
            }
        }
        public void TransLyricsTR(int mode)
        {
            switch (mode)
            {
                case 0:  //Do nothing 
                    break;
                case 1:  //TanDoku to RenZoku
                    string tail_of_last = "-";
                    for (int i = 0; i < NoteNumTotal; i++)
                    {
                        string tail = tail_of_last;
                        if (FindKana(NoteList[i].Lyric) != -1)  //is Kana
                        {
                            tail_of_last = ConvertKanaToRomaji(NoteList[i].Lyric).Substring(ConvertKanaToRomaji(NoteList[i].Lyric).Length - 1, 1);
                            NoteList[i].Lyric = tail + " " + NoteList[i].Lyric;
                        }
                        else if (FindRomaji(NoteList[i].Lyric) != -1) //is Romaji
                        {
                            tail_of_last = NoteList[i].Lyric.Substring(NoteList[i].Lyric.Length - 1, 1);
                            NoteList[i].Lyric = tail + " " + NoteList[i].Lyric;
                        }
                        else
                        {
                            tail_of_last = "-";
                        }
                    }
                    break;
                case 2:  //RenZoku to TanDoku
                    for (int i = 0; i < NoteNumTotal; i++)
                    {
                        if (NoteList[i].Lyric.Contains(" ") && (FindKana(NoteList[i].Lyric.Remove(0, 2)) != -1 || FindRomaji(NoteList[i].Lyric.Remove(0, 2)) != -1))
                        {
                            NoteList[i].Lyric = NoteList[i].Lyric.Remove(0, 2);
                        }
                    }
                    break;
            }
        }
        public string ToNoteTitle(int notenum)
        {
            if (notenum < 0 || notenum > 9999)
            {
                return "";
            }
            else if (notenum < 10)
            {
                return "[#000" + notenum.ToString() + "]";
            }
            else if (notenum < 100)
            {
                return "[#00" + notenum.ToString() + "]";
            }
            else if (notenum < 1000)
            {
                return "[#0" + notenum.ToString() + "]";
            }
            else
            {
                return "[#" + notenum.ToString() + "]";
            }
        }
        public string ConvertKanaToRomaji(string _kana)
        {
            for (int i = 0; i < 169; i++)
            {
                if (_kana == Kanas[i])
                {
                    return Romajis[i];
                }
            }
            return _kana;
        }
        public string ConvertRomajiToKana(string _romaji)
        {
            for (int i = 0; i < 169; i++)
            {
                if (_romaji == Romajis[i])
                {
                    return Kanas[i];
                }
            }
            return _romaji;
        }
        public int FindKana(string _kana)
        {
            for (int i = 0; i < 169; i++)
            {
                if (_kana == Kanas[i])
                {
                    return i;
                }
            }
            return -1;
        }
        public int FindRomaji(string _romaji)
        {
            for (int i = 0; i < 169; i++)
            {
                if (_romaji == Romajis[i])
                {
                    return i;
                }
            }
            return -1;
        }
        public bool IsGobi(string _gobi)
        {
            if (_gobi.Length != 1)
            {
                return false;
            }
            else
            {
                if (_gobi == "a" || _gobi == "i" || _gobi == "u" || _gobi == "e" || _gobi == "o" || _gobi == "n" || _gobi == "-")
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        string[] Kanas = { "あ", "い", "いぇ", "う", "うぁ", "うぃ", "うぇ", "え", "お", "か", "が", "き", "きぇ", "きゃ", "きゅ", "きょ", "ぎ", "ぎぇ", "ぎゃ", "ぎゅ", "ぎょ", "く", "くぁ", "くぃ", "くぇ", "くぉ", "ぐ", "ぐぁ", "ぐぃ", "ぐぇ", "ぐぉ", "け", "げ", "こ", "ご", "さ", "ざ", "し", "し", "しぇ", "しゃ", "しゅ", "しょ", "じ", "じぇ", "じゃ", "じゅ", "じょ", "す", "すぁ", "すぃ", "すぇ", "すぉ", "ず", "ずぁ", "ずぃ", "ずぇ", "ずぉ", "せ", "ぜ", "そ", "ぞ", "た", "だ", "ち", "ちぇ", "ちゃ", "ちゅ", "ちょ", "つ", "つぁ", "つぃ", "つぇ", "つぉ", "て", "てぃ", "てゅ", "で", "でぃ", "でゅ", "と", "とぅ", "ど", "どぅ", "な", "に", "にぇ", "にゃ", "にゅ", "にょ", "ぬ", "ぬぁ", "ぬぃ", "ぬぇ", "ぬぉ", "ね", "の", "は", "ば", "ぱ", "ひ", "ひぇ", "ひゃ", "ひゅ", "ひょ", "び", "びぇ", "びゃ", "びゅ", "びょ", "ぴ", "ぴぇ", "ぴゃ", "ぴゅ", "ぴょ", "ふ", "ふぁ", "ふぃ", "ふぇ", "ふぉ", "ぶ", "ぶぁ", "ぶぃ", "ぶぇ", "ぶぉ", "ぷ", "ぷぁ", "ぷぃ", "ぷぇ", "ぷぉ", "へ", "べ", "ぺ", "ほ", "ぼ", "ぽ", "ま", "み", "みぇ", "みゃ", "みゅ", "みょ", "む", "むぁ", "むぃ", "むぇ", "むぉ", "め", "も", "や", "ゆ", "よ", "ら", "り", "りぇ", "りゃ", "りゅ", "りょ", "る", "るぁ", "るぃ", "るぇ", "るぉ", "れ", "ろ", "わ", "お", "を", "ん" };
        string[] Romajis = { "a", "i", "ye", "u", "ua", "ui", "we", "e", "o", "ka", "ga", "ki", "kye", "kya", "kyu", "kyo", "gi", "gye", "gya", "gyu", "gyo", "ku", "kua", "kui", "kue", "kuo", "gu", "gua", "gui", "gue", "guo", "ke", "ge", "ko", "go", "sa", "za", "si","shi", "sye", "sya", "syu", "syo", "ji", "jye", "jya", "jyu", "jyo", "su", "sua", "sui", "sue", "suo", "zu", "zua", "zui", "zue", "zuo", "se", "ze", "so", "zo", "ta", "da", "chi", "che", "cha", "chu", "cho", "tu", "tua", "tui", "tue", "tuo", "te", "ti", "tyu", "de", "di", "dyu", "to", "twu", "do", "dwu", "na", "ni", "nye", "nya", "nyu", "nyo", "nu", "nua", "nui", "nue", "nuo", "ne", "no", "ha", "ba", "pa", "hi", "hye", "hya", "hyu", "hyo", "bi", "bye", "bya", "byu", "byo", "pi", "pye", "pya", "pyu", "pyo", "fu", "fa", "fi", "fe", "fo", "bu", "bua", "bui", "bue", "buo", "pu", "pua", "pui", "pue", "puo", "he", "be", "pe", "ho", "bo", "po", "ma", "mi", "mye", "mya", "myu", "myo", "mu", "mua", "mui", "mue", "muo", "me", "mo", "ya", "yu", "yo", "ra", "ri", "rye", "rya", "ryu", "ryo", "ru", "rua", "rui", "rue", "ruo", "re", "ro", "wa", "wo", "o", "n" };
    }
}
