﻿// IMvxListItemView.cs

// MvvmCross is licensed using Microsoft Public License (Ms-PL)
// Contributions and inspirations noted in readme.md and license.txt
//
// Project Lead - Stuart Lodge, @slodge, me@slodge.com

using Android.Views;
using MvvmCross.Platform.Core;

namespace MvvmCross.Binding.Droid.Views
{
    public interface IMvxListItemView
        : IMvxDataConsumer
    {
        int TemplateId { get; }
        View Content { get; set; }
    }
}