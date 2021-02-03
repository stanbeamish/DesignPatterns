﻿using System.Reflection;
using Autofac;
using DesignPatterns.DependencyInjection;
using System.Linq;
using DesignPatterns.DependencyInjection.Utilities;

namespace DesignPatterns
{
  public static class ContainerConfig
  {
    public static IContainer Configure()
    {
      var builder = new ContainerBuilder();

      builder.RegisterType<Application>().As<IApplication>();
      builder.RegisterType<BusinessLogic>().As<IBusinessLogic>();

      builder.RegisterAssemblyTypes(Assembly.Load(nameof(DesignPatterns)))
        .Where(t => t.Namespace != null && t.Namespace.Contains("Utilities"))
        .As(t => t.GetInterfaces().FirstOrDefault(i => i.Name == "I" + t.Name));

      return builder.Build();
    }
  }
}