using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using BusinessLogic.Services;
using SoftwareIncidentManagerWebApi.Filters;
using BusinessLogic;
using System.Web;

namespace EnsolversWebApi.Controllers
{
    [ApiController]
    //[TypeFilter(typeof(AuthorizationFilter))]
    [Route("folders")]
    public class FolderController : ControllerBase
    {

        private IFolderService folderService;

        private readonly ILogger<FolderController> _logger;

        public FolderController(ILogger<FolderController> _logger, IFolderService folderService)
        {
            this._logger = _logger;
            this.folderService = folderService;
        }

        [HttpPost]
        public IActionResult AddFolder([FromBody] Folder folder)
        {
            try
            {
                folderService.AddFolder(folder);
                return Created("/folders", "Folder added correctly.");
            }
            catch (ArgumentException e)
            {
                _logger.LogError(e.Message);
                return BadRequest(e.Message);
            }
            catch (InvalidOperationException ex)
            {
                _logger.LogError(ex.Message);
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPut("/{folderId}")]
        public IActionResult UpdateFolder([FromRoute] int folderId, [FromBody] Folder folder)
        {
            try
            {
                if (folderId != folder.Id)
                {
                    return BadRequest("The identtity is not the same.");
                }
                folderService.Update(folder);
                return Created("/folders", "Folder added correctly.");
            }
            catch (ArgumentException e)
            {
                _logger.LogError(e.Message);
                return BadRequest(e.Message);
            }
            catch (InvalidOperationException ex)
            {
                _logger.LogError(ex.Message);
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpDelete("/folders/{folderId}")]
        public IActionResult DeleteFolder([FromRoute] int folderId)
        {
            try
            {
                folderService.Remove(folderId);
                return Created("/folders", "Folder deleted.");
            }
            catch (ArgumentException e)
            {
                _logger.LogError(e.Message);
                return BadRequest(e.Message);
            }
            catch (InvalidOperationException ex)
            {
                _logger.LogError(ex.Message);
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpGet("/folders")]
        public IActionResult GetFolders()
        {
            try
            {
                return Created("/folders", folderService.GetFolders());
            }
            catch (ArgumentException e)
            {
                _logger.LogError(e.Message);
                return BadRequest(e.Message);
            }
            catch (InvalidOperationException ex)
            {
                _logger.LogError(ex.Message);
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }
    }
}

