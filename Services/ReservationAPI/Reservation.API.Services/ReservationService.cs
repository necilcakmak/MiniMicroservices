using Reservation.API.Infrastructure;
using Reservation.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservation.API.Services
{
    public class ReservationService : IReservationService
    {
        public ReservationDTO GetReservationByBkgNumber(int BkgNumber)
        {
            return new ReservationDTO
            {
                Id = new Random().Next(100),
                BkgNumber = BkgNumber,
                Amount = new Random().Next(1000),
                BkgDate = DateTime.Now,
                CheckingDate = DateTime.Now.Date.AddDays(30),
                CheckoutDate = DateTime.Now.Date.AddDays(37),
            };
        }
    }
}
