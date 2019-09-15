using System.Collections.Generic;

namespace Coworking.DataContracts.Entities
{
    public class RoomEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Capacity { get; set; }

        public virtual ICollection<Offices2RoomsEntity> Office2Room { get; set; }
        public virtual ICollection<Room2ServicesEntity> Room2Service { get; set; }

    }
}
