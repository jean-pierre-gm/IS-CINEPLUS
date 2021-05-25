using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.SpaServices.AngularCli;
using Microsoft.EntityFrameworkCore;
using Cineplus.Data;
using Cineplus.Models;
using Cineplus.Services;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerUI;

namespace Cineplus {
	public class Startup {
		public Startup(IConfiguration configuration) {
			Configuration = configuration;
		}

		public IConfiguration Configuration { get; }

		// This method gets called by the runtime. Use this method to add services to the container.
		public void ConfigureServices(IServiceCollection services) {
			services.AddDbContext<ApplicationDbContext>(options =>
				options.UseSqlite(
					Configuration.GetConnectionString("DefaultConnection")));

			services.AddDatabaseDeveloperPageExceptionFilter();

			services.AddDefaultIdentity<ApplicationUser>(options => options.SignIn.RequireConfirmedAccount = true)
				.AddRoles<IdentityRole>()
				.AddEntityFrameworkStores<ApplicationDbContext>();

			services.AddIdentityServer()
				.AddApiAuthorization<ApplicationUser, ApplicationDbContext>()
				.AddProfileService<ProfileService>();

			services.AddAuthentication()
				.AddIdentityServerJwt();

			services.AddControllersWithViews();
			services.AddRazorPages();
			// In production, the Angular files will be served from this directory
			services.AddSpaStaticFiles(configuration => { configuration.RootPath = "ClientApp/dist"; });

			services.AddSwaggerGen(options => {
				options.SwaggerDoc(name: "v1",
					info: new OpenApiInfo() {Title = "Cineplus Service API", Version = "v1"});
			});
			
			services.AddScoped(typeof(IRepository<>), typeof(SqlRepository<>));
			services.AddScoped<IMovieService, MovieService>();
			services.AddScoped<IGenreService, GenreService>();
			services.AddScoped<IReproductionService, ReproductionService>();
			services.AddScoped<ITheaterService, TheaterService>();
			services.AddScoped<ISeatService, SeatService>();
			services.AddScoped<ITicketService, TicketService>();
			services.AddScoped<IDateDiscountService, DateDiscountService>();
		}

		// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
		public void Configure(
			IApplicationBuilder app,
			IWebHostEnvironment env,
			UserManager<ApplicationUser> userManager,
			RoleManager<IdentityRole> roleManager) {
			if (env.IsDevelopment()) {
				app.UseDeveloperExceptionPage();
				app.UseMigrationsEndPoint();
			}
			else {
				app.UseExceptionHandler("/Error");
				// The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
				app.UseHsts();
			}

			app.UseHttpsRedirection();
			app.UseStaticFiles();
			if (!env.IsDevelopment()) {
				app.UseSpaStaticFiles();
			}

			app.UseRouting();

			app.UseAuthentication();
			app.UseIdentityServer();
			app.UseAuthorization();
			app.UseEndpoints(endpoints => {
				endpoints.MapControllerRoute(
					name: "default",
					pattern: "{controller}/{action=Index}/{id?}");
				endpoints.MapRazorPages();
			});
			
			app.UseSwagger();
			app.UseSwaggerUI(c => {
				c.SwaggerEndpoint("v1/swagger.json", "Cineplus Service API Version 1");
				c.SupportedSubmitMethods(new [] {SubmitMethod.Get, SubmitMethod.Post, SubmitMethod.Put, SubmitMethod.Delete});
			});

			app.UseSpa(spa => {
				// To learn more about options for serving an Angular SPA from ASP.NET Core,
				// see https://go.microsoft.com/fwlink/?linkid=864501

				spa.Options.SourcePath = "ClientApp";

				if (env.IsDevelopment()) {
					spa.UseAngularCliServer(npmScript: "start");
				}
			});
			
			IdentityExtensions.SeedIdentity(userManager, roleManager, Configuration);
		}
	}
}