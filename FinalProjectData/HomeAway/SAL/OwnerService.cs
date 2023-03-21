namespace SAL;
using BLL;
using BOL;
public class OwnerService
{
    OwnerManager omanager=new OwnerManager();
    public OwnerService(){

    }

    public bool AddOwner(Owner owner){
        return omanager.AddOwner(owner);
    }

    public List<Owner> ShowOwnerDetails(){
        return omanager.ShowOwnerDetails();
    }

    public Owner UpdateOwner(int OwnerId){
        return omanager.UpdateOwner(OwnerId);
    }

    public bool UpdateOwner(Owner owner) => omanager.UpdateOwner(owner);

    public bool DeleteOwner(int OwnerId)
    {
        return omanager.DeleteOwner(OwnerId);
    }
}
