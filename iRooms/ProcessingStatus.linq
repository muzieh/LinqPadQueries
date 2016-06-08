<Query Kind="Statements">
  <Connection>
    <ID>f7f90cc3-ce2c-4ae1-a41a-b23258fc1470</ID>
    <Persist>true</Persist>
    <Database>iRooms30</Database>
    <Server>LONWS536DT</Server>
  </Connection>
</Query>

var d = DocumentInfo.Where (di => di.RoomID==946).Where (dii => dii.DocumentID == 612633);
d.FirstOrDefault ( ).ProcessingStatus = 3;
SubmitChanges();