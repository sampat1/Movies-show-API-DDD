﻿namespace MoviesTicket.Shared.SeedWork;

public interface IRepository<T> where T : IAggregateRoot
{
    IUnitOfWork UnitOfWork { get; }
}
