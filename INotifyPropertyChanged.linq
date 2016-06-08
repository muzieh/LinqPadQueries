<Query Kind="Program" />


void Main()
{
	var a = new A();
	a.PropertyChanged += new System.ComponentModel.PropertyChangedEventHandler(PropertyChanged);
	a.Prop = 34;
	a.ToString().Dump();
}

void PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs args)
{
	("from outside property: " + args.PropertyName).Dump();
}

public class A : System.ComponentModel.INotifyPropertyChanged
{
	private int _prop;
	public int Prop {
		get { return _prop; } 
		set {
			_prop = value;
			if(this.PropertyChanged != null)
				this.PropertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs("Prop") );
		}
	}
	public event System.ComponentModel.PropertyChangedEventHandler  PropertyChanged;
	
	public override string ToString()
	{
		return "from inside class " + Prop.ToString();
	}
}