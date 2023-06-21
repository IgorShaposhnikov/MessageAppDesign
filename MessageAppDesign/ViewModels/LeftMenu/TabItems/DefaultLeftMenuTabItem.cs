using System.Windows.Media;

namespace MessageAppDesign.WPF.ViewModels.LeftMenu.TabItems
{
    public class DefaultLeftMenuTabItem : VMBase, ITabItem
    {
        public uint Id { get; }

        public VMBase ContentPage { get; set; }

        public string Title { get; set; }
        public byte[] Image { get; set; }

        private bool _isChecked;
        public bool IsChecked
        {
            get => _isChecked; set
            {
                _isChecked = value;
                OnPropertyChanged();
            }
        }

        public Color DefaultColor { get; set; }

        public DefaultLeftMenuTabItem(uint id, string title = "", byte[] image = default, Color color = default)
        {
            Id = id;
            Title = title;
            Image = image;
            DefaultColor = color;
        }

        public int CompareTo(ITabItem other)
        {
            return Id.CompareTo(other.Id);
        }
    }
}
