using System;
using System.Windows;

namespace JudoRef.Wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string judokaEen, judokaTwee, kleurGordelJudokaEen, kleurGordelJudokaTwee, datum;
        int scoreJudokaEen, scoreJudokaTwee;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Title = "Judoref - Jelle Vermeulen";
            VulComboboxGordels();
            BeginSituatie();
        }

        private void BtnStartKamp_Click(object sender, RoutedEventArgs e)
        {
            if (txtJudoka1.Text == "" || txtJudoka2.Text == "")
            {
                MessageBox.Show("Voer de namen in van beide judoka's");
            }
            else
            {
                UpdateGuiStartKamp();
            }
        }

        private void BtnKoka1_Click(object sender, RoutedEventArgs e)
        {
            VerwerkScoreJudoka1(3, "Koka");
        }

        private void BtnYuko1_Click(object sender, RoutedEventArgs e)
        {
            VerwerkScoreJudoka1(5, "Yuko");
        }

        private void BtnWazeri1_Click(object sender, RoutedEventArgs e)
        {
            VerwerkScoreJudoka1(7, "Wazeri");
        }

        private void BtnIppon1_Click(object sender, RoutedEventArgs e)
        {
            VerwerkScoreJudoka1(25, "Ippon");
        }

        private void BtnKoka2_Click(object sender, RoutedEventArgs e)
        {
            VerwerkScoreJudoka2(3, "Koka");
        }

        private void BtnYuko2_Click(object sender, RoutedEventArgs e)
        {
            VerwerkScoreJudoka2(5, "Yuko");
        }

        private void BtnWazeri2_Click(object sender, RoutedEventArgs e)
        {
            VerwerkScoreJudoka2(7, "Wazeri");
        }

        private void BtnIppon2_Click(object sender, RoutedEventArgs e)
        {
            VerwerkScoreJudoka2(25, "Ippon");
        }

        private void BtnStopWedstrijd_Click(object sender, RoutedEventArgs e)
        {
            BeginSituatie();
        }

        #region Zelfgemaakte functies
        private void VulComboboxGordels()
        {
            cmbGordel1.Items.Add("wit");
            cmbGordel1.Items.Add("geel");
            cmbGordel1.Items.Add("oranje");
            cmbGordel1.Items.Add("groen");
            cmbGordel1.Items.Add("blauw");
            cmbGordel1.Items.Add("bruin");
            cmbGordel1.Items.Add("zwart");

            cmbGordel2.Items.Add("wit");
            cmbGordel2.Items.Add("geel");
            cmbGordel2.Items.Add("oranje");
            cmbGordel2.Items.Add("groen");
            cmbGordel2.Items.Add("blauw");
            cmbGordel2.Items.Add("bruin");
            cmbGordel2.Items.Add("zwart");
        }

        private void BeginSituatie()
        {
            stpScore1.Visibility = Visibility.Collapsed;
            stpScore2.Visibility = Visibility.Collapsed;
            lstScoreTabel.Visibility = Visibility.Collapsed;
            btnStopWedstrijd.Visibility = Visibility.Collapsed;
            txtJudoka1.Clear();
            txtJudoka2.Clear();
            cmbGordel1.SelectedIndex = 0;
            cmbGordel2.SelectedIndex = 0;
            cmbGordel1.IsEnabled = true;
            cmbGordel2.IsEnabled = true;
            lstScoreTabel.Items.Clear();
            scoreJudokaEen = 0;
            scoreJudokaTwee = 0;
            lblScore1.Content = scoreJudokaEen;
            lblScore2.Content = scoreJudokaTwee;
        }

        private void UpdateGuiStartKamp()
        {
            judokaEen = txtJudoka1.Text;
            judokaTwee = txtJudoka2.Text;
            kleurGordelJudokaEen = Convert.ToString(cmbGordel1.SelectedItem);
            kleurGordelJudokaTwee = Convert.ToString(cmbGordel2.SelectedItem);
            stpScore1.Visibility = Visibility.Visible;
            stpScore2.Visibility = Visibility.Visible;
            btnStopWedstrijd.Visibility = Visibility.Visible;
            lstScoreTabel.Visibility = Visibility.Visible;
            cmbGordel1.IsEnabled = false;
            cmbGordel2.IsEnabled = false;

            lstScoreTabel.Items.Insert(0, "Start kamp tussen " + judokaEen + " (Gordel " + kleurGordelJudokaEen + ") en " +
                judokaTwee + " (Gordel " + kleurGordelJudokaTwee + ")");
        }

        private void VerwerkScoreJudoka1(int punten, string scoreNaam)
        {
            datum = DateTime.Now.ToString("d/MM/yyyy HH:mm:ss");
            scoreJudokaEen = scoreJudokaEen + punten;
            lblScore1.Content = scoreJudokaEen;
            lstScoreTabel.Items.Add(datum + ": " + judokaEen + " (" + kleurGordelJudokaEen + ") scoort " + punten + " punten met een " + scoreNaam);
        }

        private void VerwerkScoreJudoka2(int punten, string scoreNaam)
        {
            datum = DateTime.Now.ToString("d/MM/yyyy HH:mm:ss");
            scoreJudokaTwee = scoreJudokaTwee + punten;
            lblScore2.Content = scoreJudokaTwee;
            lstScoreTabel.Items.Add(datum + ": " + judokaTwee + " (" + kleurGordelJudokaTwee + ") scoort " + punten + " punten met een " + scoreNaam);
        }
        #endregion
    }
}
