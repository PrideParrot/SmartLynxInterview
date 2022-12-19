using SmartLynx.ApiModel.Models;
using Swashbuckle.AspNetCore.Filters;

namespace SmartLynxInterview.Examples
{
    public class FileCreateApiModelExample : IExamplesProvider<FileCreateApiModel>
    {
        public FileCreateApiModel GetExamples()
        {
            return new FileCreateApiModel()
            {
                FileName = "TestFileName",
                Type = ".txt",
                Content = new byte[] { 0x20, 0x20, 0x20, 0x20, 0x20, 0x20, 0x20 },
                AddedBy = "TestUser"
            };
        }
    }
}
