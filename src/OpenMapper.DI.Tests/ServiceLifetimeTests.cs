using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Microsoft.Extensions.DependencyInjection;
using Shouldly;
using Xunit;

namespace OpenMapper.Extensions.Microsoft.DependencyInjection.Tests
{
	public class ServiceLifetimeTests
	{
		//Implicitly Transient
		[Fact]
		public void AddOpenMapperExtensionDefaultWithAssemblySingleDelegateArgCollection()
		{
			//arrange
			var serviceCollection = new ServiceCollection();

			//act
			serviceCollection.AddOpenMapper(cfg => { }, new List<Assembly>());
			var serviceDescriptor = serviceCollection.FirstOrDefault(sd => sd.ServiceType == typeof(IMapper));

			//assert
			serviceDescriptor.ShouldNotBeNull();
			serviceDescriptor.Lifetime.ShouldBe(ServiceLifetime.Transient);
		}

		[Fact]
		public void AddOpenMapperExtensionDefaultWithAssemblyDoubleDelegateArgCollection()
		{
			//arrange
			var serviceCollection = new ServiceCollection();

			//act
			serviceCollection.AddOpenMapper((sp, cfg) => { }, new List<Assembly>());
			var serviceDescriptor = serviceCollection.FirstOrDefault(sd => sd.ServiceType == typeof(IMapper));

			//assert
			serviceDescriptor.ShouldNotBeNull();
			serviceDescriptor.Lifetime.ShouldBe(ServiceLifetime.Transient);
		}

		[Fact]
		public void AddOpenMapperExtensionDefaultWithAssemblyCollection()
		{
			//arrange
			var serviceCollection = new ServiceCollection();

			//act
			serviceCollection.AddOpenMapper(new List<Assembly>());
			var serviceDescriptor = serviceCollection.FirstOrDefault(sd => sd.ServiceType == typeof(IMapper));

			//assert
			serviceDescriptor.ShouldNotBeNull();
			serviceDescriptor.Lifetime.ShouldBe(ServiceLifetime.Transient);
		}

		[Fact]
		public void AddOpenMapperExtensionDefaultSingleDelegateWithProfileTypeCollection()
		{
			//arrange
			var serviceCollection = new ServiceCollection();

			//act
			serviceCollection.AddOpenMapper(cfg => { },new[] {typeof(ServiceLifetimeTests)});
			var serviceDescriptor = serviceCollection.FirstOrDefault(sd => sd.ServiceType == typeof(IMapper));

			//assert
			serviceDescriptor.ShouldNotBeNull();
			serviceDescriptor.Lifetime.ShouldBe(ServiceLifetime.Transient);
		}

		[Fact]
		public void AddOpenMapperExtensionDefaultDoubleDelegateWithProfileTypeCollection()
		{
			//arrange
			var serviceCollection = new ServiceCollection();

			//act
			serviceCollection.AddOpenMapper((sp, cfg) => { },new[] {typeof(ServiceLifetimeTests)});
			var serviceDescriptor = serviceCollection.FirstOrDefault(sd => sd.ServiceType == typeof(IMapper));

			//assert
			serviceDescriptor.ShouldNotBeNull();
			serviceDescriptor.Lifetime.ShouldBe(ServiceLifetime.Transient);
		}

		//Explicitly Singleton
		[Fact]
		public void AddOpenMapperExtensionSingletonWithAssemblySingleDelegateArgCollection()
		{
			//arrange
			var serviceCollection = new ServiceCollection();

			//act
			serviceCollection.AddOpenMapper(cfg => { }, new List<Assembly>(), ServiceLifetime.Singleton);
			var serviceDescriptor = serviceCollection.FirstOrDefault(sd => sd.ServiceType == typeof(IMapper));

			//assert
			serviceDescriptor.ShouldNotBeNull();
			serviceDescriptor.Lifetime.ShouldBe(ServiceLifetime.Singleton);
		}

		[Fact]
		public void AddOpenMapperExtensionSingletonWithAssemblyDoubleDelegateArgCollection()
		{
			//arrange
			var serviceCollection = new ServiceCollection();

			//act
			serviceCollection.AddOpenMapper((sp, cfg) => { }, new List<Assembly>(), ServiceLifetime.Singleton);
			var serviceDescriptor = serviceCollection.FirstOrDefault(sd => sd.ServiceType == typeof(IMapper));

			//assert
			serviceDescriptor.ShouldNotBeNull();
			serviceDescriptor.Lifetime.ShouldBe(ServiceLifetime.Singleton);
		}

