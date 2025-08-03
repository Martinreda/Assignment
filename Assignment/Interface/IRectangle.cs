using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Interface
{
    internal interface IRectangle
    {
        double Width { get; set; }
        double Height { get; set; }

        void DisplayShapeInfo();
    }
}
