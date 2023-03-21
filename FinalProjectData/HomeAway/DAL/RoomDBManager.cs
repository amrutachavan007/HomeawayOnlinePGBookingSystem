namespace DAL
{
using BOL;
using System.Data;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
public class RoomDBManager

{
public bool AddRoomDetails(RoomDetails roomDetails)
{
    string conString=@"server=localhost;uid=root;"+"pwd=root;database=HomeAway";
        //create connection
        MySqlConnection con=new MySqlConnection(conString);
        string query="INSERT INTO Roomdetails(OwnerId,PropertyName, FloorNo,Status,Rent,Deposit,Facility,RoomAddress,Gender,RoomType,URL1,URL2,URL3) VALUES('"+roomDetails.OwnerId+"','"+roomDetails.PropertyName+"','"+roomDetails.FloorNo+"','"+roomDetails.RoomStatus+"','"+roomDetails.RoomRent+"','"+roomDetails.RoomDeposit+"','"+roomDetails.RoomFacility+"','"+roomDetails.RoomAddress+"','"+roomDetails.Gender+"','"+roomDetails.RoomType+"','"+roomDetails.URL1+"','"+roomDetails.URL2+"','"+roomDetails.URL3+"')";
        MySqlCommand cmd=new MySqlCommand();
        cmd.Connection=con;
        cmd.CommandText=query;
        con.Open();
        int n=cmd.ExecuteNonQuery();
        con.Close();

        if(n>0)
        return true;

        return false;
    }

    public List<RoomDetails>ShowRoomDetails()
    {
     string conString=@"server=localhost;uid=root;"+"pwd=root;database=HomeAway";
        //create connection
        MySqlConnection con=new MySqlConnection(conString);
        string query="SELECT * FROM RoomDetails";
        MySqlCommand cmd=new MySqlCommand();
        cmd.Connection=con;
        cmd.CommandText=query;
        con.Open();
     MySqlDataReader reader=cmd.ExecuteReader();
        List<RoomDetails> rlist=new List<RoomDetails>();

        while(reader.Read())
        {
            int ownerid=int.Parse(reader["ownerid"].ToString());
            int roomid=int.Parse(reader["roomid"].ToString());
            string propertyname=reader["propertyname"].ToString();
            int floorno=int.Parse(reader["FloorNo"].ToString());
            string status=reader["status"].ToString();
            double rent=double.Parse(reader["rent"].ToString());
            double deposit=double.Parse(reader["deposit"].ToString());
            string facility=reader["facility"].ToString();
            string address=reader["roomaddress"].ToString();
            string gender=reader["gender"].ToString();
            string roomType=reader["roomtype"].ToString();
            string url1=reader["url1"].ToString();
            string url2=reader["url2"].ToString();
            string url3=reader["url3"].ToString();
            
            RoomDetails room=new RoomDetails{
                RoomId=roomid,
                PropertyName=propertyname,
                FloorNo=floorno,
                RoomStatus=status,
                RoomRent=rent,
                RoomDeposit=deposit,
                RoomFacility=facility,
                RoomAddress=address,
                Gender=gender,
                RoomType=roomType,
                URL1=url1,
                URL2=url2,
                URL3=url3,
                OwnerId=ownerid
            };
            rlist.Add(room);
       }
    return rlist;
}

public RoomDetails UpdateRoomDetails(int RoomId){

string conString=@"server=localhost;uid=root;"+"pwd=root;database=HomeAway";
        //create connection
           RoomDetails? room =null;
        MySqlConnection con=new MySqlConnection(conString);
        string query="SELECT * FROM ROOMDETAILS WHERE ROOMID="+RoomId;
        MySqlCommand cmd=new MySqlCommand();
        cmd.Connection=con;
        cmd.CommandText=query;
        con.Open();
     MySqlDataReader reader=cmd.ExecuteReader();
    
     while(reader.Read())
        {
            int ownerid=int.Parse(reader["ownerid"].ToString());
            int roomid=int.Parse(reader["roomid"].ToString());
            string propertyName=reader["propertyname"].ToString();
            int floorno=int.Parse(reader["FloorNo"].ToString());
            string status=reader["status"].ToString();
            double rent=double.Parse(reader["rent"].ToString());
            double deposit=double.Parse(reader["deposit"].ToString());
            string facility=reader["facility"].ToString();
            string address=reader["roomaddress"].ToString();
            string gender=reader["gender"].ToString();
            string roomType=reader["roomtype"].ToString();
            string url1=reader["url1"].ToString();
            string url2=reader["url2"].ToString();
            string url3=reader["url3"].ToString();
            
            
       room=new RoomDetails{
                RoomId=roomid,
                FloorNo=floorno,
                PropertyName=propertyName,
                RoomStatus=status,
                RoomRent=rent,
                RoomDeposit=deposit,
                RoomFacility=facility,
                RoomAddress=address,
                Gender=gender,
                RoomType=roomType,
                URL1=url1,
                URL2=url2,
                URL3=url3,
                OwnerId=ownerid
            };   
       }
       return room;
}


public bool UpdateRoom(RoomDetails rroom)
{
    string conString=@"server=localhost;uid=root;"+"pwd=root;database=HomeAway";
        //create connection
        MySqlConnection con=new MySqlConnection(conString);
         string query="UPDATE roomdetails SET PropertyName='"+rroom.PropertyName+"',FloorNo='"+rroom.FloorNo+"',Status='"+rroom.RoomStatus+"',Rent='"+rroom.RoomRent+"',Deposit='"+rroom.RoomDeposit+"',Facility='"+rroom.RoomFacility+"',roomaddress='"+rroom.RoomAddress+"',gender='"+rroom.Gender+"',roomType='"+rroom.RoomType+"',url1='"+rroom.URL1+"',url2='"+rroom.URL2+"',url3='"+rroom.URL3+"' where roomid='"+rroom.RoomId+"'";
        MySqlCommand cmd=new MySqlCommand();
        cmd.Connection=con;
        cmd.CommandText=query;
        con.Open();
        int n=cmd.ExecuteNonQuery();
        con.Close();

        if(n>0)
        return true;

        return false;
    }

     public bool DeleteRoom(int Roomid)
    {
        bool status = false;
        string conString=@"server=localhost;uid=root;"+"pwd=root;database=HomeAway";
        //create connection
        MySqlConnection con=new MySqlConnection(conString);
         MySqlCommand cmd=new MySqlCommand();
        cmd.Connection=con;
        string query="DELETE FROM RoomDetails where roomid="+Roomid;
        cmd.CommandText=query;
            con.Open();
            // create command object
            //
            // associate connection and query 
            // execute command
            cmd.ExecuteNonQuery();
            status = true;
       return status;
    }


 public List<RoomDetails> SearchRoomDetails(string btn)
    {
    
     string conString=@"server=localhost;uid=root;"+"pwd=root;database=HomeAway";
        //create connection
        MySqlConnection con=new MySqlConnection(conString);
       string query="SELECT * FROM RoomDetails where roomaddress='"+btn+"'";

     // string query="SELECT * FROM roomdetails where address='"+btn+"'"+ "OR rent='"+btn+"'";

        MySqlCommand cmd=new MySqlCommand();
        cmd.Connection=con;
        cmd.CommandText=query;
        con.Open();
        MySqlDataReader reader=cmd.ExecuteReader();
        List<RoomDetails> rlist=new List<RoomDetails>();

        while(reader.Read())
        {
            int ownerid=int.Parse(reader["ownerid"].ToString());
            int roomid=int.Parse(reader["roomid"].ToString());
             string propertyname=reader["propertyname"].ToString();
            int floorno=int.Parse(reader["FloorNo"].ToString());
            string status=reader["status"].ToString();
            double rent=double.Parse(reader["rent"].ToString());
            double deposit=double.Parse(reader["deposit"].ToString());
            string facility=reader["facility"].ToString();
            string address=reader["roomaddress"].ToString();
            string gender=reader["gender"].ToString();
            string roomType=reader["roomtype"].ToString();
            string url1=reader["url1"].ToString();
            string url2=reader["url2"].ToString();
            string url3=reader["url3"].ToString();
            

            RoomDetails room=new RoomDetails{
                RoomId=roomid,
                PropertyName=propertyname,
                FloorNo=floorno,
                RoomStatus=status,
                RoomRent=rent,
                RoomDeposit=deposit,
                RoomFacility=facility,
                RoomAddress=address,
                Gender=gender,
                RoomType=roomType,
                URL1=url1,
                URL2=url2,
                URL3=url3,
                OwnerId=ownerid
            };
            rlist.Add(room);
       }
       return rlist;
    }


public RoomDetails GetRoomById(int Id){
string conString=@"server=localhost;uid=root;"+"pwd=root;database=HomeAway";
        //create connection
           RoomDetails? room =null;
        MySqlConnection con=new MySqlConnection(conString);
        string query="SELECT * FROM ROOMDETAILS WHERE ROOMID="+Id;
        MySqlCommand cmd=new MySqlCommand();
        cmd.Connection=con;
        cmd.CommandText=query;
        con.Open();
     MySqlDataReader reader=cmd.ExecuteReader();
    
     while(reader.Read())
        {
            int ownerid=int.Parse(reader["ownerid"].ToString());
            int roomid=int.Parse(reader["roomid"].ToString());
            string propertyName=reader["propertyname"].ToString();
            int floorno=int.Parse(reader["FloorNo"].ToString());
            string status=reader["status"].ToString();
            double rent=double.Parse(reader["rent"].ToString());
            double deposit=double.Parse(reader["deposit"].ToString());
            string facility=reader["facility"].ToString();
            string address=reader["roomaddress"].ToString();
            string gender=reader["gender"].ToString();
            string roomType=reader["roomtype"].ToString();
            string url1=reader["url1"].ToString();
            string url2=reader["url2"].ToString();
            string url3=reader["url3"].ToString();
            
            
       room=new RoomDetails{
                RoomId=roomid,
                FloorNo=floorno,
                PropertyName=propertyName,
                RoomStatus=status,
                RoomRent=rent,
                RoomDeposit=deposit,
                RoomFacility=facility,
                RoomAddress=address,
                Gender=gender,
                RoomType=roomType,
                URL1=url1,
                URL2=url2,
                URL3=url3,
                OwnerId=ownerid
            };   
       }
       return room;
    }

    public List<RoomDetails> SearchRoomDetailsByPriceRange(int min,int max)
    {
    
     string conString=@"server=localhost;uid=root;"+"pwd=root;database=HomeAway";
        //create connection
        MySqlConnection con=new MySqlConnection(conString);
       string query="SELECT * FROM RoomDetails where rent between '"+min+"' and '"+max+"'";

     // string query="SELECT * FROM roomdetails where address='"+btn+"'"+ "OR rent='"+btn+"'";

        MySqlCommand cmd=new MySqlCommand();
        cmd.Connection=con;
        cmd.CommandText=query;
        con.Open();
        MySqlDataReader reader=cmd.ExecuteReader();
        List<RoomDetails> rlist=new List<RoomDetails>();

        while(reader.Read())
        {
             int ownerid=int.Parse(reader["ownerid"].ToString());
            int roomid=int.Parse(reader["roomid"].ToString());
             string propertyname=reader["propertyname"].ToString();
            int floorno=int.Parse(reader["FloorNo"].ToString());
            string status=reader["status"].ToString();
            double rent=double.Parse(reader["rent"].ToString());
            double deposit=double.Parse(reader["deposit"].ToString());
            string facility=reader["facility"].ToString();
            string address=reader["roomaddress"].ToString();
            string gender=reader["gender"].ToString();
            string roomType=reader["roomtype"].ToString();
            string url1=reader["url1"].ToString();
            string url2=reader["url2"].ToString();
            string url3=reader["url3"].ToString();
           

            RoomDetails room=new RoomDetails{
                RoomId=roomid,
                PropertyName=propertyname,
                FloorNo=floorno,
                RoomStatus=status,
                RoomRent=rent,
                RoomDeposit=deposit,
                RoomFacility=facility,
                RoomAddress=address,
                Gender=gender,
                RoomType=roomType,
                URL1=url1,
                URL2=url2,
                URL3=url3,
                OwnerId=ownerid
            };
            rlist.Add(room);
       }
       return rlist;
    }

    public List<RoomDetails> SearchRoomDetailsByPropertyName(string pname)
    {
    
     string conString=@"server=localhost;uid=root;"+"pwd=root;database=HomeAway";
        //create connection
        MySqlConnection con=new MySqlConnection(conString);
       string query="SELECT * FROM RoomDetails where PropertyName='"+pname+"'";

        MySqlCommand cmd=new MySqlCommand();
        cmd.Connection=con;
        cmd.CommandText=query;
        con.Open();
        MySqlDataReader reader=cmd.ExecuteReader();
        List<RoomDetails> rlist=new List<RoomDetails>();

        while(reader.Read())
        {
             int ownerid=int.Parse(reader["ownerid"].ToString());
            int roomid=int.Parse(reader["roomid"].ToString());
             string propertyname=reader["propertyname"].ToString();
            int floorno=int.Parse(reader["FloorNo"].ToString());
            string status=reader["status"].ToString();
            double rent=double.Parse(reader["rent"].ToString());
            double deposit=double.Parse(reader["deposit"].ToString());
            string facility=reader["facility"].ToString();
            string address=reader["roomaddress"].ToString();
            string gender=reader["gender"].ToString();
            string roomType=reader["roomtype"].ToString();
            string url1=reader["url1"].ToString();
            string url2=reader["url2"].ToString();
            string url3=reader["url3"].ToString();
           

            RoomDetails room=new RoomDetails{
                RoomId=roomid,
                PropertyName=propertyname,
                FloorNo=floorno,
                RoomStatus=status,
                RoomRent=rent,
                RoomDeposit=deposit,
                RoomFacility=facility,
                RoomAddress=address,
                Gender=gender,
                RoomType=roomType,
                URL1=url1,
                URL2=url2,
                URL3=url3,
                OwnerId=ownerid
            };
            rlist.Add(room);
       }
       return rlist;
    }

}
}
