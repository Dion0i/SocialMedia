using Microsoft.Extensions.DependencyInjection;
using SocialMedia.Core.Interfaces;
using SocialMedia.Insfraestructure.Repositories;

namespace SocialMedia.IOC.Dependencies
{
    public static class SocialMediaDependency
    {
        public static void AddSocialMediaDependency(this IServiceCollection services)
        {
            services.AddTransient<IPostRepository, PostRepository>();
        }
    }
}
