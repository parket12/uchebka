   M S B A M L   `   `   `  ����I  EPohoronnoeBuro, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:PohoronnoeBuroPohoronnoeBuro  5   	       PohoronnoeBuro.Employ   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:PohoronnoeBuro     5   	     � Title$  Employ��5   	   $	��450��6   $	��800��6%   .��5	      �  � RowDefinitions 5
   
   �� 5      �� 5      �� 5      $��3* �6   �� 5       � ColumnDefinitions 5   
   �� 5      $��2* �6   �� 5      .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ 	EmployDgr��5      $��1��6&   $��2��6:      AutoGenerateColumns .     CanUserAddRows .     Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��6F   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   �� *ID_Employees+6F     5      $ Surname��6A    6%   �� *	Surname+6A     5      $ 
First Name��6C    6%   �� *	FirstName+6C     5      $ Login��6?    6%   �� *login+6?     5      $ Password��6B    6%   �� *
password+6B     5      $
 Role��6G    6%   �� *Rolb.RoleName+6G   5      �� 5   
   -   5        	 ��Name$	 AddBut��5      $��2��6!   $
��40px��6.   $��533,140,27,37q�6<   $��Добавит��6S   $��2��6z   �� 5    
   -   5        $	 UpdBut��5       $��2��6!   $
��40px��6.   $��533,68,27,109q�6<   $��Изменить��6S   $��2��6{   �� 5!   
   -   5        $	 	DeleteBut��5!      $��2��6$   $
��40px��61   $��533,0,27,177q�6?   $��Удалить��6U   $��2��6   G� 5"   
   -   5        
 G�Name$
 TextTBx��5"      $��3��6'   $
��40px��64   $��0,10,407,25q�6B   �� 5#   
   -   5        $	 EmpBut��5#      $��Работники��6!   $��0��65   $��1��6E   $��10,24,354,24q�6g   �� 5$   
   -   5         ��Name$ 
TextTBXSur��5$      $��3��6&   $
��40px��63   $��135,10,271,25q�6A    J� RenderTransformOrigin$ 0.787,0.666&�6X   �� 5%   
   -   5        $ TextTBxFNam��5%      $��3��6'   $
��40px��64   $��267,10,140,22q�6B   �� 5&   
   -	   5        $ 
TextTBxLog��5&      $��3��6&   $
��40px��63   $��400,10,7,25q�6A   �� 5'   
   -
   5         ��Name$ RoleCBx��5'      $��10,10,87,28q�6$   $��3��69   $��1��6F    �� DisplayMemberPath$ RoleName��6V    �� SelectedValuePath$ ID_Rolb��6s   �� 5(   
   -   5        $		 Emp��5(      $��Роли��6   $��0��6-   $��1��6=   $��330,23,10,24q�6K   6a   5)      5*      