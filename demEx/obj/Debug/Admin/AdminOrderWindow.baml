   M S B A M L   `   `   `  ����@  <demEx, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:demEx.AdmindemEx.Admin  5   	   "    demEx.Admin.AdminOrderWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:demEx.Admin     5   	     � Title$  Заявки��5   	   $	��450��6   $	��800��6%   .��5	      �  � RowDefinitions 5
   
   �� 5      $��* �6   �� 5      $��50 �6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ dataGrid��5         AutoGenerateColumns .     
IsReadOnly .    Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$	 №��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ 30 60   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6;   �� *Id+  5      $ Имя клиента��6%   $ * 6:    6D   �� *
ClientName+  5      $ Cтатус��6%   $ * 65    6?   �� *Status+  5      $ Приоритет��6%   $ * 68    6B   �� *
Priority+  5      $ Исполнитель��6%   $ * 6:    6D   �� *EmployeeName+4  .System.Windows.Controls.DataGridTemplateColumn  5      	   CellTemplate	 5      �� 5      .R�5      �� -   5        $��Подробнее��5   %   69   5      5      5      �� 5    
   -   5        
 ��Name$
 
backButton��5!      $��1��5"      $
��Left=�5#      $��Center=�5$      $
��20 0q�5%      $��
Назад��5&      $��20(�5'      �� 5)   
   -   5        $
 	addButton��5*      $��1��5+      $��Right=�5,      $��Center=�5-      $
��20 0q�5.      $��Добавить��5/      $��20(�50      51      52      53      