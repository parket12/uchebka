   M S B A M L   `   `   `  ����I  EPohoronnoeBuro, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:PohoronnoeBuroPohoronnoeBuro  5   	       PohoronnoeBuro.AdminPage   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:PohoronnoeBuro     5   	     � Title$  	AdminPage��5   	   $	��450��6   $	��800��6(   .��5	      �  � RowDefinitions 5
   
   �� 5      �� 5      �� 5      $��3* �6   �� 5       � ColumnDefinitions 5   
   �� 5      $��2* �6   �� 5      .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ RoleDgr��5      $��1��6$   $��2��68      AutoGenerateColumns .     CanUserAddRows .     Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��6A   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   �� *	ID_Rolb+6A     5      $
 Role��6B    6%   �� *
RoleName+6B   5      �� 5   
   -   5        	 ��Name$	 AddBut��5      $��2��6!   $��1��6.   $
��40px��6>   $��
0,90,27,87q�6L   $��Добавит��6`   6r   �� 5   
   -   5        $	 UpdBut��5      $��2��6!   $��1��6.   $
��40px��6>   $��0,45,27,132q�6L   $��Изменить��6a   6t   �� 5   
   -   5        $	 	DeleteBut��5      $��2��6$   $��1��61   $
��40px��6A   $��
0,0,27,177q�6O   $��Удалить��6c   6u   �� 5   
   -   5        
 ��Name$
 TextTBx��5      $��2��6#   $
��40px��60   $��2��6>   $��533,135,27,42q�6R    � 5   
   -   5          �Name$ EmpPage��5      $��4��6!   $��2��62   �� 5    
   -   5        $	 EmpBut��5       $��Работники��6!   $��0��65   $��0,19,358,19q�6Z   $��1��6o   �� 5!   
   -   5        $!	 EmpBut_Копировать��5!      $��роли��6,   $��0��6;   $��358,19,0,19q�6L   $��1��6a    J� RenderTransformOrigin$ 0.5,0.5&�6n   6�   5"      5#      