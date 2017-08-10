﻿using System.Collections.ObjectModel;
using System.Windows.Input;

namespace Zametek.Client.ProjectPlan.Wpf
{
    public interface IResourceSettingsManagerViewModel
    {
        bool DisableResources
        {
            get;
            set;
        }

        ObservableCollection<ManagedResourceViewModel> Resources
        {
            get;
        }

        ICommand AddManagedResourceCommand
        {
            get;
        }

        ICommand RemoveManagedResourceCommand
        {
            get;
        }

        int GetNextResourceId();
    }
}
