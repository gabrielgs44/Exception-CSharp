using ExceptionExample.Entities.Exceptions;
using System;

namespace ExceptionExample.Entities
{
    class Reservation
    {
        public int RoomNumber { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }

        public Reservation(int roomNumber, DateTime checkIn, DateTime checkOut)
        {
            RoomNumber = roomNumber;
            UpdateDates(checkIn, checkOut);
        }

        public int Duration()
        {
            TimeSpan duration = CheckOut.Subtract(CheckIn);
            return (int)duration.TotalDays;
        }

        public void UpdateDates(DateTime checkIn, DateTime checkOut)
        {
            if (checkIn < DateTime.Now || checkOut < DateTime.Now)
            {
                throw new DomainException("Reservation date for update must be future dates");
            }
            if(checkOut <= checkIn)
            {
                throw new DomainException("Check-out date must be after check-in date");
            }

            CheckIn = checkIn;
            CheckOut = checkOut;
        }

        public override string ToString()
        {
            return $"Room {RoomNumber}, check-in: " +
                $"{CheckIn.ToString("dd/MM/yyyy")}, check-Out: " +
                $"{CheckOut.ToString("dd/MM/yyyy")}, {Duration()} nights";
        }
    }
}
