using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
  class MainWindowViewModel : INotifyPropertyChanged
  {
    public event PropertyChangedEventHandler PropertyChanged;

    private string manageString;
    private string fromManageString;
    private string homeString;

    public string ManageString
    {
      get
      {
        return manageString;
      }
      set
      {
        manageString = value;
        NotifyPropetyChanged();
      }
    }

    public string FromManageString
    {
      get
      {
        return fromManageString;
      }
      set
      {
        fromManageString = value;
        NotifyPropetyChanged();
      }
    }

    public string HomeString
    {
      get
      {
        return homeString;
      }
      set
      {
        homeString = value;
        NotifyPropetyChanged();
      }
    }


    public void NotifyPropetyChanged([CallerMemberName] string propertyName = "")
    {
      if (propertyName.Equals(nameof(ManageString)))
      {
        FromManageString = "From Manage Tab: " + ManageString;
      }

      PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
  }
}
