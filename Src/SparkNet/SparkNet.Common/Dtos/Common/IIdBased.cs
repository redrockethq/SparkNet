using System.ComponentModel.DataAnnotations;

namespace SparkNet.Common.Dtos.Common
{
    public interface IIdBased
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "Id is required")]
        string Id { get; set; }
    }
}
