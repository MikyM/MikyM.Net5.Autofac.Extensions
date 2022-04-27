namespace MikyM.Autofac.Extensions_Net5
{
    /// <summary>
    /// Lifetime types
    /// </summary>
    public enum Lifetime
    {
        SingleInstance,
        InstancePerRequest,
        InstancePerLifetimeScope,
        InstancePerMatchingLifetimeScope,
        InstancePerDependancy,
        InstancePerOwned
    }
}