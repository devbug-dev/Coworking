using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using Coworking.AppContracts.Services;

using Coworking.Business.Models;
using Coworking.DataAccess.Mappers;
using Coworking.DataContracts.Repositories;

namespace Coworking.Application.Services
{
    public class RoomService : IRoomService
    {

        private readonly IRoomRepository _roomRepository;

        public RoomService(IRoomRepository roomRepository)
        {
            _roomRepository = roomRepository;
        }


        public async Task<Room> AddRoom(Room room)
        {
            var addedEntity = await _roomRepository.Add(RoomMapper.Map(room));

            return RoomMapper.Map(addedEntity);
        }

        public async Task<IEnumerable<Room>> GetAllRooms()
        {
            var admins = await _roomRepository.GetAll();

            return admins.Select(RoomMapper.Map);
        }

        public async Task<Room> GetRoom(int id)
        {
            var entidad = await _roomRepository.Get(id);

            return RoomMapper.Map(entidad);
        }

        public async Task DeleteRoom(int id)
        {
            await _roomRepository.DeleteAsync(id);
        }

        public async Task<Room> UpdateRoom(Room room)
        {
            var updated = await _roomRepository.Update(RoomMapper.Map(room));

            return RoomMapper.Map(updated);
        }
    }
}
