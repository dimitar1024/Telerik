using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point3D
{
    struct Point3D
    {
        public double X { get; private set; }
        public double Y { get; private set; }
        public double Z { get; private set; }

        private static readonly Point3D zero = new Point3D();

        public static Point3D Zero
        {
            get { return zero; }
        }

        public override string ToString()
        {
            return String.Join("-", this.X, this.Y, this.Z);
        }

        
    }

    
}
