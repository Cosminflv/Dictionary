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

        public DictionaryEntity(List<WordEntity> words, Dictionary<string, int> categories)
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
        public void removeWord(WordEntity word)
        {
            if (Words == null) return;
            Words.Remove(word);
        }

        public List<WordEntity> searchByName(string prefix)
        {
            List<WordEntity> matchingWords = new List<WordEntity>();

            if (Words != null)
            {
                foreach (WordEntity word in Words)
                {
                    string wordName = word.Name.ToLower();
                    // Check if the name of the word begins with the prefix
                    if (wordName.StartsWith(prefix))
                    {
                        matchingWords.Add(word);
                    }
                }
            }

            return matchingWords;
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

        public List<WordEntity> searchByCategoryAndName(string prefix, String category)
        {
            List<WordEntity> matchingWords = new List<WordEntity>();

            if (Words != null)
            {
                foreach (WordEntity word in Words)
                {
                    string wordName = word.Name.ToLower();
                    // Check if the name of the word begins with the prefix and matches the category
                    if (wordName.StartsWith(prefix) && word.Category == category)
                    {
                        matchingWords.Add(word);
                    }
                }
            }
            return matchingWords;
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

        public bool checkWordExistence(String text)
        {
            if(Words == null) return false;
            foreach (var word in Words!)
            {
                if (text == word.Name) return true;
            }
            return false;
        }
    }
}
