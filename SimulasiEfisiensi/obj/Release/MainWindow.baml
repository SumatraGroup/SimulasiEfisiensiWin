   M S B A M L   `   `   `  ����   SimulasiEfisiensi"    SimulasiEfisiensi.MainWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml       � Title$  Simulasi Efisiensi��$	��720��$
��1280�� � Icon$ icon.bmp�� � WindowStartupLocation$ CenterScreen=�.���  � ColumnDefinitions �� $	��27* ��� $	��25* ��� $	��19* ��� $
��565* ��� $
��636* �.+��� $��Center=�$	��689��$��-2,0,0,0q�$��Center=�$
��1274��$��5��.@��� -    ��Name$ tabPLTD��$
��PLTD��.��� 
������� � LayoutTransform V� .~���  �� ScaleX$
 1.25Q� �� ScaleY$
 1.25Q��� �� T�  �� $��2* ��� �� .+��� -    ��Name$ lblDayaTerpasang��$��Daya Terpasang��$
��Left=�$��0,96,0,0q�$	��Top=�$��22��$��92��$��9(��� -   $ 
lblSFCPLTD��$%��Specific Fuel Consumption (SFC)��$
��Left=�$��	0,118,0,0q�$	��Top=�$��22��$	��200��$��9(��� -   $ lblCapFactorPLTD��$��Capacity Factor��$
��Left=�$��	0,140,0,0q�$	��Top=�$��22��$	��101��$��9(��� -   $  lblPemakaianRata2TahunPLTD��$#��Pemakaian Rata-Rata per Tahun��$
��Left=�$��	0,162,0,0q�$	��Top=�$��22��$	��162��$��9(��� -   $ lblDrumOmstarPLTD��$#��1 Drum Omstar DX1 55 US Galon��$
��Left=�$��	0,184,0,0q�$	��Top=�$��22��$	��157��$��9(��� -   $ lblRasioPLTD��$��Rasio Campuran DX1/Fuel��$
��Left=�$��	0,206,0,0q�$	��Top=�$��22��$	��157��$��9(��� -   $ lblKebutuhanOmstarPLTD��$$��Kebutuhan Omstar DX1 per Tahun��$
��Left=�$��	0,228,0,0q�$	��Top=�$��22��$	��157��$��9(��� -	   $ lblDalamDrumPLTD��$��Dalam Bentuk Drum��$
��Left=�$��	0,250,0,0q�$	��Top=�$��22��$	��157��$��9(��� -
   $ lblHargaOmstarPLTD��$��Harga Omstar per Drum��$
��Left=�$��	0,272,0,0q�$	��Top=�$��22��$	��157��$��9(��� -   $ lblProyeksiSavingPLTD��$#��Proyeksi Saving BBM Pakai DX1��$
��Left=�$��	0,294,0,0q�$	��Top=�$��22��$	��157��$��9(��� $ ��Proyeksi Benefit Pelanggan��$
��Left=�$��	0,350,0,0q�$	��Top=�$��22��$	��157��$��9(�$
��Bold"��� -   $ lblSavingCustPLTD��$$��Saving Bagi Customer per Tahun��$
��Left=�$��	0,372,0,0q�$	��Top=�$��22��$	��157��$��9(��� -   $ lblHargaBBMPLTD��$��	Harga BBM��$
��Left=�$��	0,394,0,0q�$	��Top=�$��22��$	��157��$��9(��� -   $ lblGrossSavingPLTD��$*��$Gross Saving Bagi Customer per Tahun��$
��Left=�$��	0,416,0,0q�$	��Top=�$��22��$	��166��$��9(��� -   $ lblBiayaPemakaianPLTD��$��Biaya Pemakaian DX1��$
��Left=�$��	0,438,0,0q�$	��Top=�$��22��$	��166��$��9(��� -   $ lblNetSavingPLTD��$(��"Net Saving Bagi Customer per Tahun��$
��Left=�$��	0,460,0,0q�$	��Top=�$��22��$	��166��$��9(��� -   	 ��Name$	 txtDayaTerpasang��$
��Left=�$��23��$��
255,95,0,0q�
 �� TextWrapping$

 Wrap=�$	��Top=�$	��252�� �� TextAlignment$ Right=��� -   $	 txtSFC��$
��Left=�$��23��$��255,117,0,0q�$

 Wrap=�$	��Top=�$	��252��$ Right=�
��������� -   $	 txtCapacityFactor��$
��Left=�$��23��$��255,139,0,0q�$

 Wrap=�$	��Top=�$	��252��$ Right=��� -   $	 txtPemakaianRata2PLTD��$
��Left=�$��23��$��255,161,0,0q�$

 Wrap=�$	��Top=�$	��252��$ Right=����	#FFD4D4D4 �� 
IsReadOnly . �� -   $	 txtDrumOmstarPLTD��$
��Left=�$��23��$��255,183,0,0q�$

 Wrap=�$	��Top=�$	��252��$ Right=����	#FFD4D4D4 . �� -   $	 txtRasioCampuranPLTD��$
��Left=�$��23��$��255,205,0,0q�$

 Wrap=�$	��Top=�$	��252��$ Right=����	#FFD4D4D4 . �� -   $!	 txtKebutuhanOmstarTahunPLTD��$
��Left=�$��23��$��255,227,0,0q�$

 Wrap=�$	��Top=�$	��252��$ Right=����	#FFD4D4D4 . �� -   $	 txtDalamBentukDrumPLTD��$
��Left=�$��23��$��255,249,0,0q�$

 Wrap=�$	��Top=�$	��252��$ Right=����	#FFD4D4D4 . �� -   $	 txtHargaOmstarPLTD��$
��Left=�$��23��$��255,271,0,0q�$

 Wrap=�$	��Top=�$	��252��$ Right=��� -   $	 txtProyeksiSavingPLTD��$
��Left=�$��23��$��255,293,0,0q�$

 Wrap=�$	��Top=�$	��252��$ Right=��� -   $ 	 txtSavingCustomerTahunPLTD��$
��Left=�$��23��$��255,371,0,0q�$

 Wrap=�$	��Top=�$	��252��$ Right=����	#FFD4D4D4 . �� -   $	 txtHargaBBMPLTD��$
��Left=�$��23��$��255,393,0,0q�$

 Wrap=�$	��Top=�$	��252��$ Right=��� -   $%	 txtGrossSavingCustomerTahunPLTD��$
��Left=�$��23��$��255,415,0,0q�$

 Wrap=�$	��Top=�$	��252��$ Right=����	#FFD4D4D4 . �� -   $	 txtBiayaPemakaianDX1PLTD��$
��Left=�$��23��$��255,437,0,0q�$

 Wrap=�$	��Top=�$	��252��$ Right=����	#FFD4D4D4 . �� -   $#	 txtNetSavingCustomerTahunPLTD��$
��Left=�$��23��$��255,459,0,0q�$

 Wrap=�$	��Top=�$	��252��$ Right=����	#FFD4D4D4 . �� $/��)SIMULASI PEMBANGKIT LISTRIK TENAGA DIESEL��$��
363,65,0,0q�$	��Top=�$	��288��$
��Bold"�$
��Left=�$��2��$��26���� $��MW��$
��Left=�$��0,96,0,0q�$	��Top=�$��22��$	��167��$��9(�$��1���� $��L/KWh��$
��Left=�$��	0,118,0,0q�$	��Top=�$��22��$	��167��$��9(�$��1���� $)��#%(Adanya Pemeliharaan dan Gangguan)��$��Right=�$��
0,140,72,0q�$	��Top=�$��22��$	��182��$��9(�$��1���� $��LITER��$
��Left=�$��	0,162,0,0q�$	��Top=�$��22��$	��212��$��9(�$��1��$��2���� $��LITER��$
��Left=�$��	0,184,0,0q�$	��Top=�$��22��$	��167��$��9(�$��1���� $��RASIO 1:1280��$
��Left=�$��	0,205,0,0q�$	��Top=�$��22��$	��167��$��9(�$��1���� $��LITER��$
��Left=�$��	0,228,0,0q�$	��Top=�$��22��$	��167��$��9(�$��1���� $
��DRUM��$
��Left=�$��	0,250,0,0q�$	��Top=�$��22��$	��167��$��9(�$��1���� $��RP��$
��Left=�$��	0,272,0,0q�$	��Top=�$��22��$	��167��$��9(�$��1���� $�� ��$
��Left=�$��	0,294,0,0q�$	��Top=�$��22��$	��167��$��9(�$��1���� $��LITER��$
��Left=�$��	0,372,0,0q�$	��Top=�$��22��$	��167��$��9(�$��1���� $��RP/LITER��$
��Left=�$��	0,394,0,0q�$	��Top=�$��22��$	��167��$��9(�$��1���� $��RP��$
��Left=�$��	0,416,0,0q�$	��Top=�$��22��$	��167��$��9(�$��1���� $��RP��$
��Left=�$��	0,438,0,0q�$	��Top=�$��22��$	��167��$��9(�$��1���� $��RP��$
��Left=�$��	0,460,0,0q�$	��Top=�$��22��$	��167��$��9(�$��1���� $����Neither Seller nor the Company, nor any Person on behalf of either of them, makes or has made, and Seller expressly disclaims, any direct or indirect representation of warranty with respect to the accuracy  or completeness of any information, 
written oral or in any other format, which has been made available, or is made available.��$
��Left=�$��	0,505,0,0q�$	��Top=�$	��559��$��5(�$��2���� $��%��$
��Left=�$��	0,293,0,0q�$	��Top=�$��22��$	��167��$��9(�$��1���� -     ��Name$ btnResetPLTD��$��Reset��$��2��$
��Left=�$��	0,462,0,0q�$	��Top=�$��75���� $��v 1.0��$��2��$
��Left=�$��229,509,0,0q�$	��Top=�$��7(��� -!   $ btnExportPLTD��$��Export��$��2��$
��Left=�$��129,462,0,0q�$	��Top=�$��75���� -"   $ tabDarat��$��TRANSPORTASI DARAT������  �� EndPoint$	 0,1&� �� 
StartPoint$	 0,0&�.���  � Color$ 	#FFF0F0F0�� � Offset$ 0Q�� $
 Snow��$ 1Q�� $ 	#FFF4F2F2��$ 1Q�� $ 	#FFFDF9F9��$ 1Q�� $ 	#FFFDF9F9��$ 1Q�.��� 
�������$��0,-3,0,0q� V� .~��� $
 1.25Q�$
 1.25Q��� �� T�  � RowDefinitions �� �� $��0* � �� �� �� �� .+��� -#   $ lblJmlArmadaDarat��$��Jumlah Armada��$
��Left=�$��0,96,0,0q�$	��Top=�$��22��$��92��$��9(��� -$   $ lblJauhPerjalananDarat��$(��"Jauh Perjalanan Rata-Rata per Hari��$
��Left=�$��	0,118,0,0q�$	��Top=�$��22��$	��200��$��9(�$��2���� -%   $ lblRasioPemakaianBBMDarat��$��Rasio Pemakaian BBM��$
��Left=�$��	0,140,0,0q�$	��Top=�$��22��$	��101��$��9(��� -&   $ lblRata2FaktorKerjaDarat��$��Rata-Rata Faktor Kerja��$
��Left=�$��	0,162,0,0q�$	��Top=�$��22��$	��101��$��9(��� -'   $ lblRata2PemakaianBBMDarat��$'��!Rata-Rata Pemakaian BBM per Tahun��$
��Left=�$��	0,184,0,0q�$	��Top=�$��22��$	��157��$��9(��� -(   $ lblDrumOmstarDarat��$#��1 Drum Omstar DX1 55 US Galon��$
��Left=�$��	0,206,0,0q�$	��Top=�$��22��$	��157��$��9(��� -)   $ lblRasioDarat��$��Rasio Campuran DX1/Fuel��$
��Left=�$��	0,228,0,0q�$	��Top=�$��22��$	��157��$��9(��� -*   $ lblKebutuhanOmstarDarat��$$��Kebutuhan Omstar DX1 per Tahun��$
��Left=�$��	0,250,0,0q�$	��Top=�$��22��$	��157��$��9(��� -+   $ lblDalamDrumDarat��$��Dalam Bentuk Drum��$
��Left=�$��	0,272,0,0q�$	��Top=�$��22��$	��157��$��9(��� -,   $ lblHargaOmstarDarat��$��Harga Omstar per Drum��$
��Left=�$��	0,294,0,0q�$	��Top=�$��22��$	��157��$��9(��� --   $ lblProyeksiSavingDarat��$#��Proyeksi Saving BBM Pakai DX1��$
��Left=�$��	0,316,0,0q�$	��Top=�$��22��$	��157��$��9(��� $ ��Proyeksi Benefit Pelanggan��$
��Left=�$��	0,350,0,0q�$	��Top=�$��22��$	��157��$��9(�$
��Bold"��� -.   $ lblSavingCustDarat��$$��Saving Bagi Customer per Tahun��$
��Left=�$��	0,372,0,0q�$	��Top=�$��22��$	��157��$��9(��� -/   $ lblHargaBBMDarat��$��	Harga BBM��$
��Left=�$��	0,394,0,0q�$	��Top=�$��22��$	��157��$��9(��� -0   $ lblGrossSavingDarat��$*��$Gross Saving Bagi Customer per Tahun��$
��Left=�$��	0,416,0,0q�$	��Top=�$��22��$	��166��$��9(��� -1   $ lblBiayaPemakaianDarat��$��Biaya Pemakaian DX1��$
��Left=�$��	0,438,0,0q�$	��Top=�$��22��$	��166��$��9(��� -2   $ lblNetSavingDarat��$(��"Net Saving Bagi Customer per Tahun��$
��Left=�$��	0,460,0,0q�$	��Top=�$��22��$	��166��$��9(��� -3   $	 txtJmlArmada��$��1��$
��Left=�$��23��$��0,95,0,0q�$

 Wrap=�$	��Top=�$	��253��$ Right=��� -4   $	 txtJauhPerjalananRata2��$��1��$
��Left=�$��23��$��	0,117,0,0q�$

 Wrap=�$	��Top=�$	��253��$ Right=��� -5   $	 txtRasioPemakaianBBM��$��1��$
��Left=�$��23��$��	0,139,0,0q�$

 Wrap=�$	��Top=�$	��253��$ Right=��� -6   $	 txtRata2FaktorKerja��$��1��$
��Left=�$��23��$��	0,161,0,0q�$

 Wrap=�$	��Top=�$	��253��$ Right=��� -7   $	 txtRata2PemakaianBBMTahun��$��1��$
��Left=�$��23��$��	0,183,0,0q�$

 Wrap=�$	��Top=�$	��253��$ Right=� . ���	#FFD4D4D4�� -8   $	 txtDrumOmstar��$��1��$
��Left=�$��23��$��	0,205,0,0q�$

 Wrap=�$	��Top=�$	��253��$ Right=� . ���	#FFD4D4D4�� -9   $	 txtRasioCampuran��$��1��$
��Left=�$��23��$��	0,227,0,0q�$

 Wrap=�$	��Top=�$	��253��$ Right=� . ���	#FFD4D4D4�� -:   $	 txtKebutuhanOmstarTahun��$��1��$
��Left=�$��23��$��	0,249,0,0q�$

 Wrap=�$	��Top=�$	��253��$ Right=� . ���	#FFD4D4D4�� -;   $	 txtDalamBentukDrum��$��1��$
��Left=�$��23��$��	0,271,0,0q�$

 Wrap=�$	��Top=�$	��253��$ Right=� . ���	#FFD4D4D4�� -<   $	 txtHargaOmstar��$��1��$
��Left=�$��23��$��	0,293,0,0q�$

 Wrap=�$	��Top=�$	��253��$ Right=��� -=   $	 txtProyeksiSavingBBM��$��1��$
��Left=�$��23��$��	0,315,0,0q�$

 Wrap=�$	��Top=�$	��253��$ Right=��� ->   $	 txtSavingCustomerTahun��$��1��$
��Left=�$��23��$��	0,371,0,0q�$

 Wrap=�$	��Top=�$	��253��$ Right=����	#FFD4D4D4 . �� -?   $	 txtHargaBBM��$��1��$
��Left=�$��23��$��	0,393,0,0q�$

 Wrap=�$	��Top=�$	��253��$ Right=��� -@   $!	 txtGrossSavingCustomerTahun��$��1��$
��Left=�$��23��$��	0,415,0,0q�$

 Wrap=�$	��Top=�$	��253��$ Right=����	#FFD4D4D4 . �� -A   $	 txtBiayaPemakaianDX1��$��1��$
��Left=�$��23��$��	0,437,0,0q�$

 Wrap=�$	��Top=�$	��253��$ Right=����	#FFD4D4D4 . �� -B   $	 txtNetSavingCustomerTahun��$��1��$
��Left=�$��23��$��	0,459,0,0q�$

 Wrap=�$	��Top=�$	��253��$ Right=����	#FFD4D4D4 . �� $!��SIMULASI TRANSPORTASI DARAT��$��1��$��
153,64,0,0q�$	��Top=�$��2��$	��200��$
��Bold"�$
��Left=��� $
��UNIT��$
��Left=�$��0,96,0,0q�$	��Top=�$��22��$	��167��$��9(�$��2���� $��KM��$
��Left=�$��	0,118,0,0q�$	��Top=�$��22��$	��167��$��9(�$��2���� $��KM/LITER��$
��Left=�$��	0,140,0,0q�$	��Top=�$��22��$	��167��$��9(�$��2���� $6��0%(Standby Boarding, Gangguan, Pemeliharaan Rutin��$
��Left=�$��	5,162,0,0q�$	��Top=�$��22��$	��239��$��9(�$��2���� $��LITER��$
��Left=�$��	0,184,0,0q�$	��Top=�$��22��$	��167��$��9(�$��2���� $��LITER��$
��Left=�$��	0,205,0,0q�$	��Top=�$��22��$	��167��$��9(�$��2���� $��RASIO 1:1280��$
��Left=�$��	0,228,0,0q�$	��Top=�$��22��$	��167��$��9(�$��2���� $��LITER��$
��Left=�$��	0,250,0,0q�$	��Top=�$��22��$	��167��$��9(�$��2���� $
��DRUM��$
��Left=�$��	0,272,0,0q�$	��Top=�$��22��$	��167��$��9(�$��2���� $��RP��$
��Left=�$��	0,294,0,0q�$	��Top=�$��22��$	��167��$��9(�$��2���� $��LITER��$
��Left=�$��	0,372,0,0q�$	��Top=�$��22��$	��167��$��9(�$��2���� $��RP/LITER��$
��Left=�$��	0,394,0,0q�$	��Top=�$��22��$	��167��$��9(�$��2���� $��RP��$
��Left=�$��	0,416,0,0q�$	��Top=�$��22��$	��167��$��9(�$��2���� $��RP��$
��Left=�$��	0,438,0,0q�$	��Top=�$��22��$	��167��$��9(�$��2���� $��RP��$
��Left=�$��	0,460,0,0q�$	��Top=�$��22��$	��167��$��9(�$��2���� $����Neither Seller nor the Company, nor any Person on behalf of either of them, makes or has made, and Seller expressly disclaims, any direct or indirect representation of warranty with respect to the accuracy  or completeness of any information, 
written oral or in any other format, which has been made available, or is made available.��$
��Left=�$��	0,505,0,0q�$	��Top=�$	��559��$��5(�$��3���� $��%��$
��Left=�$��	0,316,0,0q�$	��Top=�$��22��$	��167��$��9(�$��2���� -C   $ btnResetDarat��$��Reset��$��3��$
��Left=�$��	0,462,0,0q�$	��Top=�$��75���� $��v 1.0��$��3��$
��Left=�$��229,509,0,0q�$	��Top=�$��7(��� -D   $ btnExportDarat��$��Export��$��3��$
��Left=�$��129,462,0,0q�$	��Top=�$��75���� -E   $ tabLaut��$��TRANSPORTASI LAUT��$��
-2,-2,-2,0q����� $	 0,1&�$	 0,0&�.��� $ 	#FFF0F0F0��$ 0Q�� $
 Snow��$ 1Q�� $ 	#FFF4F2F2��$ 1Q�� $ 	#FFFDF9F9��$ 1Q�� $ 	#FFFDF9F9��$ 1Q�.��� 
������� V� .~��� $
 1.25Q�$
 1.25Q��� �� T�  �� �� $��0* � �� �� �� �� .+��� -F   $ lblJmlArmadaLaut��$��Jumlah Armada��$
��Left=�$��0,96,0,0q�$	��Top=�$��22��$��92��$��9(��� -G   $ lblDayaMesinLaut��$��
Daya Mesin��$
��Left=�$��	0,118,0,0q�$	��Top=�$��22��$	��200��$��9(�$��2���� -H   $ 
lblSFCLaut��$%��Specific Fuel Consumption (SFC)��$
��Left=�$��	0,140,0,0q�$	��Top=�$��22��$	��140��$��9(��� -I   $ lblCapFactorLaut��$��Capacity Factor��$
��Left=�$��	0,162,0,0q�$	��Top=�$��22��$	��101��$��9(��� -J   $ lblPemakaianRata2Laut��$#��Pemakaian Rata-Rata per Tahun��$
��Left=�$��	0,184,0,0q�$	��Top=�$��22��$	��157��$��9(��� -K   $ lblDrumOmstarLaut��$#��1 Drum Omstar DX1 55 US Galon��$
��Left=�$��	0,206,0,0q�$	��Top=�$��22��$	��157��$��9(��� -L   $ lblRasioLaut��$��Rasio Campuran DX1/Fuel��$
��Left=�$��	0,228,0,0q�$	��Top=�$��22��$	��157��$��9(��� -M   $ lblKebutuhanOmstarLaut��$$��Kebutuhan Omstar DX1 per Tahun��$
��Left=�$��	0,250,0,0q�$	��Top=�$��22��$	��157��$��9(��� -N   $ lblDalamDrumLaut��$��Dalam Bentuk Drum��$
��Left=�$��	0,272,0,0q�$	��Top=�$��22��$	��157��$��9(��� -O   $ lblHargaOmstarLaut��$��Harga Omstar per Drum��$
��Left=�$��	0,294,0,0q�$	��Top=�$��22��$	��157��$��9(��� -P   $ lblProyeksiSavingLaut��$#��Proyeksi Saving BBM Pakai DX1��$
��Left=�$��	0,316,0,0q�$	��Top=�$��22��$	��157��$��9(��� $ ��Proyeksi Benefit Pelanggan��$
��Left=�$��	0,350,0,0q�$	��Top=�$��22��$	��157��$��9(�$
��Bold"��� -Q   $ lblSavingCustLaut��$$��Saving Bagi Customer per Tahun��$
��Left=�$��	0,372,0,0q�$	��Top=�$��22��$	��157��$��9(��� -R   $ lblHargaBBMLaut��$��	Harga BBM��$
��Left=�$��	0,394,0,0q�$	��Top=�$��22��$	��157��$��9(��� -S   $ lblGrossSavingLaut��$*��$Gross Saving Bagi Customer per Tahun��$
��Left=�$��	0,416,0,0q�$	��Top=�$��22��$	��166��$��9(��� -T   $ lblHargaPemakaianLaut��$��Harga Pemakaian DX1��$
��Left=�$��	0,438,0,0q�$	��Top=�$��22��$	��166��$��9(��� -U   $ lblNetSavingLaut��$(��"Net Saving Bagi Customer per Tahun��$
��Left=�$��	0,460,0,0q�$	��Top=�$��22��$	��166��$��9(��� -V   $	 txtJmlArmadaLaut��$��1��$
��Left=�$��23��$��0,95,0,0q�$

 Wrap=�$	��Top=�$	��253��$ Right=��� -W   $	 txtDayaMesinLaut��$��1��$
��Left=�$��23��$��	0,117,0,0q�$

 Wrap=�$	��Top=�$	��253��$ Right=��� -X   $	 
txtSFCLaut��$��1��$
��Left=�$��23��$��	0,139,0,0q�$

 Wrap=�$	��Top=�$	��253��$ Right=�
��������� -Y   $	 txtCapacityFactorLaut��$��1��$
��Left=�$��23��$��	0,161,0,0q�$

 Wrap=�$	��Top=�$	��253��$ Right=��� -Z   $ 	 txtPemakaianRata2TahunLaut��$��1��$
��Left=�$��23��$��	0,183,0,0q�$

 Wrap=�$	��Top=�$	��253��$ Right=� . ���	#FFD4D4D4�� -[   $	 txtDrumOmstarLaut��$��1��$
��Left=�$��23��$��	0,205,0,0q�$

 Wrap=�$	��Top=�$	��253��$ Right=� . ���	#FFD4D4D4�� -\   $	 txtRasioCampuranLaut��$��1��$
��Left=�$��23��$��	0,227,0,0q�$

 Wrap=�$	��Top=�$	��253��$ Right=� . ���	#FFD4D4D4�� -]   $!	 txtKebutuhanOmstarTahunLaut��$��1��$
��Left=�$��23��$��	0,249,0,0q�$

 Wrap=�$	��Top=�$	��253��$ Right=� . ���	#FFD4D4D4�� -^   $	 txtDalamBentukDrumLaut��$��1��$
��Left=�$��23��$��	0,271,0,0q�$

 Wrap=�$	��Top=�$	��253��$ Right=� . ���	#FFD4D4D4�� -_   $	 txtHargaOmstarLaut��$��1��$
��Left=�$��23��$��	0,293,0,0q�$

 Wrap=�$	��Top=�$	��253��$ Right=��� -`   $	 txtProyeksiSavingBBMLaut��$��1��$
