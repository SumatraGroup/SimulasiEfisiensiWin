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
using System.Globalization;

namespace SimulasiEfisiensi
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private double SFC, pemakaianRata2TahunPLTD, drumOmstarPLTD, rasioCampuranPLTD, kebutuhanOmstarPLTD, dalamDrumPLTD, savingCustomerPLTD, grossSavingPLTD, biayaPemakaianPLTD, netSavingPLTD;
        private double drumOmstar, rasioCampuran, kebutuhanOmstar, dalamDrum, savingCustomer, grossSaving, biayaPemakaian, netSaving, rata2PemakaianBBMTahun;
        private double SFCLaut, pemakaianRata2TahunLaut, drumOmstarLaut, rasioCampuranLaut, kebutuhanOmstarLaut, dalamDrumLaut, savingCustomerLaut, grossSavingLaut, hargaPemakaianLaut, netSavingLaut;
        private double SFCLokomotif, pemakaianRata2TahunLokomotif, drumOmstarLokomotif, rasioCampuranLokomotif, kebutuhanOmstarLokomotif, dalamDrumLokomotif, savingCustomerLokomotif, grossSavingLokomotif, hargaPemakaianLokomotif, netSavingLokomotif;
        public MainWindow()
        {
            InitializeComponent();

            //PLTD
            initializePLTD();
            
            //TRANSPORTASI DARAT
            initilizeDarat();

            //TRANSPORTASI LAUT
            initializeLaut();

            //LOKOMOTIF
            initializeLokomotif();
        }

        private void initializeLokomotif()
        {
            txtJmlArmadaLokomotif.Text = "10";
            txtDayaMesinLokomotif.Text = "2.5";
            txtCapacityFactorLokomotif.Text = "65";

            SFCLokomotif = 0.25;
            txtSFCLokomotif.Text = SFCLokomotif.ToString();

            rasioCampuranLokomotif = 0.00078125;
            txtRasioCampuranLokomotif.Text = rasioCampuranLokomotif.ToString();

            drumOmstarLokomotif = 55 * 3.79;
            txtDrumOmstarLokomotif.Text = drumOmstarLokomotif.ToString("N0");

            calculateRata2PemakaianBBMLokomotif();

            txtHargaOmstarLokomotif.Text = "122,762,250";
            txtProyeksiSavingBBMLokomotif.Text = "10";

            txtSavingCustomerTahunLokomotif.Text = "0";
            txtHargaBBMLokomotif.Text = "0";
            txtGrossSavingCustomerTahunLokomotif.Text = "0";
            txtHargaPemakaianDX1Lokomotif.Text = "0";
            txtNetSavingCustomerTahunLokomotif.Text = "0";
        }

        private void initializeLaut()
        {
            txtJmlArmadaLaut.Text = "10";
            txtDayaMesinLaut.Text = "5";
            txtCapacityFactorLaut.Text = "25";

            SFCLaut = 0.25;
            txtSFCLaut.Text = SFCLaut.ToString();

            rasioCampuranLaut = 0.00078125;
            txtRasioCampuranLaut.Text = rasioCampuranLaut.ToString();

            drumOmstarLaut = 55 * 3.79;
            txtDrumOmstarLaut.Text = drumOmstarLaut.ToString("N0");

            txtHargaOmstarLaut.Text = "122,762,250";
            txtProyeksiSavingBBMLaut.Text = "10";

            calculateRata2PemakaianBBMLaut();

            txtSavingCustomerTahunLaut.Text = "0";
            txtHargaBBMLaut.Text = "0";
            txtGrossSavingCustomerTahunLaut.Text = "0";
            txtHargaPemakaianDX1Laut.Text = "0";
            txtNetSavingCustomerTahunLaut.Text = "0";
        }

        private void initilizeDarat()
        {
            txtJmlArmada.Text = "100";
            txtJauhPerjalananRata2.Text = "800";
            txtRasioPemakaianBBM.Text = "8";
            txtRata2FaktorKerja.Text = "80";

            drumOmstar = 55 * 3.79;
            txtDrumOmstar.Text = drumOmstar.ToString("N0");

            //rasioCampuran = 1 / 1280 * 100;
            //txtRasioCampuran.Text = rasioCampuran.ToString("N3");

            rasioCampuran = 0.00078125;
            txtRasioCampuran.Text = rasioCampuran.ToString();

            txtHargaOmstar.Text = "122,762,250";
            txtProyeksiSavingBBM.Text = "10";

            calculateRata2PemakaianBBMDarat();

            txtSavingCustomerTahun.Text = "0";
            txtHargaBBM.Text = "0";
            txtGrossSavingCustomerTahun.Text = "0";
            txtBiayaPemakaianDX1.Text = "0";
            txtNetSavingCustomerTahun.Text = "0";
        }

        private void initializePLTD()
        {
            txtDayaTerpasang.Text = "10";
            txtCapacityFactor.Text = "80";

            SFC = 0.25;
            txtSFC.Text = SFC.ToString();

            rasioCampuranPLTD = 0.00078125;
            txtRasioCampuranPLTD.Text = rasioCampuranPLTD.ToString();

            drumOmstarPLTD = 55 * 3.79;
            txtDrumOmstarPLTD.Text = drumOmstarPLTD.ToString("N0");

            txtHargaOmstarPLTD.Text = "122,762,250";
            txtProyeksiSavingPLTD.Text = "10";

            calculateRata2PemakaianBBMPLTD();

            txtSavingCustomerTahunPLTD.Text = "0";
            txtNetSavingCustomerTahunPLTD.Text = "0";
            txtHargaBBMPLTD.Text = "0";
            txtGrossSavingCustomerTahunPLTD.Text = "0";
            txtBiayaPemakaianDX1PLTD.Text = "0";
        }

        private void countRata2PemakaianBBMTahunPLTD_TextChanged(object sender, TextChangedEventArgs e) {
            if (txtDayaTerpasang.Text == "" || txtCapacityFactor.Text == "" || txtSFC.Text == "")
            {
                txtRata2PemakaianBBMTahun.Text = "0";
            }
            else {
                calculateRata2PemakaianBBMPLTD();
            }
        }

        private void calculateRata2PemakaianBBMPLTD()
        {
            double dayaTerpasang = double.Parse(txtDayaTerpasang.Text);
            double capacityFactor = double.Parse(txtCapacityFactor.Text);
            SFC = double.Parse(txtSFC.Text);

            pemakaianRata2TahunPLTD = dayaTerpasang * SFC * capacityFactor * 1000 * 8760 / 100;
            txtPemakaianRata2PLTD.Text = pemakaianRata2TahunPLTD.ToString("N0");

            kebutuhanOmstarPLTD = pemakaianRata2TahunPLTD * rasioCampuranPLTD;
            txtKebutuhanOmstarTahunPLTD.Text = kebutuhanOmstarPLTD.ToString("N0");

            dalamDrumPLTD = kebutuhanOmstarPLTD / drumOmstarPLTD;
            txtDalamBentukDrumPLTD.Text = dalamDrumPLTD.ToString("N0");

            calculateNetSavingPLTD();
        }

        private void countRata2PemakaianBBMTahunDarat_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (txtJmlArmada.Text == "" || txtJauhPerjalananRata2.Text == "" || txtRasioPemakaianBBM.Text == "" || txtRata2FaktorKerja.Text == "") { 
                txtRata2PemakaianBBMTahun.Text = "0";
                //txtSavingCustomerTahun.Text = "0";
                //txtJauhPerjalananRata2.Text = "0";
                //txtRasioPemakaianBBM.Text = "0";
                //txtRata2FaktorKerja.Text = "0";
            }
            else {
                calculateRata2PemakaianBBMDarat();
            }
        }

        private void calculateRata2PemakaianBBMDarat()
        {
            double jmlArmada = double.Parse(txtJmlArmada.Text);
            double jauhPerjalananRata2 = double.Parse(txtJauhPerjalananRata2.Text);
            double rasioPemakaianBBM = double.Parse(txtRasioPemakaianBBM.Text);
            double rata2FaktorKerja = double.Parse(txtRata2FaktorKerja.Text);

            rata2PemakaianBBMTahun = jmlArmada * jauhPerjalananRata2 * rata2FaktorKerja * 365 / rasioPemakaianBBM / 100;
            txtRata2PemakaianBBMTahun.Text = rata2PemakaianBBMTahun.ToString("N0");

            kebutuhanOmstar = rata2PemakaianBBMTahun * rasioCampuran;
            txtKebutuhanOmstarTahun.Text = kebutuhanOmstar.ToString("N0");

            dalamDrum = kebutuhanOmstar / drumOmstar;
            txtDalamBentukDrum.Text = dalamDrum.ToString("N0");

            calculateNetSavingDarat();
        }

        private void txtCharFilter_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.Key >= Key.D0 && e.Key <= Key.D9) || e.Key == Key.Tab || e.Key == Key.OemPeriod || (e.Key >= Key.NumPad0 && e.Key <= Key.NumPad9)) { }
            else e.Handled = true;
        }

        private void calculateNetSavingDarat_TextChanged(object sender, TextChangedEventArgs e)
        {
            calculateNetSavingDarat();
        }

        private void txtHargaOmstar_KeyUp(object sender, KeyEventArgs e)
        {
            numberingFormat();
        }

        private void numberingFormat() {
            if (txtHargaOmstar.Text != "")
            {
                double hargaOmstar = double.Parse(txtHargaOmstar.Text);
                txtHargaOmstar.Text = hargaOmstar.ToString("N0");
                txtHargaOmstar.SelectionStart = txtHargaOmstar.Text.Length;
            }

            if (txtHargaOmstarPLTD.Text != "") {
                double hargaOmstarPLTD = double.Parse(txtHargaOmstarPLTD.Text);
                txtHargaOmstarPLTD.Text = hargaOmstarPLTD.ToString("N0");
                txtHargaOmstarPLTD.SelectionStart = txtHargaOmstarPLTD.Text.Length;
            }

            if (txtHargaOmstarLaut.Text != "") {
                double hargaOmstarLaut = double.Parse(txtHargaOmstarLaut.Text);
                txtHargaOmstarLaut.Text = hargaOmstarLaut.ToString("N0");
                txtHargaOmstarLaut.SelectionStart = txtHargaOmstarLaut.Text.Length;
            }

            if (txtHargaOmstarLokomotif.Text != "") {
                double hargaOmstarLokomotif = double.Parse(txtHargaOmstarLokomotif.Text);
                txtHargaOmstarLokomotif.Text = hargaOmstarLokomotif.ToString("N0");
                txtHargaOmstarLokomotif.SelectionStart = txtHargaOmstarLokomotif.Text.Length;
            }

            if (txtHargaBBM.Text != "") {
                double hargaBBM = double.Parse(txtHargaBBM.Text);
                txtHargaBBM.Text = hargaBBM.ToString("N0");
                txtHargaBBM.SelectionStart = txtHargaBBM.Text.Length;
            }

            if (txtHargaBBMPLTD.Text != "") {
                double hargaBBMPLTD = double.Parse(txtHargaBBMPLTD.Text);
                txtHargaBBMPLTD.Text = hargaBBMPLTD.ToString("N0");
                txtHargaBBMPLTD.SelectionStart = txtHargaBBMPLTD.Text.Length;
            }

            if (txtHargaBBMLaut.Text != "") {
                double hargaBBMLaut = double.Parse(txtHargaBBMLaut.Text);
                txtHargaBBMLaut.Text = hargaBBMLaut.ToString("N0");
                txtHargaBBMLaut.SelectionStart = txtHargaBBMLaut.Text.Length;
            }

            if (txtHargaBBMLokomotif.Text != "") {
                double hargaBBMLokomotif = double.Parse(txtHargaBBMLokomotif.Text);
                txtHargaBBMLokomotif.Text = hargaBBMLokomotif.ToString("N0");
                txtHargaBBMLokomotif.SelectionStart = txtHargaBBMLokomotif.Text.Length;
            }
        }

        private void calculateNetSavingDarat() 
        {
            if (txtHargaOmstar.Text == "" || txtProyeksiSavingBBM.Text == "" || txtHargaBBM.Text == "") { }
            else
            {
                double hargaOmstar = double.Parse(txtHargaOmstar.Text);
                txtHargaOmstar.Text = hargaOmstar.ToString("N0");
                txtHargaOmstar.SelectionStart = txtHargaOmstar.Text.Length;
                biayaPemakaian = dalamDrum * hargaOmstar;
                txtBiayaPemakaianDX1.Text = biayaPemakaian.ToString("N0");

                double proyeksiSaving = double.Parse(txtProyeksiSavingBBM.Text);
                savingCustomer = proyeksiSaving / 100 * rata2PemakaianBBMTahun;
                txtSavingCustomerTahun.Text = savingCustomer.ToString("N0");

                double hargaBBM = double.Parse(txtHargaBBM.Text);
                txtHargaBBM.Text = hargaBBM.ToString("N0");
                txtHargaBBM.SelectionStart = txtHargaBBM.Text.Length;
                grossSaving = savingCustomer * hargaBBM;
                txtGrossSavingCustomerTahun.Text = grossSaving.ToString("N0");

                netSaving = grossSaving - biayaPemakaian;
                txtNetSavingCustomerTahun.Text = netSaving.ToString("N0");
            }
        }

        private void txtHargaOmstarPLTD_KeyUp(object sender, KeyEventArgs e)
        {
            numberingFormat();
        }

        private void CalculateNetSavingPLTD_TextChanged(object sender, TextChangedEventArgs e)
        {
            calculateNetSavingPLTD();
        }

        private void calculateNetSavingPLTD()
        {
            if (txtHargaOmstarPLTD.Text == "" || txtProyeksiSavingPLTD.Text == "" || txtHargaBBMPLTD.Text == "") { }
            else {
                double hargaOmstarPLTD = double.Parse(txtHargaOmstarPLTD.Text);
                txtHargaOmstarPLTD.Text = hargaOmstarPLTD.ToString("N0");
                txtHargaOmstarPLTD.SelectionStart = txtHargaOmstarPLTD.Text.Length;
                biayaPemakaianPLTD = dalamDrumPLTD * hargaOmstarPLTD;
                txtBiayaPemakaianDX1PLTD.Text = biayaPemakaianPLTD.ToString("N0");

                double proyeksiSavingPLTD = double.Parse(txtProyeksiSavingPLTD.Text);
                savingCustomerPLTD = proyeksiSavingPLTD / 100 * pemakaianRata2TahunPLTD;
                txtSavingCustomerTahunPLTD.Text = savingCustomerPLTD.ToString("N0");

                double hargaBBMPLTD = double.Parse(txtHargaBBMPLTD.Text);
                txtHargaBBMPLTD.Text = hargaBBMPLTD.ToString("N0");
                txtHargaBBMPLTD.SelectionStart = txtHargaBBMPLTD.Text.Length;
                grossSavingPLTD = savingCustomerPLTD * hargaBBMPLTD;
                txtGrossSavingCustomerTahunPLTD.Text = grossSavingPLTD.ToString("N0");

                netSavingPLTD = grossSavingPLTD - biayaPemakaianPLTD;
                txtNetSavingCustomerTahunPLTD.Text = netSavingPLTD.ToString("N0");
            }
        }

        private void txtHargaBBMPLTD_KeyUp(object sender, KeyEventArgs e)
        {
            numberingFormat();
        }

        private void txtHargaBBM_KeyUp(object sender, KeyEventArgs e)
        {
            numberingFormat();
        }

        private void countRata2PemakaianBBMTahunLaut_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (txtJmlArmadaLaut.Text == "" || txtDayaMesinLaut.Text == "" || txtCapacityFactorLaut.Text == "" || txtSFC.Text == "") { }
            else {
                calculateRata2PemakaianBBMLaut();
            }
        }

        private void calculateRata2PemakaianBBMLaut()
        {
            double jmlArmadaLaut = double.Parse(txtJmlArmadaLaut.Text);
            double dayaMesinLaut = double.Parse(txtDayaMesinLaut.Text);
            double capacityFactorLaut = double.Parse(txtCapacityFactorLaut.Text);
            //SFCLaut = double.Parse(txtSFCLaut.Text, CultureInfo.InvariantCulture);

            if (!double.TryParse(txtSFCLaut.Text, out SFCLaut)) { 
            
            }

            pemakaianRata2TahunLaut = jmlArmadaLaut * dayaMesinLaut * SFCLaut * capacityFactorLaut * 1000 * 8760 / 100;
            txtPemakaianRata2TahunLaut.Text = pemakaianRata2TahunLaut.ToString("N0");

            kebutuhanOmstarLaut = pemakaianRata2TahunLaut * rasioCampuranLaut;
            txtKebutuhanOmstarTahunLaut.Text = kebutuhanOmstarLaut.ToString("N0");

            dalamDrumLaut = kebutuhanOmstarLaut / drumOmstarLaut;
            txtDalamBentukDrumLaut.Text = dalamDrumLaut.ToString("N0");

            calculateNetSavingLaut();
        }

        private void calculateNetSavingLaut()
        {
            if (txtHargaOmstarLaut.Text == "" || txtProyeksiSavingBBMLaut.Text == "" || txtHargaBBMLaut.Text == "") { }
            else {
                double hargaOmstarLaut = double.Parse(txtHargaOmstarLaut.Text);
                txtHargaOmstarLaut.Text = hargaOmstarLaut.ToString("N0");
                txtHargaOmstarLaut.SelectionStart = txtHargaOmstarLaut.Text.Length;
                hargaPemakaianLaut = dalamDrumLaut * hargaOmstarLaut;
                txtHargaPemakaianDX1Laut.Text = hargaPemakaianLaut.ToString("N0");

                double proyeksiSavingLaut = double.Parse(txtProyeksiSavingBBMLaut.Text);
                savingCustomerLaut = proyeksiSavingLaut / 100 * pemakaianRata2TahunLaut;
                txtSavingCustomerTahunLaut.Text = savingCustomerLaut.ToString("N0");

                double hargaBBMLaut = double.Parse(txtHargaBBMLaut.Text);
                txtHargaBBMLaut.Text = hargaBBMLaut.ToString("N0");
                txtHargaBBMLaut.SelectionStart = txtHargaBBMLaut.Text.Length;
                grossSavingLaut = savingCustomerLaut * hargaBBMLaut;
                txtGrossSavingCustomerTahunLaut.Text = grossSavingLaut.ToString("N0");

                netSavingLaut = grossSavingLaut - hargaPemakaianLaut;
                txtNetSavingCustomerTahunLaut.Text = netSavingLaut.ToString("N0");
            }
        }

        private void calculateNetSavingLaut_TextChanged(object sender, TextChangedEventArgs e)
        {
            calculateNetSavingLaut();
        }

        private void txtHargaOmstarLaut_KeyUp(object sender, KeyEventArgs e)
        {
            numberingFormat();
        }

        private void txtHargaBBMLaut_KeyUp(object sender, KeyEventArgs e)
        {
            numberingFormat();
        }

        private void countRata2PemakaianBBMTahunLokomotif_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (txtJmlArmadaLokomotif.Text == "" || txtDayaMesinLokomotif.Text == "" || txtCapacityFactorLokomotif.Text == "" || txtSFCLokomotif.Text == "") { }
            else {
                calculateRata2PemakaianBBMLokomotif();
            }
        }

        private void calculateRata2PemakaianBBMLokomotif()
        {
            double jmlArmadaLokomotif = double.Parse(txtJmlArmadaLokomotif.Text);
            double dayaMesinLokomotif = double.Parse(txtDayaMesinLokomotif.Text);
            double capacityFactorLokomotif = double.Parse(txtCapacityFactorLokomotif.Text);

            pemakaianRata2TahunLokomotif = jmlArmadaLokomotif * dayaMesinLokomotif * SFCLokomotif * capacityFactorLokomotif * 1000 * 8760 / 100;
            txtPemakaianRata2TahunLokomotif.Text = pemakaianRata2TahunLokomotif.ToString("N0");

            kebutuhanOmstarLokomotif = pemakaianRata2TahunLokomotif * rasioCampuranLokomotif;
            txtKebutuhanOmstarTahunLokomotif.Text = kebutuhanOmstarLokomotif.ToString("N0");

            dalamDrumLokomotif = kebutuhanOmstarLokomotif / drumOmstarLokomotif;
            txtDalamBentukDrumLokomotif.Text = dalamDrumLokomotif.ToString("N0");

            calculateNetSavingLokomotif();
        }

        private void calculateNetSavingLokomotif()
        {
            if (txtHargaOmstarLokomotif.Text == "" || txtProyeksiSavingBBMLokomotif.Text == "" || txtHargaBBMLokomotif.Text == "") { }
            else {
                double hargaOmstarLokomotif = double.Parse(txtHargaOmstarLokomotif.Text);
                txtHargaOmstarLokomotif.Text = hargaOmstarLokomotif.ToString("N0");
                txtHargaOmstarLokomotif.SelectionStart = txtHargaOmstarLokomotif.Text.Length;
                hargaPemakaianLokomotif = dalamDrumLokomotif * hargaOmstarLokomotif;
                txtHargaPemakaianDX1Lokomotif.Text = hargaPemakaianLokomotif.ToString("N0");

                double proyeksiSavingLokomotif = double.Parse(txtProyeksiSavingBBMLokomotif.Text);
                savingCustomerLokomotif = proyeksiSavingLokomotif / 100 * pemakaianRata2TahunLokomotif;
                txtSavingCustomerTahunLokomotif.Text = savingCustomerLokomotif.ToString("N0");

                double hargaBBMLokomotif = double.Parse(txtHargaBBMLokomotif.Text);
                txtHargaBBMLokomotif.Text = hargaBBMLokomotif.ToString("N0");
                txtHargaBBMLokomotif.SelectionStart = txtHargaBBMLokomotif.Text.Length;
                grossSavingLokomotif = savingCustomerLokomotif * hargaBBMLokomotif;
                txtGrossSavingCustomerTahunLokomotif.Text = grossSavingLokomotif.ToString("N0");

                netSavingLokomotif = grossSavingLokomotif - hargaPemakaianLokomotif;
                txtNetSavingCustomerTahunLokomotif.Text = netSavingLokomotif.ToString("N0");
            }
        }

        private void calculateNetSavingLokomotif_TextChanged(object sender, TextChangedEventArgs e)
        {
            calculateNetSavingLokomotif();
        }

        private void txtHargaOmstarLokomotif_KeyUp(object sender, KeyEventArgs e)
        {
            numberingFormat();
        }

        private void txtHargaBBMLokomotif_KeyUp(object sender, KeyEventArgs e)
        {
            numberingFormat();
        }

        private void btnResetPLTD_Click(object sender, RoutedEventArgs e)
        {
            initializePLTD();
        }

        private void btnResetDarat_Click(object sender, RoutedEventArgs e)
        {
            initilizeDarat();
        }

        private void btnResetLaut_Click(object sender, RoutedEventArgs e)
        {
            initializeLaut();
        }

        private void btnResetLokomotif_Click(object sender, RoutedEventArgs e)
        {
            initializeLokomotif();
        }
    }
}
