using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point3D
{
    static class PathStorage
    {
        public static Path Load(string file)
        {
        return Path.Parse(File.ReadAllText(file));
        }
        public static void Write(Path path, string file)
        {
        File.WriteAllText(file, path.ToString());
        }
        
    }
}
