using GottaGo.Client.Contracts;
using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GottaGo.Client.ViewModels
{
	public class LoginPageViewModel : BaseViewModel
	{
        public LoginPageViewModel(IUtils utils) : base(utils)
        {
            Title = "Log in";        }
	}
}
