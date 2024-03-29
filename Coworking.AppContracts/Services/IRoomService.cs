﻿using Coworking.Business.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Coworking.AppContracts.Services
{
    public interface IRoomService
    {
        Task<Room> AddRoom(Room room);
        Task<IEnumerable<Room>> GetAllRooms();
        Task<Room> GetRoom(int id);
        Task DeleteRoom(int id);
        Task<Room> UpdateRoom(Room room);
    }
}
