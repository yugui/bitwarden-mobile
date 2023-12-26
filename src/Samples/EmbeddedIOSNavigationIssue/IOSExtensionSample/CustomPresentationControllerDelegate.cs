﻿using System;
using Foundation;
using UIKit;

namespace Bit.iOS.Autofill
{
    public class CustomPresentationControllerDelegate : UIAdaptivePresentationControllerDelegate
    {
        private readonly Action DismissModalAction;

        public CustomPresentationControllerDelegate(Action dismissModalAction)
        {
            DismissModalAction = dismissModalAction;
        }

        [Export("presentationControllerDidDismiss:")]
        public override void DidDismiss(UIPresentationController presentationController)
        {
            DismissModalAction?.Invoke();
        }
    }
}
