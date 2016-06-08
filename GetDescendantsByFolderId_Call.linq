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

Int64? FolderTreeId = 202450;
Int32? RoomId = 1156;
Int32? Depth = 0;
bool? IsPublish = false;
Int32? StartIndex = 0;
Int32? MaxRows = 0;
Boolean? IsPublished = false;
String UserName = "iRoomsAdmin@impdevnet.local";
String FolderTreeIds = null;
String DocumentIds = null;
String SortColumnName = null;
String SortDirection = null;
Int32? RowCount = 0;
Boolean? IncludeDocuments = true;
Boolean? IncludeDocumentsInChildCount = true;
Boolean? ViewAllItems = false;
Int32? GroupId = 0;
Int32? NumberOfDocuments = null;
Int32? NumberOfFolders = null;
Int32? NumberOfReadDocuments = null;

IRooms30.GetDescendantsByFolderId(
FolderTreeId,
RoomId,
Depth,
IsPublish,
StartIndex,
MaxRows,
IsPublished,
UserName,
FolderTreeIds,
DocumentIds,
SortColumnName,
SortDirection,
RowCount,
IncludeDocuments,
IncludeDocumentsInChildCount,
ViewAllItems,
GroupId,
NumberOfDocuments,
NumberOfFolders,
NumberOfReadDocuments).Dump();;