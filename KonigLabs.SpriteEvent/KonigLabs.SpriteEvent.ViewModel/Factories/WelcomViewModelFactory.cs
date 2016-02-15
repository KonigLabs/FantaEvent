using KonigLabs.SpriteEvent.CommonViewModel.Factories;
using KonigLabs.SpriteEvent.ViewModel.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KonigLabs.SpriteEvent.ViewModel.Factories
{
    public class WelcomViewModelFactory : ViewModelBaseFactory<WelcomViewModel>
    {
        protected override WelcomViewModel GetViewModel(object param)
        {
            return new WelcomViewModel();
        }
    }
}
