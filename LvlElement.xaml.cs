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
using System.Windows.Shapes;

namespace Mystery
{
    /// <summary>
    /// Логика взаимодействия для LvlElement.xaml
    /// </summary>
    public partial class LvlElement : Window
    {
        public LvlElement()
        {
            InitializeComponent();
        }
        public string NameElement = "";
        public int lvl = 0;
        //******************************************************************************************//
        private void FireRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            Hidden();
            NameElement = "fire";
            FireLvl.Visibility = Visibility.Visible;

        }
        private void WaterRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            Hidden();
            NameElement = "water";
            WaterLvl.Visibility = Visibility.Visible;
        }
        private void WindRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            Hidden();
            NameElement = "wind";
            WindLvl.Visibility = Visibility.Visible;
        }
        private void EarthRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            Hidden();
            NameElement = "earth";
            EarthLvl.Visibility = Visibility.Visible;
        }
        private void DeathRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            Hidden();
            NameElement = "death";
            DeathLvl.Visibility = Visibility.Visible;
        }
        //******************************************************************************************//


        //******************************************************************************************//
        bool end = false;

        public bool returnEnd()
        {
            return end;
        }
        private void Next_Click(object sender, RoutedEventArgs e)
        {
            end = true;
            this.Close();
        }

        void Hidden()
        {
            FireLvl.Visibility = Visibility.Hidden;
            WindLvl.Visibility = Visibility.Hidden;
            WaterLvl.Visibility = Visibility.Hidden;
            EarthLvl.Visibility = Visibility.Hidden;
            DeathLvl.Visibility = Visibility.Hidden;
        }

        private void Lvl_SelectionChanged(object sender, RoutedEventArgs e)
        {
            ComboBox com = (ComboBox)sender;
            ComboBoxItem sel = (ComboBoxItem)com.SelectedItem;
            lvl = Convert.ToInt32(sel.Content);
           
            switch (lvl)
            {
                case 9:
                    {
                        switch (NameElement)
                        {
                            case "fire":
                                {
                                    FireSkillslvl9.Visibility = Visibility.Visible;
                                    break;
                                }
                            case "wind":
                                {
                                    WindSkillslvl9.Visibility = Visibility.Visible;
                                    break;
                                }
                            case "water":
                                {
                                    WaterSkillslvl9.Visibility = Visibility.Visible;
                                    break;
                                }
                            case "earth":
                                {
                                    EarthSkillslvl9.Visibility = Visibility.Visible;
                                    break;
                                }
                            case "death":
                                {
                                    DeathSkillslvl9.Visibility = Visibility.Visible;
                                    break;
                                }
                        }
                        break;
                    }
                case 14:
                    {
                        switch (NameElement)
                        {
                            case "fire":
                                {
                                    FireSkillslvl14.Visibility = Visibility.Visible;
                                    break;
                                }
                            case "wind":
                                {
                                    WindSkillslvl14.Visibility = Visibility.Visible;
                                    break;
                                }
                            case "water":
                                {
                                    WaterSkillslvl14.Visibility = Visibility.Visible;
                                    break;
                                }
                            case "earth":
                                {
                                    EarthSkillslvl14.Visibility = Visibility.Visible;
                                    break;
                                }
                            case "death":
                                {
                                    DeathSkillslvl14.Visibility = Visibility.Visible;
                                    break;
                                }
                        }
                        break;
                    }
            }
        }


    }
}
