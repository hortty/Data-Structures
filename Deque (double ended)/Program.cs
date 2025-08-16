
using Structures;

CustomDeque<string> myDeque = new CustomDeque<string>(10);
myDeque.AddFinal("A");
myDeque.AddFinal("B");
myDeque.AddFinal("C");
myDeque.AddStart("A0");
myDeque.AddFinal("A2");
myDeque.Show();

Console.WriteLine("\n");

myDeque.RemoveEnd();
myDeque.RemoveStart();
myDeque.Show();
