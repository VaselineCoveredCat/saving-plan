using System;
using System.Collections.Generic;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Saving_Plan
{
    public partial class MainWindow : Window
    {
        public MainWindow() => InitializeComponent();

        private void CalcButt_Click(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(SalaryTextBox.Text, out int salary) && float.TryParse(SavingTextBox.Text, out float savingPercentage) && int.TryParse(TargetTextBox.Text, out int targetSaving))
            {
                int moneySaved = 0;
                int months = 0;

                savingPercentage /= 100;
                salary = Convert.ToInt32(salary * savingPercentage);

                while (moneySaved < targetSaving)
                {
                    moneySaved += salary;
                    months++;
                }

                if (months > 12)
                {
                    Result.Text = $"{Math.Round((float)months / 12, 1)} years";
                }

                else
                {
                    Result.Text = $"{months} months";
                }
            }
        }

        private void ExitButt_Click(object sender, RoutedEventArgs e) => Close();
    }
}
