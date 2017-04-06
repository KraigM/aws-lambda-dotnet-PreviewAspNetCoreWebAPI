using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using System.IO;
using Microsoft.Extensions.PlatformAbstractions;
using System.Reflection;
using System.Diagnostics;

namespace PreviewAspNetCoreWebAPI
{
	/// <summary>
	/// This class extends from APIGatewayProxyFunction which contains the method FunctionHandlerAsync which is the 
	/// actual Lambda function entry point. The Lambda handler field should be set to
	/// 
	/// PreviewAspNetCoreWebAPI::PreviewAspNetCoreWebAPI.LambdaEntryPoint::FunctionHandlerAsync
	/// </summary>
	public class LambdaEntryPoint : Amazon.Lambda.AspNetCoreServer.APIGatewayProxyFunction
	{
		protected override void Init(IWebHostBuilder builder)
		{
			builder
				.UseContentRoot(Directory.GetCurrentDirectory())
				.UseStartup<Startup>()
				.UseApiGateway();
		}
	}
}
