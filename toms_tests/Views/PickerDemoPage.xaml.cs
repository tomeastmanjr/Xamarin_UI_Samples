using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace toms_tests.Views
{
    public partial class PickerDemoPage : ContentPage
    {

		// Dictionary to get Color from color name.
		Dictionary<string, Color> nameToColor = new Dictionary<string, Color>
		{
			{ "Aqua", Color.Aqua }, { "Black", Color.Black },
			{ "Blue", Color.Blue }, { "Brown", Color.Brown },
			{ "Gray", Color.Gray }, { "Green", Color.Green },
			{ "Lime", Color.Lime }, { "Maroon", Color.Maroon },
			{ "Navy", Color.Navy }, { "Olive", Color.Olive },
			{ "Purple", Color.Purple }, { "Red", Color.Red },
			{ "Silver", Color.Silver }, { "Teal", Color.Teal },
			{ "White", Color.White }, { "Yellow", Color.Yellow }
		};

        public PickerDemoPage()
        {
            InitializeComponent();

            // Add each color name to the picker collection for display
            foreach (string colorName in nameToColor.Keys)
            {
                picker.Items.Add(colorName);
            }

			picker.SelectedIndexChanged += (sender, args) =>
				{
					if (picker.SelectedIndex == -1)
					{
						boxView.Color = Color.Default;
					}
					else
					{
						string colorName = picker.Items[picker.SelectedIndex];
						boxView.Color = nameToColor[colorName];
					}
				};
        }
    }
}
