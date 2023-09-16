using System;

class lab011 {
    static void Main() {
        Console.WriteLine("Min and Max values for predefined CTS data types:");

        Console.WriteLine("bool: does not have MinValue and MaxValue, but can take the values true or false");

        Console.WriteLine("byte: MinValue = " + byte.MinValue + ", MaxValue = " + byte.MaxValue);
        Console.WriteLine("sbyte: MinValue = " + sbyte.MinValue + ", MaxValue = " + sbyte.MaxValue);
        Console.WriteLine("char: MinValue = " + ((int)char.MinValue) + ", MaxValue = " + ((int)char.MaxValue));
        Console.WriteLine("decimal: MinValue = " + decimal.MinValue + ", MaxValue = " + decimal.MaxValue);

        Console.WriteLine("double: MinValue = " + double.MinValue + ", MaxValue = " + double.MaxValue);
        Console.WriteLine("float: MinValue = " + float.MinValue + ", MaxValue = " + float.MaxValue);
        Console.WriteLine("int: MinValue = " + int.MinValue + ", MaxValue = " + int.MaxValue);
        Console.WriteLine("uint: MinValue = " + uint.MinValue + ", MaxValue = " + uint.MaxValue);
        Console.WriteLine("long: MinValue = " + long.MinValue + ", MaxValue = " + long.MaxValue);
        Console.WriteLine("ulong: MinValue = " + ulong.MinValue + ", MaxValue = " + ulong.MaxValue);

        Console.WriteLine("object: does not have MinValue and MaxValue, represents a reference to any object");

        Console.WriteLine("short: MinValue = " + short.MinValue + ", MaxValue = " + short.MaxValue);
        Console.WriteLine("ushort: MinValue = " + ushort.MinValue + ", MaxValue = " + ushort.MaxValue);
        Console.WriteLine("string: does not have MinValue and MaxValue, represents a text string");
    }
}