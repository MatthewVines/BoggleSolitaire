using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Boggle
{
    public static class WordDictionary
    {
        private static List<string> _words;
        public static bool IsInitialized = false;

        public static void Initialize()
        {
            _words = File.ReadAllText("Dictionary.txt").Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries).ToList();
            IsInitialized = true;
        }

        public static bool IsWordInDictionary(string word)
        {
            var qry = (from entry in _words
                       where entry == word
                       select entry);

            return qry.Count() > 0;
        }
    }
}
