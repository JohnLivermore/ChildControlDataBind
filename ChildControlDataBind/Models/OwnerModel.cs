using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChildControlDataBind.Models
{
    public class OwnerModel : ObservableObject
    {
        public OwnerModel() { }

        private string _OwnerName;
        public string OwnerName { get { return _OwnerName; } set { Set(ref _OwnerName, value); } }
    }
}
