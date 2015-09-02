using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace X_SAMPAlizer
{
    class Program
    {
        [STAThreadAttribute]
        static void Main(string[] args)
        {
            Console.WriteLine("Cz to X-SAMPA Translator 1.0");
            Console.WriteLine("sdercolin / UG  CopyRight  2015");
            Console.WriteLine("请选择要使用的转换规则表：");
            OpenFileDialog Open = new OpenFileDialog();
            Open.Filter = "文本文件|*.txt";

            if (Open.ShowDialog() == DialogResult.OK)
            {
                Open.Dispose();
                Cz = new List<string>();
                X_SAMPA = new List<string>();
                int CzPieceMaxLength = 0;
                    using (StreamReader sr = new StreamReader(Open.FileName, Encoding.UTF8))
                {
                    while (!sr.EndOfStream)
                    {
                        string text = sr.ReadLine();
                        if (text.Contains("="))
                        {
                            string[] temp = text.Split(new string[] { "=" }, StringSplitOptions.None);
                            Cz.Add(temp[0]);
                            X_SAMPA.Add(temp[1]);
                            if(temp[0].Length> CzPieceMaxLength)
                            {
                                CzPieceMaxLength = temp[0].Length;
                            }
                        }
                    }
                }
                while (true)
                {
                    Console.WriteLine("请选择要转换的oto文件：");
                    OpenFileDialog OpenOto = new OpenFileDialog();
                    OpenOto.Filter = "oto文件|*.ini";
                    if (OpenOto.ShowDialog() == DialogResult.OK)
                    {
                        string NewOto = "";
                        using (StreamReader sr = new StreamReader(OpenOto.FileName, Encoding.UTF8))
                        {
                            while (!sr.EndOfStream)
                            {
                                string text = sr.ReadLine();
                                if (text.Contains("="))
                                {
                                    int pos = text.IndexOf("=");
                                    int pos2 = text.IndexOf(",", pos);
                                    string CzString = text.Substring(pos + 1, pos2 - pos - 1);
                                    string X_SAMPAString = ConvertString(CzString, CzPieceMaxLength);
                                    NewOto += text.Substring(0, pos + 1) + X_SAMPAString + text.Substring(pos2) + Environment.NewLine;
                                }
                            }
                            Console.WriteLine("oto文件转换成功，共转换" + ConvertedCount.ToString() + "条。");
                            Console.WriteLine("请保存新的oto文件：");
                            using (SaveFileDialog SaveOto = new SaveFileDialog())
                            {
                                SaveOto.Filter = "oto文件|*.ini";
                                if (SaveOto.ShowDialog() == DialogResult.OK)
                                {
                                    File.WriteAllText(SaveOto.FileName, NewOto);
                                }
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("未成功读取oto文件。");
                    }
                    Console.WriteLine("是否继续转换？");
                    Console.WriteLine("输入\"1\"以继续，否则程序将结束运行：");
                    string read = Console.ReadLine();
                    if (read != "1")
                    {
                        break;
                    }
                }
            }
        }
        static List<string> Cz;
        static List<string> X_SAMPA;
        static bool ConvertPiece(string CzPiece, out string X_SAMPAPiece)
        {
            if (Cz.Contains(CzPiece))
            {
                X_SAMPAPiece= X_SAMPA[Cz.IndexOf(CzPiece)];
                return true;
            }
            else
            {
                X_SAMPAPiece = "";
                return false;
            }
        }
        static int ConvertedCount = 0;
        static string ConvertString(string CzString, int PieceMaxLength)
        {
            string X_SAMPAString = "";
            for (int ProcessPos = 0; ProcessPos < CzString.Length; ProcessPos++)
            {
                bool PieceConverted = false;
                for (int PieceLength = PieceMaxLength; PieceLength > 0; PieceLength--)
                {
                    if(PieceLength+ProcessPos<= CzString.Length)
                    {
                        string X_SAMPAPiece;
                        if(ConvertPiece(CzString.Substring(ProcessPos,PieceLength),out X_SAMPAPiece))
                        {
                            X_SAMPAString += X_SAMPAPiece;
                            ProcessPos += PieceLength - 1;
                            PieceConverted = true;
                            break;
                        }
                    }
                    else
                    {
                        continue;
                    }
                }
                if(!PieceConverted)
                {
                    X_SAMPAString += CzString.Substring(ProcessPos, 1);
                }
            }
            if(X_SAMPAString!=CzString)
            {
                Console.WriteLine("转换成功：\"" + CzString + "\"→" + "\"" + X_SAMPAString + "\"");
                ConvertedCount++;
            }
            return X_SAMPAString;
        }
    }
}
