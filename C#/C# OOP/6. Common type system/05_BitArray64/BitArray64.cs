using System;
using System.Collections;
using System.Collections.Generic;

public class BitArray64 : IEnumerable<int>
{
    private ulong number;

    public BitArray64(ulong param)
    {
        this.number = param;
    }

    public IEnumerator<int> GetEnumerator()
    {
        for (int i = 63; i >= 0; i--)
            yield return (int)(this.number >> i) & 1; //bitwise iteration over 64-bit number
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return this.GetEnumerator();
    }

    public override int GetHashCode()
    {
        return (int)number;
    }

    //methods section
    public override bool Equals(object obj)
    {
        BitArray64 other = obj as BitArray64;
        if (other == null)
            return false;

        // Compare the value type member fields
        if (this.number != other.number)
            return false;

        return true;
    }

    public static bool operator ==(BitArray64 number1, BitArray64 number2)
    {
        return number1.Equals( number2 );
    }

    public static bool operator !=(BitArray64 number1, BitArray64 number2)
    {
        return !(number1.Equals( number2 ));
    }
}