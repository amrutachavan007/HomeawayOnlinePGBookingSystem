using BOL;
using System.Data;
using MySql.Data.MySqlClient;
namespace DAL;
public class BookingDBManager
{
    public void AddBookingDetails(Booking bDetails)
    {
         string conString=@"server=localhost;uid=root;"+"pwd=root;database=HomeAway";
        //create connection
        MySqlConnection con=new MySqlConnection(conString);
        string query="INSERT INTO Booking(CustomerId,RoomId,BookingAmount,Date) VALUES('"+bDetails.CustomerId+"','"+bDetails.RoomId+"','"+bDetails.BookingAmount+"','"+bDetails.Date+"')";
        MySqlCommand cmd=new MySqlCommand();
        cmd.Connection=con;
        cmd.CommandText=query;
        con.Open();
        int n=cmd.ExecuteNonQuery();
        con.Close();
    }

    public List<Booking> GetAllBookingDetails(){
         string conString=@"server=localhost;uid=root;"+"pwd=root;database=HomeAway";
        //create connection
        MySqlConnection con=new MySqlConnection(conString);
        string query="SELECT * FROM Booking";
        MySqlCommand cmd=new MySqlCommand();
        cmd.Connection=con;
        cmd.CommandText=query;
        con.Open();
        MySqlDataReader reader=cmd.ExecuteReader();
        List<Booking> blist=new List<Booking>();
        while(reader.Read()){
            int customerId=int.Parse(reader["CustomerId"].ToString());
            int roomId=int.Parse(reader["roomId"].ToString());
            double bookingAmount=int.Parse(reader["BookingAmount"].ToString());
            string date=reader["Date"].ToString();

            Booking bookingDetails=new Booking{
                CustomerId=customerId,
                RoomId=roomId,
                BookingAmount=bookingAmount,
                Date=date
            };
            blist.Add(bookingDetails);
       }
       return blist;
    con.Close();
    }

}