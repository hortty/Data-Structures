
using Structures;

CustomStack<int> myStack = new CustomStack<int>(10);
myStack.Append(1);
myStack.Append(2);
myStack.Append(3);
myStack.Append(4);
myStack.Pop();
myStack.Pop();
myStack.Show();