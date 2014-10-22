using System;
using System.Linq;

interface IDrawable<T>
{
    T WithDraw(decimal money);
}