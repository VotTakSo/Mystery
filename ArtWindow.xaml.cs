﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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

namespace Mystery
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class ArtWindow : Window
    {
        public ArtWindow()
        {

            InitializeComponent();
        }

        static string artFon = "pack://application:,,,/Resources/Artefacts/test.jpg";

        public string weaponImg = artFon;
        public string shieldImg = artFon;
        public string cloackImg = artFon;
        public string amuletImg = artFon;
        public string bootsImg = artFon;
        public string ringImg = artFon;
        public string runeImg = artFon;

        public string weaponElement;
        public string shieldElement;
        public string bootsElement;
        public string runesElement;

        public int weaponNumber;
        public int shieldNumber;
        public int ringNumber;
        public int amuletNumber;
        public int runeNumber;

        public bool weaponFlag = false;
        public bool shieldFlag = false;
        public bool cloackFlag = false;
        public bool amuletFlag = false;
        public bool bootsFlag  = false;
        public bool ringFlag   = false;
        public bool runeFlag = false;


        //******************************Загрузка изображений******************************//
        public void LoadImage(Image i, string s)
        {
            Uri uri = new Uri(s);
            BitmapImage bitmap = new BitmapImage(uri);
            i.Source = bitmap;
        }

        //*************************Изображения артефактов*********************************//
        string fireRuneImg = "pack://application:,,,/Resources/Artefacts/Runes/fireRune.jpg";
        string windRuneImg = "pack://application:,,,/Resources/Artefacts/Runes/windRune.jpg";
        string waterRuneImg = "pack://application:,,,/Resources/Artefacts/Runes/waterRune.jpg";
        string earthRuneImg = "pack://application:,,,/Resources/Artefacts/Runes/earthRune.jpg";
        string deathRuneImg = "pack://application:,,,/Resources/Artefacts/Runes/dearhRune.jpg";

        string potionImg = "pack://application:,,,/Resources/Artefacts/Runes/potion.jpg";

        string healImg = "pack://application:,,,/Resources/Artefacts/Runes/heal.jpg";

        string fireBowImg = "pack://application:,,,/Resources/Artefacts/Weapon/Bow/FireBow.jpg";
        string windBowImg = "pack://application:,,,/Resources/Artefacts/Weapon/Bow/WindBow.jpg";
        string waterBowImg = "pack://application:,,,/Resources/Artefacts/Weapon/Bow/WaterBow.jpg";
        string earthBowImg = "pack://application:,,,/Resources/Artefacts/Weapon/Bow/EarthBow.jpg";
        string deathBowImg = "pack://application:,,,/Resources/Artefacts/Weapon/Bow/DeathBow.jpg";

        string fireSplinterImg = "pack://application:,,,/Resources/Artefacts/Weapon/Splinter/FireSplinter.jpg";
        string windSplinterImg = "pack://application:,,,/Resources/Artefacts/Weapon/Splinter/WaterSplinter.jpg";
        string waterSplinterImg = "pack://application:,,,/Resources/Artefacts/Weapon/Splinter/WindSplinter.jpg";
        string earthSplinterImg = "pack://application:,,,/Resources/Artefacts/Weapon/Splinter/EarthSplinter.jpg";
        string dethSplinterImg = "pack://application:,,,/Resources/Artefacts/Weapon/Splinter/DeathSplinter.jpg";

        string cloackOfVipersImg= "pack://application:,,,/Resources/Artefacts/Cloack/cloack.jpg";

        string orksRingImg = "pack://application:,,,/Resources/Artefacts/Ring/OrksRing.jpg";

        string crossImg = "pack://application:,,,/Resources/Artefacts/Amulet/cross.jpg";

        string orksShieldImg = "pack://application:,,,/Resources/Artefacts/Shields/OrksShield.jpg";

        string fireShieldImg = "pack://application:,,,/Resources/Artefacts/Shields/Shield/FireShield.jpg";
        string windShieldImg = "pack://application:,,,/Resources/Artefacts/Shields/Shield/WindShield.jpg";
        string waterShieldImg = "pack://application:,,,/Resources/Artefacts/Shields/Shield/WaterShield.jpg";
        string earthShieldImg = "pack://application:,,,/Resources/Artefacts/Shields/Shield/EarthShield.jpg";
        string deathShieldImg = "pack://application:,,,/Resources/Artefacts/Shields/Shield/DeathShield.jpg";

        string bigFireShieldImg = "pack://application:,,,/Resources/Artefacts/Shields/BigShield/BigFireShield.jpg";
        string bigWindShieldImg = "pack://application:,,,/Resources/Artefacts/Shields/BigShield/BigWindShield.jpg";
        string bigWaterShieldImg = "pack://application:,,,/Resources/Artefacts/Shields/BigShield/BigWaterShield.jpg";
        string bigEarthShieldImg = "pack://application:,,,/Resources/Artefacts/Shields/BigShield/BigEarthShield.jpg";
        string bigDeathShieldImg = "pack://application:,,,/Resources/Artefacts/Shields/BigShield/BigDeathShield.jpg";

        string fireBootsImg = "pack://application:,,,/Resources/Artefacts/Boots/FireBoots.jpg";
        string windBootsImg = "pack://application:,,,/Resources/Artefacts/Boots/WindBoots.jpg";
        string waterBootsImg = "pack://application:,,,/Resources/Artefacts/Boots/WaterBoots.jpg";
        string earthBootsImg = "pack://application:,,,/Resources/Artefacts/Boots/EarthBoots.jpg";
        string deathBootsImg = "pack://application:,,,/Resources/Artefacts/Boots/DeathBoots.jpg";
        //*****************************Оружие*****************************************//
        void Bow()
        {
            weaponFlag = true;
            weaponNumber = 1;
            WeaponButton.Visibility = Visibility.Visible;
            LoadImage(WeaponImage, weaponImg);
        }
        private void FireBow_Click(object sender, RoutedEventArgs e)
        {
            weaponElement = "fire";
            weaponImg = fireBowImg;
            Bow();

        }
        private void WindBow_Click(object sender, RoutedEventArgs e)
        {
            weaponElement = "wind";
            weaponImg = windBowImg;
            Bow();

        }
        private void WaterBow_Click(object sender, RoutedEventArgs e)
        {
            weaponElement = "water";
            weaponImg = waterBowImg;
            Bow();

        }
        private void EarthBow_Click(object sender, RoutedEventArgs e)
        {
            weaponElement = "earth";
            weaponImg = earthBowImg;
            Bow();

        }
        private void DeathBow_Click(object sender, RoutedEventArgs e)
        {
            weaponElement = "death";
            weaponImg = deathBowImg;
            Bow();

        }
        void Splinter()
        {
            weaponFlag = true;
            weaponNumber = 2;
            WeaponButton.Visibility = Visibility.Visible;
            LoadImage(WeaponImage, weaponImg);

        }
        private void FireSplinter_Click(object sender, RoutedEventArgs e)
        {
            weaponElement = "fire";
            weaponImg = fireSplinterImg;
            Splinter();
        }
        private void WindSplinter_Click(object sender, RoutedEventArgs e)
        {
            weaponElement = "wind";
            weaponImg = windSplinterImg;
            Splinter();
        }
        private void WaterSplinter_Click(object sender, RoutedEventArgs e)
        {
            weaponElement = "water";
            weaponImg = waterSplinterImg;
            Splinter();
        }
        private void EarthSplinter_Click(object sender, RoutedEventArgs e)
        {
            weaponElement = "earth";
            weaponImg = earthSplinterImg;
            Splinter();
        }
        private void DeathSplinter_Click(object sender, RoutedEventArgs e)
        {
            weaponElement = "death";
            weaponImg = dethSplinterImg;
            Splinter();
        }
        private void Weapon_Click(object sender, RoutedEventArgs e)
        {
            weaponFlag = false;
            weaponNumber = 0;
            weaponElement = null;
            WeaponButton.Visibility = Visibility.Hidden;
            weaponImg = artFon;
            LoadImage(WeaponImage, weaponImg);

        }
        //***********************************Щиты******************************************************//
        private void OrksShield_Click(object sender, RoutedEventArgs e)
        {
            shieldElement = "fire";
            shieldImg = orksShieldImg;
            
            shieldFlag = true;
            shieldNumber = 3;
            ShieldButton.Visibility = Visibility.Visible;
            LoadImage(ShieldImage, shieldImg);

        }
        //*********************Малые щиты**********************************************//
        void shield()
        {
            shieldFlag = true;
            shieldNumber = 1;
            ShieldButton.Visibility = Visibility.Visible;
            LoadImage(ShieldImage, shieldImg);
        }
        private void FireShield_Click(object sender, RoutedEventArgs e)
        {
            shieldElement = "fire";
            shieldImg = fireShieldImg;
            shield();
            
        }
        private void WindShield_Click(object sender, RoutedEventArgs e)
        {
            shieldElement = "wind";
            shieldImg = windShieldImg;
            shield();

        }
        private void WaterShield_Click(object sender, RoutedEventArgs e)
        {
            shieldElement = "water";
            shieldImg = waterShieldImg;
            shield();

        }
        private void EarthShield_Click(object sender, RoutedEventArgs e)
        {
            shieldElement = "earth";
            shieldImg = earthShieldImg;
            shield();

        }
        private void DeathShield_Click(object sender, RoutedEventArgs e)
        {
            shieldElement = "death";
            shieldImg = deathShieldImg;
            shield();

        }
        //********************Большие щиты*******************************//
        void BigShield()
        {
            shieldFlag = true;
            shieldNumber = 2;
            ShieldButton.Visibility = Visibility.Visible;
            LoadImage(ShieldImage, shieldImg);
        }
        private void BigFireShield_Click(object sender, RoutedEventArgs e)
        {
            shieldElement = "fire";
            shieldImg = bigFireShieldImg;
            BigShield();

        }
        private void BigWindShield_Click(object sender, RoutedEventArgs e)
        {
            shieldElement = "wind";
            shieldImg = bigWindShieldImg;
            BigShield();

        }
        private void BigWaterShield_Click(object sender, RoutedEventArgs e)
        {
            shieldElement = "water";
            shieldImg = bigWaterShieldImg;
            BigShield();

        }
        private void BigEarthShield_Click(object sender, RoutedEventArgs e)
        {
            shieldElement = "earth";
            shieldImg = bigEarthShieldImg;
            BigShield();

        }
        private void BigDeathShield_Click(object sender, RoutedEventArgs e)
        {
            shieldElement = "death";
            shieldImg = bigDeathShieldImg;
            BigShield();

        }
        //Убрать щит
        private void Shield_Click(object sender, RoutedEventArgs e)
        {
            shieldFlag = false;
            shieldNumber = 0;
            shieldElement = null;
            ShieldButton.Visibility = Visibility.Hidden;
            //FireBow.IsEnabled = false;
            shieldImg = artFon;
            LoadImage(ShieldImage, shieldImg);
        }

        //********************************************************************************************//
        private void CloackOfVipers_Click(object sender, RoutedEventArgs e)
        {
            cloackImg = cloackOfVipersImg;
            cloackFlag = true;
            CloackButton.Visibility = Visibility.Visible;
            LoadImage(CloackImage, cloackImg);
        }
        private void Cloack_Click(object sender, RoutedEventArgs e)
        {
            cloackFlag = false;
            CloackButton.Visibility = Visibility.Hidden;
            cloackImg = artFon;
            LoadImage(CloackImage, cloackImg);
        }
        //*******************************************************************************************//
        private void Cross_Click(object sender, RoutedEventArgs e)
        {
            amuletImg = crossImg;
            amuletFlag = true;
            amuletNumber = 1;
            AmuletButton.Visibility = Visibility.Visible;
            LoadImage(AmuletImage, amuletImg);
        }
        private void Amulet_Click(object sender, RoutedEventArgs e)
        {
            amuletFlag = false;
            amuletNumber = 0;
            AmuletButton.Visibility = Visibility.Hidden;
            amuletImg = artFon;
            LoadImage(AmuletImage, amuletImg);
        }
        //*******************************************************************************************//
        private void OrksRing_Click(object sender, RoutedEventArgs e)
        {
            ringImg = orksRingImg;
            ringFlag = true;
            ringNumber = 1;
            RingButton.Visibility = Visibility.Visible;
            LoadImage(RingImage, ringImg);
        }
        private void Ring_Click(object sender, RoutedEventArgs e)
        {
            ringFlag = false;
            ringNumber = 0;
            RingButton.Visibility = Visibility.Hidden;
            ringImg = artFon;
            LoadImage(RingImage, ringImg);
        }
        //*******************************************************************************************//
        void boots()
        {
            bootsFlag = true;
            BootsButton.Visibility = Visibility.Visible;
            LoadImage(BootsImage, bootsImg);
        }
        private void FireBoots_Click(object sender, RoutedEventArgs e)
        {
            bootsElement = "fire";
            bootsImg = fireBootsImg;
            boots();
        }
        private void WindBoots_Click(object sender, RoutedEventArgs e)
        {
            bootsElement = "wind";
            bootsImg = windBootsImg;
            boots();
        }
        private void WaterBoots_Click(object sender, RoutedEventArgs e)
        {
            bootsElement = "water";
            bootsImg = waterBootsImg;
            boots();
        }
        private void EarthBoots_Click(object sender, RoutedEventArgs e)
        {
            bootsElement = "earth";
            bootsImg = earthBootsImg;
            boots();
        }
        private void DeathBoots_Click(object sender, RoutedEventArgs e)
        {
            bootsElement = "death";
            bootsImg = deathBootsImg;
            boots();
        }
        private void Boots_Click(object sender, RoutedEventArgs e)
        {
            bootsFlag = false;
            bootsElement = null;
            BootsButton.Visibility = Visibility.Hidden;
            bootsImg = artFon;
            LoadImage(BootsImage, bootsImg);
        }
        //******************************************************************************************//

        //******************************************************************************************//
        bool end = false;

        public bool returnEnd()
        {
            return end;
        }
        private void Go_Click(object sender, RoutedEventArgs e)
        {
            end = true;
            this.Close();
        }


    }
}
