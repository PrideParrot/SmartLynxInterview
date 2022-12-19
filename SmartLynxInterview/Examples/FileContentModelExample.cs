using SmartLynx.ApiModel.Models;
using Swashbuckle.AspNetCore.Filters;

namespace SmartLynxInterview.Examples
{
    public class FileContentModelExample : IExamplesProvider<FileContentApiModel>
    {

        FileContentApiModel IExamplesProvider<FileContentApiModel>.GetExamples()
        {
            return new FileContentApiModel()
            {
                Content = new byte[] { 0x20, 0x20, 0x20, 0x20, 0x20, 0x20, 0x20 }
            };
        }
    }
}
