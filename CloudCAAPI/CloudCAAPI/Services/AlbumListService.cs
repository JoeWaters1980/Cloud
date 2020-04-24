using CloudCAAPI.Models;
using System.Collections.Generic;

namespace CloudCAAPI.Services
{
    public class AlbumListService : IAlbumListService
    {
        //a dictionary to store our albums in
        private readonly Dictionary<string, int> _albumListStorage = new Dictionary<string, int>();

        public void AddAblumsToList(AlbumListModel albumList)
        {
            _albumListStorage.Add(albumList.AlbumName, albumList.AlbumYear);
        }

        // method below will get the items from our album list

        public Dictionary<string, int> GetItemsFromAlbumList()
        {
            // this will return the dictionary
            return _albumListStorage;
        }

        public void RemoveAblum(string albumName)
        {
            _albumListStorage.Remove(albumName);
        }
    }
}
