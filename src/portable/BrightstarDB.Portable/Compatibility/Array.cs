﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BrightstarDB.Portable.Compatibility
{
    public static class Array
    {
        public static int IndexOf<T>(T[] array, T value)
        {
            return System.Array.IndexOf(array, value);
        }

        public static void Copy(System.Array sourceArray, System.Array destinationArray, int count)
        {
            System.Array.Copy(sourceArray, destinationArray, count);
        }

        public static void Copy(System.Array sourceArray, int sourceIndex, System.Array destinationArray, int destinationIndex, int count)
        {
            System.Array.Copy(sourceArray, sourceIndex, destinationArray, destinationIndex, count);
        }

        public static int BinarySearch<T>(T[] array, int index, int length, T value, IComparer<T> comparer)
        {
            return System.Array.BinarySearch(array, index, length, value, comparer);
        }

        public static void ConstrainedCopy(System.Array source, int srcOffset, System.Array destination, int destOffset, int count)
        {
            System.Array sav = new byte[count];
            System.Array.Copy(destination, destOffset, sav, 0, count);
            try
            {
                System.Array.Copy(source, srcOffset, destination, destOffset, count);
            }
            catch (Exception)
            {
                System.Array.Copy(sav, 0, destination, destOffset, count);
                throw;
            }
        }

    }
}
