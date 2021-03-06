﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

using Windows.UI.Xaml.Controls;

namespace HoloLensCommander
{
    /// <summary>
    /// The class that implements the mixed reality viewer dialog.
    /// </summary>
    public sealed partial class MixedRealityViewDialog : ContentDialog
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MixedRealityViewDialog" /> class.
        /// </summary>
        /// <param name="monitor">The HoloLensMonitor that is responsible for communication with the HoloLens.</param>
        public MixedRealityViewDialog(HoloLensMonitor monitor)
        {
            this.DataContext = new MixedRealityViewDialogViewModel(
                monitor);
            this.InitializeComponent();
        }
    }
}
