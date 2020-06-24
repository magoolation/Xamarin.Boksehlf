﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace Xamarin.Bookshelf.Mobile.Services
{
    public class DialogService : IDialogService
    {
        public Task<string> DisplayActionSheet(string title, string cancel, string destruction, string[] actions) => MainThread.InvokeOnMainThreadAsync(() => Shell.Current.DisplayActionSheet(title, cancel, destruction, actions));

        public Task DisplayAlertAsync(string title, string message, string accept) => MainThread.InvokeOnMainThreadAsync(() => Shell.Current.DisplayAlert(title, message, accept));

        public Task<bool> DisplayAlertAsync(string title, string message, string accept, string cancel) => MainThread.InvokeOnMainThreadAsync(() => Shell.Current.DisplayAlert(title, message, accept, cancel));
    }
}