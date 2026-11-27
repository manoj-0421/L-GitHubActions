using System;
using System.Collections.Generic;
using UnityEngine;

public static class ServiceLocator
{
    public static readonly Dictionary<Type, object> Services = new Dictionary<Type, object>();

    public static void Register<T>(T service)
    {
        Type type = typeof(T);
        if(service == null)
        {
            throw new ArgumentNullException($"Service Cannot be null {nameof(service)}");
        }

        if(Services.ContainsKey(type))
        {
            throw new Exception($"Service already registered {type.Name}");
        }

        Services.Add(type,service);
    }

    public static T GetService<T>()
    {
        Type type = typeof(T);
        if(Services.TryGetValue(type, out object obj))
        {
            return (T)obj;
        }
        throw new Exception($"Service not registered {type.Name}");
    }

    public static bool TryGetService<T>(out T service)
    {
        Type type = typeof(T);
        if(Services.TryGetValue(type, out object obj))
        {
            service = (T)obj;
            return true;
        }

        service = default;
        return false;
    }

    public static void UnRegister<T>()
    {
        Services.Remove(typeof(T));
    }

    public static void Clear()
    {
        Services.Clear();
    }
}

