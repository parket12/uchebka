   M S B A M L   `   `   `  ����I  EPohoronnoeBuro, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:PohoronnoeBuroPohoronnoeBuro  5   	       PohoronnoeBuro.Infoooo   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:PohoronnoeBuro     5   	     � Title$  Infoooo��5   	   $	��450��6   $	��800��6&   .��5	      �  � RowDefinitions 5
   
   �� 5      �� 5      �� 5      $��3* �6   �� 5       � ColumnDefinitions 5   
   �� 5      $��2* �6   �� 5      .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ 	EmployDgr��5      $��1��6&   $��2��6:      AutoGenerateColumns .     CanUserAddRows .     Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��6A   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   �� *	ID_INFO+6A     5      $ 	Date Info��6B    6%   �� *
DateInfo+6B     5      $ Name Payment Method��6Y    6%   �� *!PaymentMethod.NamePaymentMethod+6Y     5      $ 
Name Stock��6I    6%   �� *Stock.NameStock+6I     5      $ 	FirstName��6M    6%   �� *Employees.FirstName+6M   5      �� 5   
   -   5        	 ��Name$	 AddBut��5      $��2��6!   $
��40px��6.   $��533,140,27,37q�6<   $��Добавит��6S   $��2��6z   �� 5   
   -   5        $	 UpdBut��5      $��2��6!   $
��40px��6.   $��533,68,27,109q�6<   $��Изменить��6S   $��2��6{   �� 5    
   -   5        $	 	DeleteBut��5       $��2��6$   $
��40px��61   $��533,0,27,177q�6?   $��Удалить��6U   $��2��6   �� 5!   
   -   5        
 ��Name$
 NameProdTBx��5!      $��3��6'   $
��40px��64   $��0,10,407,25q�6B   �� 5"   
   -   5         ��Name$ 	InsureCBx��5"      $��10,10,27,28q�6&   $��3��6;   $��1��6H    �� DisplayMemberPath$ NamePaymentMethod��6X    �� SelectedValuePath$ ID_PaymentMethod��6~   �� 5#   
   -   5        $ CategoryCBx��5#      $��267,10,138,28q�6(   $��3��6?   $ 	NameStock��6L   $ ID_Stock��6j   �� 5$   
   -   5        $ PlotCBx��5$      $��400,10,4,28q�6$   $��3��69   $ 	FirstName��6F   $ ID_Employees��6d   �� 5%   
   -	   5        $	 ToInsureWin��5%      $��116,19,319,29q�6&   $��Страховые ком��6W   $��1��6o   �� 5&   
   -
   5        $	 	ToPlotWin��5&      $��10,19,441,29q�6$   $��Участки��6R   $��1��6d    J� RenderTransformOrigin$ 0.802,0.563&�6q   �� 5'   
   -   5        $	 ToPaymentMetWin��5'      $��225,19,216,29q�6*   $!��Способы оплаты��6_   $��1��6x   �� 5(   
   -   5        $	 ToStockMetWin��5(      $��331,19,110,29q�6(   $��
Акции��6[   $��1��6k   �� 5)   
   -   5        $	 ToCategoriiWin��5)      $��431,19,10,29q�6)   $��Категории��6\   $��1��6p   5+      5,      