using System;
using System.Collections;
using System.Collections.Generic;

public class BitArray : IEnumerable<int>
{
    private int[] numbers;

    public BitArray(int size)
    {
        this.numbers = new int[(int)Math.Ceiling(size / 32.0)];
        this.Size = size;
    }

    public int Size { get; private set; }

    public int this[int index]
    {
        get
        {
            this.EnsureIndex(index);

            int number = numbers[index / 32];
            int position = index % 32;

            return (number & (1 << position)) != 0 ? 1 : 0;
        }
        set
        {
            this.EnsureIndex(index);
            int position = index % 32;

            if (value == 0)
            {
                numbers[index / 32] &= ~(1 << position);
            }
            else if (value == 1)
            {
                numbers[index / 32] |= 1 << position;
            }
            else
            {
                throw new ArgumentException("Invalid value provided: " + value + ". A bit can be 0 or 1 only.");
            }
        }
    }

    private void EnsureIndex(int index)
    {
        if (index < 0 || index >= this.Size)
        {
            throw new IndexOutOfRangeException("The index " + index + " is outside the bounds of the bit array.");
        }
    }

    public IEnumerator<int> GetEnumerator()
    {
        for (int i = 0; i < this.Size; i++)
        {
            yield return this[i];
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return this.GetEnumerator();
    }
}