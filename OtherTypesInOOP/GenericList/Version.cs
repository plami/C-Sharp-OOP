using System;

namespace GenericList
{
        [AttributeUsage(
            AttributeTargets.Struct |
            AttributeTargets.Class |
            AttributeTargets.Interface |
            AttributeTargets.Enum |
            AttributeTargets.Method)
        ]
        public class VersionAttribute : System.Attribute
        {
            public string Version { get; private set; }

            public VersionAttribute(int major, int minor)
            {
                this.Version = String.Format("{0}.{1}", major, minor);
            }

            public override string ToString()
            {
                return Version;
            }
        }
    }
