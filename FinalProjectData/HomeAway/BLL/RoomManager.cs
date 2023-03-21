namespace BLL;
using System;
using BOL;
using DAL;

public class RoomManager
{
    RoomDBManager dbmanager = new RoomDBManager();

    public bool AddRoomDetails(RoomDetails roomDetails)
    {
        return dbmanager.AddRoomDetails(roomDetails);
    }

    public List<RoomDetails> ShowRoomDetails()
    {
        return dbmanager.ShowRoomDetails();
    }

    public RoomDetails UpdateRoomDetails(int RoomId)
    {
        return dbmanager.UpdateRoomDetails(RoomId);
    }

    public bool UpdateRoom(RoomDetails rroom)
    {
        return dbmanager.UpdateRoom(rroom);
    }

    public bool DeleteRoom(int CustomerId)
    {
        return dbmanager.DeleteRoom(CustomerId);
    }

    public List<RoomDetails> SearchRoomDetails(string btn)
    {
        return dbmanager.SearchRoomDetails(btn);
    }

    public RoomDetails GetRoomById(int RoomId){
        return dbmanager.GetRoomById(RoomId);
    }

    public List<RoomDetails> SearchRoomDetailsByPriceRange(int min, int max){
        return dbmanager.SearchRoomDetailsByPriceRange(min,max);
    }

    public List<RoomDetails> SearchRoomDetailsByPropertyName(string btn)
    {
        return dbmanager.SearchRoomDetailsByPropertyName(btn);
    }
}