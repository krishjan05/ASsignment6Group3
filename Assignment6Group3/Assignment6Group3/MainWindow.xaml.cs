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

namespace Assignment6Group3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        const double DAILY_CHARGES = 350.00;
        public MainWindow()
        {
            InitializeComponent();
        }
        public double CalcStayCharges(int numberOfDays)
        {
            double stayCharges;
            stayCharges = DAILY_CHARGES * numberOfDays;
            return stayCharges;
        }
        public double CalcMiscCharges(double medicationCharges, double surgicalCharges, double labCharges,double physicalRehab)
        {
            double miscCharges = medicationCharges + surgicalCharges + labCharges + physicalRehab;
            return miscCharges; 
        }
        public double CalcTotalCharges()
        {
            int days;
            double mCharges;
            double sCharges;
            double lCharges;
            double pRehabCharges;
            double totalCharges = 0.00;
            if (int.TryParse(txtDays.Text, out days) && double.TryParse(txtMedication.Text, out mCharges) &&
                double.TryParse(txtSurgical.Text, out sCharges) && double.TryParse(txtLab.Text, out lCharges) &&
                double.TryParse(txtPhysicalRehab.Text, out pRehabCharges))
            {
                totalCharges = CalcStayCharges(days) + CalcMiscCharges(mCharges, sCharges, lCharges, pRehabCharges);
                return totalCharges;
            }
            return totalCharges;
        }

        private void btnCalculate_Click(object sender, RoutedEventArgs e)
        {
            lblTotal.Content = CalcTotalCharges();
        }
    }
}
