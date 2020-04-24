using CloudCAAPI.Models;
using System.Collections.Generic;
// this is our interface file

namespace CloudCAAPI.Services
{
    public interface IAlbumListService
    {
        Dictionary<string, int> GetItemsFromAlbumList();
        void AddAblumsToList(AlbumListModel albumList);
        void RemoveAblum(string albumName);
    }
}