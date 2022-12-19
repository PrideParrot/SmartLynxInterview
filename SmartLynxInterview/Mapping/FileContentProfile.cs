using AutoMapper;
using SmartLynx.ApiModel.Models;
using SmartLynx.DataModel.FileModels;

namespace SmartLynx.Shared.Mapping
{
    public class FileContentProfile : Profile
    {
        public FileContentProfile()
        {
            CreateMap<FileContentApiModel, FileModel>()
                .ReverseMap();
        }
    }
}
