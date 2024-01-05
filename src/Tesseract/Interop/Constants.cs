using System;

namespace Tesseract.Interop
{
    /// <summary>
    /// Description of Constants.
    /// </summary>
    internal static class Constants
    {
        public const string LeptonicaDllName = "libleptonica1841";
        public const string TesseractDllName = "libtesseract533";
        
        // tesseract uses an int to represent true false values.
        public const int TRUE = 1;
        public const int FALSE = 0;
    }
}