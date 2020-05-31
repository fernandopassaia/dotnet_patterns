using System;
using System.Reflection;

namespace Console
{
    //Static: A Static Class cannot be instantiated. You just need to use the classname itselft to accees it.
    public static class DumpObjectHelper
    {
        public static PropertyInfo[] dumpObject(object objectToDeserialize)
        {
            Type t = objectToDeserialize.GetType(); // Where obj is object whose properties you need.
            PropertyInfo[] pi = t.GetProperties();
            return pi;
        }
    }
}
