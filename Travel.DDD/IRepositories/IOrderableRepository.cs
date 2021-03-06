﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using Travel.DDD.Domain;
using Travel.DDD.IRepositories.Commons;

namespace Travel.DDD.IRepositories
{
    /// <summary>
    /// 提供排序功能的规范
    /// </summary>
    public interface IOrderableRepository<TEntity> where TEntity : class, IEntity {
        /// <summary>
        /// 带排序的结果集
        /// </summary>
        /// <param name="orderBy"></param>
        /// <returns></returns>
        IQueryable<TEntity> GetModel(Action<IOrderable<TEntity>> orderBy);

        /// <summary>
        /// 根据指定lambda表达式和排序方式,得到延时结果集
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        IQueryable<TEntity> GetModel(Action<IOrderable<TEntity>> orderBy, Expression<Func<TEntity, bool>> predicate);
    }
}
