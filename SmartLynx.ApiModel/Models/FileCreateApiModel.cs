using System.ComponentModel.DataAnnotations;

namespace SmartLynx.ApiModel.Models
{
    [Serializable]
    public class FileCreateApiModel
    {
        [Required]
        public string FileName { get; set; }

        [Required]
        public string Type { get; set; }

        [Required]
        public byte[] Content { get; set; }

        [Required]
        public string AddedBy { get; set; }
    }
}
