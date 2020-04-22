namespace GDevelop.Data
{
    public class Cint : ClampValueBase<int>
    {
        public Cint(int max, int min) : base(max, min)
        {
        }

        public Cint(int value, int max, int min) : base(value, max, min)
        {
        }

        public static Cint operator +(Cint cint, int value)
        {
            cint.Value += value;
            return cint;
        }

        public static Cint operator -(Cint cint, int value)
        {
            cint.Value -= value;
            return cint;
        }

        public static Cint operator *(Cint cint, int value)
        {
            cint.Value *= value;
            return cint;
        }

        public static bool operator >(Cint cint, int value)
        {
            return cint.Value > value;
        }

        public static bool operator >=(Cint cint, int value)
        {
            return cint.Value >= value;
        }

        public static bool operator <(Cint cint, int value)
        {
            return cint.Value < value;
        }

        public static bool operator <=(Cint cint, int value)
        {
            return cint.Value <= value;
        }

        public static bool operator ==(Cint cint, int value)
        {
            return cint.Value == value;
        }

        public static bool operator !=(Cint cint, int value)
        {
            return cint.Value != value;
        }

        public static implicit operator int(Cint cint) => cint.Value;

        public override int Clamp(int value)
        {
            if (value > Max)
            {
                value = Max;
            }
            else if (value < Min)
            {
                value = Min;
            }
            return value;
        }
    }
}
