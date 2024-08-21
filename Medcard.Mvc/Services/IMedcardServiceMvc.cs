﻿using Medcard.DbAccessLayer.Dto;
using Medcard.Mvc.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Medcard.Mvc.Services
{
    public interface IMedcardServiceMvc
    {
        Task<IReadOnlyCollection<OwnerModel>> GetAllAsync();
        Task<OwnerModel> GetByIdAsync(Guid id);
        Task<OwnerModel> CreateAsync(MedcardViewModel medcardViewModel);
        Task<OwnerModel> UpdateAsync(Guid id, MedcardViewModel medcardViewModel);
        Task UpdateDrugsAsync(Guid petId, string drugs);
        Task UpdateTreatmentsAsync(Guid petId, string treatments);
        Task<bool> DeleteAsync(Guid id);
        Task<Guid> SearchByPetName(string petName);
    }
}