using Gaia.Places.XamLibs.ExtendedComponents.Abstractions;
using Gaia.Places.XamLibs.ExtendedComponents.UWP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms.Platform.UWP;


[assembly: ExportRenderer(typeof(Gaia.Places.XamLibs.ExtendedComponents.Abstractions.ExtendedButton), typeof(ExtendedButtonRenderer))]

namespace Gaia.Places.XamLibs.ExtendedComponents.UWP
{
    class ExtendedButtonRenderer : ButtonRenderer
    {
        ExtendedButton _element;

        protected override void OnElementChanged(ElementChangedEventArgs<Xamarin.Forms.Button> e)
        {
            System.Diagnostics.Debug.WriteLine(">>>>>>>>> OnElementChanged:  ExtendedButtonRenderer - UWP");

            _element = (ExtendedButton)this.Element;
            base.OnElementChanged(e);
            if (e.NewElement != null)
            {
                //Subrscribe to the events stuff
            }
            else if (e.OldElement != null)
            {
                //Unsubscribe from events
            }

        }

    }
}
