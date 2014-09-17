using FlitBit.Dto;
using SparkNet.Common.Dtos.Common;

namespace SparkNet.Common.Dtos.Collections
{
    [DTO]
    public interface IBasicCollection : IIdBased, INameBased
    {
        CollectionKind Type { get; set; }
    }
}