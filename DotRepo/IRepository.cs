using System.Collections.Generic;

namespace DotRepo
{
    public interface IRepository<T> where T : class
    {
        IList<T> Data { get; set; }
    }
}