   M S B A M L   `   `   `  ����  AcademicPerformance+    %AcademicPerformance.Views.WinRoleEdit   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -   5          � Title$!  Редактор ролей��5   	   $��717.5��6    $
��1600��6/    � WindowStartupLocation$ CenterScreen=�5   	      WindowsStyle#���   5	   	   .��5
      �  � ColumnDefinitions 5   
   �� 5      $	��150 �6   �� 5      $	��880 �6   �� 5      $
��317* �6   �� 5      $
��247* �6    � RowDefinitions 5   
   �� 5      $��30 �6   �� 5      $��70 �6   �� 5      $��30 �6   �� 5      $��70 �6   �� 5      $��30 �6   �� 5      $��70 �6   �� 5      $��30 �6   �� 5      $��70 �6   �� 5      $��30 �6   �� 5      $��70 �6   �� 5!      $��30 �6   �� 5"      $��70 �6   �� 5$      $��30 �6   �� 5%      .+�5'   
   o� $��30��6   $	��Top=�6   $��3��63   .@�5(      m� -   5         m�Name$ miFile��5(      $��Файл��6'   .@�5)      �� m� 5*      -   5        $ miExit��5*      $��
Выход��6+   6:   �� 5+      5,      5-      �� 5.   
   -   5         ��Name$ 	lblSearch��5.      $��
Поиск��6#     
LabelStyle#���  63   $��1��5/      �� 50   
   -   5         ��Name$ tbSearch��50      $��1��6$   $��1��61   ��6B   ��  �� Path$ 
SearchText� �� Mode$ TwoWay=�	 �� UpdateSourceTrigger$	 PropertyChanged=�&   System.Windows.Controls.DataGrid  51   
   -   5        
  Name$
 	dgJournal��51      $��2��6&   $��2��63   $��11��6G      AutoGenerateColumns .     
IsReadOnly . $��12(�53   %   $��0,0,0,29q�64   ��52   /   �� $ FilteredUserList� �� SelectedItem 6]   �� $ SelectedRow�$ TwoWay=�   Columns 54      0  *System.Windows.Controls.DataGridTextColumn  55      -   5        dgIdUser��,  &System.Windows.Controls.DataGridColumn   Header$ 	№ п/п��56   %      Width5  /System.Windows.Controls.DataGridLengthConverter$ 50 58   %   1  +System.Windows.Controls.DataGridBoundColumn   Binding 57   %   �� *IdUser+58   %     5:      -   5        dgLoginUser��$ 
Логин��5;   %   $ * 5=   %    5<   %   �� *	LoginUser+5=   %     5?      -	   5        dgPasswordUser��$ Пароль��5@   %   $ * 5B   %    5A   %   �� *PasswordUser+5B   %     5C      -
   5        
dgRoleUser��$ Роль��5D   %   $ * 5F   %    5E   %   �� *
RoleUser+5F   %   5H      �� 5J   
   -   5        $ 	lblIdUser��5J      $��IdUser��6#   #���  64   $��2��5K      $��3��6    $��20(�6-   $��10,10,76,10q�6;   �� 5L   
   -   5        $ tbIdUser��5L      $��2��6$   $��3��64   $��2��5N      $��246,0,36,28q�6&   $��2��6;    �� 
IsReadOnly . ��5M      �� *SelectedRow.IdUser+$ TwoWay=�$	 PropertyChanged=�.��5N   _   5O      �� 5P   
   -   5        $ lblEvaluation��5P      $��
Логин��6'   #���  5Q      $��2��65   $��5��6E   $��20(�6R   $��10,10,76,10q�6`   �� 5R   
   -   5        $ cbEvaluation��5R      $��2��6(   $��4��68   $��2��5V      $��246,29,36,0q�6&   $��2��6;   ��5T      �� *SelectedRow.LoginUser+$ TwoWay=�$	 PropertyChanged=�5V   ;   �� 5W   
   -   5        $ lblPasswordUser��5W      $��Пароль��6)   #���  5X      $��2��65   $��7��6E   $��20(�6R   $��10,10,76,10q�6`   �� 5Y   
   -   5        $ tbPasswordUser��5Y      $��2��6*   $��7��6:   $��2��6G   $��
246,0,36,0q�6[   ��5Z      �� $ SelectedRow.PasswordUser�$ TwoWay=��� 5\   
   -   5        $ lblNAmeDiscipline��5\      $��Rоль��6+   #���  5]      $��2��65   $��9��6E   $��20(�6R   $��10,10,76,10q�6`   �� 5^   
   -   5         ��Name$ 
cbRoleUser��5^      $��2��6'   $��9��67    �� DisplayMemberPath$ NameRole��5_   A   $��2��5b      $��
246,0,36,0q�6'   ��5_      �� *
RoleList+$ OneWay=� 5a      �� *SelectedRole+$ TwoWay=�$	 PropertyChanged=�5b   '   �� 5c   
   -   5         ��Name$
 Exit��5c      $��
Выход��6     BtnStyle#���  6/   $��1��5d      $��12��6   $��10,10,10,11q�6T   $��2��6i   ��6+   Z� 6i   �� 5e   
   -   5        $
 Save��5e      $+��%Сохранить изменения��6   #���  6=   $��2��5f      $��12��6   $��100,11,100,10q�6B   $��2��6Y   $��2��6j   ��5e   `   �� $ SaveCommand���5f   +   Z� 6j   �� 5g   
   -   5        $ Delete��5g      $!��Удалить запись��6!   #���  6:   $��2��5h      $��1��6   $��174,0,178,2q�6A   $��2��6V   ��5g   ^   �� $ DeleteCommand���5h   *   Z� 6V   5i      5j      