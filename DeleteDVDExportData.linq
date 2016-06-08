<Query Kind="Statements">
  <Connection>
    <ID>ee79db28-1c90-4788-bde4-0917f2eb4187</ID>
    <Persist>true</Persist>
    <Server>LONWS536DT</Server>
    <Database>master</Database>
    <NoPluralization>true</NoPluralization>
    <DisplayName>LONWS536DT</DisplayName>
    <LinkedDb>iRooms30</LinkedDb>
    <LinkedDb>iRooms30Audit</LinkedDb>
  </Connection>
</Query>

var req = IRooms30.DvdExportRequests.Where (der => der.DvdExportRequestId < 1187).ToList();

foreach (var dvd in req)
{
	
	//dvd.DvdExportRequestDocumentInfo;
	
	IRooms30.DvdExportRequestDocumentInfo.DeleteAllOnSubmit(dvd.DvdExportRequestDocumentInfo);
	IRooms30.DvdExportRequestFolderInfo.DeleteAllOnSubmit(dvd.DvdExportRequestFolderInfo);
	IRooms30.DvdExportNotifiedOffices.DeleteAllOnSubmit(dvd.DvdExportNotifiedOffices);
	IRooms30.DvdExportRequests.DeleteOnSubmit(dvd);
	SubmitChanges();
}