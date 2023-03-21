namespace SAL;
//using BLL;
using BOL;
using DAL;
public class AccountService
{
    AccountManager acmanager;
    //constructor
    public AccountService(){
            acmanager=new AccountManager();
    }
      
    //GetUser for login
    public User GetUser(string email,string pwd)
    {
        return acmanager.GetUser(email,pwd);
    }
    
}


    
