﻿using MoviesTicket.Application.Projections;

namespace MoviesTicket.Application.Repository;

public interface IReadOnlyMovieRepository : IReadOnlyRepository<Movies>
{
    public Task<(IEnumerable<Movies> Movies, int TotalCount)> GetMovies(FilterModel searchModel,CancellationToken cancellationToken);
    public Task<bool> HasMovies(Guid movieGuid,CancellationToken cancellationToken);
}

