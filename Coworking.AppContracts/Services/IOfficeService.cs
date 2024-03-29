﻿using Coworking.Business.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Coworking.AppContracts.Services
{
    public interface IOfficeService
    {
        Task<Office> AddOffice(Office office);
        Task<IEnumerable<Office>> GetAllOffices();
        Task<Office> GetOffice(int id);
        Task DeleteOffice(int id);
        Task<Office> UpdateOffice(Office office);

    }
}
