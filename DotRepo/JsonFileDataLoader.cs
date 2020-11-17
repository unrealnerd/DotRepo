using DotRepo;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace DotRepo
{
    public class JsonFileDataLoader<T> : IDataLoader<T> where T : class, IModel
    {
        private readonly string _filePath;

        public JsonFileDataLoader(string filePath)
        {
            _filePath = filePath;
        }

        public IList<T> GetData()
        {
            var jsonString = File.ReadAllText(_filePath);
            return JsonSerializer.Deserialize<List<T>>(jsonString);
        }
    }
}
