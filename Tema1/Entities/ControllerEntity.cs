﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;
using System.Windows.Media;
using Microsoft.VisualBasic;

namespace Tema1.Entities
{
    public class ControllerEntity
    {
        private readonly JsonHandlerEntity _jsonHandlerEntity;
        public DictionaryEntity? DictionaryEntity { get; set; }

        private readonly AdminEntity _adminEntity;

        public ControllerEntity()
        {
            _jsonHandlerEntity = new JsonHandlerEntity();

            _adminEntity = new AdminEntity();
        }

        public bool initDictionary()
        {
            List<WordEntity>? deserializedWords = _jsonHandlerEntity.getWordsFromJson("D:\\Informatica\\ANUL II\\MAP\\MAPTema1\\Tema1\\Json\\Words.json");

            if (deserializedWords == null) return false;

            Dictionary<string, int> categories = GetUniqueCategories(deserializedWords);

            DictionaryEntity = new DictionaryEntity(deserializedWords, categories);

            return true;
        }

        public List<WordEntity> searchByCategory(string category)
        {
            if (DictionaryEntity == null) { return new List<WordEntity>(); }

            List<WordEntity>? result = DictionaryEntity.searchByCategory(category);

            if (result == null) { return new List<WordEntity>(); }

            return result;
        }

        private Dictionary<string, int> GetUniqueCategories(List<WordEntity> words)
        {
            Dictionary<string, int> categoriesMap = new Dictionary<string, int>();
            int id = 0;

            foreach (WordEntity word in words)
            {
                if (!categoriesMap.ContainsKey(word.Category))
                {
                    categoriesMap.Add(word.Category, id);
                    id++;
                }
            }
            return categoriesMap;
        }

        public ImageSource? ConvertStringToImageSource(string imagePath)
        {
            try
            {
                // Create a new BitmapImage object
                BitmapImage imageSource = new BitmapImage();

                // Set the image source URI to the provided string path
                imageSource.BeginInit();
                imageSource.UriSource = new Uri(imagePath, UriKind.RelativeOrAbsolute);
                imageSource.EndInit();

                return imageSource;
            }
            catch (Exception ex)
            {
                // Handle any exceptions that may occur during conversion
                Console.WriteLine("Error converting string to ImageSource: " + ex.Message);
                return null;
            }
        }

        public string GetImageForWord(string wordToFind)
        {
            List<WordEntity> words = DictionaryEntity!.Words!;
            foreach (var word in words)
            {
                if (wordToFind.Equals(word.Name))
                {
                    if (word.ImagePath != "")
                    {
                        return word.ImagePath!;
                    }
                }
            }
            return "D:/Informatica/ANUL II/MAP/MAPTema1/Tema1/images/no_image.JPG";
        }

        public string GetCategoryForWord(string wordToFind)
        {
            List<WordEntity> words = DictionaryEntity!.Words!;
            foreach (var word in words)
            {
                if (wordToFind.Equals(word.Name))
                {
                    return word.Category;
                }
            }
            return "No Category Found";
        }

        public string GetDescriptionForWord(string wordToFind)
        {
            List<WordEntity> words = DictionaryEntity!.Words!;
            foreach (var word in words)
            {
                if (wordToFind.Equals(word.Name))
                {
                    return word.Description;
                }
            }

            return "No description available";
        }

        public bool checkTextValid(String text)
        {
            List<WordEntity> words = DictionaryEntity!.Words!;
            foreach (var word in words)
            {
                if (text == word.Name) return true;
            }
            return false;
        }
    }
}
