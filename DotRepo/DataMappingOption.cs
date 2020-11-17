using System.Collections.Generic;

namespace DotRepo{
    public class DataMappingOption
    {
        public string TableName { get; set; }
        public Dictionary<string,string> PropertyMap { get; set; }

        public string[] Keys { get; set; }
    }
}