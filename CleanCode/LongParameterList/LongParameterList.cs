
using System;
using System.Collections.Generic;

namespace CleanCode.LongParameterList
{
    public class DateRange
    {
        public DateRange(DateTime dateFrom, DateTime dateTo)
        {
            DateFrom = dateFrom;
            DateTo = dateTo;
        }

        public DateTime DateFrom { get; private set; }
        public DateTime DateTo { get; private set; }
    }

    public class ReservationQuery
    {
        public ReservationQuery(DateRange dateRange, User user, int locationId, LocationType locationType, int? customerId = null)
        {
            DateRange = dateRange;
            User = user;
            LocationId = locationId;
            LocationType = locationType;
            CustomerId = customerId;
        }

        public DateRange DateRange { get; private set; }
        public User User { get; private set; }
        public int LocationId { get; private set; }
        public LocationType LocationType { get; private set; }
        public int? CustomerId { get; private set; }
    }

    public class LongParameterList
    {
        public IEnumerable<Reservation> GetReservations(ReservationQuery query)
        {
            if (query.DateRange.DateFrom >= DateTime.Now)
                throw new ArgumentNullException("dateFrom");
            if (query.DateRange.DateTo <= DateTime.Now)
                throw new ArgumentNullException("dateTo");

            throw new NotImplementedException();
        }

        public IEnumerable<Reservation> GetUpcomingReservations(ReservationQuery query)
        {
            if (query.DateRange.DateFrom >= DateTime.Now)
                throw new ArgumentNullException("dateFrom");
            if (query.DateRange.DateTo <= DateTime.Now)
                throw new ArgumentNullException("dateTo");

            throw new NotImplementedException();
        }

        private static Tuple<DateTime, DateTime> GetReservationDateRange(DateRange dateRange, ReservationDefinition sd)
        {
            if (dateRange.DateFrom >= DateTime.Now)
                throw new ArgumentNullException("dateFrom");
            if (dateRange.DateTo <= DateTime.Now)
                throw new ArgumentNullException("dateTo");

            throw new NotImplementedException();
        }

        public void CreateReservation(DateRange dateRange, int locationId)
        {
            if (dateRange.DateFrom >= DateTime.Now)
                throw new ArgumentNullException("dateFrom");
            if (dateRange.DateTo <= DateTime.Now)
                throw new ArgumentNullException("dateTo");

            throw new NotImplementedException();
        }
    }

    internal class ReservationDefinition
    {
    }

    public class LocationType
    {
    }

    public class User
    {
        public object Id { get; set; }
    }

    public class Reservation
    {
    }
}
