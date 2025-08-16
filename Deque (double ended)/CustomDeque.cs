namespace Structures;

class CustomDeque<T>
{
    private T?[] items;
    private int index = 0;
    private int maxLength = 0;

    public CustomDeque(int length)
    {
        items = new T[length];
        maxLength = length;
    }

    // could be done using circular buffer
    public void AddFinal(T value)
    {
        if (index + 1 >= maxLength)
        {
            Console.WriteLine("Max limit exceeded!");
            return;
        }

        items[index] = value;
        index++;
    }

    public void AddStart(T value)
    {
        if (index + 1 >= maxLength)
        {
            Console.WriteLine("Max limit exceeded!");
            return;
        }

        for (int i = index; i > 0; i--)
        {
            items[i] = items[i - 1];
        }

        items[0] = value;
        index++;
    }

    // could be done using circular buffer
    public void RemoveStart()
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

    public void RemoveEnd()
    {
        if (index - 1 < 0)
        {
            Console.WriteLine("Minimum achieved!");
            return;
        }

        items[index] = default;

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