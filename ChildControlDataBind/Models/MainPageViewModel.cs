using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChildControlDataBind.Models
{
    public class MainPageViewModel : ObservableObject
    {
        public MainPageViewModel()
        {
            Properties = new List<PropertyModel>();

            Properties.Add(new PropertyModel()
            {
                PropertyName = "ABC",
                Owner = new OwnerModel()
                {
                    OwnerName = "ABC Owner"
                }
            });

            Properties.Add(new PropertyModel()
            {
                PropertyName = "DEF",
                Owner = new OwnerModel()
                {
                    OwnerName = "DEF Owner"
                }
            });
        }

        public List<PropertyModel> Properties { get; set; }

        private PropertyModel _SelectedProperty;
        public PropertyModel SelectedProperty
        {
            get { return _SelectedProperty; }
            set
            {
                Set(ref _SelectedProperty, value);
                NotifyPropertyChanged(nameof(SelectedProperty.PropertyName));
            }
        }

        public async Task LoadAsync()
        {
            SelectedProperty = Properties.FirstOrDefault();
        }
    }
}
