using System;

namespace Jiesen.Common.Attribute
{
    [AttributeUsage(AttributeTargets.Property)]
    public class IsUnicode:System.Attribute
    {
        public bool Unicode { get; set; }

        public IsUnicode(bool isUnicode)
        {
            Unicode = isUnicode;
        }

    }
}