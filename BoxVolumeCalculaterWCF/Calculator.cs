using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace BoxVolumeCalculaterWCF
{
    [DataContract]
    public class Calculator
    {
        private double _length;
        [DataMember]
        public double Length
        {
            get { return _length; }
            set { _length = value; }
        }

        private double _width;
        [DataMember]
        public double Width
        {
            get { return _width; }
            set { _width = value; }
        }

        private double _height;
        [DataMember]
        public double Height
        {
            get { return _height; }
            set { _height = value; }
        }

        private double _side1;
        [DataMember]
        public double Side1
        {
            get { return _side1; }
            set { _side1 = value; }
        }

        private double _side2;
        [DataMember]
        public double Side2
        {
            get { return _side2; }
            set { _side2 = value; }
        }

        private double _volume;
        [DataMember]
        public double Volume
        {
            get { return _volume; }
            set { _volume = value; }
        }

        public Calculator()
        {
            
        }

        public Calculator(double lenght, double width, double height)
        {
            this.Length = lenght;
            this.Width = width;
            this.Height = height;
        }

        public override string ToString()
        {
            return $"{nameof(_length)}: {_length}, {nameof(_width)}: {_width}, {nameof(_height)}: {_height}, {nameof(_side1)}: {_side1}, {nameof(_side2)}: {_side2}";

            //return string.Format("Volume: {0}", _volume);
        }
    }
}