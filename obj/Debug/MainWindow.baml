   M S B A M L   `   `   `  ����F  BppcLookupV2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:ppcLookup	ppcLookup  5   	       ppcLookup.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:ppcLookup     5   	   -   5          �Name$  
lookupMain��5   	    � Title$ 
PPC Lookup��5   	   $	��410��6   $	��600��6)    � 
ResizeMode$ CanMinimize=�65   $��Courier)�6N   
������� � Icon$- 'C:\Users\Public\PPC Database\Search.ico��6u   .��5	      �  � ColumnDefinitions 5   
   �� 5      $��1* �6   �� 5      $��2* �6    � RowDefinitions 5   
   �� 5      $��* �6   .+�5   
   �� -   5         ��Name$ stateBox��5      $��0��6%   $��1��65   $��	20,77,0,0q�6B   $
��Left=�6U   $	��Top=�6p   $	��136��6�    �� SelectedIndex$ 0��6�   $ �� IsSynchronizedWithCurrentItem$
 TrueY�6�   	 �� IsTextSearchEnabled	 .  $��Courier)�6  �� 5   
   -   5        $ 	countyBox��5      $��0��6&   $��1��66   $��
20,132,0,0q�6C   $
��Left=�6X   $	��Top=�6t   $	��136��6�   $ 0��6�   $
 TrueY�6�   	 .  $��Courier)�6  �� 5   
   -   5        
 ��Name$
 townList��5      $��1��6$   $��1��64   $��
-30,35,0,0q�6A   $
��Left=�6U   $	��300��6p   $	��Top=�6~   $	��400��6�   $��Lucida Console)�6�   6�   �� 5   
   -   5         ��Name$ stateLbl��5      $��0��6&   $��1��66   $��	20,60,0,0q�6C   $
��Left=�6W   $
��Wrap=�6r   $	��Top=�6�   $	��136��6�   $��Courier)�6�   $��15��6�   $��State:��6�    �� TextAlignment$ Center=�6�   �� 5   
   -   5        $ 	countyLbl��5      $��0��6'   $��1��67   $��
20,115,0,0q�6D   $
��Left=�6Y   $
��Wrap=�6u   $��County:��6�   $	��Top=�6�   $	��136��6�   $ Center=�6�   $��Courier)�6�   �� 5   
   -   5         ��Name$ 
townFilter��5      $��0��6&   $��1��66   $��
-20,30,0,0q�6C   $	��150��6W   $��22��6c   {�. 6�   �� 5   
   -   5        $ 	searchLbl��5      $��0��6'   $��1��67   $��
20,175,0,0q�6D   $
��Left=�6Y   $
��Wrap=�6u   $��Search Towns:��6�   $	��Top=�6�   $	��136��6�   $ Center=�6�   $��Courier)�6�   $��Disabled=�6�   �� 5   
   -	   5        $ instructions��5      $��1��6*   $��1��6:   $��-33,305,0,-25q�6G   $��20��6^   $	��300��6j   $ Center=�6v   -+Click an entry in the list to copy the code6�   �� 5   
   -
   5         ��Name$ requestEdit��5      $��0��6&   $��1��66   $��
25,160,0,0q�6C   $
��Left=�6W   $��30��6r   $	��130��6~   .��6�   Send Edit Request6�   5      5      