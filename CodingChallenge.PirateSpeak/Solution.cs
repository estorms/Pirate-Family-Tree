using System;
using System.Linq;
using System.Collections.Generic;

namespace CodingChallenge.PirateSpeak
{
    public class Solution
    {
        public string[] GetPossibleWords(string jumble, string[] dictionary)
        {
            try {
            //order the jumbled string by converting it to a char array and then ordering by each letter in the array
            var orderedJumble = jumble.ToCharArray().OrderBy(c => c);
            //concat the ordered char array back to string (<IEnumerable> char won't convert via ToString())
            var orderJumbleString = String.Concat(orderedJumble);
            //repeat the above process for each string in the dictionary and add it to a list instantiated to hold the ordered dictionary strings
            var DictionaryList = new List<string>();
            foreach(var s in dictionary) {
               var orderedDictionary = s.ToCharArray().OrderBy(c => c);
               var orderedDictionaryString = String.Concat(orderedDictionary);
               DictionaryList.Add(orderedDictionaryString);
            }
            var valuesList = new List<string>();

            for (var i = 0; i < DictionaryList.Count; i++) {
                if (DictionaryList[i] == orderJumbleString) {
                    valuesList.Add(dictionary[i]);
                }
                    Console.WriteLine("{0}", DictionaryList[i]);
            }
            for (var i = 0; i < valuesList.ToArray().Length; i++) {
                Console.WriteLine("{0} w/in array", valuesList[i]);
            }
            return valuesList.ToArray();

            // throw new NotImplementedException();
        }
        catch {
            throw new ArgumentException();
        }
    }
}}