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
        public int Lvl = 0;
        public LvlElement()
        {
            InitializeComponent();
        }
        public LvlElement(int lvl)
        {
            Lvl = lvl;
            InitializeComponent();
        }
        public string NameElement = "";
        public int lvl = 0;
        //******************************************************************************************//
        private void FireRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            Hidden();
            NameElement = "fire";
            if (Lvl == 0) 
            FireLvl.Visibility = Visibility.Visible;
            else
            {
                Skills(Lvl);
            }
        }
        private void WaterRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            Hidden();
            NameElement = "water";
         
            if (Lvl == 0)
                WaterLvl.Visibility = Visibility.Visible;
            else
            {
                Skills(Lvl);
            }
        }
        private void WindRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            Hidden();
            NameElement = "wind";
            if (Lvl == 0)
                WindLvl.Visibility = Visibility.Visible;
            else
            {
                Skills(Lvl);
            }
        }
        private void EarthRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            Hidden();
            NameElement = "earth";
            if (Lvl == 0)
                EarthLvl.Visibility = Visibility.Visible;
            else
            {
                Skills(Lvl);
            }
        }
        private void DeathRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            Hidden();
            NameElement = "death";
            if (Lvl == 0)
                DeathLvl.Visibility = Visibility.Visible;
            else
            {
                Skills(Lvl);
            }
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
            if (skillFlag == false & elementSkillFlag == false)
            {
                MessageBox.Show("Выберите способности");
            }
            else
            {
                end = true;
                this.Close();
            }
        }

        public void Skills(int lvl)
        {
            switch (lvl)
            {
                case 9:
                    {
                        switch (NameElement)
                        {
                            case "fire":
                                {
                                    HiddenSkills();
                                    FireSkillslvl9.Visibility = Visibility.Visible;
                                    break;
                                }
                            case "wind":
                                {
                                    HiddenSkills();
                                    WindSkillslvl9.Visibility = Visibility.Visible;
                                    break;
                                }
                            case "water":
                                {
                                    HiddenSkills();
                                    WaterSkillslvl9.Visibility = Visibility.Visible;
                                    break;
                                }
                            case "earth":
                                {
                                    HiddenSkills();
                                    EarthSkillslvl9.Visibility = Visibility.Visible;
                                    break;
                                }
                            case "death":
                                {
                                    HiddenSkills();
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
                                    HiddenSkills();
                                    FireSkillslvl14.Visibility = Visibility.Visible;
                                    break;
                                }
                            case "wind":
                                {
                                    HiddenSkills();
                                    WindSkillslvl14.Visibility = Visibility.Visible;
                                    break;
                                }
                            case "water":
                                {
                                    HiddenSkills();
                                    WaterSkillslvl14.Visibility = Visibility.Visible;
                                    break;
                                }
                            case "earth":
                                {
                                    HiddenSkills();
                                    EarthSkillslvl14.Visibility = Visibility.Visible;
                                    break;
                                }
                            case "death":
                                {
                                    HiddenSkills();
                                    DeathSkillslvl14.Visibility = Visibility.Visible;
                                    break;
                                }
                        }
                        break;
                    }

            }
        }

        void Hidden()
        {
            FireLvl.Visibility = Visibility.Hidden;
            WindLvl.Visibility = Visibility.Hidden;
            WaterLvl.Visibility = Visibility.Hidden;
            EarthLvl.Visibility = Visibility.Hidden;
            DeathLvl.Visibility = Visibility.Hidden;

            FireSkillslvl9.Visibility = Visibility.Hidden;
            FireSkillslvl14.Visibility = Visibility.Hidden;
            WindSkillslvl9.Visibility = Visibility.Hidden;
            WindSkillslvl14.Visibility = Visibility.Hidden;
            WaterSkillslvl9.Visibility = Visibility.Hidden;
            WaterSkillslvl14.Visibility = Visibility.Hidden;
            EarthSkillslvl9.Visibility = Visibility.Hidden;
            EarthSkillslvl14.Visibility = Visibility.Hidden;
            DeathSkillslvl9.Visibility = Visibility.Hidden;
            DeathSkillslvl14.Visibility = Visibility.Hidden;

            skillLvl = 0;
            elementSkillLvl = 0;
            skillFlag = false;
            elementSkillFlag = false;
        }
        void HiddenSkills()
        {

            FireSkillslvl9.Visibility = Visibility.Hidden;
            FireSkillslvl14.Visibility = Visibility.Hidden;
            WindSkillslvl9.Visibility = Visibility.Hidden;
            WindSkillslvl14.Visibility = Visibility.Hidden;
            WaterSkillslvl9.Visibility = Visibility.Hidden;
            WaterSkillslvl14.Visibility = Visibility.Hidden;
            EarthSkillslvl9.Visibility = Visibility.Hidden;
            EarthSkillslvl14.Visibility = Visibility.Hidden;
            DeathSkillslvl9.Visibility = Visibility.Hidden;
            DeathSkillslvl14.Visibility = Visibility.Hidden;

            skillLvl = 0;
            elementSkillLvl = 0;
            skillFlag = false;
            elementSkillFlag = false;
        }
        private void Lvl_SelectionChanged(object sender, RoutedEventArgs e)
        {
            ComboBox com = (ComboBox)sender;
            ComboBoxItem sel = (ComboBoxItem)com.SelectedItem;
            if (Lvl == 0)
                lvl = Convert.ToInt32(sel.Content);
            else
                lvl = Lvl;
            Skills(lvl);
        }
        public bool elementSkillFlag = false;
        public int elementSkillLvl = 0;
        public bool skillFlag = false;
        public int skillLvl = 0;
        public int astralPower;
        private void Lvl9_SelectionChanged(object sender, RoutedEventArgs e)
        {
            int number;
            ComboBox com = (ComboBox)sender;
            ComboBoxItem sel = (ComboBoxItem)com.SelectedItem;
            string stringNumber = sel.Content.ToString();
            number = Convert.ToInt32(stringNumber[0].ToString());

            switch (number)
            {
                case 1:
                    {
                        elementSkillFlag = true;
                        skillFlag = false;
                        elementSkillLvl = 3;
                        astralPower = 17;
                        skillLvl = 0;
                        break;
                    }
                case 2:
                    {
                        elementSkillFlag = true;
                        skillFlag = false;
                        elementSkillLvl = 4;
                        astralPower = 15;
                        skillLvl = 0;
                        MessageBox.Show("ku");
                        break;
                    }
                case 3:
                    {
                        skillFlag = true;
                        elementSkillFlag = false;
                        skillLvl = 3;
                        astralPower = 17;
                        elementSkillLvl = 0;
                        break;
                    }
                case 4:
                    {
                        skillFlag = true;
                        elementSkillFlag = false;
                        skillLvl = 4;
                        astralPower = 15;
                        elementSkillLvl = 0;
                        break;
                    }
            }

        }
        private void Lvl14_SelectionChanged(object sender, RoutedEventArgs e)
        {
            int number;
            ComboBox com = (ComboBox)sender;
            ComboBoxItem sel = (ComboBoxItem)com.SelectedItem;
            string stringNumber = sel.Content.ToString();
            number = Convert.ToInt32(stringNumber[0].ToString());

            switch (number)
            {
                case 1:
                    {
                        elementSkillFlag = true;
                        skillFlag = false;
                        elementSkillLvl = 5;
                        astralPower = 23;
                        skillLvl = 0;
                        break;
                    }
                case 2:
                    {
                        elementSkillFlag = true;
                        skillFlag = false;
                        elementSkillLvl = 5;
                        astralPower = 17;
                        skillLvl = 3;
                        break;
                    }
                case 3:
                    {
                        skillFlag = true;
                        elementSkillFlag = false;
                        skillLvl = 5;
                        astralPower = 15;
                        elementSkillLvl = 4;
                        break;
                    }
            }

        }

    }
}
