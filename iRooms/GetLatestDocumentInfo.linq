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
	where i.RoomID == 1085  //&& i.DocumentID == 848173
	orderby  i.DateCreated descending
	select i;
documentversion.Dump();

var last = documentversion.Where(d => d.IsPublished == false).First();
last.LastUpdated = DateTime.Now;

last.Dump();
SubmitChanges();