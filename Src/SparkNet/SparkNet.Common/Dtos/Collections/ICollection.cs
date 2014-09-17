using System.Collections.Generic;
using FlitBit.Dto;

namespace SparkNet.Common.Dtos.Collections
{
    [DTO]
    public interface ICollection : IBasicCollection
    {
        bool ShouldWaitForSync { get; set; }

        bool ShouldCompact { get; set; }

        bool IsSystem { get; set; }

        bool IsVolatile { get; set; }

        IKeyOptions KeyOptions { get; set; }

        int NumberOfShards { get; set; }

        IEnumerable<string> ShardKeys { get; set; }

    }
}