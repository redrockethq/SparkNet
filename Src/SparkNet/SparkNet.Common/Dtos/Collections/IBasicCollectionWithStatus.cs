using FlitBit.Dto;

namespace SparkNet.Common.Dtos.Collections
{
    [DTO]
    public interface IBasicCollectionWithStatus : IBasicCollection
    {
        CollectionState Status { get; set; }
    }
}