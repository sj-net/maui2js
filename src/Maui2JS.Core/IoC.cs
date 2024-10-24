using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maui2JS.Core
{
    /// <summary>
    /// Inversion of Control.
    /// Service locator pattern is anti-pattern.
    /// AVOID THIS IF YOU WANT YOUR CODE TO BE UNIT TESTED.
    /// </summary>
    /// <seealso cref="IServiceProvider" />
    [ExcludeFromCodeCoverage]
    public sealed class Ioc
    {
        private bool isDesignMode = false;

        private volatile IServiceProvider serviceProvider;

        /// <summary>
        /// Initializes a new instance of the <see cref="Ioc"/> class.
        /// Prevents a default instance of the <see cref="Ioc"/> class from being created.
        /// </summary>
        private Ioc()
        {
        }

        /// <summary>
        /// Gets the default instance.
        /// </summary>
        /// <value>
        /// The default.
        /// </value>
        public static Ioc Default { get; } = new();

        /// <summary>
        /// Gets or sets a value indicating whether this instance is testing.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance is testing; otherwise, <c>false</c>.
        /// </value>
        public static bool IsTesting { get; set; } = false;

        /// <summary>
        /// Gets the service provider.
        /// </summary>
        /// <value>
        /// The service provider.
        /// </value>
        public IServiceProvider ServiceProvider => this.serviceProvider;

        /// <summary>
        /// Gets the service.
        /// </summary>
        /// <param name="serviceType">Type of the service.</param>
        /// <param name="doNotThrowException">if set to <c>true</c> [do not throw exception].</param>
        /// <returns>Service.</returns>
        /// <exception cref="System.InvalidOperationException">
        /// The service provider has not been configured yet.
        /// or
        /// The requested service type was not registered.
        /// </exception>
        public object GetService(Type serviceType, bool doNotThrowException = false)
        {
            if (this.serviceProvider is null && !IsTesting)
            {
                return this.isDesignMode
                    ? CreateDesginInstance(serviceType)
                    : (doNotThrowException
                            ? null
                            : throw new InvalidOperationException($"The requested {serviceType} was not registered."));
            }

            object service = this.serviceProvider!.GetService(serviceType);

            return service is null
                ? this.isDesignMode
                    ? CreateDesginInstance(serviceType)
                    : ((doNotThrowException || IsTesting)
                            ? null
                            : throw new InvalidOperationException($"The requested {serviceType} was not registered."))
                : service;
        }

        /// <summary>
        /// Gets the service.
        /// </summary>
        /// <typeparam name="T">Type of the service.</typeparam>
        /// <param name="doNotThrowException">if set to <c>true</c> [do not throw exception].</param>
        /// <returns>Service.</returns>
        /// <exception cref="System.InvalidOperationException">
        /// The service provider has not been configured yet.
        /// or
        /// The requested service type was not registered.
        /// </exception>
        public T GetService<T>(bool doNotThrowException = false)
            where T : class
        {
            if (this.serviceProvider is null && !IsTesting)
            {
                return this.isDesignMode
                    ? CreateDesginInstance<T>()
                    : (doNotThrowException
                            ? null
                            : throw new InvalidOperationException($"The requested type({typeof(T)}) was not registered."));
            }

            T service = this.serviceProvider!.GetService<T>();

            return service is null
                ? this.isDesignMode
                    ? CreateDesginInstance<T>()
                    : ((doNotThrowException || IsTesting)
                            ? null
                            : throw new InvalidOperationException($"The requested type({typeof(T)}) was not registered."))
                : service;
        }

        /// <summary>
        /// Configures the services.
        /// </summary>
        /// <param name="serviceProvider">The service provider.</param>
        public void SetServiceProvider(IServiceProvider serviceProvider)
        {
            this.serviceProvider ??= serviceProvider;
        }

        /// <summary>
        /// Sets the design mode.
        /// </summary>
        /// <param name="isDesignMode">if set to <c>true</c> [is design mode].</param>
        public void SetDesignMode(bool isDesignMode)
        {
            this.isDesignMode = isDesignMode;
        }

        /// <summary>
        /// Determines whether this instance is initialized.
        /// </summary>
        /// <returns>
        ///   <c>true</c> if this instance is initialized; otherwise, <c>false</c>.
        /// </returns>
        public bool IsInitialized()
        {
            return this.serviceProvider is not null;
        }

        public void Clean()
        {
            this.serviceProvider = null;
        }

        private static object CreateDesginInstance(Type type)
        {
            // in design mode, the IoC won't be initialized.
            return type.GetConstructor(Type.EmptyTypes) != null && !type.IsAbstract
               ? Activator.CreateInstance(type)
               : throw new InvalidOperationException($"Cannot create instance of type {type.FullName}");
        }

        private static T CreateDesginInstance<T>()
        {
            return (T)CreateDesginInstance(typeof(T));
        }
    }
}
