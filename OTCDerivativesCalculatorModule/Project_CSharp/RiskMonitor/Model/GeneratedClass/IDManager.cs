using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FpmlSerializedCSharp
{
    static class IDManager
    {
        public static ISerialized getID(string IDRef)
        {
            return refSerialClass[IDRef];
        }

        internal static void SetID(string IDRef, ISerialized ob)
        {
            ob.ID_ = IDRef;
            refSerialClass.Add(IDRef,ob);
        }

        public static void clearAll()
        {
            refSerialClass.Clear();
        }

        private static Dictionary<string, ISerialized> refSerialClass = new Dictionary<string, ISerialized>();

    }
}
