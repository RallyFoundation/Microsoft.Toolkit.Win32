// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Security;
using windows = Windows;

namespace Microsoft.Toolkit.Win32.UI.Controls.Interop.WinRT
{
    /// <summary>
    /// Provides data for the <see cref="IWebView.MoveFocusRequested"/> event. This class cannot be inherited.
    /// </summary>
    /// <remarks>Copy from <see cref="windows.Web.UI.Interop.WebViewControlMoveFocusRequestedEventArgs"/> to avoid requirement to link Windows.winmd</remarks>
    /// <seealso cref="EventArgs" />
    /// <seealso cref="windows.Web.UI.Interop.WebViewControlMoveFocusRequestedEventArgs"/>
    public sealed class WebViewControlMoveFocusRequestedEventArgs : EventArgs
    {
        [SecurityCritical]
        private readonly windows.Web.UI.Interop.WebViewControlMoveFocusRequestedEventArgs _args;

        internal WebViewControlMoveFocusRequestedEventArgs(windows.Web.UI.Interop.WebViewControlMoveFocusRequestedEventArgs args)
        {
            _args = args ?? throw new ArgumentNullException(nameof(args));
        }

        /// <summary>
        /// Gets the move focus reason.
        /// </summary>
        /// <value><see cref="WebViewControlMoveFocusReason" /> The move focus reason</value>
        public WebViewControlMoveFocusReason Reason => (WebViewControlMoveFocusReason)_args.Reason;

        /// <summary>
        /// Performs an implicit conversion from <see cref="windows.Web.UI.Interop.WebViewControlMoveFocusRequestedEventArgs"/> to <see cref="WebViewControlMoveFocusRequestedEventArgs"/>.
        /// </summary>
        /// <param name="args">The <see cref="windows.Web.UI.Interop.WebViewControlMoveFocusRequestedEventArgs"/> instance containing the event data.</param>
        /// <returns>The result of the conversion.</returns>
        public static implicit operator WebViewControlMoveFocusRequestedEventArgs(windows.Web.UI.Interop.WebViewControlMoveFocusRequestedEventArgs args) => ToWebViewControlMoveFocusRequestedEventArgs(args);

        /// <summary>
        /// Creates a <see cref="WebViewControlMoveFocusRequestedEventArgs"/> from <see cref="windows.Web.UI.Interop.WebViewControlMoveFocusRequestedEventArgs"/>.
        /// </summary>
        /// <param name="args">The <see cref="windows.Web.UI.Interop.WebViewControlMoveFocusRequestedEventArgs"/> instance containing the event data.</param>
        /// <returns><see cref="WebViewControlMoveFocusRequestedEventArgs"/></returns>
        public static WebViewControlMoveFocusRequestedEventArgs ToWebViewControlMoveFocusRequestedEventArgs(
            windows.Web.UI.Interop.WebViewControlMoveFocusRequestedEventArgs args) =>
            new WebViewControlMoveFocusRequestedEventArgs(args);
    }
}