<Query Kind="SQL">
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



USE iRooms30
GO
EXEC sp_change_users_login 'update_one', 'iroomsuser', 'iroomsuser'
GO


USE iRooms30
Go
EXEC sp_changedbowner sa


ALTER DATABASE iRooms30 SET TRUSTWORTHY ON
GO

