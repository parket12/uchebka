   M S B A M L   `   `   `  ����I  EPohoronnoeBuro, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:PohoronnoeBuroPohoronnoeBuro  5   	       PohoronnoeBuro.KassaPage   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:PohoronnoeBuro     5   	     � Title$  	KassaPage��5   	   $	��450��6   $	��800��6(   .��5	      �  � RowDefinitions 5
   
   �� 5      �� 5      �� 5      $��3* �6   �� 5       � ColumnDefinitions 5   
   �� 5      $��2* �6   �� 5      .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ 	EmployDgr��5      $��1��6&   $��2��6:      AutoGenerateColumns .     CanUserAddRows .     Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��6D   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   �� *
ID_Product+6D     5      $ Name of product��6G    6%   �� *NameOfProduct+6G     5      $ Price��6?    6%   �� *Price+6?     5      $ NameOfInsuranceCompany��6a    6%   �� *)'InsuranceCompany.NameOfInsuranceCompany+6a     5      $ Password��6G    6%   �� *Plot.NamePlot+6G     5      $
 Role��6_    6%   �� *'%ProductCategory.NameOfProductCategory+6_   5      �� 5   
   -   5        	 ��Name$	 AddBut��5      $��2��6!   $��533,140,27,26q�6.   $��Добавит��6E   $��2��6l   �� 5    
   -   5        $	 UpdBut��5       $��2��6!   $��533,68,27,98q�6.   $��Изменить��6D   $��2��6l   �� 5!   
   -   5        $	 	DeleteBut��5!      $��2��6$   $��533,0,27,167q�61   $��Удалить��6G   $��2��6q   �� 5"   
   -   5        
 ��Name$
 NameProdTBx��5"      $��3��6'   $
��40px��64   $��0,10,407,25q�6B   �� 5#   
   -   5        $
 PriceTBx��5#      $��3��6$   $
��40px��61   $��135,10,271,25q�6?    J� RenderTransformOrigin$ 0.787,0.666&�6V   �� 5$   
   -   5         ��Name$ 	InsureCBx��5$      $��10,10,27,28q�6&   $��3��6;   $��1��6H    �� DisplayMemberPath$ NameOfInsuranceCompany��6X    �� SelectedValuePath$ ID_InsuranceCompany��6�   �� 5%   
   -   5        $ CategoryCBx��5%      $��267,10,138,28q�6(   $��3��6?   $ NameOfProductCategory��6L   $ ID_ProductCategory��6v   �� 5&   
   -	   5        $ PlotCBx��5&      $��400,10,4,28q�6$   $��3��69   $ NamePlot��6F   $ ID_Plot��6c   �� 5'   
   -
   5        $ FiltrCBx��5'      $��4,20,133,17q�6%   $ NameOfProductCategory��6:   $��1��6d   6t   �� 5(   
   -   5        $
 	SearchTBx��5(      $��139,25,5,25q�6%   $ 0.787,0.666&�6:   $��1��6^   �� 5)   
   -   5        $	 	SearchBut��5)      $��
220,51,5,0q�6$   $��1��68   $��
Найти��6H   $��8(�6X   6e   �� 5*   
   -   5        $	 RexetBut��5*      $��139,51,80,0q�6$   $��1��69   $��Очистить��6I   $��8(�6\   6i   �� 5+   
   -   5        $	 ToInsureWin��5+      $��116,19,319,29q�6&   $��Страховые ком��6W   $��1��6o   �� 5,   
   -   5        $	 	ToPlotWin��5,      $��10,19,441,29q�6$   $��Участки��6R   $��1��6d   $ 0.802,0.563&�6q   �� 5-   
   -   5        $	 ToPaymentMetWin��5-      $��225,19,216,29q�6*   $!��Способы оплаты��6_   $��1��6x   �� 5.   
   -   5        $	 ToStockMetWin��5.      $��331,19,110,29q�6(   $��
Акции��6[   $��1��6k   �� 5/   
   -   5        $	 ToCategoriiWin��5/      $��431,19,10,29q�6)   $��Категории��6\   $��1��6p   �� 50   
   -   5        $	 	ToInfoWin��50      $��10,19,164,29q�6$   $��Инфо��6R   $��1��6a   $��1��6n   52      53      