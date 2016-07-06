<Query Kind="Statements">
  <Connection>
    <ID>f7f90cc3-ce2c-4ae1-a41a-b23258fc1470</ID>
    <Persist>true</Persist>
    <Database>iRooms30</Database>
    <Server>LONWS536DT</Server>
  </Connection>
</Query>

//var d = DocumentInfo.Where (di => di.RoomID==1836).OrderByDescending(di => di.DocumentID);
//d.Dump();
//220639
//848612
//848611
var d = DocumentInfo.Where (di => di.RoomID==1836).Where (dii => dii.DocumentID == 848613);
d.FirstOrDefault ( ).ProcessingStatus = 3;
SubmitChanges();