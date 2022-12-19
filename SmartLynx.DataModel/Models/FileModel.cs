namespace SmartLynx.DataModel.FileModels
{
    [Serializable]
    public class FileModel
    {
        public Guid Id { get; set; } 
        public string FileName { get; set; }
        public byte[] Content { get; set; }
        public string Type { get; set; }
        public string AddedBy { get; set; }
        public DateTime AddedDate { get; set; }
    }
}