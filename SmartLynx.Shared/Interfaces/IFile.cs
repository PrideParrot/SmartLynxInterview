using SmartLynx.ApiModel.FileModels;
using SmartLynx.ApiModel.Models;
using SmartLynx.DataModel.FileModels;

namespace SmartLynx.Shared.Interfaces
{
    public interface IFile
    {
        List<FileApiModel> GetAllFiles();
        FileContentApiModel GetFileContent(Guid fileId);
        void DeleteFile(Guid fileId);
        void AddFile(FileCreateApiModel fileModel);
    }
}