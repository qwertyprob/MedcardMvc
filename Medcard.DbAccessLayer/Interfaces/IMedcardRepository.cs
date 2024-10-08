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
        Task<OwnerDto> CreateAsync(MedcardViewModel medcardViewModel);
        Task<OwnerDto> UpdateAsync(Guid id,MedcardViewModel medcardViewModel);
        Task<OwnerDto> UpdateNoDrugsNoTreatmentsAsync(Guid id, MedcardViewModel medcardViewModel);
        Task<OwnerDto> UpdateDrugsAndTreatments(Guid id, string Drugs, string Treatments,string Recomendations);
        Task<bool> DeleteAsync(Guid id);
    }

}