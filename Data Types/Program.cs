using System;

namespace Data_Types
{
    class Program
    {
        static void Main(string[] args)
        {
            //0 to 255
            byte byteType = 200;
            Console.WriteLine($"Value stored in byte variable: {byteType}" );

            //-128 to 127
            sbyte sbyteType = -100;
            Console.WriteLine($"Value stored in sbyte variable: {sbyteType}");

            //-32768 to 32767
            short shortType = 30000;
            Console.WriteLine($"Value stored in short variable: {shortType}");

            //0 to 65535
            ushort ushortType = 60000;
            Console.WriteLine($"Value stored in ushort variable: {ushortType}");

            //-2147483648 to 2147483647
            int intType = -2000000000;
            Console.WriteLine($"Value stored in int variable: {intType}");

            //0 to 4294967295
            uint uintType = 2000000000;
            Console.WriteLine($"Value stored in uint variable: {uintType}");

            // -9223372036854775808 to 9223372036854775807
            long longType = -1000000000000000000;
            Console.WriteLine($"Value stored in long variable: {longType}");

            //0 to 18446744073709551615
            ulong ulongType = 1000000000000000000;
            Console.WriteLine($"Value stored in ulong variable: {ulongType} \n");
            Console.ReadKey();

            //Bytes Size
            Console.WriteLine($"Bytes reserved for byte: {sizeof(byte)}");
            Console.WriteLine($"Bytes reserved for sbyte: {sizeof(sbyte)}");
            Console.WriteLine($"Bytes reserved for short: {sizeof(short)}");
            Console.WriteLine($"Bytes reserved for ushort: {sizeof(ushort)}");
            Console.WriteLine($"Bytes reserved for int: {sizeof(int)}");
            Console.WriteLine($"Bytes reserved for uint: {sizeof(uint)}");
            Console.WriteLine($"Bytes reserved for long: {sizeof(long)}");
            Console.WriteLine($"Bytes reserved for ulong: {sizeof(ulong)}");
            Console.WriteLine($"Bytes reserved for float: {sizeof(float)}");
            Console.WriteLine($"Bytes reserved for double: {sizeof(double)}");
            Console.WriteLine($"Bytes reserved for decimal: {sizeof(decimal)}");
            Console.WriteLine($"Bytes reserved for char: {sizeof(char)}");
            Console.WriteLine($"Bytes reserved for bool: {sizeof(bool)} \n");
            Console.ReadKey();

            Console.WriteLine("Maximum and minimum value for float data type");
            Console.WriteLine($"Maximum: {float.MaxValue}");
            Console.WriteLine($"Minimum: {float.MinValue} \n");

            Console.WriteLine("Maximum and minimum value for double data type");
            Console.WriteLine($"Maximum: {double.MaxValue}");
            Console.WriteLine($"Minimum: {double.MinValue} \n");

            Console.WriteLine("Maximum and minimum value for decimal data type");
            Console.WriteLine($"Maximum: {decimal.MaxValue}");
            Console.WriteLine($"Minimum: {decimal.MinValue} \n");
            Console.ReadKey();

            char charType = 'a';
            Console.WriteLine($"Character: {charType}");

            string stringType = "This is a string";
            Console.WriteLine($"String: {stringType}");

            bool boolType = true;
            Console.WriteLine($"Bool: {boolType}");

            dynamic dinamicType = "Hello"; //This can be any king of data
            Console.WriteLine($"Dinamic: {dinamicType}");

            object objectType = 15;
            Console.WriteLine($"Object: {objectType}");

        }
    }
}
