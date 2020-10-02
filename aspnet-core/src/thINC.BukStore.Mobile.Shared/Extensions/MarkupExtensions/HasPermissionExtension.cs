using System;
using thINC.BukStore.Core;
using thINC.BukStore.Core.Dependency;
using thINC.BukStore.Services.Permission;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace thINC.BukStore.Extensions.MarkupExtensions
{
    [ContentProperty("Text")]
    public class HasPermissionExtension : IMarkupExtension
    {
        public string Text { get; set; }
        
        public object ProvideValue(IServiceProvider serviceProvider)
        {
            if (ApplicationBootstrapper.AbpBootstrapper == null || Text == null)
            {
                return false;
            }

            var permissionService = DependencyResolver.Resolve<IPermissionService>();
            return permissionService.HasPermission(Text);
        }
    }
}