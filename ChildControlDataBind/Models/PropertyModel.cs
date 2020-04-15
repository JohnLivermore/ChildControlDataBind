using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChildControlDataBind.Models
{
    public class PropertyModel : ObservableObject
    {
        public PropertyModel()
        {
            Owner = new OwnerModel();
        }

        private string _PropertyName;
        public string PropertyName { get { return _PropertyName; } set { Set(ref _PropertyName, value); } }

        public OwnerModel Owner { get; set; }
    }
}
