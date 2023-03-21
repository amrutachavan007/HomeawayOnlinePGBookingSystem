namespace SAL;
using BLL;
using BOL;
public class BookingService
{
    BookingManager bManager = new BookingManager();
    public void AddBookingDetails(Booking bDetails){
        bManager.AddBookingDetails(bDetails);
    }

    public List<Booking> GetAllBookingDetails(){
        return bManager.GetAllBookingDetails();
    }
}