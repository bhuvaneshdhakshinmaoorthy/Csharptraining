using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OperatorOverloading
{
    public class Box
    {
        private int _length;
        private int _width;
        private int _height;
        public BOX()
        {

        }
        public Box(int length, int width,int height)

            _length = length;
            _width = width;
            _height = height;
        }
        public double CalculateVolume()
        {
            return _length * _width * _height;
        }
        public static Box(Box box1, Box box2)
        {
            Box box = new Box();
            box._length = box1._length + box2._length;
            box._width = box._width;
            box._height = box._height;
            return box;
        }
    }
}