using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem01_GSM
{
    class Display
    {
        private int size;
        private int numberOfColors;

        public int NumberOfColors
        {
            get { return numberOfColors; }
            set { numberOfColors = value; }
        }

        

        public int Size
        {
            get { return size; }
            set { size = value; }
        }

        public Display()
        {
        }
        public Display(int size) 
        {
            this.Size = size;
        }

        public Display(int size, int numberOfColors)
            : this(size)
        {
            this.NumberOfColors = numberOfColors;
        }
    }
}
