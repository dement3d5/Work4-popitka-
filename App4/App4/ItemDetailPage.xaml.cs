using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App4
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    [QueryProperty(nameof(ItemId),nameof(ItemId))]
    public partial class ItemDetailPage : ContentPage
    {
        private int itemId;
        public int ItemId
        {
            get => ItemId;
            set
            {
                itemId = value;
                if (itemId > 0)
                {
                    SelectedItem = App.DataBase.GetItem(itemId);
                    lable.Text = SelectedItem.Name;
                }

            }
        }

        public Item SelectedItem { get; set; }

        public ItemDetailPage()
        {
            InitializeComponent();
        }
    }
}