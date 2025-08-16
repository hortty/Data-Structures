
using Structures;

CustomQueue<string> myQueue = new CustomQueue<string>(10);
myQueue.Add("A");
myQueue.Add("B");
myQueue.Add("C");
myQueue.Add("D");
myQueue.Add("E");
myQueue.Remove();
myQueue.Remove();
myQueue.Show();