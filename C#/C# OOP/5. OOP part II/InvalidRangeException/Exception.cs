using System;
using System.Linq;

public class InvalidRangeException <T> : ApplicationException
{
    private const string ErrorMessage = "The value is not in range";

    public InvalidRangeException(string message = ErrorMessage, Exception innerEx = null) 
        : base(message, innerEx)
    {
    }

    public InvalidRangeException(T start, T end, string message = ErrorMessage, Exception innerEx = null) 
        : base(message, innerEx)
    {
        this.Start = start;
        this.Last = end;
    }

    public T Start { get; private set; }

    public T Last { get; private set; }
}
