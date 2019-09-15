namespace Coworking.DataContracts.Entities
{
    public class Room2ServicesEntity
    {

        public int IdRoom { get; set; }
        public int IdService { get; set; }

        public virtual RoomEntity Room { get; set; }
        public virtual ServiceEntity Service { get; set; }

    }
}
