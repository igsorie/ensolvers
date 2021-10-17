using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using BusinessLogic.Services;
using SoftwareIncidentManagerWebApi.Filters;
using BusinessLogic;

namespace EnsolversWebApi.Controllers
{
    [ApiController]
    //[TypeFilter(typeof(AuthorizationFilter))]
    [Route("items")]
    public class ItemController : ControllerBase
    {

        private IItemService itemService;

        private readonly ILogger<FolderController> _logger;

        public ItemController(ILogger<FolderController> _logger, IItemService itemService)
        {
            this._logger = _logger;
            this.itemService = itemService;
        }

        [HttpPost]
        public IActionResult AddItem([FromBody] Item item)
        {
            try
            {
                itemService.AddItem(item);
                return Created("/items", "Item added correctly.");
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

        [HttpPut("/items/{itemId}")]
        public IActionResult UpdateItem([FromRoute] int itemId, [FromBody] Item item)
        {
            try
            {
                if (itemId != item.Id)
                {
                    return BadRequest("The identtity is not the same.");
                }
                itemService.Update(item);
                return Created("/items", "Item updated correctly.");
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

        [HttpGet("/items/{folderId}")]
        public IActionResult GetItemsFromFolders([FromRoute] int folderId)
        {
            try
            {
                return Created("/items", itemService.GetItemsFromFolder(folderId));
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