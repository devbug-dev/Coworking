using Coworking.Api.ViewModels;
using Coworking.Business.Models;

namespace Coworking.Api.Mappers
{
    public static class BookingMapper
    {

        public static Booking Map(BookingModel model)
        {

            return new Booking()
            {
                BookingDate = model.BookingDate,
                CreateDate = model.CreateDate,
                Id = model.Id,
                OfficeId = model.OfficeId,
                RentWorkSpace = model.RentWorkSpace,
                RoomId = model.RoomId,
                UserId = model.UserId

            };

        }

    }
}
