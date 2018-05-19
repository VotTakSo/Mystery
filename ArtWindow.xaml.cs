using System;
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
        int astralPower;
        int lvl;
        public ArtWindow(string s, int AstralPower, int Lvl)
        {
            astralPower = AstralPower;
            lvl = Lvl;
            InitializeComponent();
        }

        static string artFon = "pack://application:,,,/Resources/Artefacts/test.jpg";

        int bufAmulet;
        int bufweapon;
        int bufBoots;
        int bufRune1;
        int bufRune2;
        int bufRune3;
        int bufCloack;
        int bufShield;
        int bufRing;

        public string weaponImg = artFon;
        public string shieldImg = artFon;
        public string cloackImg = artFon;
        public string amuletImg = artFon;
        public string bootsImg = artFon;
        public string ringImg = artFon;
        public string runeImg1 = artFon;
        public string runeImg2 = artFon;
        public string runeImg3 = artFon;

        public string weaponElement;
        public string shieldElement;
        public string bootsElement;
        public string runeElement1;
        public string runeElement2;
        public string runeElement3;

        public int weaponNumber;
        public int shieldNumber;
        public int ringNumber;
        public int amuletNumber;
        public int runeNumber1;
        public int runeNumber2;
        public int runeNumber3;

        public bool weaponFlag = false;
        public bool shieldFlag = false;
        public bool cloackFlag = false;
        public bool amuletFlag = false;
        public bool bootsFlag  = false;
        public bool ringFlag   = false;
        public bool runeFlag1 = false;
        public bool runeFlag2 = false;
        public bool runeFlag3 = false;

       
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
        string deathRuneImg = "pack://application:,,,/Resources/Artefacts/Runes/deathRune.jpg";

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
            astralPower += bufweapon;
            bufweapon = 3;
            if (astralPower >= bufweapon)
            {
                weaponFlag = true;
            weaponNumber = 1;
            WeaponButton.Visibility = Visibility.Visible;
            LoadImage(WeaponImage, weaponImg);
                astralPower -= bufweapon;
            }
            else
            {
                bufweapon = 0;
                weaponElement = "";
                weaponImg = artFon;
                AstralPowerError();
            }
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
            astralPower += bufweapon;
            bufweapon = 3;
            if (astralPower >= bufweapon)
            {
                weaponFlag = true;
                weaponNumber = 2;
                WeaponButton.Visibility = Visibility.Visible;
                LoadImage(WeaponImage, weaponImg);
                astralPower -= bufweapon;
            }
            else
            {
                weaponElement = "";
                weaponImg = artFon;
                AstralPowerError();
                bufweapon = 0;
            }

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
            astralPower += bufweapon;
            bufweapon = 0;
            weaponNumber = 0;
            weaponElement = null;
            WeaponButton.Visibility = Visibility.Hidden;
            weaponImg = artFon;
            LoadImage(WeaponImage, weaponImg);

        }
        //***********************************Щиты******************************************************//
        private void OrksShield_Click(object sender, RoutedEventArgs e)
        {
            astralPower += bufShield;
            bufShield = 4;
            if (astralPower >= bufShield)
            {
                shieldElement = "fire";
                shieldImg = orksShieldImg;

                shieldFlag = true;
                shieldNumber = 3;
                ShieldButton.Visibility = Visibility.Visible;
                LoadImage(ShieldImage, shieldImg);
                astralPower -= bufShield;
            }
            else
            {
                bufShield = 0;
                AstralPowerError();
            }
        }
        //*********************Малые щиты**********************************************//
        void shield()
        {
            astralPower += bufShield;
            bufShield = 3;
            if (astralPower >= bufShield)
            {
                shieldFlag = true;
                shieldNumber = 1;
                ShieldButton.Visibility = Visibility.Visible;
                LoadImage(ShieldImage, shieldImg);
                astralPower -= bufShield;
            }
            else
            {
                shieldElement = "";
                shieldImg = artFon;
                AstralPowerError();
                bufShield = 0;
            }
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
            if (lvl > 13)
            {
                astralPower += bufShield;
                bufShield = 6;
                if (astralPower >= bufShield)
                {
                    shieldFlag = true;
                    shieldNumber = 2;
                    ShieldButton.Visibility = Visibility.Visible;
                    LoadImage(ShieldImage, shieldImg);
                    astralPower -= bufShield;
                }
                else
                {
                    shieldElement = "";
                    shieldImg = artFon;
                    AstralPowerError();
                    bufShield = 0;
                }
            }
            else
            {
                shieldElement = "";
                shieldImg = artFon;
                LvlError();
                bufShield = 0;
            }
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
            astralPower += bufShield;
            bufShield = 0;
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
            if (lvl > 12)
            {
                astralPower += bufCloack;
                bufCloack = 5;
                if (astralPower >= bufCloack)
                {
                    cloackImg = cloackOfVipersImg;
                    cloackFlag = true;
                    CloackButton.Visibility = Visibility.Visible;
                    LoadImage(CloackImage, cloackImg);
                    astralPower -= bufCloack;
                }
                else
                {
                    AstralPowerError();
                    bufCloack = 0;
                }
            }
            else
            {
                shieldElement = "";
                shieldImg = artFon;
                LvlError();
                bufShield = 0;
            }
        }
        private void Cloack_Click(object sender, RoutedEventArgs e)
        {
            cloackFlag = false;
            astralPower += bufCloack;
            bufCloack = 0;
            CloackButton.Visibility = Visibility.Hidden;
            cloackImg = artFon;
            LoadImage(CloackImage, cloackImg);
        }
        //*******************************************************************************************//
        private void Cross_Click(object sender, RoutedEventArgs e)
        {
            astralPower += bufAmulet;
            bufAmulet = 2;
            if (astralPower >= bufAmulet)
            {
                amuletImg = crossImg;
                amuletFlag = true;
                amuletNumber = 1;
                AmuletButton.Visibility = Visibility.Visible;
                LoadImage(AmuletImage, amuletImg);
                astralPower -= bufAmulet;
            }
            else
            {
                AstralPowerError();
                bufAmulet = 0;
            }
        }
        private void Amulet_Click(object sender, RoutedEventArgs e)
        {
            amuletFlag = false;
            astralPower += bufAmulet;
            bufAmulet = 0;
            amuletNumber = 0;
            AmuletButton.Visibility = Visibility.Hidden;
            amuletImg = artFon;
            LoadImage(AmuletImage, amuletImg);
        }
        //*******************************************************************************************//
        private void OrksRing_Click(object sender, RoutedEventArgs e)
        {
            if (lvl > 12)
            {
                astralPower += bufRing;
                bufRing = 2;
                if (astralPower >= bufRing)
                {
                    ringImg = orksRingImg;
                    ringFlag = true;
                    ringNumber = 1;
                    RingButton.Visibility = Visibility.Visible;
                    LoadImage(RingImage, ringImg);
                    astralPower -= bufRing;
                }
                else
                {
                    AstralPowerError();
                    bufRing = 0;
                }
            }
            else
            {
                shieldElement = "";
                shieldImg = artFon;
                LvlError();
                bufShield = 0;
            }
        }
        private void Ring_Click(object sender, RoutedEventArgs e)
        {
            ringFlag = false;
            astralPower += bufRing;
            bufRing = 0;
            ringNumber = 0;
            RingButton.Visibility = Visibility.Hidden;
            ringImg = artFon;
            LoadImage(RingImage, ringImg);
        }
        //*******************************************************************************************//
        void boots()
        {
            astralPower += bufBoots;
            bufBoots = 3;
            if (astralPower >= bufBoots)
            {
                bootsFlag = true;
                BootsButton.Visibility = Visibility.Visible;
                LoadImage(BootsImage, bootsImg);
                astralPower -= bufBoots;
            }
            else
            {
                bootsElement = "";
                bootsImg = artFon;
                AstralPowerError();
                bufBoots = 0;
            }
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
            astralPower += bufBoots;
            bufBoots = 0;
            bootsElement = null;
            BootsButton.Visibility = Visibility.Hidden;
            bootsImg = artFon;
            LoadImage(BootsImage, bootsImg);
        }
        //******************************************************************************************//
        void rune()
        {

            bootsFlag = true;
            BootsButton.Visibility = Visibility.Visible;
            LoadImage(Rune1Image, runeImg1);
        }
        void RunPos3(string element, string img, int ap, int rn)
        {
            astralPower += bufRune3;
            bufRune3 = ap;
            if (astralPower >= bufRune3)
            {
                runeFlag3 = true;
                RuneSlot3Button.Visibility = Visibility.Visible;
                runeElement3 = element;
                runeImg3 = img;
                LoadImage(Rune3Image, runeImg3);
                runeNumber3 = rn;
                astralPower -= bufRune3;
            }
            else
            {
                AstralPowerError();
                bufRune3 = 0;
            }
        }
        void RunPos2(string element, string img, int ap, int rn)
        {
            astralPower += bufRune2;
            bufRune2 = ap;
            if (astralPower >= bufRune2)
            {
                runeFlag2 = true;
                RuneSlot2Button.Visibility = Visibility.Visible;
                runeElement2 = element;
                runeImg2 = img;
                LoadImage(Rune2Image, runeImg2);
                runeNumber2 = rn;
                astralPower -= bufRune2;
            }
            else
            {
                AstralPowerError();
                bufRune2 = 0;
            }
        }
        void RunPos1(string element, string img, int ap, int rn)
        {
            astralPower += bufRune1;
            bufRune1 = ap;
            if (astralPower >= bufRune1)
            {
                runeFlag1 = true;
                RuneSlot1Button.Visibility = Visibility.Visible;
                runeElement1 = element;
                runeImg1 = img;
                LoadImage(Rune1Image, runeImg1);
                runeNumber1 = rn;
                astralPower-=bufRune1;
            }
            else
            {
                AstralPowerError();
                bufRune1 = 0;
            }
        }

        private void FireRune_Click(object sender, RoutedEventArgs e)
        {
            string s = "fire";
            int rn = 3;
            int ap = 1;
            if (runeFlag1)
            {
                if (runeFlag2)
                {
                    if(runeFlag3)
                    {
                        MessageBox.Show("Error");
                    }
                    else
                    {
                        RunPos3(s, fireRuneImg, ap, rn);
                       
                    }
                }
                else
                {
                    RunPos2(s, fireRuneImg, ap, rn);
                }
            }
            else
            {
                RunPos1(s, fireRuneImg, ap, rn);

            }
        }
        private void WaterRune_Click(object sender, RoutedEventArgs e)
        {
            string s = "water";
            int rn = 3;
            int ap = 1;
            if (runeFlag1)
            {
                if (runeFlag2)
                {
                    if (runeFlag3)
                    {
                        MessageBox.Show("Error");
                    }
                    else
                    {
                        RunPos3(s, waterRuneImg, ap, rn);
                    }
                }
                else
                {
                    RunPos2(s, waterRuneImg, ap, rn);
                }
            }
            else
            {
                RunPos1(s, waterRuneImg, ap, rn);
            }
        }
        private void WindRune_Click(object sender, RoutedEventArgs e)
        {
            string s = "wind";
            int rn = 3;
            int ap = 1;
            if (runeFlag1)
            {
                if (runeFlag2)
                {
                    if (runeFlag3)
                    {
                        MessageBox.Show("Error");
                    }
                    else
                    {
                        RunPos3(s, windRuneImg, ap, rn);
                    }
                }
                else
                {
                    RunPos2(s, windRuneImg, ap, rn);
                }
            }
            else
            {
                RunPos1(s, windRuneImg, ap, rn);
            }
        }
        private void EarthRune_Click(object sender, RoutedEventArgs e)
        {
            string s = "earth";
            int rn = 3;
            int ap = 1;
            if (runeFlag1)
            {
                if (runeFlag2)
                {
                    if (runeFlag3)
                    {
                        MessageBox.Show("Error");
                    }
                    else
                    {
                        RunPos3(s, earthRuneImg, ap, rn);
                    }
                }
                else
                {
                    RunPos2(s, earthRuneImg, ap, rn);
                }
            }
            else
            {

                RunPos1(s, earthRuneImg, ap, rn);
            }
        }
        private void DeathRune_Click(object sender, RoutedEventArgs e)
        {
            string s = "death";
            int rn = 3;
            int ap = 1;
            if (runeFlag1)
            {
                if (runeFlag2)
                {
                    if (runeFlag3)
                    {
                        MessageBox.Show("Error");
                    }
                    else
                    {
                        RunPos3(s, deathRuneImg, ap, rn);
                    }
                }
                else
                {
                    RunPos2(s, deathRuneImg, ap, rn);
                }
            }
            else
            {
                RunPos1(s, deathRuneImg, ap, rn);
            }
        }
        private void Potion_Click(object sender, RoutedEventArgs e)
        {
            string s = "";
            int rn = 1;
            int ap = 2;
            if (runeFlag1)
            {
                if (runeFlag2)
                {
                    if (runeFlag3)
                    {
                        MessageBox.Show("Error");
                    }
                    else
                    {
                        RunPos3(s, potionImg, ap, rn);
                    }
                }
                else
                {
                    RunPos2(s, potionImg, ap, rn);
                }
            }
            else
            {
                RunPos1(s, potionImg, ap, rn);

            }
        }
        private void Heal_Click(object sender, RoutedEventArgs e)
        {
            string s = "";
            int rn = 2;
            int ap = 1;
            if (runeFlag1)
            {
                if (runeFlag2)
                {
                    if (runeFlag3)
                    {
                        MessageBox.Show("Error");
                    }
                    else
                    {
                        RunPos3(s, healImg, ap, rn); 
                    }
                }
                else
                {
                    RunPos2(s, healImg, ap, rn);
                }
            }
            else
            {
                RunPos1(s, healImg, ap, rn);
            }
        }
        
        private void Rune1_Click(object sender, RoutedEventArgs e)
        {
            runeFlag1 = false;
            astralPower += bufRune1;
            bufRune1 = 0;
            RuneSlot1Button.Visibility = Visibility.Hidden;
            runeImg1 = artFon;
            LoadImage(Rune1Image, runeImg1);
            runeNumber1 = 0;
            runeElement1 = "";
        }
        private void Rune2_Click(object sender, RoutedEventArgs e)
        {
            runeFlag2 = false;
            astralPower += bufRune2;
            bufRune2 = 0;
            RuneSlot2Button.Visibility = Visibility.Hidden;
            runeImg2 = artFon;
            LoadImage(Rune2Image, runeImg2);
            runeNumber2 = 0;
            runeElement2 = "";
        }
        private void Rune3_Click(object sender, RoutedEventArgs e)
        {
            runeFlag3 = false;
            astralPower += bufRune3;
            bufRune3 = 0;
            RuneSlot3Button.Visibility = Visibility.Hidden;
            runeImg3 = artFon;
            LoadImage(Rune3Image, runeImg3);
            runeNumber3 = 0;
            runeElement3 = "";
        }
        //******************************************************************************************//
        bool end = false;

        void AstralPowerError()
        {
            MessageBox.Show("Недостаточно астральной силы");
        }
        void LvlError()
        {
            MessageBox.Show("Доступно с 14 уровня");
        }

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
