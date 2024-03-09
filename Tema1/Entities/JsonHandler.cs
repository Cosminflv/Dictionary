using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Tema1.Entities
{
    public class JsonHandlerEntity
    {

        public JsonHandlerEntity() { }

        public void serializeWords(List<WordEntity> words, string path)
        {
            try
            {
                // Serialize the list of WordEntity objects to JSON
                string jsonString = JsonSerializer.Serialize(words);

                // Write the JSON string to a file
                File.WriteAllText(path, jsonString);

                Console.WriteLine("Serialization successful.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error during serialization: {ex.Message}");
            }
        }
        public List<WordEntity>? getWordsFromJson(string path)
        {
            try
            {
                // Read the JSON string from the file
                string jsonString = File.ReadAllText(path);

                // Deserialize the JSON string to a list of WordEntity objects
                List<WordEntity>? words = JsonSerializer.Deserialize<List<WordEntity>>(jsonString);

                Console.WriteLine("Deserialization successful.");

                return words;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error during deserialization: {ex.Message}");
                return null;
            }
        }

        public void serializeAccounts(List<Tuple<string, string>> accounts, string path)
        {
            try
            {
                // Serialize the list of WordEntity objects to JSON
                string jsonString = JsonSerializer.Serialize(accounts);

                // Write the JSON string to a file
                File.WriteAllText(path, jsonString);

                Console.WriteLine("Serialization successful.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error during serialization: {ex.Message}");
            }
        }

        public List<Tuple<string, string>>? getAccounts(string path)
        {
            try
            {
                string jsonString = File.ReadAllText(path);

                List<Tuple<string, string>> accounts = JsonSerializer.Deserialize<List<Tuple<string, string>>>(jsonString);

                Console.WriteLine("Deserialization successful.");

                return accounts;
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Error during deserialization: {ex.Message}");
                return null;
            }
        }
    }
}
