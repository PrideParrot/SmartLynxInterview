using SmartLynx.ApiModel.FileModels;
using SmartLynx.DataModel.FileModels;
using Swashbuckle.AspNetCore.Filters;

namespace SmartLynxInterview.Examples
{
    public class FileModelExample : IExamplesProvider<FileModel>
    {
        public FileModel GetExamples()
        {
            return new FileModel()
            {
                FileName = "TestFileName",
                Content = new byte[] { 0x20, 0x20, 0x20, 0x20, 0x20, 0x20, 0x20 },
                Type = ".txt",
                AddedBy = "TestUser",
                AddedDate = DateTime.Now
            };
        }
    }
}
