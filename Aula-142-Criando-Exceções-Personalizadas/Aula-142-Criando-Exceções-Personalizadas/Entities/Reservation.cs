using System;
using Aula_142_Criando_Exceções_Personalizadas.Entities.Exceptions;

namespace Aula_142_Criando_Exceções_Personalizadas.Entities
{
    class Reservation
    {
        public int RoomNumber { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }

        public Reservation()
        {

        }
        public Reservation(int roomNumber, DateTime checkIn, DateTime checkOut)
        {
            if (checkOut <= checkIn)
            {
                throw new DomainException("Check-out date must be after check-in date");
            }
            RoomNumber = roomNumber;
            CheckIn = checkIn;
            CheckOut = checkOut;
        }

        public int Duration()
        {
            TimeSpan duration = CheckOut.Subtract(CheckIn);
            return (int)duration.TotalDays;
        }
        public void UpdateDates(DateTime checkin, DateTime checkout)
        {
            DateTime date = DateTime.Now;
            if(checkin < date || checkout < date)
            {
                throw new DomainException("Reservation dates for update must be future dates");
            }
            if(checkout <= checkin)
            {
                throw new DomainException("Check-out date must be after check-in date");
            }

            CheckIn = checkin;
            CheckOut = checkout;
        }

        public override string ToString()
        {
            return "Reservation: Room "
                + RoomNumber
                + ", check-in: "
                + CheckIn.ToString("dd/MM/yyyy")
                + ", check-out: "
                + CheckOut.ToString("dd/MM/yyyy")
                + ", "
                + Duration()
                + " nights";
        }
    }
}
