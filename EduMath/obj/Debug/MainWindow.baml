   M S B A M L   `   `   `  ����B  >EduMath, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:EduMathEduMath  5   	   ;"clr-namespace:EduMath.UserControlsEduMath.UserControls  5   	       EduMath.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:EduMath     5   	   ;usercontrols"clr-namespace:EduMath.UserControls     5   	     � Title$  EduMath��5	   	   $	��600��6   $
��1200��6&   $	��600��63   $	��770��6C    � 	Resources 5       �� 
TargetType   ButtonStyle �� Property �� Value �� 
TargetType ��Name �� Triggers P� Property	 P� Value��%�  &	        �� 5   
   " ��6   .�5      ��  �@�OverridesDefaultStyle . 66   �� 5       � ��
 �   �6+   �� 5       � ��
 ���� 6,   �� 5       � ��$ 30(�6)   �� 5       � ��$ Arial)�6+   �� 5       � �� 5      �� 5      " ��6&   .R�5      � #��z��6   .+�5      �� $ ContentPresenter��6/   #��z��6I   $��Center=�6m   $��Center=�6�   5      5      5       5      P� 5       � {�	 . . �5      ��  � �� �	#FF3884C063   �� 5       � ��$ Normal"�63   5      P� 5        � {�	 .  . �5!      ��  � �� �	#FF0A649363   �� 5"       � ��$
 Bold"�63   5#      5%      5&      .��5(      � -   5        
 �Name$

 Grid��5(      
������  � ColumnDefinitions 5)   
   �� 5*      $	��150��6   �� 5+      �� 5,      �� 5-      �� 5.      �� 5/       � RowDefinitions 51   
   �� 52      �� 53      �� 54      �� 55      �� 56      .+�59   
   �� -   5         ��Name$ ButtonTheory��59   .   $��0��6   $��0��6!   $��Teoria��6D   #��[  6U   6z   �� 5:   
   -   5        $ ButtonExamples��5:   .   $��0��6   $��1��6!   $��
Przykłady��6F   #��[  6Z   6   �� 5;   
   -   5        $ ButtonTasks��5;   .   $��0��6   $��2��6!   $��Zadania��6C   #��[  6U   6z   �� 5<   
   -   5        $ ButtonTests��5<   .   $��0��6   $��3��6!   $��Testy��6C   #��[  6S   6x   �� 5=   
   -   5        $ ButtonProgres��5=   .   $��0��6   $��4��6!   $��Progres��6E   #��[  6W   6|   �� 5?   
   -   5         ��Name$ ContentControl��5?      $��1��6^   $��0��6n   $��5��6{   $��5��6�   $��Stretch=�6�   $��Stretch=�6�   $��Stretch=�6�   $��Stretch=�6�   ��6J   �� 6�   5@      5A      