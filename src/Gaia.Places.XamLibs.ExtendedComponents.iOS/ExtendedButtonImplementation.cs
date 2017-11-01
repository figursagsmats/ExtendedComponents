﻿using Gaia.Places.XamLibs.ExtendedComponents.Abstractions;
using System;
using Xamarin.Forms;
using Gaia.Places.XamLibs.ExtendedComponents.iOS;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(Gaia.Places.XamLibs.ExtendedComponents.Abstractions.ExtendedButton), typeof(ExtendedButtonRenderer))]
namespace Gaia.Places.XamLibs.ExtendedComponents.iOS
{
    /// <summary>
    /// ExtendedComponents Renderer
    /// </summary>
    public class ExtendedButtonRenderer : ButtonRenderer
    {
        /// <summary>
        /// Used for registration with dependency service
        /// </summary>
        public static void Init() { }

        ExtendedButton _element;

        protected override void OnElementChanged(ElementChangedEventArgs<Xamarin.Forms.Button> e)
        {
            System.Diagnostics.Debug.WriteLine("\t>>>>> OnElementChanged:  ExtendedButtonRenderer IOS <<<<<<<<");

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
