using System.Collections.Generic;

namespace SparkNet.Common
{
    public interface ICollections
    {
        IEnumerable<string> All(bool shouldOmitSystem = true);
    }
}