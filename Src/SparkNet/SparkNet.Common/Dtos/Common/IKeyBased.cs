using System.ComponentModel.DataAnnotations;
using FlitBit.Dto;

namespace SparkNet.Common.Dtos.Common
{
    [DTO]
    public interface IKeyBased
    {
        [Required(AllowEmptyStrings =  false, ErrorMessage = "Key is required")]
        string Key { get; set; }
    }
}