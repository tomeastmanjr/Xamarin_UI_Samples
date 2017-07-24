using toms_tests.Controls;
using toms_tests.iOS.Controls;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(TLEntry), typeof(TLEntryRenderer))]

namespace toms_tests.iOS.Controls
{
	public class TLEntryRenderer : EntryRenderer
	{
		protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
		{
			base.OnElementChanged(e);

			var element = e.NewElement as TLEntry;
			if (element.ReturnButton == ReturnButtonType.Next)
			{
				Control.ReturnKeyType = UIKit.UIReturnKeyType.Next;
				Control.ShouldReturn += (textField) =>
				{
					element.OnNext();
					return false;
				};
			}
		}
	}

}
