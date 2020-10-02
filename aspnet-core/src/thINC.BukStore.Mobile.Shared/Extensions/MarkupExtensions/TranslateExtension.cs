using System;
using thINC.BukStore.Core;
using thINC.BukStore.Localization;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace thINC.BukStore.Extensions.MarkupExtensions
{
    [ContentProperty("Text")]
    public class TranslateExtension : IMarkupExtension
    {
        public string Text { get; set; }

        public object ProvideValue(IServiceProvider serviceProvider)
        {
            if (ApplicationBootstrapper.AbpBootstrapper == null || Text == null)
            {
                return Text;
            }

            return L.Localize(Text);
        }
    }
}