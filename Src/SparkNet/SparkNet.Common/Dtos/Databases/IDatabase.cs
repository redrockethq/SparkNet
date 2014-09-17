using System.ComponentModel.DataAnnotations;
using FlitBit.Dto;
using SparkNet.Common.Dtos.Common;

namespace SparkNet.Common.Dtos.Databases
{
    [DTO]
    public interface IDatabase : IBasicDatabase, IIdBased
    {
        [Required]
        string Path { get; set; }
        
        bool IsSystem { get; set; }
    }
}