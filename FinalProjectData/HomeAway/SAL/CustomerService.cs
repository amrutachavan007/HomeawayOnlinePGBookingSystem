namespace SAL;
using BLL;
using BOL;
public class CustomerService
{
    CustomerManager cmanager=new CustomerManager();
    public CustomerService(){

    }

    public bool RegisterCustomer(Customer customer){
        return cmanager.RegisterCustomer(customer);
    }

    public List<Customer> ShowCustomerDetails(){
        return cmanager.ShowCustomerDetails();
    }

    public Customer UpdateCustomer(int CustomerId){
        return cmanager.UpdateCustomer(CustomerId);
    }

    public bool UpdateCustomer(Customer customer) => cmanager.UpdateCustomer(customer);

    public bool DeleteCustomer(int CustomerId)
    {
        return cmanager.DeleteCustomer(CustomerId);
    }

    public Customer GetCustomerById(int id){
       return cmanager.GetCustomerById(id);
    }
}
