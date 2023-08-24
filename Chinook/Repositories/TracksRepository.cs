using Chinook.Models;
using Chinook.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Chinook.Repositories
{
    public class TracksRepository : ITrackRepository
    {
        private readonly ChinookContext _context;
        public TracksRepository(ChinookContext context)
        {
            _context = context;
        }

        public IQueryable<Track> GetTracksByArtistId(long artistId)
        {
            return _context.Tracks
                .Include(tr => tr.Album)
                .Where(tr => tr.Album.ArtistId == artistId);
        }

        public Track? GetTrackById(long trackId)
        {
            return _context.Tracks
                .Where(tr => tr.TrackId == trackId)
                .FirstOrDefault();
        }
    }
}

