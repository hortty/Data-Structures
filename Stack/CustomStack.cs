namespace Structures;

class CustomStack<T>
{
    private T?[] stack;
    private int index = 0;
    private int maxLength = 0;

    public CustomStack(int length)
    {
        stack = new T[length];
        maxLength = length;
    }

    public void Append(T value)
    {
        if (maxLength < index + 1)
        {
            Console.WriteLine("Max limit exceeded!");
            return;
        }

        stack[index] = value;
        index++;
    }

    public void Pop()
    {
        if (index - 1 < 0)
        {
            Console.WriteLine("Minimum achieved!");
            return;
        }
        index--;
        stack[index] = default;
    }

    public void Show()
    {
        for (int i = index - 1; i >= 0; i--)
        {
            Console.WriteLine(stack[i]);
        }
    }
}