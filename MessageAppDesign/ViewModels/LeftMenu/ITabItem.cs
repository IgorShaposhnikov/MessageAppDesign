using System;

namespace MessageAppDesign.WPF.ViewModels.LeftMenu
{
    public interface ITabItem : IComparable<ITabItem>
    {
        uint Id { get; }
        VMBase ContentPage { get; set; }
        string Title { get; set; }
        byte[] Image { get; set; }
        /// <summary>
        /// If byte image == null;
        /// </summary>
        System.Windows.Media.Color DefaultColor { get; set; }
        bool IsChecked { get; set; }
    }
}
