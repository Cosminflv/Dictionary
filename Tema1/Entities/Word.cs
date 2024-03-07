using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema1.Entities
{
    public class WordEntity(string name, string description, string category, string? imagePath)
    {
        public string Name { get; } = name;
        public string Description { get; } = description;
        public string? ImagePath { get; } = imagePath;

        public string Category { get; } = category;
    }
}
