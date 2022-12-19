using SmartLynx.ApiModel.FileModels;
using SmartLynx.ApiModel.Models;
using Swashbuckle.AspNetCore.Filters;

namespace SmartLynxInterview.Examples
{
    public class CreateTokenExample : IExamplesProvider<UserModel>
    {
        public UserModel GetExamples()
        {
            return new UserModel()
            {
                UserName= "TestUser",
                Password= "TestPassword"
            };
        }
    }
}
