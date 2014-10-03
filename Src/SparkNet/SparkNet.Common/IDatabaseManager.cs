using System.Collections.Generic;
using SparkNet.Common.Dtos.Databases;

namespace SparkNet.Common
{
    public interface IDatabaseManager
    {
        IEnumerable<string> All();

        void Create(ICreateDatabase database);

        void Create(ICreateWithUsersDatabase database);

        void Drop(string name);
    }
}