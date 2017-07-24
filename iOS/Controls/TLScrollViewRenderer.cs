using System;
using toms_tests.Controls;
using toms_tests.iOS.Controls;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(TLScrollView), typeof(TLScrollViewRenderer))]

namespace toms_tests.iOS.Controls
{
    public class TLScrollViewRenderer : ScrollViewRenderer
    {
		protected override void OnElementChanged(VisualElementChangedEventArgs e)
		{
			base.OnElementChanged(e);

			var element = e.NewElement as TLScrollView;
			element?.Render();
		}
    }
}
