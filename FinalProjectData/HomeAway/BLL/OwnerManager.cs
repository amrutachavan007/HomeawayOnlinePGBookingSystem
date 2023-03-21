namespace BLL;
using BOL;
using DAL;
public class OwnerManager
{
    OwnerDBManager dBManager=new OwnerDBManager();
    public bool AddOwner(Owner owner){
        bool status=dBManager.AddOwner(owner);
        return status;
    }

    public List<Owner> ShowOwnerDetails(){
        return dBManager.ShowOwnerDetails();
    }
    public Owner UpdateOwner(int OwnerId){
        return dBManager.UpdateOwner(OwnerId);
    }

    public bool UpdateOwner(Owner owner) => dBManager.UpdateOwner(owner);

    public bool DeleteOwner(int OwnerId)
    {
        return dBManager.DeleteOwner(OwnerId);
    }
}
