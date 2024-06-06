#if UNITY_5_3_OR_NEWER
#define NOESIS
using Noesis;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
#else
using System;
using System.Windows;
using System.Windows.Controls;
#endif

namespace Dashboard
{
    public partial class DashboardView : UserControl
    {
        public DashboardView()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            NoesisUnity.LoadComponent(this);
        }
    }
}