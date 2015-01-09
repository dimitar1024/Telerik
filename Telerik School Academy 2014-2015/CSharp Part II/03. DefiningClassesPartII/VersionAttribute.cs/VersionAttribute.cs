using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace VersionAttribute.cs
{
   [AttributeUsage(
    AttributeTargets.Struct |
    AttributeTargets.Class |
    AttributeTargets.Interface |
    AttributeTargets.Method |
    AttributeTargets.Enum
    )]
    class VersionAttribute : System.Attribute
    {
       public string Version { set; get; }


       public VersionAttribute(string version) 
       {
           this.Version = version;
       }

       public override string ToString()
       {
           return this.ToString();
       }
    }
}
