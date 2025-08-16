namespace Structures;

class CustomQueue<T>
{
    private T?[] items;
    private int index = 0;
    private int maxLength = 0;

    public CustomQueue(int length)
    {
        items = new T[length];
        maxLength = length;
    }

    // could be done using circular buffer
    public void Add(T value)
    {
        if (maxLength < index + 1)
        {
            Console.WriteLine("Max limit exceeded!");
            return;
        }

        items[index] = value;
        index++;
    }

    // could be done using circular buffer
    public void Remove()
    {
        if (index - 1 < 0)
        {
            Console.WriteLine("Minimum achieved!");
            return;
        }

        for (int i = 0; i < index - 1; i++)
        {
            items[i] = items[i + 1];
        }

        index--;
    }

    public void Show()
    {
        for (int i = 0; i < index; i++)
        {
            Console.Write(items[i] + " ");
        }
    }
}