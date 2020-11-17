using DotRepo;
using System;
using System.Collections.Generic;

namespace DotRepo
{
    public class Repository<T> : IRepository<T> where T : class, IModel
    {
        public IList<T> Data { get; set; }
        public Repository(IDataLoader<T> dataLoader)
        {
            Data = dataLoader.GetData();
        }
    }
}
