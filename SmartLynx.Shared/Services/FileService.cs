using AutoMapper;
using SmartLynx.ApiModel.FileModels;
using SmartLynx.ApiModel.Models;
using SmartLynx.DataModel.Contexts;
using SmartLynx.DataModel.FileModels;
using SmartLynx.Shared.Interfaces;

namespace SmartLynx.Shared.Services
{
    public class FileService : IFile
    {
        private readonly FileContext _context;
        private readonly IMapper _mapper;
        public FileService(FileContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public void AddFile(FileCreateApiModel fileModel)
        {
            var model = new FileModel();
            model = _mapper.Map<FileModel>(fileModel);

            model.Id = Guid.NewGuid();
            model.AddedDate = DateTime.Now;

            _context.Files.Add(model);
            _context.SaveChanges();
        }

        public void DeleteFile(Guid fileId)
        {
            var itemToRemove = _context.Files.Single(x => x.Id == fileId);

            if (itemToRemove != null)
            {
                _context.Files.Remove(itemToRemove);
                _context.SaveChanges();
            }
        }

        public List<FileApiModel> GetAllFiles()
        {
            var items = _context.Files
                               .Select(x => new FileApiModel
                               {
                                   Id = x.Id,
                                   FileName = x.FileName,
                                   Type = x.Type,
                                   AddedBy = x.AddedBy,
                                   AddedDate = x.AddedDate
                               }).ToList();

            return items;
        }

        public FileContentApiModel GetFileContent(Guid fileId)
        {
            var item = _context.Files.SingleOrDefault(x => x.Id == fileId);                        
            var convertedItem = _mapper.Map<FileContentApiModel>(item);
            return convertedItem;
        }
    }
}