using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEnd.DataAccess.DbContext
{
	public class DbContextExample //: DbContext
	{
		//private readonly IConfiguration configuration;
		//private readonly ILogger logger;

		//public UploaderDbContext(IConfiguration configuration, ILoggerFactory logger, DbContextOptions<UploaderDbContext> options) : base(options)
		//{
		//	this.configuration = configuration;
		//	this.logger = logger.CreateLogger("DbContext logger");
		//	if (Database.IsSqlServer())
		//	{
		//		try
		//		{
		//			string clientId = configuration[ServicePrincipalConstants.SP_CLIENT_ID_KEY];
		//			string aadTenantId = configuration[ServicePrincipalConstants.SP_TENANT_ID_KEY];
		//			string clientSecretKey = configuration[ServicePrincipalConstants.SP_CLIENT_SECRET_KEY];

		//			string AadInstance = "https://login.windows.net/{0}";
		//			string ResourceId = "https://database.windows.net/";

		//			AuthenticationContext authenticationContext = new(string.Format(AadInstance, aadTenantId));
		//			ClientCredential clientCredential = new(clientId, clientSecretKey);

		//			AuthenticationResult authenticationResult = authenticationContext.AcquireTokenAsync(ResourceId, clientCredential).Result;

		//			var conn = (Microsoft.Data.SqlClient.SqlConnection)this.Database.GetDbConnection();

		//			this.logger.LogInformation($"Token from Azure AD: {authenticationResult.AccessToken}");
		//			this.logger.LogInformation($"Old token in SQL Connection: {conn.AccessToken}");

		//			conn.AccessToken = authenticationResult.AccessToken;

		//			this.logger.LogInformation($"New token in SQL Connection: {conn.AccessToken}");
		//		}
		//		catch (System.Exception) { }
		//	}
		//}


		//public DbSet<Report> Report { get; set; }
		//public DbSet<ReportLayerWaters> ReportLayerWaters { get; set; }
		 

		//protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		//{
		//	optionsBuilder.EnableSensitiveDataLogging();
		//	base.OnConfiguring(optionsBuilder);
		//}

		//protected override void OnModelCreating(ModelBuilder modelBuilder)
		//{
		//	modelBuilder.HasDefaultSchema(configuration["Schema"]);

		//	#region Seeds
		//	Seed.ReportTypeSeed(modelBuilder);
		//	Seed.ReportStatusSeed(modelBuilder);
		//	#endregion

		//}
	}
}
