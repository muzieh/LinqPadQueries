<Query Kind="FSharpProgram">
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

//!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
//Will delete all entires from that directory list without prompting 
//!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!

let foldersToClear = [
	@"c:\iRooms\PrizmCache"
	@"c:\iRooms\Temp\"
	]
	

let deleteContent path =
 let directoryInfo = new DirectoryInfo(path)
 directoryInfo.GetFiles() |>
 	Array.iter (fun fileInfo -> fileInfo.Delete() )
 directoryInfo.GetDirectories() |>
 	Array.iter (fun dirInfo -> 
		//dirInfo.Delete(true)
		//don't delate directories
		dirInfo.Dump()
		)

List.iter deleteContent foldersToClear