
namespace System
{
    internal static class StringExtensions
    {
        public static string CutString(this string thisObj, int qChar)
        {
            if (thisObj.Length <= qChar) 
            {
                return thisObj;
            }
            else
            {
                return thisObj.Substring(0, qChar) + "...";
            }
        }
    }
}
