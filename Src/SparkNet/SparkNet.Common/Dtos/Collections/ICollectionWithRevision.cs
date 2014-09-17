using System.ComponentModel.DataAnnotations;
using FlitBit.Dto;

namespace SparkNet.Common.Dtos.Collections
{
    [DTO]
    public interface ICollectionWithRevision : ICollection
    {
        [Required]
        string Revision { get; set; }
    }
}