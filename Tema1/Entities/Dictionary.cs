using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema1.Entities
{
    public class DictionaryEntity
    {
        public List<WordEntity>? Words { get; set; }

        public Dictionary<string, int>? categories { get; set; }

        public DictionaryEntity(List<WordEntity> words, Dictionary<string, int>? categories)
        {
            this.Words = words;
            this.categories = categories;
        }

        public DictionaryEntity() { Words = null; categories = null; }

        public void addWord(WordEntity word)
        {
            if (Words == null) return;
            Words.Add(word);
        }
        public void removeWord(string wordToRemove)
        {
            foreach(WordEntity word in Words!)
            {
                if(word.Name == wordToRemove)
                {
                    Words.Remove(word);
                    break;
                }
            }
        }

        public List<WordEntity> searchByCategory(string category)
        {
            List<WordEntity> result = new List<WordEntity> ();

            if (Words == null) return result;

            foreach (WordEntity word in Words)
            {
                if(word.Category == category) result.Add(word);
            }
            return result;
        }

        public string? getCategoryByIndex(int index)
        {
            if (categories == null) return null;

            string selectedCategory = categories.FirstOrDefault(kvp => kvp.Value == index).Key;

            return selectedCategory;
        }

        public List<string> wordsNames()
        {
            List<string> words = new List<string> ();

            foreach(WordEntity word in Words!)
            {
                words.Add(word.Name);
            }
            return words;
        }

        public WordEntity? checkWordExistence(String text)
        {
            if(Words == null) return null;
            foreach (var word in Words!)
            {
                if (text == word.Name) return word;
            }
            return null;
        }

        public List<WordEntity>? pickRandomWords()
        {
 
            if (Words == null || Words.Count == 0) return null;

            Random random = new Random();

            List<WordEntity> shuffledWords = Words.OrderBy(x => random.Next()).ToList();

            List<WordEntity> randomWords = shuffledWords.Take(5).ToList();

            return randomWords;
        }
    }
}
