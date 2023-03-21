namespace SAL;
using System;
using BLL;
using BOL;


public class RoomService
{
    RoomManager rmanager=new RoomManager();
    public RoomService(){

    }

    public bool AddRoomDetails(RoomDetails roomDetails )
    {
        return rmanager.AddRoomDetails(roomDetails);

    }

 public List<RoomDetails>ShowRoomDetails()
    {
        return rmanager.ShowRoomDetails();

    }

public RoomDetails UpdateRoomDetails(int RoomId){
        return rmanager.UpdateRoomDetails(RoomId);
    }

  public bool UpdateRoom(RoomDetails rroom)
  {
       return rmanager.UpdateRoom(rroom);
  }

 public bool DeleteRoom(int CustomerId)
    {
        return rmanager.DeleteRoom(CustomerId);
    }
      

      public List<RoomDetails> SearchRoomDetails(string btn)
    {
        return rmanager.SearchRoomDetails(btn);

    }  

    public RoomDetails GetRoomById(int RoomId){
        return rmanager.GetRoomById(RoomId);
    }

    public List<RoomDetails> SearchRoomDetailsByPriceRange(int min, int max){
        return rmanager.SearchRoomDetailsByPriceRange(min,max);
    }
    public List<RoomDetails> SearchRoomDetailsByPropertyName(string name)
    {
        return rmanager.SearchRoomDetailsByPropertyName(name);

    } 
    
}