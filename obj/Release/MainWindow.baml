   M S B A M L   `   `   `  ����   Mystery    Mystery.MainWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006       � Title$  
MainWindow��$	��700��$
��1000��.��� .+�� .+��� -    ��Name$ 	PlayerAva��$
��Left=�$	��100��$��884,227,0,0q�$	��Top=�$	��100���� -   $ EnemyAva��$��Resources/photo.jpg��$
��Left=�$	��100��$��	0,227,0,0q�$	��Top=�$	��100��	� -    	�Name$ 
fireButton��$��
Огонь��$
��Left=�$��100,449,0,0q�$	��Top=�$��21��	� -   $ 
windButton��$��Воздух��$
��Left=�$��250,449,0,0q�$	��Top=�$��21��	� -   $ waterButton��$��Вода��$
��Left=�$��400,449,0,0q�$	��Top=�$��21��	� -   $ earthButton��$��
Земля��$
��Left=�$��550,449,0,0q�$	��Top=�$��21��	� -   $ 
dethButton��$��Смерть��$
��Left=�$��700,449,0,0q�$	��Top=�$��21��	� -   $ neitralButton��$��Нейтральная��$
��Left=�$��850,449,0,0q�$	��Top=�$��21���� -	    ��Name$ fireMana��$��Label��$
��Left=�$��
60,441,0,0q�$	��Top=�$��36���� -
   $ windMana��$��Label��$
��Left=�$��227,441,0,0q�$	��Top=�$��36���� -   $ 	waterMana��$��Label��$
��Left=�$��373,441,0,0q�$	��Top=�$��36���� -   $ 	earthMana��$��Label��$
��Left=�$��522,441,0,0q�$	��Top=�$��36���� -   $ dethMana��$��Label��$
��Left=�$��683,441,0,0q�$	��Top=�$��36���� -   $ fireEnemyMana��$��Label��$
��Left=�$��
60,100,0,0q�$	��Top=�$��36���� -   $ windEnemyMana��$��Label��$
��Left=�$��227,100,0,0q�$	��Top=�$��36���� -   $ waterEnemyMana��$��Label��$
��Left=�$��373,100,0,0q�$	��Top=�$��36���� -   $ earthEnemyMana��$��Label��$
��Left=�$��522,100,0,0q�$	��Top=�$��36���� -   $ dethEnemyMana��$��Label��$
��Left=�$��683,100,0,0q�$	��Top=�$��36��	� -   $ fireEnemyButton��$��
Огонь��$
��Left=�$��100,112,0,0q�$	��Top=�	� -   $ windEnemyButton��$��Воздух��$
��Left=�$��250,112,0,0q�$	��Top=�	� -   $ waterEnemyButton��$��Вода��$
��Left=�$��400,112,0,0q�$	��Top=�	� -   $ earthEnemyButton��$��
Земля��$
��Left=�$��550,112,0,0q�$	��Top=�	� -   $ dethEnemyButton��$��Смерть��$
��Left=�$��700,112,0,0q�$	��Top=�	� -   $ neitralEnemyButton��$��Нейтральная��$
��Left=�$��850,112,0,0q�$	��Top=��� -   $ Hp��$��Label��$
��Left=�$��
10,194,0,0q�$	��Top=��� -   $ EnemyHp��$��Label��$
��Left=�$��900,194,0,0q�$	��Top=��� -   $	 Hod��$��Label��$
��Left=�$��
465,27,0,0q�$	��Top=�� -    �Name$ fireGrid��$��100,500,100,30q� � RowDefinitions ��  � ColumnDefinitions �� �� �� �� �� �� �� �� .+��� -   $��Button��$��0��$��0��$��0,0,0,0q�����  �� ImageSource$ Resources/Goblin.jpg���� -   $��Button��$��1��$��0��$��0,0,0,0q��� -   $��Button��$��2��$��0��$��0,0,0,0q�� -    $ WindGrid��$��100,500,100,30q� ��  �� �� �� �� �� �� �� �� .+��� -!   $��Button��$��0��$��0��$��0,0,0,0q����� $ Resources/photo.jpg���� -"   $��Button��$��1��$��0��$��0,0,0,0q��� -#   $��Button��$��2��$��0��$��0,0,0,0q�� -$   $ 	WaterGrid��$��100,500,100,30q� ��  �� �� �� �� �� �� �� �� .+��� -%   $��Button��$��0��$��0��$��0,0,0,0q����� $ Resources/photo.jpg���� -&   $��Button��$��1��$��0��$��0,0,0,0q��� -'   $��Button��$��2��$��0��$��0,0,0,0q�� -(   $ 	EarthGrid��$��100,500,100,30q� ��  �� �� �� �� �� �� �� �� .+��� -)   $��Button��$��0��$��0��$��0,0,0,0q����� $ Resources/photo.jpg���� -*   $��Button��$��1��$��0��$��0,0,0,0q��� -+   $��Button��$��2��$��0��$��0,0,0,0q�� -,   $ DethGrid��$��100,500,100,30q� ��  �� �� �� �� �� �� �� �� .+��� --   $��Button��$��0��$��0��$��0,0,0,0q����� $ Resources/photo.jpg���� -.   $��Button��$��1��$��0��$��0,0,0,0q��� -/   $��Button��$��2��$��0��$��0,0,0,0q�� -0   $ NeitralGrid��$��100,500,100,30q� ��  �� �� �� �� �� �� �� �� .+��� -1   $��Button��$��0��$��0��$��0,0,0,0q����� $ Resources/Goblin.jpg���� -2   $��Button��$��1��$��0��$��0,0,0,0q��� -3   $��Button��$��2��$��0��$��0,0,0,0q�� -4   $ poleGrid��$��200,140,200,230q� �� ��  �� �� �� �� �� .+��� -5   $ pole1Img��$��Resources/fon.jpg��$��0��$��0���� -6   $ pole2Img��$��Resources/fon.jpg��$��1��$��0���� -7   $ pole3Img��$��Resources/fon.jpg��$��2��$��0���� -8   $ pole4Img��$��Resources/fon.jpg��$��3��$��0���� -9   $ pole5Img��$��Resources/fon.jpg��$��4��$��0���� -:   $ pole6Img��$��Resources/fon.jpg��$��0��$��1���� -;   $ pole7Img��$��Resources/fon.jpg��$��1��$��1���� -<   $ pole8Img��$��Resources/fon.jpg��$��2��$��1���� -=   $ pole9Img��$��Resources/fon.jpg��$��3��$��1���� ->   $ 	pole10Img��$��Resources/fon.jpg��$��4��$��1���� -?    ��Name$ pole1��$��0������ $ Resources/fon.jpg���� -@   $ pole2��$��1������ $ Resources/fon.jpg���� -A   $ pole3��$��2������ $ Resources/fon.jpg���� -B   $ pole4��$��3������ $ Resources/fon.jpg���� -C   $ pole5��$��4������ $ Resources/fon.jpg���� -D   $ pole6��$��0��$��2������ $ Resources/fon.jpg���� -E   $ pole7��$��1��$��2������ $ Resources/fon.jpg���� -F   $ pole8��$��2��$��2������ $ Resources/fon.jpg���� -G   $ pole9��$��3��$��2������ $ Resources/fon.jpg���� -H   $ pole10��$��4��$��2������ $ Resources/fon.jpg��