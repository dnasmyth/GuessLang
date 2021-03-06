﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAlpha
{
    public class LanguageDictionary
    {
        public LanguageDictionary(string lang)
        {
            Language = lang;
            switch (lang)
            {
                case "English":
                    LangDictionary = GetEnglish();
                    break;
                case "Spanish":
                    LangDictionary = GetSpanish();
                    break;
            }
        }

        public string Language
        {
            get { return language; }
            set
            {
                language = value;
            }
        }


        string language;
        Dictionary<char, Letter> langDictionary;
        public Dictionary<char, Letter> dictionary = null;

        public Dictionary<char, Letter> LangDictionary
        {
            get { return langDictionary; }
            set
            {
                langDictionary = value;
            }
        }

        public static Dictionary<char, Letter> GetSpanish()
        {
            Dictionary<char, Letter> spanish = new Dictionary<char, Letter>(34);
            spanish.Add('E', new Letter('E', 13.72));
            spanish.Add('T', new Letter('T', 4.6));
            spanish.Add('A', new Letter('A', 11.72));
            spanish.Add('O', new Letter('O', 8.44));
            spanish.Add('I', new Letter('I', 5.28));
            spanish.Add('N', new Letter('N', 6.83));
           spanish.Add('S', new Letter('S', 7.2));
            spanish.Add('R', new Letter('R', 6.41));
            spanish.Add('H', new Letter('H', 1.18));
            spanish.Add('D', new Letter('D', 4.67));
            spanish.Add('L', new Letter('L', 5.24));
            spanish.Add('U', new Letter('U', 4.55));
            spanish.Add('C', new Letter('C', 3.87));
            spanish.Add('M', new Letter('M', 3.08));
            spanish.Add('F', new Letter('F', 0.69));
            spanish.Add('Y', new Letter('Y', 1.09));
            spanish.Add('W', new Letter('W', 0.04));
            spanish.Add('G', new Letter('G', 1.0));
            spanish.Add('P', new Letter('P', 2.89));
           spanish.Add('B', new Letter('B', 1.49));
           spanish.Add('V', new Letter('V', 1.05));
            spanish.Add('K', new Letter('K', 0.11));
            spanish.Add('X', new Letter('X', 0.14));
            spanish.Add('Q', new Letter('Q', 1.11));
            spanish.Add('J', new Letter('J', 0.52));
            spanish.Add('Z', new Letter('Z', 0.47));
            spanish.Add('Á', new Letter('Á', 0.44));
            spanish.Add('É', new Letter('É', 0.36));
            spanish.Add('Í', new Letter('Í', 0.7));
            spanish.Add('Ñ', new Letter('Ñ', 0.17));
            spanish.Add('Ó', new Letter('Ó', 0.76));
            spanish.Add('Ú', new Letter('Ú', 0.12));
            spanish.Add('Ü', new Letter('Ü', 0.02));
            spanish.Add(' ', new Letter(' ', 0.00));
            return spanish;
        }

            public static Dictionary<char, Letter> GetEnglish()
        {
            Dictionary<char, Letter> english = new Dictionary<char, Letter>(27);
            english.Add('E', new Letter('E', 12.02));
            english.Add('T', new Letter('T', 9.1));
            english.Add('A', new Letter('A', 8.12));
            english.Add('O', new Letter('O', 7.68));
            english.Add('I', new Letter('I', 7.31));
            english.Add('N', new Letter('N', 6.95));
           english.Add('S', new Letter('S', 6.28));
            english.Add('R', new Letter('R', 6.02));
            english.Add('H', new Letter('H', 5.92));
            english.Add('D', new Letter('D', 4.32));
            english.Add('L', new Letter('L', 3.98));
            english.Add('U', new Letter('U', 2.88));
            english.Add('C', new Letter('C', 2.71));
            english.Add('M', new Letter('M', 2.61));
            english.Add('F', new Letter('F', 2.3));
            english.Add('Y', new Letter('Y', 2.11));
            english.Add('W', new Letter('W', 2.09));
            english.Add('G', new Letter('G', 2.03));
            english.Add('P', new Letter('P', 1.82));
            english.Add('B', new Letter('B', 1.49));
            english.Add('V', new Letter('V', 1.11));
            english.Add('K', new Letter('K', 0.69));
           english.Add('X', new Letter('X', 0.17));
            english.Add('Q', new Letter('Q', 0.11));
            english.Add('J', new Letter('J', 0.10));
            english.Add('Z', new Letter('Z', 0.07));
            english.Add(' ', new Letter(' ', 0.00));
            return english;
        }
    }
}
