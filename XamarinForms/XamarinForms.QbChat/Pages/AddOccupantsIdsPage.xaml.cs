﻿using System.Collections.Generic;

using Xamarin.Forms;
using XamarinForms.QbChat.ViewModels;

namespace XamarinForms.QbChat
{
    public partial class AddOccupantsIdsPage : ContentPage
	{
		private bool isLoading = false;
		private string dialogId;
		private List<SelectedUser> UsersForList { get; set;}

		public AddOccupantsIdsPage (string outDialogId)
		{
			InitializeComponent ();
			this.dialogId = outDialogId;
            listView.ItemSelected += (o, e) => { listView.SelectedItem = null; };
		}

		protected override void OnAppearing ()
		{
			base.OnAppearing ();

            var vm = new AddOccupantsIdsViewModel(this.dialogId);
            this.BindingContext = vm;
            vm.OnAppearing();
        }
	}
}

