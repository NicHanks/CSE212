using System.Threading.Channels;

namespace MySet;

public class MySetArray
{
    private int size = 0;
    // private int sizeAll = 0;
    private int cap = 10;
    private int[] array;
    
    public MySetArray()
    {
        // array of ints
        array = new int[cap];
        size = 0;
        // sizeAll = 0;
    }

    public void Add(int value)
    {
         // no dups
         // growing the array

         if (!Contains(value)) // O(n)
         {
             // Find a spot for the value
             var index = _Contains(0X000BEEF);  // O(n)
             if (index >= 0)
             {
                 array[index] = value;
                 size++;
             }
             else
             {
                 // add O(1)
                 if (size + 1 >= cap)
                 {
                     // Full
                     Array.Resize(ref array, size + 10);
                     cap += 10;
                 }

                 // Add
                 array[size++] = value;
             }
         }

         Console.WriteLine($"size = {size}, cap = {cap}");
         Console.WriteLine(String.Join(", ", array));
    }
    
    public void Remove(int value)
    {
        // Remove value none = 0xDEADBEEF
        var index = _Contains(value);  // O(n)
        if (index >= 0)
        {
            array[index] = 0x0000BEEF;
            size--;
        }
        Console.WriteLine($"size = {size}, cap = {cap}");
        Console.WriteLine(String.Join(", ", array));
    }

    public bool Contains(int value)
    {
        return _Contains(value) >= 0;
    }
    
    private int _Contains(int value)
    {
        // for searching for value O(n)
        var index = 0;
        foreach (var v in array)
        {
            if (v == value)
            {
                return index;
            }

            index++;
        }
        return -1;
    }
    
    public int Size()  // O(1)
    {
        return size;
    }

}