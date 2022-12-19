namespace SmartLynx.ApiModel.FileModels
{
    [Serializable]
    public class FileApiModel
    {
        public Guid Id { get; set; }
        public string FileName { get; set; }
        public string Type { get; set; }
        public string AddedBy { get; set; }
        public DateTime AddedDate { get; set; }
    }
}