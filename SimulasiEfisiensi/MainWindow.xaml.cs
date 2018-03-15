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
        private string[] str;
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

            str = new string[20];
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

        private void btnExport_Click(object sender, RoutedEventArgs e)
        {
            exportToTxt();
        }

        private void exportToTxt()
        {
            if (tabPLTD.IsSelected) {
                str[0] = "Simulasi Pembangkit Listrik Tenaga Diesel";
                str[1] = lblDayaTerpasang.Content + " " + txtDayaTerpasang.Text + " MW";
                str[2] = lblSFCPLTD.Content + " " + txtSFC.Text + " L/KWh";
                str[3] = lblCapFactorPLTD.Content + " " + txtCapacityFactor.Text + "% (Adanya Pemeliharaan dan Gangguan)";
                str[4] = lblPemakaianRata2TahunPLTD.Content + " " + txtPemakaianRata2PLTD.Text + " LITER";
                str[5] = lblDrumOmstarPLTD.Content + " " + txtDrumOmstarPLTD.Text + " LITER";
                str[6] = lblRasioPLTD.Content + " " + txtRasioCampuranPLTD.Text + " (Rasio 1:1280)";
                str[7] = lblKebutuhanOmstarPLTD.Content + " " + txtKebutuhanOmstarTahunPLTD.Text + " LITER";
                str[8] = lblDalamDrumPLTD.Content + " " + txtDalamBentukDrumPLTD.Text + " Drum";
                str[9] = lblHargaOmstarPLTD.Content + " Rp " + txtHargaOmstarPLTD.Text;
                str[10] = lblProyeksiSavingPLTD.Content + " " + txtProyeksiSavingPLTD.Text + "%";
                str[11] = "";
                str[12] = "Proyeksi Benefit Pelanggan";
                str[13] = lblSavingCustPLTD.Content + " " + txtSavingCustomerTahunPLTD.Text + " LITER";
                str[14] = lblHargaBBMPLTD.Content + " " + txtHargaBBMPLTD.Text + " RP/LITER";
                str[15] = lblGrossSavingPLTD.Content + " Rp " + txtGrossSavingCustomerTahunPLTD.Text;
                str[16] = lblBiayaPemakaianPLTD.Content + " Rp " + txtBiayaPemakaianDX1PLTD.Text;
                str[17] = lblNetSavingPLTD.Content + " Rp " + txtNetSavingCustomerTahunPLTD.Text;

                System.IO.File.WriteAllLines(AppDomain.CurrentDomain.BaseDirectory + @"\ExportPLTD.txt", str);
            }
            else if (tabDarat.IsSelected) {
                str[0] = "Simulasi Transportasi Darat";
                str[1] = lblJmlArmadaDarat.Content + " " + txtJmlArmada.Text + " UNIT";
                str[2] = lblJauhPerjalananDarat.Content + " " + txtJauhPerjalananRata2.Text + " KM";
                str[3] = lblRasioPemakaianBBMDarat.Content + " " + txtRasioPemakaianBBM.Text + " KM/LITER";
                str[4] = lblRata2FaktorKerjaDarat.Content + " " + txtRata2FaktorKerja.Text + "% (Adanya Pemeliharaan dan Gangguan)";
                str[5] = lblRata2PemakaianBBMDarat.Content + " " + txtRata2PemakaianBBMTahun.Text + " LITER";
                str[6] = lblDrumOmstarDarat.Content + " " + txtDrumOmstar.Text + " LITER";
                str[7] = lblRasioDarat.Content + " " + txtRasioCampuran.Text + " (Rasio 1:1280)";
                str[8] = lblKebutuhanOmstarDarat.Content + " " + txtKebutuhanOmstarTahun.Text + " LITER";
                str[9] = lblDalamDrumDarat.Content + " " + txtDalamBentukDrum.Text + " Drum";
                str[10] = lblHargaOmstarDarat.Content + " Rp " + txtHargaOmstar.Text;
                str[11] = lblProyeksiSavingDarat.Content + " " + txtProyeksiSavingBBM.Text + "%";
                str[12] = "";
                str[13] = "Proyeksi Benefit Pelanggan";
                str[14] = lblSavingCustDarat.Content + " " + txtSavingCustomerTahun.Text + " LITER";
                str[15] = lblHargaBBMDarat.Content + " " + txtHargaBBM.Text + " RP/LITER";
                str[16] = lblGrossSavingDarat.Content + " Rp " + txtGrossSavingCustomerTahun.Text;
                str[17] = lblBiayaPemakaianDarat.Content + " Rp " + txtBiayaPemakaianDX1.Text;
                str[18] = lblNetSavingDarat.Content + " Rp " + txtNetSavingCustomerTahun.Text;

                System.IO.File.WriteAllLines(AppDomain.CurrentDomain.BaseDirectory + @"\ExportDarat.txt", str);
            }
            else if (tabLaut.IsSelected) {
                str[0] = "Simulasi Kapal Laut";
                str[1] = lblJmlArmadaLaut.Content + " " + txtJmlArmadaLaut.Text + " BH";
                str[2] = lblDayaMesinLaut.Content + " " + txtDayaMesinLaut.Text + " MW";
                str[3] = lblSFCLaut.Content + " " + txtSFCLaut.Text + " L/KWh";
                str[4] = lblCapFactorLaut.Content + " " + txtCapacityFactorLaut.Text + "% (Karena Docking, Gangguan, dan Waktu Sandar di Pelabuhan)";
                str[5] = lblPemakaianRata2Laut.Content + " " + txtPemakaianRata2TahunLaut.Text + " LITER";
                str[6] = lblDrumOmstarLaut.Content + " " + txtDrumOmstarLaut.Text + " LITER";
                str[7] = lblRasioLaut.Content + " " + txtRasioCampuranLaut.Text + " (Rasio 1:1280)";
                str[8] = lblKebutuhanOmstarLaut.Content + " " + txtKebutuhanOmstarTahunLaut.Text + " LITER";
                str[9] = lblDalamDrumLaut.Content + " " + txtDalamBentukDrumLaut.Text + " Drum";
                str[10] = lblHargaOmstarLaut.Content + " Rp " + txtHargaOmstarLaut.Text;
                str[11] = lblProyeksiSavingLaut.Content + " " + txtProyeksiSavingBBMLaut.Text + "%";
                str[12] = "";
                str[13] = "Proyeksi Benefit Pelanggan";
                str[14] = lblSavingCustLaut.Content + " " + txtSavingCustomerTahunLaut.Text + " LITER";
                str[15] = lblHargaBBMLaut.Content + " " + txtHargaBBMLaut.Text + " RP/LITER";
                str[16] = lblGrossSavingLaut.Content + " Rp " + txtGrossSavingCustomerTahunLaut.Text;
                str[17] = lblHargaPemakaianLaut.Content + " Rp " + txtHargaPemakaianDX1Laut.Text;
                str[18] = lblNetSavingLaut.Content + " Rp " + txtNetSavingCustomerTahunLaut.Text;

                System.IO.File.WriteAllLines(AppDomain.CurrentDomain.BaseDirectory + @"\ExportLaut.txt", str);
            }
            else if (tabLokomotif.IsSelected) {
                str[0] = "Simulasi Lokomotif";
                str[1] = lblJmlArmadaLokomotif.Content + " " + txtJmlArmadaLokomotif.Text + " BH";
                str[2] = lblDayaMesinLokomotif.Content + " " + txtDayaMesinLokomotif.Text + " MW";
                str[3] = lblSFCLokomotif.Content + " " + txtSFCLokomotif.Text + " L/KWh";
                str[4] = lblCapFactorLokomotif.Content + " " + txtCapacityFactorLokomotif.Text + "% (Karena Docking, Gangguan, dan Waktu Sandar di Pelabuhan)";
                str[5] = lblPemakaianRata2Lokomotif.Content + " " + txtPemakaianRata2TahunLokomotif.Text + " LITER";
                str[6] = lblDrumOmstarLokomotif.Content + " " + txtDrumOmstarLokomotif.Text + " LITER";
                str[7] = lblRasioLokomotif.Content + " " + txtRasioCampuranLokomotif.Text + " (Rasio 1:1280)";
                str[8] = lblKebutuhanOmstarLokomotif.Content + " " + txtKebutuhanOmstarTahunLokomotif.Text + " LITER";
                str[9] = lblDalamDrumLokomotif.Content + " " + txtDalamBentukDrumLokomotif.Text + " Drum";
                str[10] = lblHargaOmstarLokomotif.Content + " Rp " + txtHargaOmstarLokomotif.Text;
                str[11] = lblProyeksiSavingLokomotif.Content + " " + txtProyeksiSavingBBMLokomotif.Text + "%";
                str[12] = "";
                str[13] = "Proyeksi Benefit Pelanggan";
                str[14] = lblSavingCustLokomotif.Content + " " + txtSavingCustomerTahunLokomotif.Text + " LITER";
                str[15] = lblHargaBBMLokomotif.Content + " " + txtHargaBBMLokomotif.Text + " RP/LITER";
                str[16] = lblGrossSavingLokomotif.Content + " Rp " + txtGrossSavingCustomerTahunLokomotif.Text;
                str[17] = lblHargaPemakaianLokomotif.Content + " Rp " + txtHargaPemakaianDX1Lokomotif.Text;
                str[18] = lblNetSavingLokomotif.Content + " Rp " + txtNetSavingCustomerTahunLokomotif.Text;

                System.IO.File.WriteAllLines(AppDomain.CurrentDomain.BaseDirectory + @"\ExportLokomotif.txt", str);
            }
            MessageBox.Show("Data Has Been Exported Successfully", "Info", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
