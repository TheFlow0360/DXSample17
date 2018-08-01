using System;
using System.ComponentModel;
using DevExpress.Xpf.Ribbon;

namespace DXSample17
{
    public class CustomRibbonPageCategory : RibbonPageCategory
    {
        protected override void IsVisibleChanging(ref Boolean newValue)
        {
            base.IsVisibleChanging(ref newValue);
            if (DesignerProperties.GetIsInDesignMode(this))
            {
                newValue = true;
            }
        }
    }
}