��Left=�$��23��$��	0,315,0,0q�$

 Wrap=�$	��Top=�$	��253��$ Right=��� -a   $ 	 txtSavingCustomerTahunLaut��$��1��$
��Left=�$��23��$��	0,371,0,0q�$

 Wrap=�$	��Top=�$	��253��$ Right=����	#FFD4D4D4 . �� -b   $	 txtHargaBBMLaut��$��1��$
��Left=�$��23��$��	0,393,0,0q�$

 Wrap=�$	��Top=�$	��253��$ Right=��� -c   $%	 txtGrossSavingCustomerTahunLaut��$��1��$
��Left=�$��23��$��	0,415,0,0q�$

 Wrap=�$	��Top=�$	��253��$ Right=����	#FFD4D4D4 . �� -d   $	 txtHargaPemakaianDX1Laut��$��1��$
��Left=�$��23��$��	0,437,0,0q�$

 Wrap=�$	��Top=�$	��253��$ Right=����	#FFD4D4D4 . �� -e   $#	 txtNetSavingCustomerTahunLaut��$��1��$
��Left=�$��23��$��	0,459,0,0q�$

 Wrap=�$	��Top=�$	��253��$ Right=����	#FFD4D4D4 . �� $��SIMULASI KAPAL LAUT��$��1��$��
