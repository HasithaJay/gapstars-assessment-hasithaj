using Chinook.Models;

namespace Chinook.Repositories.Interfaces
{
    public interface IPlaylistRepository
    {
        public IQueryable<Playlist> GetPlaylistById(long playlistId);
        public IQueryable<Playlist> GetAllPlaylists();
        public IQueryable<Playlist> GetFavouritePlaylist(string currentUserId);
        public void AddToFavourites(string currentUserId, Track track);
        public void RemoveFromFavourites(Track trackId, string CurrentUserId);
        public void RemoveFromPlaylist(long playlistId, Track track);
        public void CheckForExistingPlaylistsAndAdd(string CurrentUserId, string NewPlaylistName, Track track);
    }
}