		[Fact]
		public void AddOpenMapperExtensionSingletonWithAssemblyCollection()
		{
			//arrange
			var serviceCollection = new ServiceCollection();

			//act
			serviceCollection.AddOpenMapper(new List<Assembly>(), ServiceLifetime.Singleton);
			var serviceDescriptor = serviceCollection.FirstOrDefault(sd => sd.ServiceType == typeof(IMapper));

			//assert
			serviceDescriptor.ShouldNotBeNull();
			serviceDescriptor.Lifetime.ShouldBe(ServiceLifetime.Singleton);
		}

		[Fact]
		public void AddOpenMapperExtensionSingletonSingleDelegateWithProfileTypeCollection()
		{
			//arrange
			var serviceCollection = new ServiceCollection();

			//act
			serviceCollection.AddOpenMapper(cfg => { },new[] {typeof(ServiceLifetimeTests)}, ServiceLifetime.Singleton);
			var serviceDescriptor = serviceCollection.FirstOrDefault(sd => sd.ServiceType == typeof(IMapper));

			//assert
			serviceDescriptor.ShouldNotBeNull();
			serviceDescriptor.Lifetime.ShouldBe(ServiceLifetime.Singleton);
		}

		[Fact]
		public void AddOpenMapperExtensionSingletonDoubleDelegateWithProfileTypeCollection()
		{
			//arrange
			var serviceCollection = new ServiceCollection();

			//act
			serviceCollection.AddOpenMapper((sp, cfg) => { },new[] {typeof(ServiceLifetimeTests)}, ServiceLifetime.Singleton);
			var serviceDescriptor = serviceCollection.FirstOrDefault(sd => sd.ServiceType == typeof(IMapper));

			//assert
			serviceDescriptor.ShouldNotBeNull();
			serviceDescriptor.Lifetime.ShouldBe(ServiceLifetime.Singleton);
		}

		//Explicitly Transient
		[Fact]
		public void AddOpenMapperExtensionTransientWithAssemblySingleDelegateArgCollection()
		{
			//arrange
			var serviceCollection = new ServiceCollection();

			//act
			serviceCollection.AddOpenMapper(cfg => { }, new List<Assembly>(), ServiceLifetime.Transient);
			var serviceDescriptor = serviceCollection.FirstOrDefault(sd => sd.ServiceType == typeof(IMapper));

			//assert
			serviceDescriptor.ShouldNotBeNull();
			serviceDescriptor.Lifetime.ShouldBe(ServiceLifetime.Transient);
		}

		[Fact]
		public void AddOpenMapperExtensionTransientWithAssemblyDoubleDelegateArgCollection()
		{
			//arrange
			var serviceCollection = new ServiceCollection();

			//act
			serviceCollection.AddOpenMapper((sp, cfg) => { }, new List<Assembly>(), ServiceLifetime.Transient);
			var serviceDescriptor = serviceCollection.FirstOrDefault(sd => sd.ServiceType == typeof(IMapper));

			//assert
			serviceDescriptor.ShouldNotBeNull();
			serviceDescriptor.Lifetime.ShouldBe(ServiceLifetime.Transient);
		}

		[Fact]
		public void AddOpenMapperExtensionTransientWithAssemblyCollection()
		{
			//arrange
			var serviceCollection = new ServiceCollection();

			//act
			serviceCollection.AddOpenMapper(new List<Assembly>(), ServiceLifetime.Transient);
			var serviceDescriptor = serviceCollection.FirstOrDefault(sd => sd.ServiceType == typeof(IMapper));

			//assert
			serviceDescriptor.ShouldNotBeNull();
			serviceDescriptor.Lifetime.ShouldBe(ServiceLifetime.Transient);
		}

