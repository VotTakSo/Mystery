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
        public ArtWindow()
        {

            InitializeComponent();
        }

        static string artFon = "pack://application:,,,/Resources/Artefacts/test.jpg";

        public string weaponImg = "pack://application:,,,/Resources/Artefacts/test.jpg";
        public string shieldImg = "pack://application:,,,/Resources/Artefacts/test.jpg";

        public string weaponElement;
        public string shieldElement;

        public int weaponNumber;
        public int shieldNumber;

        public bool weaponFlag = false;
        public bool shieldFlag = false;

       
//******************************Загрузка изображений******************************//
        public void LoadImage(Image i, string s)
        {
            Uri uri = new Uri(s);
            BitmapImage bitmap = new BitmapImage(uri);
            i.Source = bitmap;
        }

//*************************Изображения артефактов*********************************//
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

        string fireShieldImg = "pack://application:,,,/Resources/Artefacts/Shields/Shield/FireShield.jpg";
        string windShieldImg = "pack://application:,,,/Resources/Artefacts/Shields/Shield/WindShield.jpg";
        string waterShieldImg = "pack://application:,,,/Resources/Artefacts/Shields/Shield/WaterShield.jpg";
        string earthShieldImg = "pack://application:,,,/Resources/Artefacts/Shields/Shield/EarthShield.jpg";
        string dethShieldImg = "pack://application:,,,/Resources/Artefacts/Shields/Shield/DeathShield.jpg";

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

        private void Splinter_Click(object sender, RoutedEventArgs e)
        {
            weaponFlag = true;
            weaponNumber = 2;
            weaponElement = "death";
            WeaponButton.Visibility = Visibility.Visible;
            //FireBow.IsEnabled = false;
            weaponImg = dethSplinterImg;
            LoadImage(WeaponImage, weaponImg);
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
    //*********************Малый щит смерти**********************************************//
        private void DethShield_Click(object sender, RoutedEventArgs e)
        {
            shieldFlag = true;
            shieldNumber = 1;
            shieldElement = "death";
            ShieldButton.Visibility = Visibility.Visible;
            //FireBow.IsEnabled = false;
            shieldImg = dethShieldImg;
            LoadImage(ShieldImage, shieldImg);
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
