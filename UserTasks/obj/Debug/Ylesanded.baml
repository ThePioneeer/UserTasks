   M S B A M L   `   `   `  ����D  @UserTasks, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:UserTasks	UserTasks  5   	       UserTasks.Ylesanded   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:UserTasks     5   	     � Title$  
Ülesanded��5   	   $	��400��6   $
��1063��6(   .��5	      � $��5,5,5,5q�6    � RowDefinitions 5
   
   �� 5      $	��300 �6   �� 5      $��30 �6   .+�5   
   �� -   5        $��ListYlesanded��5      $��0��6(   $��
5, 5, 5, 5q�5      ��5      ��  � 	Resources 5       �� 
TargetType �� Triggers �� Binding �� Path �� Value �� Property	 �� Value��%  '��       �� 5      " ��6    5      �� 5       6&   �� $ aktiveeritud� Jah6L   .a�5      ��  � ��
	 �  ��6;   5      �� 5       6&   �� $ valmis� Jah6F   .a�5      ��  � ��
	 � � �6;   5      5      5      
 �� View
 5      �� 5      .P�5       ��  �� Width$ 75��6%   $��Kuupäev��60    �� DisplayMemberBinding 6B   �� $ kuupaev�6r   �� 5!      $ 75��6%   $��Tähtaeg��60    6B   �� $ tahtaeg�6r   �� 5"      $	 650��6%   $��	Ülesanne��61    6D   �� $ ulesanne�6u   �� 5#      $ 50��6%   $��Lisas��60    6@   �� $ lisaja�6o   �� 5$      $ 55��6%   $��
Aktiveeris��60    6E   �� $ aktiveerija�6y   �� 5%      $ 80��6%   $��Aktiveeritud��60    6G   �� $ aktiveeritud�6|   �� 5&      $ 50��6%   $��Valmis��60    6A   �� $ valmis�6p   5'      5)      �� 5+   
    �� Orientation$ 
Horizontal=�6   $��1��6.   .+�5,      �� -   5        $��ButtonLisaYl��5,   -   $��Lisa ülesanne��6   $��5,0,0,0q�6\   �� 5-      -   5        $��ButtonDelete��5-   '   $��Kustuta��6   $��5,0,0,0q�6V   �� 5.      -   5        $��ButtonAktiveeri��5.   )   $��	Aktiveeri��6   $��
5, 0, 0, 0q�6@   6T   �� 5/      -   5        $��ButtonValmis��5/   &   $��Valmis��6   $��5,0,0,0q�6U   �� 50      -   5        $��ButtonRefresh��50   )   $��
Värskenda��6   $��5,0,0,0q�6Z   51      52      53      