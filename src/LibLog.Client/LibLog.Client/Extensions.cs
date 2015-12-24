using System;
using System.Reflection;
using MaterialSkin.Controls;

namespace LibLog.Client
{
    public static class Extensions
    {
        public static void Maximize(this MaterialForm materialForm, bool maximized)
        {
            typeof(MaterialForm).GetMethod("MaximizeWindow", BindingFlags.NonPublic | BindingFlags.Instance)
                                .Invoke(materialForm, new object[] { maximized });
        }
    }
}
