using WebServicesCI.DTO;

namespace WebServicesCI.TestData
{
    public static class TestBookingModels
    {
        public static BookingModel ValidBookingModel = new()
        {
            FirstName = "Jim",
            LastName = "Brown",
            TotalPrice = 111,
            DepositPaid = true,
            BookinDates = new BookingDates()
            {
                CheckIn = DateTime.Now.AddDays(5).ToString("yyyy-MM-dd"),
                CheckOut = DateTime.Now.AddDays(12).ToString("yyyy-MM-dd")
            },
            AdditionalNeeds = "Breakfast"
        };

        public static BookingModel InValidBookingModel = new()
        {
            BookinDates = new BookingDates()
            {
                CheckIn = DateTime.Now.AddDays(5).ToString("yyyy-MM-dd"),
                CheckOut = DateTime.Now.AddDays(12).ToString("yyyy-MM-dd")
            },
            AdditionalNeeds = "Breakfast"
        };
    }
}
