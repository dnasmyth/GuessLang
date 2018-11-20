using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MAlpha
{
    public partial class CodeForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public CodeForm()
        {
            InitializeComponent();
           
        }

        Dictionary<char, Letter> [] AnalisisDict = new Dictionary<char, Letter>[2];
        
        LanguageDictionary spanish = new LanguageDictionary("Spanish");
        LanguageDictionary english = new LanguageDictionary("English");
        LanguageDictionary[] testDic = new LanguageDictionary[2];
        


        void UpdateFreq(string text, Dictionary<char, Letter> dic)
        {
            double totalChar = text.Length;
            for (int i = 0; i < dic.Count; i++)
            {
                var l = dic.ElementAt(i);
                l.Value.Frequency = (l.Value.Count / totalChar) * 100.0;
            }
        }

        private void decodeBtn_Click(object sender, EventArgs e)
        {
            testDic[0] = spanish;
            testDic[1] = english;
            AnalisisDict[0] = new Dictionary<char, Letter>();
            AnalisisDict[1] = new Dictionary<char, Letter>();
            for (int i = 0; i <= 1; i++)
            {
                Letter letter = default;
                string text = codedTextMemo.Text;
                text = text.ToUpper();
                foreach (char x in text)
                {
                    if (testDic[i].LangDictionary.ContainsKey(x))
                    {
                        if (AnalisisDict[i].ContainsKey(x))
                        {
                            AnalisisDict[i].TryGetValue(x, out letter);
                            letter.Count++;
                        }
                        else
                        {
                            Letter toAdd = new Letter()
                            {

                                AlphaChar = x,
                                Count = 1
                            };
                            Letter TestLetter = default;
                            testDic[i].LangDictionary.TryGetValue(x, out TestLetter);
                            toAdd.TargetFrequency = TestLetter.Frequency;
                            AnalisisDict[i].Add(x, toAdd);

                        }
                    }
                }
                UpdateFreq(text, AnalisisDict[i]);
            }
            var en = (from f in AnalisisDict[0]
                     orderby f.Value.TargetFrequency descending
                     select f.Value).ToList<Letter>();
            FreqListBox.DataSource = en;
            var sp = (from f in AnalisisDict[1]
                     orderby f.Value.TargetFrequency descending
                     select f.Value).ToList<Letter>();
            listBoxSpanish.DataSource = sp;
            double spanishPercent = default;
            double englishPercent = default;
            foreach (Letter item in sp)
            {
                spanishPercent += item.Frequency;
            }
            foreach (Letter item in en)
            {
                englishPercent += item.Frequency;
            }
            if (spanishPercent > englishPercent)
                teAnswer.Text = "Spanish";
            else teAnswer.Text = "English";
            teSpan.Text = spanishPercent.ToString("0.00");
            teEng.Text = englishPercent.ToString("0.00");

        }
    }
}
