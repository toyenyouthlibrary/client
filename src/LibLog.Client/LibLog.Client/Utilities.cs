using System;
using System.Reflection;
using MaterialSkin.Controls;

namespace LibLog.Client
{
    public static class Utilities
    {
        public static void MaximizeMaterialForm(MaterialForm materialForm, bool maximized)
        {
            typeof(MaterialForm).GetMethod("MaximizeWindow", BindingFlags.NonPublic | BindingFlags.Instance)
                                .Invoke(materialForm, new object[] { maximized });
        }
    }
}
