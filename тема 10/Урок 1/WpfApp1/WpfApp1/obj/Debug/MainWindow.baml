   M S B A M L   `   `   `  ����B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp1WpfApp1  5   	       WpfApp1.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WpfApp1     5   	     � Title$  
MainWindow��5   	   $	��450��6   $��926.05��6)   .��5	      � $��0,0,2,0q�6    � ColumnDefinitions 5
   
   �� 5      $
��208* �6   �� 5      �� 5      $	��86* �6   �� 5      $
��322* �6   �� 5      $	��70* �6   �� 5      $
��229* �6   .+�5   
   �� -   5         ��Name$ buttonOrder��5      $��Сделать заказ��6&   $
��Left=�6>   $��
25,101,0,0q�6Y   $	��Top=�6m   $	��132��6�   $��81��6�   $��2��6�   $��2��6�   ���	#FF762020$��15(�6�   
�������6�   �� 5   
   -   5        $ button1��5      $#��Выполнить заказ��6"   $��3��6<   $��
0,245,23,0q�6L   $	��Top=�6`   $��81��6x   $��Right=�6�   $	��137��6�   $��15(�6�   ���	#FF8B5656
�������6�   �� 5   
   -   5         ��Name$ textBox��5      $��3��6#   $��43��63   $��76,247,189,0q�6?    �� TextWrapping$
 Wrap=�6U   $	��Top=�6i   �� 5   
   -   5         ��Name$ 	textBlock��5      $��2��6'   $
��Left=�67   $��
25,247,0,0q�6R   $
��Wrap=�6f   $-��'Введите номер заказа:��6z   $	��Top=�6�   $��43��6�   $	��137��6�    J� RenderTransformOrigin$ 2.452,0.546&�6�   $��2��6�   $��16(�6�   �� 5   
   -   5        $ 
textBlock1��5      $��3��6(   $
��Left=�68   $��
99,101,0,0q�6S   $
��Wrap=�6g   $	��Top=�6{   $��77��6�   $	��200��6�   $E��?Заказ сделан. Номер Вашего заказа: ��6�   $��16(�6�   5      5      