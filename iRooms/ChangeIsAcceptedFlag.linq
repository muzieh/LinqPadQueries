<Query Kind="Statements">
  <Connection>
    <ID>f7f90cc3-ce2c-4ae1-a41a-b23258fc1470</ID>
    <Persist>true</Persist>
    <Database>iRooms30</Database>
    <Server>LONWS536DT</Server>
  </Connection>
</Query>

Users.Where(u => u.LoginName.Contains("thomas.kilkenny20@imprima.com")).Dump();
var userid = 4827;

var roomUser = RoomUsers.Where(ru => ru.UserID == 4827 && ru.RoomID == 1085 && ru.GroupID == 2785 ).First( );
roomUser.IsAccepted = false;
SubmitChanges();
RoomUsers.Where(ru => ru.UserID == 4827 && ru.RoomID == 1085 && ru.GroupID == 2785 ).First( ).Dump();