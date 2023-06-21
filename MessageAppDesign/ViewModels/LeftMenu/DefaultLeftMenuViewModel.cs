using MessageAppDesign.WPF.ViewModels.LeftMenu.TabItems;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.InteropServices;
using System.Windows.Media;

namespace MessageAppDesign.WPF.ViewModels.LeftMenu
{
    public class DefaultLeftMenuViewModel : VMBase
    {
        private ObservableCollection<ITabItem> _tabItems = new ObservableCollection<ITabItem>();
        public IEnumerable<ITabItem> TabItems { get => _tabItems; }



        public DefaultLeftMenuViewModel()
        {
            var colors = new List<Color>
            {
                (Color)System.Windows.Media.ColorConverter.ConvertFromString("#404043"),
                (Color)System.Windows.Media.ColorConverter.ConvertFromString("#f7941d"),
                (Color)System.Windows.Media.ColorConverter.ConvertFromString("#3343f7"),
                (Color)System.Windows.Media.ColorConverter.ConvertFromString("#562389"),
                (Color)System.Windows.Media.ColorConverter.ConvertFromString("#f6d21d"),
                (Color)System.Windows.Media.ColorConverter.ConvertFromString("#d7244f"),
            };

            for (var i = 0; i < colors.Count; i++) 
            {
                _tabItems.Add(new DefaultLeftMenuTabItem(0, color: colors[i]));
            }
        }
    }
}
