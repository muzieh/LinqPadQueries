<Query Kind="Statements">
  <Connection>
    <ID>f7f90cc3-ce2c-4ae1-a41a-b23258fc1470</ID>
    <Persist>true</Persist>
    <Database>iRooms30</Database>
    <Server>LONWS536DT</Server>
  </Connection>
</Query>

var emailPattern = @"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*";
var reg = new Regex(emailPattern);
var emails = "asdfasdf asdf asdf as dfasdf asd f asdf.asdfwer@imprima.com sdf.asdf@imprima.local";

var m = reg.Matches(emails);
foreach (var match in m)
{
	match.Dump();
}