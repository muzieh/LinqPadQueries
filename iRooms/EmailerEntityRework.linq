<Query Kind="Statements">
  <Connection>
    <ID>565cd58f-afc6-428e-9c54-aa05214ad187</ID>
    <Persist>true</Persist>
    <Driver>EntityFrameworkDbContext</Driver>
    <CustomAssemblyPath>C:\tfs\Main\Source\Services\DataModels\bin\Debug\DataModels.dll</CustomAssemblyPath>
    <CustomTypeName>iRooms.Services.Interfaces.DataModels.iRoomsDbContext</CustomTypeName>
    <CustomCxString>Data Source=localhost;Initial Catalog=iRooms30;User ID=iRoomsUser;Password=1qaz2wsx$</CustomCxString>
  </Connection>
  <Namespace>iRooms.Services.Interfaces.DataModels.Communications.DataTransferObjects</Namespace>
  <Namespace>iRooms.Services.Interfaces.DataModels.Communications.Entities</Namespace>
</Query>

//var mailboxes = new int[] {447};
//
//var mmq = new  MailMessagesQuery() {
//	UserId = 2,
//	IncludeDocumentsAndFoldersList = true,
//	IncludeRecipientsList = true,
//	RoomId = 918,
//	AsRecipient = false
//
//};
//this.Communications.ListMessages(mmq).Dump();

var mailboxesNewa = new int[] {447};

var mmqNewa = new  MailMessagesQuery() {
	UserId = 2, 
	IncludeDocumentsAndFoldersList = true,
	IncludeRecipientsList = true,
	RoomId = 918,
	AsRecipient = false,
	Sort = new MailMessageSortField[] { new MailMessageSortField() {Direction=SortDirection.Descending, Field = MailMessageField.Category} }
	,Category = MailMessageCategory.QnaNotification

};
this.Communications.ListMessages(mmqNewa).Select (c => new{ Id = c.MailMessage.MailMessageId, Category = c.MailMessage.MailMessageCategory}).Dump();