using System.ComponentModel.DataAnnotations;
using FlitBit.Dto;

namespace SparkNet.Common.Dtos.Collections
{
    [DTO]
    public interface ICollectionWithRevisionAndChecksum : ICollectionWithRevision
    {
        [Required]
        string Checksum { get; set; }
    }
}