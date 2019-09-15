using System.Collections.Generic;

namespace Coworking.DataContracts.Entities
{
    public class ServiceEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool Active { get; set; }
        public float Price { get; set; }

        public virtual ICollection<Room2ServicesEntity> Room2Service { get; set; }
    }
}
