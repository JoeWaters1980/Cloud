using CloudCAAPI.Models;
using CloudCAAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace CloudCAAPI.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]

    public class AlbumListController : Controller
    {
        private readonly IAlbumListService _albumListService;

        public AlbumListController(IAlbumListService albumListService)
        {
            _albumListService = albumListService;
        }

        [HttpGet]
        public IActionResult GetAlbumList()
        {
            var results = _albumListService.GetItemsFromAlbumList();
            return Ok(results);

        }

        [HttpPost]

        public IActionResult AddAlbumToList([FromBody] AlbumListModel albumList)
        {
            _albumListService.AddAblumsToList(albumList);

            return Ok();
        }

        [HttpDelete]
        public IActionResult RemoveAlbumsFromList([FromBody]AlbumListModel albumList)
        {
            _albumListService.RemoveAblum(albumList.AlbumName);

            return Ok();
        }
    }

}