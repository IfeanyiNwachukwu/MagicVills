﻿using MagicVilla_API.Models;
using System.Linq.Expressions;

namespace MagicVilla_API.Repository.IRepository
{
    public interface IVillaRepository : IBaseRepository<Villa>
    {
       
        Task<Villa> UpdateAsync(Villa entity);
       

        
    }
}
