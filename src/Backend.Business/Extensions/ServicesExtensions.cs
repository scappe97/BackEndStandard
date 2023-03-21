 
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEnd.Business.Extensions
{
	public static class ServicesExtensions
	{

		public static void AddBusinessServices(this IServiceCollection services)
		{
			//Services
			//services.AddTransient<IPurchasesService, PurchasesService>()
			// Repositories
			//.AddScoped<IReadAndAccessFileRepository, ReadAndAccessFileRepository>()
			//.AddScoped<IConvertFromFileToModelRepository, ConvertFromFileToModelRepository>();
		}
	}
}
