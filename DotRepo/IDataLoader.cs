using DotRepo;
using System;
using System.Collections.Generic;
using System.Text;

namespace DotRepo
{
    public interface IDataLoader<T> where T : IModel
    {
        IList<T> GetData();
    }
}
