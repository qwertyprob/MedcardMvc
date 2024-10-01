﻿using Medcard.DbAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medcard.DbAccessLayer.Dto
{
    [Serializable]
    public class RecomendationsDto
    {
        public Guid PetId { get; set; }
        public string Description { get; set; } = "Здесь пока ничего не указано!";
    }
}
