<Query Kind="Statements" />

var rnd = new Random();
var baseDir = @"d:\tmp\store";

for(int documentId = 1; documentId < 1500000; documentId+=9) 
{
	var roomId = rnd.Next(1,5) * 11;
	if(documentId % 100 == 0)
		documentId.Dump();
	
	var documentIdString = documentId.ToString();
	documentIdString =  documentIdString.PadLeft(4,'0');
	var fileVersion = 1;
	
	var length = documentIdString.Length; 
	var rightPart = documentIdString.Substring(length-3, 3);
	var leftPart = documentIdString.Substring(0, length - 3);
	var path = String.Format(@"R{0}\{1}\{2}",roomId, leftPart, rightPart);
	
	path = Path.Combine(baseDir, path);
	
	var filepath = Path.Combine(path, String.Format("{2}_{0}_{1}_p{3}.txt", documentId, fileVersion, roomId,43));
	if(!Directory.Exists(path))
		Directory.CreateDirectory(path);
	File.WriteAllText(filepath,path);
	
	if ( rnd.Next(1,100) > 50 ) {
		var filepath = Path.Combine(path, String.Format("{2}_{0}_{1}_p{3}.txt", documentId, 2, roomId,43));
		if(!Directory.Exists(path))
			Directory.CreateDirectory(path);
		File.WriteAllText(filepath,path);
		
			if ( rnd.Next(1,100) > 80 ) {
				var filepath = Path.Combine(path, String.Format("{2}_{0}_{1}_p{3}.txt", documentId, 3, roomId,43));
				if(!Directory.Exists(path))
					Directory.CreateDirectory(path);
				File.WriteAllText(filepath,path);
			}
	
	}
	
}
