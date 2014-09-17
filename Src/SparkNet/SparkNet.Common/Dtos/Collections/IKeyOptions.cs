using FlitBit.Dto;

namespace SparkNet.Common.Dtos.Collections
{
    [DTO]
    public interface IKeyOptions
    {
        KeyKind Type { get; set; }
    }
}