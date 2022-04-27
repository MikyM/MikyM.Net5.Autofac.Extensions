using System;

namespace MikyM.Autofac.Extensions_Net5.Attributes
{
    /// <summary>
    /// Marks a class for registration as a service
    /// </summary>
    [AttributeUsage(AttributeTargets.Class)]
    public sealed class ServiceAttribute : Attribute
    {
        public ServiceAttribute()
        {
        }
    }
}