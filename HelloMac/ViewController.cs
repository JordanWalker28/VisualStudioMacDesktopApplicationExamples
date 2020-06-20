﻿using System;

using AppKit;
using Foundation;

namespace HelloMac
{
    public partial class ViewController : NSViewController
    {
        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            // Do any additional setup after loading the view.
        }

        public override NSObject RepresentedObject
        {
            get
            {
                return base.RepresentedObject;
            }
            set
            {
                base.RepresentedObject = value;
                // Update the view, if already loaded.
            }
        }

        partial void Press(NSObject sender)
        {
            int count = Int32.Parse(labelInfo.StringValue);
            Console.WriteLine("Press Me Pressed");
            count += 1;
            labelInfo.StringValue = count.ToString();
        }
    }
}
