using Gaia.Places.XamLibs.ExtendedComponents.Abstractions;
using Gaia.Places.XamLibs.ExtendedComponents.UWP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms.Platform.UWP;
using Xamarin.Forms;
using Windows.UI.Xaml.Media;
using Windows.UI;

[assembly: ExportRenderer(typeof(Gaia.Places.XamLibs.ExtendedComponents.Abstractions.ExtendedEntry), typeof(ExtendedEntryRenderer))]

namespace Gaia.Places.XamLibs.ExtendedComponents.UWP
{
    class ExtendedEntryRenderer : EntryRenderer
    {
        ExtendedEntry _element;

        protected override void OnElementChanged(ElementChangedEventArgs<Xamarin.Forms.Entry> e)
        {
            System.Diagnostics.Debug.WriteLine(">>>>>>>>> OnElementChanged:  ExtendedEntryRenderer - UWP");

            _element = (ExtendedEntry)this.Element;

            base.OnElementChanged(e);
            if (e.NewElement != null)
            {
                //Subrscribe to the events stuff
            }
            else if (e.OldElement != null)
            {
                //Unsubscribe from events
            }
            if (Control != null)
            {
                Control.Background = new SolidColorBrush(Colors.Cyan);
            }

        }

    }
}
