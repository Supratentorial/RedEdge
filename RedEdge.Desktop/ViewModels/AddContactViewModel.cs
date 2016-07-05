using System.Collections.ObjectModel;
using Template10.Mvvm;

namespace RedEdge.Desktop.ViewModels
{
    public class AddContactViewModel :ViewModelBase
    {
        public ObservableCollection<string> TitleOptions { get; set; }

        public AddContactViewModel()
        {
            TitleOptions = new ObservableCollection<string>()
            {
                "Mr", "Mrs", "Ms", "Miss", "Master", "Doctor", "Sir", "Professor"
            };
        }
    }
}
