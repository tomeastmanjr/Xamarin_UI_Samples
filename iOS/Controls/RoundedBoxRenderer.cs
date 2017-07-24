﻿using toms_tests.Controls;
using toms_tests.iOS.Controls;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(RoundedBox), typeof(RoundedBoxRenderer))]

namespace toms_tests.iOS.Controls
{
	public class RoundedBoxRenderer : ViewRenderer<RoundedBox, UIView>
	{
		protected override void OnElementChanged(ElementChangedEventArgs<RoundedBox> e)
		{
			base.OnElementChanged(e);

			if (Element == null)
				return;

			Layer.MasksToBounds = true;
			Layer.CornerRadius = (float)this.Element.CornerRadius / 2.0f;
			Layer.BorderColor = this.Element.BorderColor.ToCGColor();
			Layer.BorderWidth = (float)this.Element.BorderWidth;

			var nativeControl = Platform.GetRenderer(Element.Content) as UIView;
			AddSubview(nativeControl);
		}
	}
}