namespace BLL;
using BOL;
using DAL;
public class AccountManager
{
    AccountDBManager aDBManager;

    public AccountManager(){
        aDBManager=new AccountDBManager();
    }

    public User GetUser(string email,string pwd)
    {
        return aDBManager.GetUser(email,pwd);
    }


}