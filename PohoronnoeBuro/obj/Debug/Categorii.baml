   M S B A M L   `   `   `  ����I  EPohoronnoeBuro, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:PohoronnoeBuroPohoronnoeBuro  5   	       PohoronnoeBuro.Categorii   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:PohoronnoeBuro     5   	     � Title$  	Categorii��5   	   $	��450��6   $	��800��6(   .��5	      �  � RowDefinitions 5
   
   �� 5      �� 5      �� 5      $��3* �6   �� 5       � ColumnDefinitions 5   
   �� 5      $��2* �6   �� 5      .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ RoleDgr��5      $��1��6$   $��2��68      AutoGenerateColumns .     CanUserAddRows .     Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��6L   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   �� *ID_ProductCategory+6L     5      $ Name Payment Method��6O    6%   �� *NameOfProductCategory+6O   5      �� 5   
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
��40px��60   $��2��6>   $��533,135,27,42q�6R   6i   �� 5   
   -   5        $	 ToInsureWin��5      $��116,19,319,29q�6&   $��
Касса��6W   $��1��6g   �� 5    
   -   5        $	 	ToPlotWin��5       $��10,19,441,29q�6$   $��Участки��6R   $��1��6d    J� RenderTransformOrigin$ 0.802,0.563&�6q   �� 5!   
   -   5        $	 ToPaymentMetWin��5!      $��225,19,216,29q�6*   $!��Способы оплаты��6_   $��1��6x   �� 5"   
   -	   5        $	 ToStockMetWin��5"      $��331,19,110,29q�6(   $��
Акции��6[   $��1��6k   �� 5#   
   -
   5        $	 ToCategoriiWin��5#      $��431,19,10,29q�6)   $��
Касса��6\   $��1��6l   �� 5$   
   -   5        $	 	ToInfoWin��5$      $��10,19,164,29q�6$   $��Инфо��6R   $��1��6a   $��1��6n   5%      5&      