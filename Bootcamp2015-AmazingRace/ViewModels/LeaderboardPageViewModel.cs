﻿using Bootcamp2015.AmazingRace.Common;
using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Bootcamp2015.AmazingRace.ViewModels
{
    public class LeaderboardPageViewModel : Screen
    {
        private INavigationService _navigationService;

        public ICommand GotoClueCommand
        {
            get
            {
               return  new DelegateCommand(o => OnGotoCluePage());
            }
        }


        public LeaderboardPageViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;

            //GotoJoinTeamCommand = new DelegateCommand(o => OnGotoJoinTeamPage());
        }

        protected void OnGotoCluePage()
        {
            _navigationService.NavigateToViewModel<LeaderboardPageViewModel>();
        }
    }
}