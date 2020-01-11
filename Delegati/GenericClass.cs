namespace Delegati
{
    internal class GenericClass<T>
    {
        private T genericAttribute;

        public T ReturnGenericAttribute()
        {
            return genericAttribute;
        }

        public void SetGenericAttribute(T inputParam)
        {
            genericAttribute = inputParam;
        }

        public string Print()
        {
            return genericAttribute.ToString();
        }
    }
}