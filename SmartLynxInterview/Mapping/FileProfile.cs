using AutoMapper;
using SmartLynx.ApiModel.FileModels;
using SmartLynx.ApiModel.Models;
using SmartLynx.DataModel.FileModels;

namespace SmartLynx.Shared.Mapping
{
    public class FileProfile : Profile
    {
        public FileProfile()
        {
            CreateMap<FileApiModel, FileModel>()
                .ReverseMap();

            CreateMap<FileCreateApiModel, FileModel>()
                .ReverseMap();
        }
    }
}
