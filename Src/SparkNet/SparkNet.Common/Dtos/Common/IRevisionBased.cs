using System.ComponentModel.DataAnnotations;
using FlitBit.Dto;

namespace SparkNet.Common.Dtos.Common
{
    [DTO]
    public interface IRevisionBased
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "Revision is required")]
        string Revision { get; set; }
    }
}