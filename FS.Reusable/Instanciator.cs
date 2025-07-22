namespace FS.Reusable
{
    public static class Instanciator
    {
        public static T InstantiateId<T>()
        {
            if (typeof(T) == typeof(string))
            {
                return (T)(object)Guid.NewGuid().ToString();
            }

            return Activator.CreateInstance<T>();
        }
    }
}
