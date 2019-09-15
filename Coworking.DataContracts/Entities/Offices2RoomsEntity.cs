﻿

namespace Coworking.DataContracts.Entities
{
    public class Offices2RoomsEntity
    {
        public int OfficeId { get; set; }
        public int RoomId { get; set; }


        public virtual OfficeEntity Office { get; set; }
        public virtual RoomEntity Room { get; set; }
    }
}
