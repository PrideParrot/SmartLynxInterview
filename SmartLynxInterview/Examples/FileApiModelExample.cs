using SmartLynx.ApiModel.FileModels;
using Swashbuckle.AspNetCore.Filters;

namespace SmartLynxInterview.Examples
{
    public class FileApiModelExample : IExamplesProvider<FileApiModel>
    {
        public FileApiModel GetExamples()
        {
            return new FileApiModel()
            {
                FileName = "TestFileName",
                Type = ".txt",
                AddedBy = "TestUser",
                AddedDate = DateTime.Now
            };
        }
    }
}
