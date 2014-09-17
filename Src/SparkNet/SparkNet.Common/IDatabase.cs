using System.Collections.Generic;

namespace SparkNet.Common
{
    public interface IDatabase
    {
        IEnumerable<string> All();

        void Create();

        void Drop();
    }
}