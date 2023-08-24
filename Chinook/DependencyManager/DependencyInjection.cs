using Chinook.Repositories;
using Chinook.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Chinook.DependencyManager
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services,
            IConfiguration configuration)
        {
            _ = services.AddScoped<ITrackRepository>(_ =>
                    new TracksRepository(
                        _.GetRequiredService<IDbContextFactory<ChinookContext>>().CreateDbContext()))
                .AddScoped<IArtistRepository>(_ =>
                    new ArtistRepository(
                        _.GetRequiredService<IDbContextFactory<ChinookContext>>().CreateDbContext()))
                .AddScoped<IPlaylistRepository>(_ =>
                    new PlaylistRepository(
                        _.GetRequiredService<IDbContextFactory<ChinookContext>>().CreateDbContext()))
                .AddScoped<IUserPlaylistRepository>(_ =>
                    new UserPlaylistRepository(
                        _.GetRequiredService<IDbContextFactory<ChinookContext>>().CreateDbContext()));
            return services;
        }
    }
}

