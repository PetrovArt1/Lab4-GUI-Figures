   M S B A M L   `   `   `  ����?  ;View, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:ViewView  5   	       View.NewFigure   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   $localclr-namespace:View     5   	     � Title$  
New figure��5   	   $��242.394��5	   	   $��521.945��5
   	   ���#E6E6FA � 
ResizeMode$ NoResize=�5   	   .��5      � $��0,0,4,3q�6   .+�5   
   �� -   5        ���#0030ff
�������$
��Left=�5      $��
19,116,0,0q�5      $	��Top=�5      $	��153��5      .��5      �� 
�������$��Ok��5      $��18(�5      $
��Bold"�5       J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5         ShadowDepth$	 0.5Q�6'      
BlurRadius$ 5Q�5   '      Color$ Black��5   '   5      5       �� 5!   
   -   5        ���#a0a020
�������$
��Left=�5#      $��
19,162,0,0q�5$      $	��Top=�5%      $	��153��5&      .��5(      �� 
�������$��Cancel��5)      $��18(�5*      $
��Bold"�5+       5,        5-      $	 0.5Q�6'   $ 5Q�5.   '   $ Black��5/   '   51      52      �� 53   
   -   5         ��Name$ RectangleCheck��54      $��	Rectangle��53      $
��Left=�55      $��	19,41,0,0q�56      $	��Top=�57      $	��101��5:      $��20��5;      �� 5<   
   -   5        $ TriangleCheck��5=      $��Triangle��5<      $
��Left=�5>      $��	19,66,0,0q�5?      $	��Top=�5@      $	��101��5C      $��20��5D      �� 5E   
   -   5        $ CircleCheck��5F      $��Circle��5E      $
��Left=�5G      $��	19,91,0,0q�5H      $	��Top=�5I      $	��101��5L      $��20��5M      �� 5N   
   -   5        $��labelCreatedFigure��5O      $��Add figure, please.��5N      $��19,5,0,0q�5P      $��13(�5Q       J� RenderTransformOrigin$ 0.62,-3.429&�5R      $
��Left=�5S      $	��474��5T      $��31��5U      $	��Top=�5V      &   System.Windows.Controls.DataGrid  5W   
   -   5        $��dataGridWithParameters��5W      $
��Left=�5X      $	��149��5Y      $��
193,41,0,0q�5Z      $	��Top=�5[      $	��300��5\         CanUserAddRows .  	   AutoGenerateColumns	 . 5_      5`      5a      