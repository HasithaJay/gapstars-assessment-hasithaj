using Chinook.Models;
using Chinook.Repositories.Interfaces;

namespace Chinook.Repositories
{
    public class ArtistRepository : IArtistRepository
    {
        private readonly ChinookContext _context;
        public ArtistRepository(ChinookContext context)
        {
            _context = context;
        }

        public IQueryable<Album> GetAlbumsForArtist(long artistId)
        {
            return _context.Albums.Where(a => a.ArtistId == artistId);
        }

        public IQueryable<Artist> GetAllArtists()
        {
            return _context.Artists;
        }

        public IQueryable<Artist> GetArtistById(long albumId)
        {
            return _context.Artists
                .Where(ar => ar.ArtistId == albumId);
        }
    }
}

