namespace SmartLynx.ApiModel.Models
{
    [Serializable]
    public class FileContentApiModel
    {
        public Guid Id { get; set; }
        public byte[] Content { get; set; }
    }
}
