<Query Kind="Program">
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

void Main()
{
	MultiAsync();
	Console.WriteLine("running");
}

public static async void MultiAsync()
{
	var stack = new Stack();
	
	for(int i = 0; i<10000; i++)
	{
		var t = LongTaskAsync();
		stack.Push(t);
	}
	
	while(stack.Count > 0)
	{
		var t = (Task<int>)stack.Pop();
		Console.WriteLine("t " + await t);
	}
	
}

public static Task<int> LongTaskAsync()
{
	return Task.Delay(TimeSpan.FromSeconds(1)).ContinueWith(a => {
		double z = 0;
		for(int i=0;i<1000000;i++)
			z += Math.Sin((double)i / 1000000.0);
			
		return Task.CurrentId.Value;
	});
}
// Define other methods and classes here
