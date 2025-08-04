namespace FS.Reusable;

/// <summary>
/// A class used for instantiating objects in different ways as part of different design patterns and testing
/// </summary>
public static class Instantiator
{
    /// <summary>
    /// Generic method for instantiating an id.
    /// </summary>
    /// <typeparam name="T">Can be any type</typeparam>
    /// <returns>An instance of type T</returns>
    public static T InstantiateId<T>()
    {
        if (typeof(T) == typeof(string))
        {
            return (T)(object)Guid.NewGuid().ToString();
        }

        return Activator.CreateInstance<T>();
    }

    public static T Instantiate<T>()
    {
        return Activator.CreateInstance<T>();
    }

}