namespace DAL;
using BOL;
using System.Data;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

public class CustomerDBManager
{
    public bool RegisterCustomer(Customer customer){
        string conString=@"server=localhost;uid=root;"+"pwd=root;database=HomeAway";
        //create connection
        MySqlConnection con=new MySqlConnection(conString);
        string query="INSERT INTO User(UserName,UserContactNo,UserEmail,UserPassword,RoleId) VALUES('"+customer.CustomerName+"','"+customer.CustomerContactNo+"','"+customer.CustomerEmail+"','"+customer.CustomerPassword+"','"+2+"')";
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

    public List<Customer> ShowCustomerDetails(){
         string conString=@"server=localhost;uid=root;"+"pwd=root;database=HomeAway";
        //create connection
        MySqlConnection con=new MySqlConnection(conString);
        string query="SELECT * FROM User where RoleId=2 order by UserId desc";
        MySqlCommand cmd=new MySqlCommand();
        cmd.Connection=con;
        cmd.CommandText=query;
        con.Open();
        MySqlDataReader reader=cmd.ExecuteReader();
        List<Customer> clist=new List<Customer>();

        while(reader.Read()){
            int CustomerId=int.Parse(reader["UserId"].ToString());
            string CustomerName=reader["UserName"].ToString();
            string CustomerContactNo=reader["UserContactNo"].ToString();
            string CustomerEmail=reader["UserEmail"].ToString();
            string CustomerPassword=reader["UserPassword"].ToString();
            //Can we show password to admin or not?????????

            Customer customer=new Customer{
                CustomerId=CustomerId,
                CustomerName=CustomerName,
                CustomerContactNo=CustomerContactNo,
                CustomerEmail=CustomerEmail,
                CustomerPassword=CustomerPassword
            };
            clist.Add(customer);
       }
       return clist;
        //con.Close();
    }

    public Customer UpdateCustomer(int Id){
        string conString=@"server=localhost;uid=root;"+"pwd=root;database=HomeAway";
        //create connection
        Customer customer=null;
        MySqlConnection con=new MySqlConnection(conString);
        string query="SELECT * FROM User where UserId='"+Id+"'";
        MySqlCommand cmd=new MySqlCommand();
        cmd.Connection=con;
        cmd.CommandText=query;
        con.Open();
        MySqlDataReader reader=cmd.ExecuteReader();

        while(reader.Read()){
            int CustomerId=int.Parse(reader["UserId"].ToString());
            string CustomerName=reader["UserName"].ToString();
            string CustomerContactNo=reader["UserContactNo"].ToString();
            string CustomerEmail=reader["UserEmail"].ToString();
            string CustomerPassword=reader["UserPassword"].ToString();
            //Can we show password to admin or not?????????

            customer=new Customer{
                CustomerId=CustomerId,
                CustomerName=CustomerName,
                CustomerContactNo=CustomerContactNo,
                CustomerEmail=CustomerEmail,
                CustomerPassword=CustomerPassword
            };
       }
       return customer;
    }

    public bool UpdateCustomer(Customer customer){
        string conString=@"server=localhost;uid=root;"+"pwd=root;database=HomeAway";
        //create connection
        MySqlConnection con=new MySqlConnection(conString);
        string query="UPDATE User SET UserName='"+customer.CustomerName+"',UserContactNo='"+customer.CustomerContactNo+"',UserEmail='"+customer.CustomerEmail+"',UserPassword='"+customer.CustomerPassword+"' where UserId="+customer.CustomerId;
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

    public bool DeleteCustomer(int CustomerId)
    {
        bool status = false;
        string conString=@"server=localhost;uid=root;"+"pwd=root;database=HomeAway";
        //create connection
        MySqlConnection con=new MySqlConnection(conString);
         MySqlCommand cmd=new MySqlCommand();
        cmd.Connection=con;
        string query="DELETE FROM User where UserId="+CustomerId;
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

    public Customer GetCustomerById(int Id){
        string conString=@"server=localhost;uid=root;"+"pwd=root;database=HomeAway";
        //create connection
        Customer customer=null;
        MySqlConnection con=new MySqlConnection(conString);
        string query="SELECT * FROM User where UserId='"+Id+"'";
        MySqlCommand cmd=new MySqlCommand();
        cmd.Connection=con;
        cmd.CommandText=query;
        con.Open();
        MySqlDataReader reader=cmd.ExecuteReader();

        while(reader.Read()){
            int CustomerId=int.Parse(reader["UserId"].ToString());
            string CustomerName=reader["UserName"].ToString();
            string CustomerContactNo=reader["UserContactNo"].ToString();
            string CustomerEmail=reader["UserEmail"].ToString();
            string CustomerPassword=reader["UserPassword"].ToString();
            //Can we show password to admin or not?????????

            customer=new Customer{
                CustomerId=CustomerId,
                CustomerName=CustomerName,
                CustomerContactNo=CustomerContactNo,
                CustomerEmail=CustomerEmail,
                CustomerPassword=CustomerPassword
            };
       }
       return customer;
    }
}
