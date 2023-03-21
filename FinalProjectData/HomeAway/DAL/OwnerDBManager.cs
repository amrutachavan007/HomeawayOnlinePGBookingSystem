namespace DAL;
using BOL;
using System.Data;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

public class OwnerDBManager
{
    public bool AddOwner(Owner owner){
        string conString=@"server=localhost;uid=root;"+"pwd=root;database=HomeAway";
        //create connection
        MySqlConnection con=new MySqlConnection(conString);
        string query="INSERT INTO User(UserName,UserContactNo,UserEmail,RoleId) VALUES('"+owner.OwnerName+"','"+owner.OwnerContactNo+"','"+owner.OwnerEmail+"','"+3+"')";
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

    public List<Owner> ShowOwnerDetails(){
         string conString=@"server=localhost;uid=root;"+"pwd=root;database=HomeAway";
        //create connection
        MySqlConnection con=new MySqlConnection(conString);
        string query="SELECT * FROM User where RoleId=3";
        MySqlCommand cmd=new MySqlCommand();
        cmd.Connection=con;
        cmd.CommandText=query;
        con.Open();
        MySqlDataReader reader=cmd.ExecuteReader();
        List<Owner> olist=new List<Owner>();

        while(reader.Read()){
            int OwnerId=int.Parse(reader["UserId"].ToString());
            string OwnerName=reader["UserName"].ToString();
            string OwnerContactNo=reader["UserContactNo"].ToString();
            string OwnerEmail=reader["UserEmail"].ToString();
            //Can we show password to admin or not?????????

            Owner owner=new Owner{
                OwnerId=OwnerId,
                OwnerName=OwnerName,
                OwnerContactNo=OwnerContactNo,
                OwnerEmail=OwnerEmail
            };
            olist.Add(owner);
       }
       return olist;
        //con.Close();
    }

    public Owner UpdateOwner(int Id){
        string conString=@"server=localhost;uid=root;"+"pwd=root;database=HomeAway";
        //create connection
        Owner owner=null;
        MySqlConnection con=new MySqlConnection(conString);
        string query="SELECT * FROM User where UserId='"+Id+"'";
        MySqlCommand cmd=new MySqlCommand();
        cmd.Connection=con;
        cmd.CommandText=query;
        con.Open();
        MySqlDataReader reader=cmd.ExecuteReader();

        while(reader.Read()){
            int OwnerId=int.Parse(reader["UserId"].ToString());
            string OwnerName=reader["UserName"].ToString();
            string OwnerContactNo=reader["UserContactNo"].ToString();
            string OwnerEmail=reader["UserEmail"].ToString();
    
            owner=new Owner{
                OwnerId=OwnerId,
                OwnerName=OwnerName,
                OwnerContactNo=OwnerContactNo,
                OwnerEmail=OwnerEmail
            };
       }
       return owner;
    }

    public bool UpdateOwner(Owner owner){
        string conString=@"server=localhost;uid=root;"+"pwd=Jagruti@27;database=HomeAway";
        //create connection
        MySqlConnection con=new MySqlConnection(conString);
        string query="UPDATE User SET UserName='"+owner.OwnerName+"',UserContactNo='"+owner.OwnerContactNo+"',UserEmail='"+owner.OwnerEmail+"' where UserId="+owner.OwnerId;
        //string query="UPDATE Customer SET CustomerName='"+customer.CustomerName+"',CustomerContactNo='"+customer.CustomerContactNo+"',CustomerEmail='"+customer.CustomerEmail+"',CustomerPassword='"+customer.CustomerPassword+"' where CustomerId="+4;
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

    public bool DeleteOwner(int OwnerId)
    {
        bool status = false;
        string conString=@"server=localhost;uid=root;"+"pwd=Jagruti@27;database=HomeAway";
        //create connection
        MySqlConnection con=new MySqlConnection(conString);
         MySqlCommand cmd=new MySqlCommand();
        cmd.Connection=con;
        string query="DELETE FROM User where UserId="+OwnerId;
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
}