		[Fact]
		public void AddOpenMapperExtensionTransientSingleDelegateWithProfileTypeCollection()
		{
			//arrange
			var serviceCollection = new ServiceCollection();

			//act
			serviceCollection.AddOpenMapper(cfg => { },new[] {typeof(ServiceLifetimeTests)}, ServiceLifetime.Transient);
			var serviceDescriptor = serviceCollection.FirstOrDefault(sd => sd.ServiceType == typeof(IMapper));

			//assert
			serviceDescriptor.ShouldNotBeNull();
			serviceDescriptor.Lifetime.ShouldBe(ServiceLifetime.Transient);
		}

		[Fact]
		public void AddOpenMapperExtensionTransientDoubleDelegateWithProfileTypeCollection()
		{
			//arrange
			var serviceCollection = new ServiceCollection();

			//act
			serviceCollection.AddOpenMapper((sp, cfg) => { },new[] {typeof(ServiceLifetimeTests)}, ServiceLifetime.Transient);
			var serviceDescriptor = serviceCollection.FirstOrDefault(sd => sd.ServiceType == typeof(IMapper));

			//assert
			serviceDescriptor.ShouldNotBeNull();
			serviceDescriptor.Lifetime.ShouldBe(ServiceLifetime.Transient);
		}

		//Explicitly Scoped
		[Fact]
		public void AddOpenMapperExtensionScopedWithAssemblySingleDelegateArgCollection()
		{
			//arrange
			var serviceCollection = new ServiceCollection();

			//act
			serviceCollection.AddOpenMapper(cfg => { }, new List<Assembly>(), ServiceLifetime.Scoped);
			var serviceDescriptor = serviceCollection.FirstOrDefault(sd => sd.ServiceType == typeof(IMapper));

			//assert
			serviceDescriptor.ShouldNotBeNull();
			serviceDescriptor.Lifetime.ShouldBe(ServiceLifetime.Scoped);
		}

		[Fact]
		public void AddOpenMapperExtensionScopedWithAssemblyDoubleDelegateArgCollection()
		{
			//arrange
			var serviceCollection = new ServiceCollection();

			//act
			serviceCollection.AddOpenMapper((sp, cfg) => { }, new List<Assembly>(), ServiceLifetime.Scoped);
			var serviceDescriptor = serviceCollection.FirstOrDefault(sd => sd.ServiceType == typeof(IMapper));

			//assert
			serviceDescriptor.ShouldNotBeNull();
			serviceDescriptor.Lifetime.ShouldBe(ServiceLifetime.Scoped);
		}

		[Fact]
		public void AddOpenMapperExtensionScopedWithAssemblyCollection()
		{
			//arrange
			var serviceCollection = new ServiceCollection();

			//act
			serviceCollection.AddOpenMapper(new List<Assembly>(), ServiceLifetime.Scoped);
			var serviceDescriptor = serviceCollection.FirstOrDefault(sd => sd.ServiceType == typeof(IMapper));

			//assert
			serviceDescriptor.ShouldNotBeNull();
			serviceDescriptor.Lifetime.ShouldBe(ServiceLifetime.Scoped);
		}

		[Fact]
		public void AddOpenMapperExtensionScopedSingleDelegateWithProfileTypeCollection()
		{
			//arrange
			var serviceCollection = new ServiceCollection();

			//act
			serviceCollection.AddOpenMapper(cfg => { },new[] {typeof(ServiceLifetimeTests)}, ServiceLifetime.Scoped);
			var serviceDescriptor = serviceCollection.FirstOrDefault(sd => sd.ServiceType == typeof(IMapper));

			//assert
			serviceDescriptor.ShouldNotBeNull();
			serviceDescriptor.Lifetime.ShouldBe(ServiceLifetime.Scoped);
		}

		[Fact]
		public void AddOpenMapperExtensionScopedDoubleDelegateWithProfileTypeCollection()
		{
			//arrange
			var serviceCollection = new ServiceCollection();

			//act
			serviceCollection.AddOpenMapper((sp, cfg) => { },new[] {typeof(ServiceLifetimeTests)}, ServiceLifetime.Scoped);
			var serviceDescriptor = serviceCollection.FirstOrDefault(sd => sd.ServiceType == typeof(IMapper));

			//assert
			serviceDescriptor.ShouldNotBeNull();
			serviceDescriptor.Lifetime.ShouldBe(ServiceLifetime.Scoped);
		}

	}
}