namespace FS.Data
{
    public static class Instanciator
    {
        public static T InstantiateId<T>()
        {
            if (typeof(T) == typeof(string))
            {
                return (T)(object)Guid.NewGuid().ToString();
            }
            else
            {
                return Activator.CreateInstance<T>();
            }
        }
    }
}
