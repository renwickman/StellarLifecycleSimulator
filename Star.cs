using System;

namespace StarLifecycleSimulator
{
  class Star
  {
    public string name;
    public string type;
    public int age;
    public double brightness;
  
    public Star(string name, string type)
    {
      this.name = name;
      this.type = type;
      age = 0;
      brightness = 1.0;
    }
    public Star(string name) : this(name, "Unknown")
    {
      type = "Unknown";
      Console.WriteLine($"Star type set to default: {type}");
    }
    public void Shine()
    {
      Console.WriteLine($"Star {name} is shining with brightness {brightness}.");
    }
    public void GrowOlder()
    {
      brightness = brightness * .1;
      age += 1000000000;
    }
    public void Supernova()
    {
      brightness =  0;
      Console.WriteLine($"Star {name} has exploded in a supernova.");
    }
  }
}
