   M S B A M L   `   `   `  ����F  BppcLookupV2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:ppcLookupV2ppcLookupV2  5   	       ppcLookupV2.SendEdit   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:ppcLookupV2     5   	   -   5          �Name$  requestEdit��5   	    � Title$ Request an Edit/Addition��5   	   $	��300��6*   $	��300��67    � 
ResizeMode$ NoResize=�6C    � ShowInTaskbar .  .��5	      �  � ColumnDefinitions 5   
   �� 5      $��10 �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��15 �6    � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   .+�5   
   �� $��1��6   $��0��6$    �� TextAlignment$ Center=�61   $��0,15,0,0q�6H   Request Type:6j   �� 5   
   -   5         ��Name$ requestCbox��5      $��2��6(   $��25��68   6F   �� 5   
   $��1��6   $��1��6$   $ Center=�61   $��0,15,0,0q�6H   State:6b   �� 5   
   -   5         ��Name$ stateBox��5      $��2��6$   $��1��64   $��20��6A   	 �� MaxLines$	 1��6M   6\   �� 5    
   $��1��6   $��2��6$   $ Center=�61   $��0,15,0,0q�6H   	County:6c   �� 5!   
   -   5        $ 	countyBox��5!      $��2��6%   $��2��65   $��20��6B   $	 1��6N   6]   �� 5#   
   $��1��6   $��3��6$   $ Center=�61   $��0,15,0,0q�6H   Town:6a   �� 5$   
   -   5        $ townBox��5$      $��2��6#   $��3��63   $��20��6@   $	 1��6L   6[   �� 5&   
   $��1��6   $��4��6$   $ Center=�61   $��0,15,0,0q�6H   Protection Code:6l   �� 5'   
   -   5        $ codeBox��5'      $��2��6#   $��4��63   $��20��6@   $	 1��6L   6[   �� 5)   
   -   5        
 ��Name$
 sendRequest��5)      $��1��6&   $��5��66   $��30��6C   $��80��6O   .��6t   Send6z   �� 5*   
   -   5        $
 cancelRequest��5*      $��2��6(   $��5��68   $��30��6E   $��80��6Q   .��6x   Cancel6�   5,      5-      