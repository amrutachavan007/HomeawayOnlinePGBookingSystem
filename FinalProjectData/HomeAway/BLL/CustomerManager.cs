namespace BLL;
using BOL;
using DAL;
public class CustomerManager
{
    CustomerDBManager dBManager=new CustomerDBManager();
    public bool RegisterCustomer(Customer customer){
        bool status=dBManager.RegisterCustomer(customer);
        return status;
    }

    public List<Customer> ShowCustomerDetails(){
        return dBManager.ShowCustomerDetails();
    }
    public Customer UpdateCustomer(int CustomerId){
        return dBManager.UpdateCustomer(CustomerId);
    }

    public bool UpdateCustomer(Customer customer) => dBManager.UpdateCustomer(customer);

    public bool DeleteCustomer(int CustomerId)
    {
        return dBManager.DeleteCustomer(CustomerId);
    }

    public Customer GetCustomerById(int CustomerId){
        return dBManager.GetCustomerById(CustomerId);
    }
}
