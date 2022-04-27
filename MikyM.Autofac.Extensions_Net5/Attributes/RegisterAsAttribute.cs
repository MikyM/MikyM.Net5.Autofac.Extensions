﻿using System;

namespace MikyM.Autofac.Extensions_Net5.Attributes
{
    /// <summary>
    /// Defines as what should the service be registered
    /// </summary>
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
    public sealed class RegisterAsAttribute : Attribute
    {
        /// <summary>
        /// Type to register given service as
        /// </summary>
        public Type? RegisterAsType { get; private set; }

        /// <summary>
        /// Type of AutoFac registration
        /// </summary>
        public RegisterAs? RegisterAsOption { get; private set; }

        /// <summary>
        /// Defines as what should the service be registered
        /// </summary>
        /// <param name="registerAs">Type to use for the registration</param>
        /// <exception cref="ArgumentNullException"></exception>
        public RegisterAsAttribute(Type registerAs)
        {
            RegisterAsType = registerAs ?? throw new ArgumentNullException(nameof(registerAs));
        }

        /// <summary>
        /// Defines as what should the service be registered
        /// </summary>
        /// <param name="registerAs">Type of registration</param>
        public RegisterAsAttribute(RegisterAs registerAs)
        {
            RegisterAsOption = registerAs;
        }
    }
}