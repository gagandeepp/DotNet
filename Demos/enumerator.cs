public class MyEnumerator : IEnumerator<int>
{
    private int[] _items;
    private int _position = -1;

    public MyEnumerator(int[] items)
    {
        _items = items;
    }

    public bool MoveNext()
    {
        _position++;
        return (_position < _items.Length);
    }

    public void Reset()
    {
        _position = -1;
    }

    public int Current
    {
        get
        {
            try
            {
                return _items[_position];
            }
            catch (IndexOutOfRangeException)
            {
                throw new InvalidOperationException();
            }
        }
    }

    object IEnumerator.Current => Current;

    public void Dispose()
    {
        // Dispose resources if needed
    }
}
