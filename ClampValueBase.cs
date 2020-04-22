namespace GDevelop.Data
{
    public abstract class ClampValueBase<T>
    {
        public T Value
        {
            get => this.value;
            set => this.value = Clamp(value);
        }
        public T Max { get; protected set; }
        public T Min { get; protected set; }

        protected T value;

        public ClampValueBase(T value, T max, T min)
        {
            Max = max;
            Min = min;
            Value = value;
        }

        public ClampValueBase(T max, T min)
        {
            Max = max;
            Min = min;
            Value = max;
        }

        public virtual void UpdateClamp(T max, T min)
        {
            Max = max;
            Min = min;
            Value = Value;
        }

        public abstract T Clamp(T value);

        public override string ToString()
        {
            return $"Max:{Max}, Min:{Min}, Value = {Value}";
        }
    }
}
