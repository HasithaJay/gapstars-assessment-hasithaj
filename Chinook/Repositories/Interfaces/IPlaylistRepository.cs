using Chinook.Models;

namespace Chinook.Repositories.Interfaces
{
    public interface IPlaylistRepository
    {
        public IQueryable<Playlist> GetPlaylistById(long playlistId);
        public IQueryable<Playlist> GetAllPlaylists();
        public IQueryable<Playlist> GetFavoritePlaylist(string currentUserId);
        public void AddToFavorites(string currentUserId, Track track);
        public void RemoveFromFavorites(Track trackId, string CurrentUserId);
        public void RemoveFromPlaylist(long playlistId, Track track);
        public void CheckForExistingPlaylistsAndAdd(string CurrentUserId, string NewPlaylistName, Track track);
    }
}
