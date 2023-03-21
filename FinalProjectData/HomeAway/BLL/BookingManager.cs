namespace BLL;
using System;
using BOL;
using DAL;

public class BookingManager
{

    BookingDBManager bDBManager =new BookingDBManager();

    public void AddBookingDetails(Booking bDetails)
    {
        bDBManager.AddBookingDetails(bDetails);
    }

    public List<Booking> GetAllBookingDetails(){
        return bDBManager.GetAllBookingDetails();
    }
}