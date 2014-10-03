using System.Collections.Generic;

namespace SparkNet.Common
{
    public interface IDocument
    {
        IEnumerable<T> All<T>(string collection);

        void Create<T>(string collection, T document);

        T ById<T>(string id);

        void Update<T>(string collection, T document, bool shouldReplaceDocument = false);

        void Delete(string id);
    }
}