namespace Ecommerce.CommonClass
{
    public class PatchableProperty<T> where T : class
    {
        public T? Value { get; set; }

        public PatchableProperty(T value)
        {
            Value = value;
        }
    }
}
