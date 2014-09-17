using System.ComponentModel.DataAnnotations;
using FlitBit.Dto;

namespace SparkNet.Common.Dtos.Common
{
    [DTO]
    public interface INameBased
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "Name is required")]
        string Name { get; set; }
    }
}