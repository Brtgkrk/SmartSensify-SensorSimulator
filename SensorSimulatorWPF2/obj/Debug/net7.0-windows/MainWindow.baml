   M S B A M L   `   `   `  ����N  JSensorSimulatorWPF2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:SensorSimulatorWPF2SensorSimulatorWPF2  5   	   $    SensorSimulatorWPF2.MainWindow   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   3local!clr-namespace:SensorSimulatorWPF2     5   	     � Title$  
MainWindow��5   	   $	��600��6   $	��900��6)    � 
ResizeMode$ CanMinimize=�5	   	   .��5
      � .+�5   
   �� -   5        $��Refresh��5      $
��Left=�6#   $��	10,10,0,0q�6>   $	��Top=�6Q   $	��130��6i   $��22��6u   6�   �� 5   
   -   5        $��Add New Sensor��5      $
��Left=�6*   $��
145,10,0,0q�6E   $	��Top=�6Y   $	��130��6q   $��22��6}   6�   �� 5   
   -   5        $��Check API Connection��5      $
��Left=�60   $��
280,10,0,0q�6K   $	��Top=�6_   $	��130��6w   $��22��6�   6�   �� 5   
   -   5        $��GenerateDataButton��5      $0��*Start Generating data for selected sensors��6+   $
��Left=�6`   $��
416,10,0,0q�6{   $	��Top=�6�   $	��243��6�   $��22��6�   6�   � 5   
   -   5        $��DataGenerationProgressBar��5      $
��Left=�67   $��22��6R   $��
664,10,0,0q�6^   $	��Top=�6r   $	��211��6�   �� 5   
   -   5         ��Name$ listBoxSensors��5      $��0,37,0,0q�6*   ��5      �� 5      .R�5      �� 
�������$��1,1,1,1q�65    �� Padding$ 5q�6O   $	��870��6[   ._�5      � .+�5      �� .+�5   "   �� 
�������$��0,0,0,1q�6A   ._�5   &   �� $
��Bold"�60   �� 5   *   $�Sensor name: ��6.    �� 5   *   �6.   �� *Name+5   '   5   #   � 5   "   .+�5   &   �� .+�5   *   �� �� 5   .   $
�ID: ��62    �� 5    .   �62   �� *Id+5!   +   �� 5"   *   �� 5#   .   $�Secret key: ��62    �� 5$   .   �62   �� *	SecretKey+5%   +   5&   '   �� 5'   &   $
��Left=�61   $��
300, 0 0 0q�6L   .+�5(   *   �� $4��.Time between data generation (in miliseconds):��64   $	��250��6j   �� 5)   *   $	��250��62   ��6>   �� *DataGenerationSpeed+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=� �� FallbackValue$
 1000��5*   '   5+   #   �� 5,   "   $
��Bold"�6,   Sensor Types:6M   �� 5-   "   ��6/   �� *SensorTypes+��5.   &   �� 5/   *   .R�50   .   ��  �� Orientation$ 
Horizontal=�69   .+�51   2   � .+�53   6   �� �� 54   6   $	�•��6:   
���   �6C    �� 55   6   �6:   �� *Name+ �� 56   6   $� from ��6:    �� 57   6   �6:   �� *
ValueMin+ �� 58   6   �6:   �� *Unit+ �� 59   6   $
� to ��6:    �� 5:   6   �6:   �� *
ValueMax+ �� 5;   6   �6:   �� *Unit+5<   7   �� 5=   6   $��Center=�6@   $��
300, 0 0 0q�6[   �� 5>   :   $�LastValue: ��6>    �� 5?   :   $
��Bold"�6Y   �6>   �� *	LastValue+6Y    �� 5@   :   �6>   �� *Unit+5A   7   5B   3   5C   /   5D   +   5F   #   5G      �� 5H      -   5        $��	840,0,0,0q�5H   '   $��Right=�6v    d� 	IsChecked 6:   �� *
IsSelected+6v   �� 5I      -   5        $��Edit Sensor��5I   !   $��Right=�6M   $��Center=�6i   $��0,0,0,0q�6�   
	 � Tag	 5K      �� 5L   "   
 �� Path$
 DataContext�6n    �� RelativeSource 6*   ��  �� AncestorType" ��6n   5N      �� 5O      -	   5        $��Delete��5O   !   $��Right=�6L   $��Center=�6h   $��0,0,0,0q�6�   	 5Q      �� 5R   "   $
 DataContext�6n    6*   �� " ��6n   5T      5U      5V      5W      5Y      5]      5^      