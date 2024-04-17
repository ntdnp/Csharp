using Azure;
using DemoApp.Domain.Abstractions;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApp.Persistence
{
	public class ServiceCollectionExtension
	{
		public static void AddRepositoryUntiOfWork(this IServiceCollection serviceCollection) 
		{
			serviceCollection.AddScoped<IUnitiOfWork, UnitiOfWork>;
		
		}
	}
}
