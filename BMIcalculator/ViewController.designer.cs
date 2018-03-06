// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace BMIcalculator
{
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel bmiLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton calcBtn { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton clearBtn { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField heightTextField { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel verdictLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField weightTextField { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (bmiLabel != null) {
                bmiLabel.Dispose ();
                bmiLabel = null;
            }

            if (calcBtn != null) {
                calcBtn.Dispose ();
                calcBtn = null;
            }

            if (clearBtn != null) {
                clearBtn.Dispose ();
                clearBtn = null;
            }

            if (heightTextField != null) {
                heightTextField.Dispose ();
                heightTextField = null;
            }

            if (verdictLabel != null) {
                verdictLabel.Dispose ();
                verdictLabel = null;
            }

            if (weightTextField != null) {
                weightTextField.Dispose ();
                weightTextField = null;
            }
        }
    }
}