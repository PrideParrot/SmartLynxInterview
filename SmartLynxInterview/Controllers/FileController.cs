using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SmartLynx.ApiModel.FileModels;
using SmartLynx.ApiModel.Models;
using SmartLynx.Shared.Interfaces;
using SmartLynxInterview.Examples;
using Swashbuckle.AspNetCore.Annotations;
using Swashbuckle.AspNetCore.Filters;

namespace SmartLynxInterview.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FileController : ControllerBase
    {
        private readonly ILogger<FileController> _logger;
        private readonly IFile _file;

        public FileController(ILogger<FileController> logger, IFile file)
        {
            _logger = logger;
            _file = file;
        }

        [HttpGet]
        [Authorize]
        [SwaggerResponse(StatusCodes.Status200OK, Type = typeof(List<FileApiModel>))]
        [SwaggerResponse(StatusCodes.Status400BadRequest)]
        [SwaggerResponse(StatusCodes.Status401Unauthorized)]
        [Route("GetAllFiles")]
        public IActionResult GetAllFiles()
        {
            try
            {
                var result = _file.GetAllFiles();
                return new JsonResult(result);
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return BadRequest(e.Message);
            }
        }

        [HttpGet]
        [Authorize]
        [SwaggerResponse(StatusCodes.Status200OK, Type = typeof(FileContentApiModel))]
        [SwaggerResponse(StatusCodes.Status400BadRequest)]
        [SwaggerResponse(StatusCodes.Status401Unauthorized)]
        [Route("GetFileContent")]
        public IActionResult GetFileContent(Guid fileId)
        {
            try
            {
                var result = _file.GetFileContent(fileId);
                return new JsonResult(result);
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return BadRequest(e.Message);
            }
        }


        [HttpPost]
        [Authorize]
        [SwaggerResponse(StatusCodes.Status200OK)]
        [SwaggerResponse(StatusCodes.Status400BadRequest)]
        [SwaggerResponse(StatusCodes.Status401Unauthorized)]
        [SwaggerRequestExample(typeof(FileCreateApiModelExample), typeof(FileCreateApiModelExample))]
        [Route("AddFile")]
        public IActionResult AddFile([FromBody] FileCreateApiModel item)
        {
            try
            {
                _file.AddFile(item);
                return Ok();
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return BadRequest(e.Message);
            }
        }

        [HttpDelete]
        [Authorize]
        [SwaggerResponse(StatusCodes.Status200OK)]
        [SwaggerResponse(StatusCodes.Status400BadRequest)]
        [SwaggerResponse(StatusCodes.Status401Unauthorized)]
        [Route("DeleteFile")]
        public IActionResult DeleteFile(Guid fileId)
        {
            try
            {
                _file.DeleteFile(fileId);
                return Ok();
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return BadRequest(e.Message);
            }
        }

    }
}
