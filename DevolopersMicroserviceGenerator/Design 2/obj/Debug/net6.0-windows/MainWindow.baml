   M S B A M L   `   `   `  ����C  ?Design 2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:Design_2.MVVM.ViewModelDesign_2.MVVM.ViewModel  5   	   #clr-namespace:Design_2Design_2  5   	       Design_2.MainWindow   5   	   W SPresentationCore, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ;	viewModel%clr-namespace:Design_2.MVVM.ViewModel     5   	   (localclr-namespace:Design_2     5   	   -   5        $	��600��5	   	   $	��920��6     � WindowStyle$
  none=�5
   	    � 
ResizeMode$ NoResize=�5   	   
������  � AllowsTransparency$
 True��5   	    � WindowStartupLocation$ CenterScreen=�5   	    � DataContext 5      +  %Design_2.MVVM.ViewModel.MainViewModel  5   
   .��5      �� ���#222222 �� CornerRadius$ 5��5      ._�5   
   �  � ColumnDefinitions 5      �� 5      $	��200 �6#   �� 5       � RowDefinitions 5      �� 5      $��75 �6    �� 5      .+�5"      �� $��MDGenerator��6   $��Center=�5#      $
��Left=�5$      
�������$��22(�5&      $��20,0,0,0q�5'      �� 5)      $��1��6   .+�5*      	� $
��Home��6   $��50��5+      
�������$��14(�5-         MenuButtonTheme#��[  5.       d� 	IsChecked$
 TrueY�5/      ��50      �� *HomeViewCommand+	� 51      $��Microservice��6   $��50��52      
�������$��14(�54      #��[  55      ��56      �� *MicroserviceViewCommand+	� 57      $��Docker Compose��6   $��50��58      
�������$��14(�5:      #��[  5;      	� 5<      $��Add New Service��6   $��50��5=      
�������$��14(�5?      #��[  5@      ��5A      �� *AddNewServiceStartViewCommand+5B      �� 5E      $��1��6   $��1��5F      $��10q�5G      ��5H      �� *CurrentView+�� 5I      -   5        	 ��Name$	 closeButton��5I      $��1��6)   $��
685,5,5,40q�69   $-��'/round_panorama_fish_eye_white_24dp.png��6M   $��Uniform=�6~   $��18��6�   5J      5L      5M      