   M S B A M L   `   `   `  ����B  >EduMath, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:EduMath.UserControlsEduMath.UserControls  5      4    .EduMath.UserControls.UserControlProgresDisplay   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      4local"clr-namespace:EduMath.UserControls     5      $	��500��5   9   .��5
      �   � ColumnDefinitions  5   
   �� 5      $
��0.5* �6   $	��400��6,   �� 5      $��0.25* �6   $��50��6-   �� 5      $��0.25* �6   $��50��6-    � RowDefinitions 5   
   �� 5      $��60 �6   �� 5      .+�5   
   �� -   5         ��Name$ TextBlockError��5      $'��!Nie można wyświetlić statystyk��6,   $��0��6R   $��3��6b   $��0��6v   $��2��6�    �� TextAlignment$ Center=�6�   $��Stretch=�6�   $��Center=�6�   
������ $��40(�6�   $y�Hidden=�6  �� 5   
   -   5        $ 
TextBlock1��5      $��Dział��6(   $ Center=�65   $��0��6L   $��1��6\   $��20(�6p   $��Center=�6~   �� 5   
   -   5        $ 
TextBlock2��5      $��Ukończone zadania��6(   $ Center=�6A   $��1��6X   $��1��6h   $��20(�6|   $
��Wrap=�6�   $��Center=�6�   �� 5   
   -   5        $ 
TextBlock3��5      $��Najlepszy wynik testu��6(   $ Center=�6E   $��2��6\   $��1��6l   $��20(�6�   $
��Wrap=�6�   $��Center=�6�   �� 5   
   -   5         ��Name$ ItemsControl1��5      
������ 
������ $��5,5,5,5q�6a   $��28(�6r   $��Arial)�6�   $��0��6�   $��1��6�   $��1��6�   $��1��6�   ��5      �� 5       �� 
TargetType" ��6   .�5      ��  �� Property � �� �� Value$ 25��6/   �� 5       � ��$ 20(�61   �� 5       � ��$ Arial)�63   �� 5       � ��
 ���� 63   �� 5       �@��TextAlignment$ Center=�66   �� 5        � {� .  62   5!      .@�5#      �� -   5        $ TextBoxSection1��5#      $��Pojęcia podstawowe��61   �� 5$      -   5        $ TextBoxSection2��5$      $��Równania i nierówności��61   �� 5%      -   5        $ TextBoxSection3��5%      $��Wyrażenia algebraiczne��61   �� 5&      -	   5        $ TextBoxSection4��5&      $#��Geometria - własności figur��61   �� 5'      -
   5        $ TextBoxSection5��5'      $��Trygonometria��61   �� 5(      -   5        $ TextBoxSection6��5(      $��Geometria - pola figur��61   �� 5)      -   5        $ TextBoxSection7��5)      $��Funkcje��61   �� 5*      -   5        $ TextBoxSection8��5*      $��Funkcje liniowe��61   �� 5+      -   5        $ TextBoxSection9��5+      $��Funkcje kwadratowe��61   �� 5,      -   5        $ TextBoxSection10��5,      $��Funkcje trygonometryczne��62   �� 5-      -   5        $ TextBoxSection11��5-      $��
Wielomiany��62   �� 5.      -   5        $ TextBoxSection12��5.      $&�� Funkcje wymierne i homograficzne��62   �� 5/      -   5        $ TextBoxSection13��5/      $*��$Funkcje wykładnicze i logarytmiczne��62   �� 50      -   5        $ TextBoxSection14��50      $��Ciągi��62   �� 51      -   5        $ TextBoxSection15��51      $��Analiza matematyczna��62   �� 52      -   5        $ TextBoxSection16��52      $��Geometria analityczna��62   �� 53      -   5        $ TextBoxSection17��53      $��Geometria przestrzenna��62   �� 54      -   5        $ TextBoxSection18��54      $/��)Rachunek prawdopodobieństwa i statystyka��62   55      �� 56   
   -   5        $ ItemsControl2��56      
������ 
������ $��5,5,5,5q�6a   $��28(�6r   $��Arial)�6�   $��1��6�   $��1��6�   $��1��6�   $��1��6�   ��57      �� 58      " ��6   .�59      ��  � ��$ 25��6/   �� 5:       � ��$ 20(�61   �� 5;       � ��$ Arial)�63   �� 5<       �@��TextAlignment$ Center=�66   �� 5=       � ��
 ���� 63   �� 5>       � {� .  62   5?      5A      �� 5B   
   -   5        $ ItemsControl3��5B      
������ 
������ $��5,5,5,5q�6a   $��28(�6r   $��Arial)�6�   $��2��6�   $��1��6�   $��1��6�   $��1��6�   ��5C      �� 5D      " ��6   .�5E      ��  � ��$ 25��6/   �� 5F       � ��$ 20(�61   �� 5G       � ��$ Arial)�63   �� 5H       �@��TextAlignment$ Center=�66   �� 5I       � ��
 ���� 63   �� 5J       � {� .  62   5K      5M      5N      5O      