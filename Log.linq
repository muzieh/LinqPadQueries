<Query Kind="Statements">
  <Connection>
    <ID>ee79db28-1c90-4788-bde4-0917f2eb4187</ID>
    <Persist>true</Persist>
    <Server>LONWS536DT</Server>
    <Database>iRooms30</Database>
    <NoPluralization>true</NoPluralization>
    <DisplayName>LONWS536DT</DisplayName>
    <LinkedDb>iRooms30</LinkedDb>
    <LinkedDb>iRooms30Audit</LinkedDb>
  </Connection>
</Query>

//var i = 0;
//foreach (var element in IRooms30Audit.Log)
//{
//	
//	IRooms30Audit.Log.DeleteOnSubmit(element);
//	if(i%100 == 0)
//	{
//		SubmitChanges();
//		i = 0;
//	}
//	i++;
//}
//SubmitChanges();
IRooms30Audit.Log.OrderByDescending (l => l.DateCreated).Take(20).Dump();