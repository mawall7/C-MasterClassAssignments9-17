using System.Numerics;

namespace NumericTypesSuggester
{
    internal class NumericTypeSuggester
    {
        public const string BigInteger = "BigInteger";
        public const string ULong = "ulong";
        public const string UInt = "uint";
        public const string UShort = "ushort";
        public const string Byte = "byte";
        public const string Long = "long";
        public const string Int ="int";
        public const string Short="short" ;
        public const string SByte="sbyte";
        public const string Decimal ="decimal";
        public const string Double ="double";
        public const string Float = "float";
        public const string ImpossibleRepresentation = "impossible representation";
        


        public static string GetName(BigInteger minValue, BigInteger maxValue, bool IntegralOnly, bool isPrecise)
        {
            return IntegralOnly ?
                GetIntegralNumberName(minValue, maxValue) :
                GetFloatingPointNumberName(minValue, maxValue, isPrecise);
        }

        private static string GetFloatingPointNumberName(BigInteger minValue, BigInteger maxValue, bool isPrecise)
        {
            return isPrecise ?
                GetPreciseFloatingPointNumberName(
                    minValue, maxValue) :
                GetImPreciseFloatingPointNumberName(
                minValue, maxValue);

        }

        private static string GetImPreciseFloatingPointNumberName(BigInteger minValue, BigInteger maxValue)
        {
            if(minValue >= new BigInteger(float.MinValue) &&
                maxValue <= new BigInteger(float.MaxValue))
            {
                return Float;
            }
            if (minValue >= new BigInteger(double.MinValue) &&
               maxValue <= new BigInteger(double.MaxValue))
            {
                return Double;
            }
            return ImpossibleRepresentation;
        }

        private static string GetPreciseFloatingPointNumberName(BigInteger minValue, BigInteger maxValue)
        {
            if (minValue >= new BigInteger(decimal.MinValue) &&
                maxValue <= new BigInteger(decimal.MaxValue))
            {
                return Decimal;
            }
            else return ImpossibleRepresentation;
        }

        private static string GetIntegralNumberName(BigInteger minValue, BigInteger maxValue)
        {
            return minValue >= 0 ?
                GetUnSignedIntegralNumberName(maxValue) :
                GetSignedIntegralNumberName(minValue,maxValue);
        }

        private static string GetSignedIntegralNumberName(BigInteger minValue, BigInteger maxValue)
        {
            if (maxValue <= new BigInteger(sbyte.MaxValue) &&
                minValue >= new BigInteger(sbyte.MinValue))
            {
                return SByte;
            }
            if (maxValue <= new BigInteger(short.MaxValue) &&
             minValue >= new BigInteger(short.MinValue))
            {
                return Short;
            }
            if (maxValue <= new BigInteger(int.MaxValue) &&
             minValue >= new BigInteger(int.MinValue))
            {
                return Int;
            }
            if (maxValue <= new BigInteger(long.MaxValue) &&
             minValue >= new BigInteger(long.MinValue))
            {
                return Long;
            }

            return BigInteger;
        }

        private static string GetUnSignedIntegralNumberName(BigInteger maxValue)
        {
            if(maxValue <= new BigInteger(byte.MaxValue))
            {
                return Byte;
            }
            if (maxValue <= new BigInteger(ushort.MaxValue))
            {
                return UShort;
            }
            if (maxValue <= new BigInteger(uint.MaxValue))
            {
                return UInt;
            }
            if (maxValue <= new BigInteger(ulong.MaxValue))
            {
                return ULong;
            }
            
            return BigInteger;

        }
    }
}