using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using Coworking.AppContracts.Services;

using Coworking.Business.Models;
using Coworking.DataAccess.Mappers;
using Coworking.DataContracts.Repositories;

namespace Coworking.Application.Services
{
    public class BookingService : IBookingService
    {

        private readonly IBookingRepository _bookingRepository;

        public BookingService(IBookingRepository bookingRepository)
        {
            _bookingRepository = bookingRepository;
        }


        public async Task<Booking> AddBooking(Booking booking)
        {
            var addedEntity = await _bookingRepository.Add(BookingMapper.Map(booking));

            return BookingMapper.Map(addedEntity);
        }

        public async Task<IEnumerable<Booking>> GetAllBookings()
        {
            var bookings = await _bookingRepository.GetAll();

            return bookings.Select(BookingMapper.Map);
        }

        public async Task<Booking> GetBooking(int id)
        {
            var entidad = await _bookingRepository.Get(id);

            return BookingMapper.Map(entidad);
        }

        public async Task DeleteBooking(int id)
        {
            await _bookingRepository.DeleteAsync(id);
        }

        public async Task<Booking> UpdateBooking(Booking booking)
        {
            var updated = await _bookingRepository.Update(BookingMapper.Map(booking));

            return BookingMapper.Map(updated);
        }
    }
}
