using System;

namespace ValoresEspeciais
{
    public class Program
    {
        private static void Main(string[] args)
        {
            byte byte_max = byte.MaxValue;
            byte byte_min = byte.MinValue;
            Console.WriteLine($"byte máximo: {byte_max}\nbyte mínimo: {byte_min}");
            sbyte sbyte_max = sbyte.MaxValue;
            sbyte sbyte_min = sbyte.MinValue;
            Console.WriteLine($"sbyte máximo: {sbyte_max}\nsbyte mínimo: {sbyte_min}");
            short short_max = short.MaxValue;
            short short_min = short.MinValue;
            Console.WriteLine($"short máximo: {short_max}\nshort mínimo: {short_min}");
            ushort ushort_max = ushort.MaxValue;
            ushort ushort_min = ushort.MinValue;
            Console.WriteLine($"ushort máximo: {ushort_max}\nushort mínimo: {ushort_min}");
            int int_max = int.MaxValue;
            int int_min = int.MinValue;
            Console.WriteLine($"int máximo: {int_max}\nint mínimo: {int_min}");
            uint uint_max = uint.MaxValue;
            uint uint_min = uint.MinValue;
            Console.WriteLine($"uint máximo: {uint_max}\nuint mínimo: {uint_min}");
            uint uint_overflow_max = unchecked(uint_max + 1);
            Console.WriteLine($"uint máximo + 1 overflow: {uint_overflow_max}");

            long long_max = long.MaxValue;
            long long_min = long.MinValue;
            Console.WriteLine($"long máximo: {long_max}\nlong mínimo: {long_min}");
            ulong ulong_max = ulong.MaxValue;
            ulong ulong_min = ulong.MinValue;
            Console.WriteLine($"ulong máximo: {ulong_max}\nulong mínimo: {ulong_min}");
            float float_max = float.MaxValue;
            float float_min = float.MinValue;
            Console.WriteLine($"float máximo: {float_max}\nfloat mínimo: {float_min}");
            float overflow_float = float_max * 100f;
            float overflow_float_infinity = float_max * float_max;
            Console.WriteLine($"float máximo * 100f overflow: {overflow_float:F3}");
            Console.WriteLine($"float máximo * máximo overflow: {overflow_float_infinity:F3}");
            float underflow_float = float_min / 100000f;
            Console.WriteLine($"float mínimo / 100000f underflow: {underflow_float:F3}");

            double double_max = double.MaxValue;
            double double_min = double.MinValue;
            Console.WriteLine($"double máximo: {double_max}\ndouble mínimo: {double_min}");
            decimal decimal_max = decimal.MaxValue;
            decimal decimal_min = decimal.MinValue;
            Console.WriteLine($"decimal máximo: {decimal_max}\ndecimalmínimo: {decimal_min}");

            float float_min_infinite = float.NegativeInfinity;
            float float_max_infinite = float.PositiveInfinity;
            float float_nan = float.NaN;
            Console.WriteLine($"float máximo infinito: {float_min_infinite}\nfloat mínimo infinito: {float_max_infinite}\nfloat NaN: {float_nan}");

            double double_min_infinite = double.NegativeInfinity;
            double double_max_infinite = double.PositiveInfinity;
            double double_nan = double.NaN;
            Console.WriteLine($"double máximo infinito: {double_min_infinite}\ndouble mínimo infinito: {double_max_infinite}\ndouble NaN: {double_nan}");
        }
    }
}
