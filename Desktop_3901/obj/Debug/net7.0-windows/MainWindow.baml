   M S B A M L   `   `   `  ����G  CDesktop_3901, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:Desktop_3901Desktop_3901  5   	       Desktop_3901.MainWindow   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:Desktop_3901     5   	     � Title$  
MainWindow��5   	   $	��600��6   $	��950��6)    � WindowStyle$
 None=�5	   	    � AllowsTransparency$
 True��5
   	   
������  � 
ResizeMode$ NoResize=�5   	    � WindowStartupLocation$ CenterScreen=�5   	    � DataContext 5         Desktop_3901.MainWindowVM  5   
   .��5      �  � RowDefinitions 5   
   �� 5      $��60 �6   �� 5      �� 5      $��80 �6   .+�5   
   �� $��3��6    �� CornerRadius$ 20��6"   ��5      �� 5      .��5      �  � Color$ #81C784��6#   	 � Offset$		 0.0Q�63   � 5       $ #4CAF50��6#   $		 0.5Q�63   � 5!      $ #FFF176��6#   $	 1Q�63   5"      5$      �� 5&   
   ���#004D40.+�5'      �� $��0��6   $!��Student Registration System��6%   $��25(�6H   $��10q�6V   
 �� TextAlignment$
 Center=�6c   
�������$��Comic Sans MS)�6�    �� Padding$ 5q�5(      $��Heavy"�6$   5)      � 5+   
   $��1��6    � ColumnDefinitions 5,      �� 5-      $��60 �6#   �� 5.      �� 5/      $��60 �6#   .+�52      � $��1��6   $��10q�6#   $	��790��6/   .+�54      &   System.Windows.Controls.DataGrid  -   5          Name$ StudentGrid��54         AutoGenerateColumns$ False��60   $��2��6�   ��6L   �� *
Students+ �� UpdateSourceTrigger$ PropertyChanged=� �� SelectedItem 6�   �� *SelectedStudent+$ PropertyChanged=�   Columns 55      4  .System.Windows.Controls.DataGridTemplateColumn  56      ,  &System.Windows.Controls.DataGridColumn   Header$ Profile��61      
IsReadOnly$
 True��6B      Headerstyle   HeaderStyle# [  6T      CellTemplate 57      �� 58   "   .R�59   &   �� $��30��6k   $	��150��6w   ��6,   �� *Image+$ PropertyChanged=�6w   5:   #   5<      0  *System.Windows.Controls.DataGridTextColumn  5=      $ ID��6-   $
 True��69   # [  6K      Width5  /System.Windows.Controls.DataGridLengthConverter$	 100 6�   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6v   �� *Id+$ PropertyChanged=�6�     5>      $ 
First Name��6-   $
 True��6A   # [  6S   $	 150 6�    6~   �� *	FirstName+$ PropertyChanged=�6�     5?      $ 	Last Name��6-   $
 True��6@   # [  6R   $	 150 6�    6}   �� *
LastName+$ PropertyChanged=�6�     5@      $ Date od Birth��6-   $
 True��6D   # [  6V   $	 150 6�    6�   �� *DateofBirth+$ PropertyChanged=�6�     5A      $	 GPA��6-   $
 True��6:   # [  6L   $ 80 6�    6w   �� *GPA+$ PropertyChanged=�6�   5C      5E      5G      � 5H   
   $��2��6   ���#004D40 5I      �� 5J      �� 5K      �� 5L      �� 5M      .+�5O      �� -   5         ��Name$ Addstu��5O   %   $��0��6   $��Add Student��65   $��Comic Sans MS)�6K   $
��Bold"�6f     buttonstyle#��[ 6�   ��6x   �� *AddStudentCommand+$ PropertyChanged=�6�   �� 5P      -   5        $ Delstu��5P   %   $��1��6   $��Delete Student��65   $��Comic Sans MS)�6N   $
��Bold"�6i   #��[ 6�   ��6{   �� *RemoveStudentCommand+$ PropertyChanged=�6�   �� 5Q      -   5        $ Editstu��5Q   %   $��2��6   $��Edit Student��66   $��Comic Sans MS)�6M   $
��Bold"�6h   #��[ 6�   ��6z   �� *EditStudentCommand+$ PropertyChanged=�6�   �� 5R      -   5        $��3��5R      $
��Exit��6%   $
��Bold"�65   $��Comic Sans MS)�6G   #��[ 6b   6�   5T      5U      5V      