181,65,0,0q�$	��Top=�$��2��$	��144��$
��Bold"�$
��Left=��� $��BH��$
��Left=�$��0,96,0,0q�$	��Top=�$��22��$	��167��$��9(�$��2���� $��MW��$
��Left=�$��	0,118,0,0q�$	��Top=�$��22��$	��167��$��9(�$��2���� $��L/KWh��$
��Left=�$��	0,140,0,0q�$	��Top=�$��22��$	��167��$��9(�$��2���� $@��:%(Karena Docking, Gangguan, dan Waktu Sandar di Pelabuhan)��$
��Left=�$��	0,162,0,0q�$	��Top=�$��22��$	��279��$��9(�$��2��$��2���� $��LITER��$
��Left=�$��	0,184,0,0q�$	��Top=�$��22��$	��167��$��9(�$��2���� $��LITER��$
��Left=�$��	0,205,0,0q�$	��Top=�$��22��$	��167��$��9(�$��2���� $��RASIO 1:1280��$
��Left=�$��	0,228,0,0q�$	��Top=�$��22��$	��167��$��9(�$��2���� $��LITER��$
��Left=�$��	0,250,0,0q�$	��Top=�$��22��$	��167��$��9(�$��2���� $
��DRUM��$
��Left=�$��	0,272,0,0q�$	��Top=�$��22��$	��167��$��9(�$��2���� $��RP��$
��Left=�$��	0,294,0,0q�$	��Top=�$��22��$	��167��$��9(�$��2���� $��LITER��$
��Left=�$��	0,372,0,0q�$	��Top=�$��22��$	��167��$��9(�$��2���� $��RP/LITER��$
��Left=�$��	0,394,0,0q�$	��Top=�$��22��$	��167��$��9(�$��2���� $��RP��$
��Left=�$��	0,416,0,0q�$	��Top=�$��22��$	��167��$��9(�$��2���� $��RP��$
��Left=�$��	0,438,0,0q�$	��Top=�$��22��$	��167��$��9(�$��2���� $��RP��$
��Left=�$��	0,460,0,0q�$	��Top=�$��22��$	��167��$��9(�$��2���� $����Neither Seller nor the Company, nor any Person on behalf of either of them, makes or has made, and Seller expressly disclaims, any direct or indirect representation of warranty with respect to the accuracy  or completeness of any information, 
written oral or in any other format, which has been made available, or is made available.��$
��Left=�$��	0,505,0,0q�$	��Top=�$	��559��$��5(�$��3���� $��%��$
��Left=�$��	0,316,0,0q�$	��Top=�$��22��$	��167��$��9(�$��2���� -f   $ btnResetLaut��$��Reset��$��3��$
��Left=�$��	0,462,0,0q�$	��Top=�$��75���� $��v 1.0��$��3��$
��Left=�$��229,509,0,0q�$	��Top=�$��7(��� -g   $ btnExportLaut��$��Export��$��3��$
��Left=�$��129,462,0,0q�$	��Top=�$��75���� -h   $ tabLokomotif��$��	LOKOMOTIF��$��
-2,-2,-2,0q����� $	 0,1&�$	 0,0&�.��� $ 	#FFF0F0F0��$ 0Q�� $
 Snow��$ 1Q�� $ 	#FFF4F2F2��$ 1Q�� $ 	#FFFDF9F9��$ 1Q�� $ 	#FFFDF9F9��$ 1Q�.��� 
������� V� .~��� $
 1.25Q�$
 1.25Q��� �� T�  �� �� $��0* � �� �� �� �� .+��� -i   $ lblJmlArmadaLokomotif��$��Jumlah Armada��$
��Left=�$��0,96,0,0q�$	��Top=�$��22��$��92��$��9(��� -j   $ lblDayaMesinLokomotif��$��
Daya Mesin��$
��Left=�$��	0,118,0,0q�$	��Top=�$��22��$	��200��$��9(�$��2���� -k   $ lblSFCLokomotif��$%��Specific Fuel Consumption (SFC)��$
��Left=�$��	0,140,0,0q�$	��Top=�$��22��$	��140��$��9(��� -l   $ lblCapFactorLokomotif��$��Capacity Factor��$
��Left=�$��	0,162,0,0q�$	��Top=�$��22��$	��101��$��9(��� -m   $  lblPemakaianRata2Lokomotif��$#��Pemakaian Rata-Rata per Tahun��$
��Left=�$��	0,184,0,0q�$	��Top=�$��22��$	��157��$��9(��� -n   $ lblDrumOmstarLokomotif��$#��1 Drum Omstar DX1 55 US Galon��$
��Left=�$��	0,206,0,0q�$	��Top=�$��22��$	��157��$��9(��� -o   $ lblRasioLokomotif��$��Rasio Campuran DX1/Fuel��$
��Left=�$��	0,228,0,0q�$	��Top=�$��22��$	��157��$��9(��� -p   $! lblKebutuhanOmstarLokomotif��$$��Kebutuhan Omstar DX1 per Tahun��$
��Left=�$��	0,250,0,0q�$	��Top=�$��22��$	��157��$��9(��� -q   $ lblDalamDrumLokomotif��$��Dalam Bentuk Drum��$
��Left=�$��	0,272,0,0q�$	��Top=�$��22��$	��157��$��9(��� -r   $ lblHargaOmstarLokomotif��$��Harga Omstar per Drum��$
��Left=�$��	0,294,0,0q�$	��Top=�$��22��$	��157��$��9(��� -s   $  lblProyeksiSavingLokomotif��$#��Proyeksi Saving BBM Pakai DX1��$
��Left=�$��	0,316,0,0q�$	��Top=�$��22��$	��157��$��9(��� $ ��Proyeksi Benefit Pelanggan��$
��Left=�$��	0,350,0,0q�$	��Top=�$��22��$	��157��$��9(�$
��Bold"��� -t   $ lblSavingCustLokomotif��$$��Saving Bagi Customer per Tahun��$
��Left=�$��	0,372,0,0q�$	��Top=�$��22��$	��157��$��9(��� -u   $ lblHargaBBMLokomotif��$��	Harga BBM��$
��Left=�$��	0,394,0,0q�$	��Top=�$��22��$	��157��$��9(��� -v   $ lblGrossSavingLokomotif��$*��$Gross Saving Bagi Customer per Tahun��$
��Left=�$��	0,416,0,0q�$	��Top=�$��22��$	��166��$��9(��� -w   $  lblHargaPemakaianLokomotif��$��Harga Pemakaian DX1��$
��Left=�$��	0,438,0,0q�$	��Top=�$��22��$	��166��$��9(��� -x   $ lblNetSavingLokomotif��$(��"Net Saving Bagi Customer per Tahun��$
��Left=�$��	0,460,0,0q�$	��Top=�$��22��$	��166��$��9(��� -y   $	 txtJmlArmadaLokomotif��$��1��$
��Left=�$��23��$��0,95,0,0q�$

 Wrap=�$	��Top=�$	��253��$ Right=��� -z   $	 txtDayaMesinLokomotif��$��1��$
��Left=�$��23��$��	0,117,0,0q�$

 Wrap=�$	��Top=�$	��253��$ Right=��� -{   $	 txtSFCLokomotif��$��1��$
��Left=�$��23��$��	0,139,0,0q�$

 Wrap=�$	��Top=�$	��253��$ Right=�
��������� -|   $ 	 txtCapacityFactorLokomotif��$��1��$
��Left=�$��23��$��	0,161,0,0q�$

 Wrap=�$	��Top=�$	��253��$ Right=��� -}   $%	 txtPemakaianRata2TahunLokomotif��$��1��$
��Left=�$��23��$��	0,183,0,0q�$

 Wrap=�$	��Top=�$	��253��$ Right=� . ���	#FFD4D4D4�� -~   $	 txtDrumOmstarLokomotif��$��1��$
��Left=�$��23��$��	0,205,0,0q�$

 Wrap=�$	��Top=�$	��253��$ Right=� . ���	#FFD4D4D4�� -   $	 txtRasioCampuranLokomotif��$��1��$
��Left=�$��23��$��	0,227,0,0q�$

 Wrap=�$	��Top=�$	��253��$ Right=� . ���	#FFD4D4D4�� -�   $&	  txtKebutuhanOmstarTahunLokomotif��$��1��$
��Left=�$��23��$��	0,249,0,0q�$

 Wrap=�$	��Top=�$	��253��$ Right=� . ���	#FFD4D4D4�� -�   $!	 txtDalamBentukDrumLokomotif��$��1��$
��Left=�$��23��$��	0,271,0,0q�$

 Wrap=�$	��Top=�$	��253��$ Right=� . ���	#FFD4D4D4�� -�   $	 txtHargaOmstarLokomotif��$��1��$
��Left=�$��23��$��	0,293,0,0q�$

 Wrap=�$	��Top=�$	��253��$ Right=��� -�   $#	 txtProyeksiSavingBBMLokomotif��$��1��$
��Left=�$��23��$��	0,315,0,0q�$

 Wrap=�$	��Top=�$	��253��$ Right=��� -�   $%	 txtSavingCustomerTahunLokomotif��$��1��$
��Left=�$��23��$��	0,371,0,0q�$

 Wrap=�$	��Top=�$	��253��$ Right=����	#FFD4D4D4 . �� -�   $	 txtHargaBBMLokomotif��$��1��$
��Left=�$��23��$��	0,393,0,0q�$

 Wrap=�$	��Top=�$	��253��$ Right=��� -�   $*	 $txtGrossSavingCustomerTahunLokomotif��$��1��$
��Left=�$��23��$��	0,415,0,0q�$

 Wrap=�$	��Top=�$	��253��$ Right=����	#FFD4D4D4 . �� -�   $#	 txtHargaPemakaianDX1Lokomotif��$��1��$
��Left=�$��23��$��	0,437,0,0q�$

 Wrap=�$	��Top=�$	��253��$ Right=����	#FFD4D4D4 . �� -�   $(	 "txtNetSavingCustomerTahunLokomotif��$��1��$
��Left=�$��23��$��	0,459,0,0q�$

 Wrap=�$	��Top=�$	��253��$ Right=����	#FFD4D4D4 . �� $��SIMULASI LOKOMOTIF��$��1��$��
183,65,0,0q�$	��Top=�$��2��$	��141��$
��Bold"�$
��Left=��� $
��UNIT��$
��Left=�$��0,96,0,0q�$	��Top=�$��22��$	��167��$��9(�$��2���� $��MW��$
��Left=�$��	0,118,0,0q�$	��Top=�$��22��$	��167��$��9(�$��2���� $��L/KWh��$
��Left=�$��	0,140,0,0q�$	��Top=�$��22��$	��167��$��9(�$��2���� $@��:%(Karena Gangguan, Pemeliharaan, Stop Boarding di Stasiun)��$
��Left=�$��	0,162,0,0q�$	��Top=�$��22��$	��257��$��9(�$��2��$��2���� $��LITER��$
��Left=�$��	0,184,0,0q�$	��Top=�$��22��$	��167��$��9(�$��2���� $��LITER��$
��Left=�$��	0,205,0,0q�$	��Top=�$��22��$	��167��$��9(�$��2���� $��RASIO 1:1280��$
��Left=�$��	0,228,0,0q�$	��Top=�$��22��$	��167��$��9(�$��2���� $��LITER��$
��Left=�$��	0,250,0,0q�$	��Top=�$��22��$	��167��$��9(�$��2���� $
��DRUM��$
��Left=�$��	0,272,0,0q�$	��Top=�$��22��$	��167��$��9(�$��2���� $��RP��$
��Left=�$��	0,294,0,0q�$	��Top=�$��22��$	��167��$��9(�$��2���� $��LITER��$
��Left=�$��	0,372,0,0q�$	��Top=�$��22��$	��167��$��9(�$��2���� $��RP/LITER��$
��Left=�$��	0,394,0,0q�$	��Top=�$��22��$	��167��$��9(�$��2���� $��RP��$
��Left=�$��	0,416,0,0q�$	��Top=�$��22��$	��167��$��9(�$��2���� $��RP��$
��Left=�$��	0,438,0,0q�$	��Top=�$��22��$	��167��$��9(�$��2���� $��RP��$
��Left=�$��	0,460,0,0q�$	��Top=�$��22��$	��167��$��9(�$��2���� $����Neither Seller nor the Company, nor any Person on behalf of either of them, makes or has made, and Seller expressly disclaims, any direct or indirect representation of warranty with respect to the accuracy  or completeness of any information, 
written oral or in any other format, which has been made available, or is made available.��$
��Left=�$��	0,505,0,0q�$	��Top=�$	��559��$��5(�$��3���� $��%��$
��Left=�$��	0,316,0,0q�$	��Top=�$��22��$	��167��$��9(�$��2���� -�   $ btnResetLokomotif��$��Reset��$��3��$
��Left=�$��	0,462,0,0q�$	��Top=�$��75���� $��v 1.0��$��3��$
��Left=�$��229,509,0,0q�$	��Top=�$��7(��� -�   $ btnExportLokomotif��$��Export��$��3��$
��Left=�$��129,462,0,0q�$	��Top=�$��75���� $��332,11,403,572q�$��
header.bmp��$
��None=�$��2��$��Center=�$��Center=�$��3�� V� .~��� $	 0.7Q�$	 0.7Q��� �� T� 