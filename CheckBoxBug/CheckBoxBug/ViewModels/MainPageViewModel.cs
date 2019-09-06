using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace CheckBoxBug.ViewModels
{
  public class MainPageViewModel : ViewModelBase
  {
    private ObservableCollection<int> _items;
    public ObservableCollection<int> Items
    {
      get => _items;
      set
      {
        SetProperty(ref (_items), value);
      }
    }

    public MainPageViewModel(INavigationService navigationService)
        : base(navigationService)
    {
      Title = "Main Page";
      ItemSelectedCommand = new DelegateCommand<object>(ItemSelectedAction);

      var items = new List<int>();
      items.Add(1);
      items.Add(2);
      items.Add(3);
      
      Items = new ObservableCollection<int>(items);
    }

    public DelegateCommand<object> ItemSelectedCommand { get; set; }

    private void ItemSelectedAction(object obj)
    {
      var selected = obj;
    }
  }
}
