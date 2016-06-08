<Query Kind="Statements">
  <Connection>
    <ID>565cd58f-afc6-428e-9c54-aa05214ad187</ID>
    <Persist>true</Persist>
    <Driver>EntityFrameworkDbContext</Driver>
    <CustomAssemblyPath>C:\tfs\Main\Source\Services\DataModels\bin\Debug\DataModels.dll</CustomAssemblyPath>
    <CustomTypeName>iRooms.Services.Interfaces.DataModels.iRoomsDbContext</CustomTypeName>
    <CustomCxString>Data Source=localhost;Initial Catalog=iRooms30;User ID=iRoomsUser;Password=1qaz2wsx$</CustomCxString>
  </Connection>
  <Reference>&lt;RuntimeDirectory&gt;\System.Web.dll</Reference>
  <Reference>&lt;RuntimeDirectory&gt;\System.Configuration.dll</Reference>
  <Reference>&lt;RuntimeDirectory&gt;\Microsoft.Build.Framework.dll</Reference>
  <Reference>&lt;RuntimeDirectory&gt;\System.Runtime.Caching.dll</Reference>
  <Reference>&lt;RuntimeDirectory&gt;\System.Web.ApplicationServices.dll</Reference>
  <Reference>&lt;RuntimeDirectory&gt;\System.Web.Services.dll</Reference>
  <Reference>&lt;RuntimeDirectory&gt;\Microsoft.Build.Utilities.v4.0.dll</Reference>
  <Reference>&lt;RuntimeDirectory&gt;\System.DirectoryServices.dll</Reference>
  <Reference>&lt;RuntimeDirectory&gt;\System.DirectoryServices.Protocols.dll</Reference>
  <Reference>&lt;RuntimeDirectory&gt;\System.EnterpriseServices.dll</Reference>
  <Reference>&lt;RuntimeDirectory&gt;\System.Design.dll</Reference>
  <Reference>&lt;RuntimeDirectory&gt;\Microsoft.Build.Tasks.v4.0.dll</Reference>
  <Reference>&lt;RuntimeDirectory&gt;\System.ServiceProcess.dll</Reference>
  <Reference>&lt;RuntimeDirectory&gt;\System.Windows.Forms.dll</Reference>
  <Reference>&lt;RuntimeDirectory&gt;\System.Web.RegularExpressions.dll</Reference>
  <Namespace>System.Web</Namespace>
  <Namespace>System.Net</Namespace>
</Query>

var sourceDocumentFileName = @"d:\TestDocuments\Book4.xlsx";
var intermediateFileNameTemplate = @"d:\TestDocuments\output5\out.png";

var url = "http://localhost:18680/convert2swf?enterprise=3&source=" 
	+ HttpUtility.UrlEncode(sourceDocumentFileName) + "&target=" +
	HttpUtility.UrlEncode(intermediateFileNameTemplate);
url.Dump();

//var client = new WebClient();
var req = WebRequest.Create(url);
req.Timeout = -1;

//var html = client.DownloadString(url);
var response = req.GetResponse();
response.Dump();