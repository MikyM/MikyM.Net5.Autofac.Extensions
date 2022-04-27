using System;
using System.Collections.Concurrent;
using System.Linq;
using System.Reflection;
using Autofac.Core.Activators.Reflection;

namespace MikyM.Autofac.Extensions_Net5
{
    /// <summary>
    /// Constructor finder that finds all constructors
    /// </summary>
    public sealed class AllConstructorsFinder : IConstructorFinder
    {
        private static readonly ConcurrentDictionary<Type, ConstructorInfo[]> Cache = new();


        public ConstructorInfo[] FindConstructors(Type targetType)
        {
            var result = Cache.GetOrAdd(targetType,
                t => t.GetTypeInfo().DeclaredConstructors.Where(c => !c.IsStatic).ToArray());

            return result.Length > 0 ? result : throw new NoConstructorsFoundException(targetType);
        }
    }
}
