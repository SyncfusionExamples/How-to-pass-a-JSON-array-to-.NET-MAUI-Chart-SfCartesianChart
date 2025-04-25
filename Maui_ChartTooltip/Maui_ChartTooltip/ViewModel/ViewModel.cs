using System.Collections.ObjectModel;

namespace Maui_ChartTooltip
{
    public class ViewModel
    {
        public ObservableCollection<Model> Data { get; set; }

        public ViewModel()
        {
            Data = new ObservableCollection<Model>()
            {
                new Model(){ Country = "India", Population = 234 },
                new Model(){ Country = "United States", Population = 156 },
                new Model(){ Country = "China", Population = 280 },
                new Model(){ Country = "Australia", Population = 134 },
                new Model(){ Country = "Kuwait", Population = 80 }
            };
        }
    }
}
