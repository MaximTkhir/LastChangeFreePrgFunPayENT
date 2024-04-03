using LastChangeFreePrgFunPayENT;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace LastChangeFreePrgFunPayENT
{
    /// <summary>
    /// Interaction logic for TableWindow.xaml
    /// </summary>
    public partial class TableWindow : Window
    {
        LastChangeFourPrgFunPayEntities entfun = new LastChangeFourPrgFunPayEntities();
        public TableWindow()
        {
            InitializeComponent();
            AllInfaFunPay.ItemsSource = entfun.LastChangeBaseViewData.ToList();
        }

    
    }
}
