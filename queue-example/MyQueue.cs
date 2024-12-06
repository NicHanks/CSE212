using System.Diagnostics;

namespace queue_example;

public class MyQueue
{
    private int[] _items;
    private int _Capacity = 5;
    private int _head = -1;
    private int _tail = -1;
    private int _count = 0;
    
    public MyQueue()
    {
        _items = new int[_Capacity];
        _count = 0;
        _head = -1;
        _tail = -1;
    }
    
    public int Size()
    {
        return _count;
    }
    
    public void Enqueue(int value)
    {
        // Check if head is still -1
        if (_head == -1)
        {
            _head = 0;
            _tail = 0;
        }
        else if (_count == _Capacity)
        {
            int newSize = (int)(_Capacity * 1.10 + 5);
            Console.WriteLine($"Newsize = {newSize}");
            Array.Resize(ref _items, newSize);
            _Capacity = newSize;
        }

        // move head and add value to items
        _items[_head++] = value;
        _count++;
        _head %= _Capacity;
    }
    
    public int Dequeue()
    {
        // Check is head is -1 -> error
        if (_head == -1)
        {
            Trace.Assert(false);
            return (-1);
        }
        
        // Get value from items
        var results = _items[_tail++];

        _count--;
        _tail %= _Capacity;
        
        return(results);
    }

    public int Peek()
    {
        // Check if head is -1
        if (_head == -1)
        {
            return (-1);
        }
        
        // Return current value at the head
        return (_items[_tail]);
    }
    
}
