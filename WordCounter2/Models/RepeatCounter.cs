﻿using System;
using System.Collections.Generic;

namespace WordCounter.Models
{
    public class RepeatCounter
    {
        private string _theWord;
        private string[] _arrayOfWords;
        private Dictionary<string, int> _WordsFromArrayDictionary = new Dictionary<string, int>() { };
        private bool _validCounter;

        public RepeatCounter(string word, string phrase)
        {
            HandleFirstWord(word);
            HandlePhrase(phrase);
        }

        public void SetTheWord(string input)
        {
            _theWord = input.ToLower();
        }

        public string GetTheWord()
        {
            return _theWord;
        }

        public void SetTheArrayOfWords(string input)
        {
            char[] takeOut = { '.', ',', ' ', '"', '-', '!', '@', '#', '$', '%', '^', '&', '(', ')', '?', '*', '_', '+', '`', '~', '/', '\'', '=' };
            _arrayOfWords = input.ToLower().Split(takeOut);
        }

        public string[] GetTheArrayOfWords()
        {
            return _arrayOfWords;
        }

        public bool GetValidCounter()
        {
            return _validCounter;
        }

        public void SetWordsFromArrayDictionary(string[] input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                if (GetWordsFromArrayDictionary().ContainsKey(input[i]))
                {
                    GetWordsFromArrayDictionary()[input[i]]++;
                }
                else
                {
                    GetWordsFromArrayDictionary().Add(input[i], 1);
                }
            }
        }

        public void CheckIfValidWord(string word)
        {
            string input = word;
            if (input.Split(" ").Length == 1)
            {
                _validCounter = true;
                SetTheWord(input);
            }
            else
            {
                _validCounter = false;
            }
        }

        public Dictionary<string, int> GetWordsFromArrayDictionary()
        {
            return _WordsFromArrayDictionary;
        }

        public int FindTheNumberOfOccurences()
        {
            if (GetWordsFromArrayDictionary().ContainsKey(GetTheWord()))
            {
                return GetWordsFromArrayDictionary()[GetTheWord()];
            }
            else
            {
                return 0;
            }
        }

        public void HandleFirstWord(string word)
        {
            CheckIfValidWord(word);
        }

        public void HandlePhrase(string phrase)
        {
            SetTheArrayOfWords(phrase);
            SetWordsFromArrayDictionary(GetTheArrayOfWords());
        }
    }
}
