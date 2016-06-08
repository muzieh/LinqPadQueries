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

var methods = IRooms30.GetType().GetMethods().Where (ir => ir.Name.Equals(@"GetDescendantsByFolderId")).ToList();
var methodInfo = methods[0];

//methodInfo.GetParameters().Dump();
foreach (var param in methodInfo.GetParameters())
{
	var sb = new StringBuilder();

	var type = (param.ParameterType.ToString());
	type = type.Replace("System.","");
	
	sb.Append(type);
	sb.Append(" ");
	sb.Append(param.Name);
	sb.Append(" = xxx;");
	sb.ToString().Dump();
	
}

foreach (var param in methodInfo.GetParameters())
{
	var sb = new StringBuilder();

	var type = (param.ParameterType.ToString());
	type = type.Replace("System.","");
	

	sb.Append(param.Name);
	sb.Append(",");
	sb.ToString().Dump();
	
}

//IRooms30.GetDescendantsByFolderId ()