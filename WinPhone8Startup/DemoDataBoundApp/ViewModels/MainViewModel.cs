using GalaSoft.MvvmLight;
using GoogleNews.DAL;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Linq;

namespace DemoDataBoundApp.ViewModel
{
    /// <summary>
    /// This class contains properties that the main View can data bind to.
    /// <para>
    /// Use the <strong>mvvminpc</strong> snippet to add bindable properties to this ViewModel.
    /// </para>
    /// <para>
    /// You can also use Blend to data bind with the tool's support.
    /// </para>
    /// <para>
    /// See http://www.galasoft.ch/mvvm
    /// </para>
    /// </summary>
    public class MainViewModel : ViewModelBase
    {
        private IDataService _data;

        /// <summary>
        /// Initializes a new instance of the MainViewModel class.
        /// </summary>
        public MainViewModel(IDataService data)
        {
            _data = data;

            if (IsInDesignMode)
            {
                // Code runs in Blend --> create design time data.
            }
            else
            {
                this.Items = new ObservableCollection<ItemViewModel>();

                //Dummy data - load items
                LoadItems("");
            }
        }

        async private void LoadItems(string query)
        {
            var items = await _data.GetItems(query);

            var itemVMs = items.Select(i => new ItemViewModel { ID = i.ID, LineOne = i.LineOne, LineThree = i.LineThree, LineTwo = i.LineTwo });
            this.Items = new ObservableCollection<ItemViewModel>(itemVMs);
        }

        public ObservableCollection<ItemViewModel> Items { get; private set; }

        private string _sampleProp;
        public string SampleProperty 
        { 
            get { return _sampleProp; } 
            set { _sampleProp = value; RaisePropertyChanged("SampleProperty"); } 
        } 
    }
}