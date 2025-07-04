﻿using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Core.Entities;

namespace Core.DataAccess
{
    public interface IEntityRepository<T>
        where T : class, IEntity, new()
    {
        List<T> GetAll(Expression<Func<T, bool>> filter = null); // ürünleri filtre verdiyse ona göre, vermediyse hepsini getir.

        T Get(Expression<Func<T, bool>> filter); // burada bir şeyin detayına, örnek olarak bir kredinin detayına gitme işi var. o yüzden liste değildir.

        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
