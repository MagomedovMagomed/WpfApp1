using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfApp1.DataContent;


namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для Page1.xaml
    /// </summary>

    
    public partial class Page1 : Page
    {
        private Agent _currentAgent = new Agent();

        //bool isValid(string )
        //{
        //    string pattern = "[.\\-_a-z0-9]+@([a-z0-9][\\-a-z0-9]+\\.)+[a-z]{2,6}";
        //    Match isMatch = Regex.Match(, pattern, RegexOptions.IgnoreCase);
        //    return isMatch.Success;
        //}

        public Page1()
        {
            InitializeComponent();
        }
    }
}
