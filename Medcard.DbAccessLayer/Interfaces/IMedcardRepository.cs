﻿using Medcard.DbAccessLayer.Dto;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Medcard.DbAccessLayer.Interfaces
{

    public interface IMedcardRepository
    {
        
        Task<IReadOnlyCollection<OwnerDto>> GetAllAsync();
        Task<OwnerDto> GetByIdAsync(Guid id);
    }

}