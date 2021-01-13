using System;

namespace HandsOnTry.HelpersAndExtensions
{
    internal static class Extensions
    {
        internal static T[] SubArray<T>(this T[] array, int offset, int length)
        {
            T[] result = new T[length];
            Array.Copy(array, offset, result, 0, length);
            return result;
        }
    }
}