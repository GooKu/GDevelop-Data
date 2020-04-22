namespace GDevelop.Data
{
    class Cfloat : ClampValueBase<float>
    {
        public Cfloat(float max, float min) : base(max, min)
        {
        }

        public Cfloat(float value, float max, float min) : base(value, max, min)
        {
        }

        public static Cfloat operator +(Cfloat cfloat, float value)
        {
            cfloat.Value += value;
            return cfloat;
        }

        public static Cfloat operator -(Cfloat cfloat, int value)
        {
            cfloat.Value -= value;
            return cfloat;
        }

        public static Cfloat operator *(Cfloat cfloat, int value)
        {
            cfloat.Value *= value;
            return cfloat;
        }

        public static Cfloat operator /(Cfloat cfloat, int value)
        {
            cfloat.Value /= value;
            return cfloat;
        }

        public static bool operator >(Cfloat cfloat, int value)
        {
            return cfloat.Value > value;
        }

        public static bool operator >=(Cfloat cfloat, int value)
        {
            return cfloat.Value >= value;
        }

        public static bool operator <(Cfloat cfloat, int value)
        {
            return cfloat.Value < value;
        }

        public static bool operator <=(Cfloat cfloat, int value)
        {
            return cfloat.Value <= value;
        }

        public static bool operator ==(Cfloat cfloat, int value)
        {
            return cfloat.Value == value;
        }

        public static bool operator !=(Cfloat cfloat, int value)
        {
            return cfloat.Value != value;
        }

        public static implicit operator float(Cfloat cfloat) => cfloat.Value;

        public override float Clamp(float value)
        {
            if (value > Max || value < Min)
            {
                value = Max;
            }
            else if (value < Min)
            {
                value = Max;
            }
            return value;
        }
    }
}
