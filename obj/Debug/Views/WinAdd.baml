   M S B A M L   `   `   `  ����  AcademicPerformance&     AcademicPerformance.Views.WinAdd   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -   5          � Title$  Добавить��5   	   $	��600��6   $	��710��6'    � WindowStartupLocation$ CenterScreen=�5   	      WindowsStyle#���   5	   	   .��5
      � ��5   
   �� 5       �� EndPoint$ 0.5,1&�6"    �� 
StartPoint$ 0.5,0&�63   .��5      �  � Color$ Black��6    � Offset$ 0Q�6-   � 5      $ White��6   $ 1Q�6-   5       � ColumnDefinitions 5   
   �� 5      $	��300 �6   �� 5      $	��400 �6    � RowDefinitions 5   
   �� 5      $��20 �6   �� 5      �� 5      $��20 �6   �� 5      �� 5      $��20 �6   �� 5      �� 5      $��20 �6   �� 5      �� 5      $��20 �6   �� 5      �� 5       $��20 �6   �� 5!      .+�5#   
   �� $��Добавить��6   $��1��6#   $��2��61     	LabelLogo#���  5$      
�������64   �� 5%   
   -   5         ��Name$ 	cbStudent��5%      	 �� Text$	 Ученик��6&   $��3��64   $��10,9.8,9.8,10.4q�6A   
 �� DisplayMemberPath$
 FullName��5&   7   ��6   �� *StudentList+ �� SelectedItem 5'      �� *SelectedStudent+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=��� 5(   
   -   5         ��Name$ 	tbStudent��5(      $��1��6%   $��3��5)   �   $��10q�6�   ���#ffd800$��24(�6�   $��Center=�6�   ��5(   5   ��  �� Path$ SelectedStudent.FullName�5)   �   �� 5*   
   -   5        $ cbEvaluation��5*      $	 Оценка��6)   $��5��67   $��10,9.6,9.8,9.6q�6D   $
 NameEvaluation��5+   :   ��6   �� *EvaluationList+ 5,      �� *SelectedEvaluation+$ TwoWay=�$ PropertyChanged=��� 5-   
   -   5        $ tbEvaluation��5-      $��1��6(   $��5��5.      $��10q�6   ���#ffd800$��24(�6A   $��Center=�6O   ��5-   8   �� $' !SelectedEvaluation.NameEvaluation�5.   O   �� 5/   
   -   5        $ 	cbTeacher��5/      $ 	 Преподаватель��6&   $��7��6;   ���#ffd800$��10,10.4,9.8,9.8q�50   (   $
 FullName��51   7   ��6   �� *TeacherList+ 52      �� *SelectedTeacher+$ TwoWay=�$ PropertyChanged=��� 53   
   -   5        $ 	tbTeacher��53      $��1��6%   $��7��55      $��10q�6    �� 
IsReadOnly . ���#ffd800$��24(�6S   $��Center=�6a   ��53   5   �� $ SelectedTeacher.FullName�55   a   �� 56   
   -   5        $ cbDiscipline��56      $	 Дисциплина��6)   $��9��6;   $
 NameDiscipline��57   :   ���#ffd800$��10,10.2,9.8,10q�59   (   ��57      �� *DisciplineList+ 58      �� *SelectedDiscipline+$ TwoWay=�$ PropertyChanged=�59   (   �� 5:   
   -	   5        $ tbDiscipline��5:      $��1��6(   $��9��5;      $��10q�6   ���#ffd800$��24(�6@   $��Center=�6N   ��5:   8   �� $' !SelectedDiscipline.NameDiscipline�5;   N   �� 5<   
   -
   5         ��Name$ btnSave��5<      $��Сохранить��6"     BtnStyle#���  5=      $��11��64   ���#ffd800��5<   7   �� $ 
AddCommand�5>   %   �� 5?   
   -   5        $ btnBack��5?      $��
Назад��6"   #���  5@      $��11��64   $��1��5A      ���#ffd80066   5B      5C      