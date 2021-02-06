﻿using System;
using System.Threading;
using System.Threading.Tasks;
using DaraAds.Domain.Shared;

namespace DaraAds.Application
{
    public interface IRepository<TEntity, TId>
        where TEntity : BaseEntity<TId>
    {
        Task<TEntity> FindById(TId id, CancellationToken cancellationToken);
        
        Task Save(TEntity entity, CancellationToken cancellationToken);
        
        //Task<TEntity> FindWhere(Expression<Func<TEntity, bool>> predicate, CancellationToken cancellationToken);
    } 
    
}
