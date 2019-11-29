namespace Generics
{
    class Math_NonGeneric
    {
        public static int Add(int num1, int num2) => num1 + num2;
        public static float Add(float num1, float num2) => num1 + num2;
        public static decimal Add(decimal num1, decimal num2) => num1 + num2;
    }

    class Math_Generic
    {
        public static T Add<T>(T num1, T num2) where T : struct
        {
            dynamic a = num1;
            dynamic b = num2;
            return a + b;
        }
    }
}