   M S B A M L   `   `   `  ���� F  BppcLookupV2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:ppcLookup	ppcLookup      ppcLookup.MainWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     )localclr-namespace:ppcLookup     -     �Name$  
lookupMain�� � Title$ 
PPC Lookup��$	��390��$	��600�� � 
ResizeMode$ CanMinimize=�$��Courier)�
������� � Icon$- 'C:\Users\Public\PPC Database\Search.ico��.���  � ColumnDefinitions �� $��1* ��� $��2* � � RowDefinitions �� $��* �.+��� -    ��Name$ stateBox��$��0��$��1��$��	20,60,0,0q�$
��Left=�$	��Top=�$	��136�� �� SelectedIndex$ 0��$ �� IsSynchronizedWithCurrentItem$
 TrueY�	 �� IsTextSearchEnabled	 .  $��Courier)��� -   $ 	countyBox��$��0��$��1��$��
20,108,0,0q�$
��Left=�$	��Top=�$	��136��$ 0��$
 TrueY�	 .  $��Courier)��� -   
 ��Name$
 townList��$��1��$��1��$��	-30,6,0,0q�$
��Left=�$	��300��$	��Top=�$	��400��$��Lucida Console)��� -    ��Name$ stateLbl��$��0��$��1��$��	20,40,0,0q�$
��Left=�$
��Wrap=�$	��Top=�$	��136��$��Courier)�$��15��$��State:�� �� TextAlignment$ Center=��� -   $ 	countyLbl��$��0��$��1��$��	20,90,0,0q�$
��Left=�$
��Wrap=�$��County:��$	��Top=�$	��136��$ Center=�$��Courier)��� -    ��Name$ 
townFilter��$��0��$��1��$��	-20,0,0,0q�$	��150��$��22��{�. �� -   $ 	searchLbl��$��0��$��1��$��
20,150,0,0q�$
��Left=�$
��Wrap=�$��Search Towns:��$	��Top=�$	��136��$ Center=�$��Courier)�$��Disabled=��� -	   $ instructions��$��1��$��1��$��-25,305,0,0q�$��20��$	��300��$ Center=�-+Click an entry in the list to copy the code