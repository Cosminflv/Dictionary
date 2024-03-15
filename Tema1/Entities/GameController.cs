using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;
using System.Windows.Media;
using System.Windows.Navigation;

namespace Tema1.Entities
{
    internal class GameController
    {
        private readonly Random _random;
        public List<WordEntity>? WordsToGuess { get; set; }
        public JsonHandlerEntity JsonHandlerEntity { get; }
        public DictionaryEntity? DictionaryEntity { get; set; }
        public GameController(JsonHandlerEntity jsonHandler) { JsonHandlerEntity = jsonHandler; _random = new Random(); }

        public bool initDictionary()
        {
            List<WordEntity>? deserializedWords = JsonHandlerEntity.getWordsFromJson(@"..\..\..\Json\Words.json");

            if (deserializedWords == null) return false;

            DictionaryEntity = new DictionaryEntity(deserializedWords, null);

            return true;
        }

        public void startGame()
        {
            WordsToGuess = DictionaryEntity!.pickRandomWords();
        }

        public bool consumeWord()
        {
            WordsToGuess!.RemoveAt(0);

            if(WordsToGuess!.Count == 0) return false;

            return true;
        }

        public string GetRandomDescriptionOrImagePath()
        {
            if(WordsToGuess![0].ImagePath == null) return WordsToGuess![0].Description;

            int randomNumber = _random.Next(2);

            return randomNumber == 0 ? WordsToGuess![0].Description : WordsToGuess![0].ImagePath!;
        }

        public bool CheckEnteredWord(string wordToCheck)
        {
            return wordToCheck == WordsToGuess!.First().Name.ToLower() || wordToCheck == WordsToGuess!.First().Name;
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

        public bool IsGameFinished()
        {
            return WordsToGuess!.Count == 0;
        }


    }
}
