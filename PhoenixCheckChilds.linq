<Query Kind="SQL">
  <Connection>
    <ID>f7f90cc3-ce2c-4ae1-a41a-b23258fc1470</ID>
    <Persist>true</Persist>
    <Database>iRooms30</Database>
    <Server>LONWS536DT</Server>
  </Connection>
</Query>

declare @RoomId int
declare @FolderId int

set @RoomId = 1238
set @FolderId = 217606
set @GroupId = 

create table #FoldersToPermission
(
	FolderTreeId int,
	FolderHierarchyId HierarchyId
)

insert into #FoldersToPermission(FolderTreeId) values (217606)

update	ftp
set		FolderHierarchyId = f.FolderHierarchyId
from	#FoldersToPermission ftp
		inner join iRooms.FolderInfo f
			on ftp.FolderTreeId = f.FolderTreeId
			and f.isPublished = 0
			and f.RoomId = @RoomId
		
	
select * from #FoldersToPermission

select * from iRooms.FolderInfo where RoomId = @RoomId and isPublished = 0

select	fi.FolderTreeId, 
		fi.FolderHierarchyId,
		fi.FolderName
into	#ChildFolders
from	iRooms.FolderInfo fi
		inner join #FoldersTOPermission fp
				on  fi.FolderHierarchyId.IsDescendantOf(fp.FolderHierarchyId) = 1
				and fi.IsPublished = 0
				and fi.RoomId = @RoomId
				and fi.isDeleted = 0
				and fi.FolderHierarchyId <> fp.FolderHierarchyId
		inner join iRooms.FolderPermissions fpermi
				on fpermi.FolderTreeId = fi.FolderTreeId
				and fpermi.isPublished = 0
				and fpermi.RoomdId = @RoomsId
				and fpermi.GroupId = 


select	di.FolderTreeId, 
		di.DocumentId,
		di.DocumentHeirarchyId,
		di.DocumentName
into	#ChildDocuments
from	iRooms.DocumentInfo di
		inner join #FoldersTOPermission fp
				on  di.DocumentHeirarchyId.IsDescendantOf(fp.FolderHierarchyId) = 1
				and di.IsPublished = 0
				and di.RoomId = @RoomId
				and di.isDeleted = 0
				



select * from #ChildFolders
select * from #ChildDocuments

drop table #FoldersToPermission
drop table #ChildFolders
drop table #ChildDocuments