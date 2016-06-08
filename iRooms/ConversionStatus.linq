<Query Kind="Statements">
  <Connection>
    <ID>f7f90cc3-ce2c-4ae1-a41a-b23258fc1470</ID>
    <Persist>true</Persist>
    <Database>iRooms30</Database>
    <Server>LONWS536DT</Server>
  </Connection>
</Query>

var documentversion = 
	from i in DocumentInfo 
	where i.RoomID == 1695 && !i.IsPublished && (i.ProcessingStatus == 1 || !i.ProcessingStatus.HasValue) && i.DocumentType == 1
	select i;
//documentversion.Dump();

foreach (var document in documentversion)
{
	document.ProcessingStatus = 3;
}

SubmitChanges();