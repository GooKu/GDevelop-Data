namespace GDevelop.Data
{
    public abstract class ClampValueBase<T>
    {
        public T Value
        {
            get => Value;
            protected set
            {
                value = Clamp(value);
            }
        }
        public T Max { get; protected set; }
        public T Min { get; protected set; }

        public ClampValueBase(T value, T max, T min)
        {
            Value = value;
            Max = max;
            Min = min;
        }

        public ClampValueBase(T max, T min)
        {
            Value = Max = max;
            Min = min;
        }

        public virtual void UpdateClamp(T max, T min)
        {
            Max = max;
            Min = min;
            Value = Value;
        }

        public abstract T Clamp(T value);
    }
}
