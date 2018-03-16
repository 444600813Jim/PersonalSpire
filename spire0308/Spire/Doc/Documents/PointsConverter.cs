namespace Spire.Doc.Documents
{
    using Spire.Layouting;
    using System;

    public sealed class PointsConverter
    {
        private bool bool_0;
        private byte[] byte_0;
        private static Class1073 class1073_0 = new Class1073();

        public static float FromCm(float cantimeter)
        {
            return (float) class1073_0.method_1((double) cantimeter, PrintUnits.Centimeter, PrintUnits.Point);
        }

        public static float FromInch(float inch)
        {
            return (float) class1073_0.method_1((double) inch, PrintUnits.Inch, PrintUnits.Point);
        }

        public static float FromMm(float cantimeter)
        {
            return (float) class1073_0.method_1((double) cantimeter, PrintUnits.Millimeter, PrintUnits.Point);
        }

        public static float FromPixel(float px)
        {
            return (float) class1073_0.method_1((double) px, PrintUnits.Pixel, PrintUnits.Point);
        }
    }
}

