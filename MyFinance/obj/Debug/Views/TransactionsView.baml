   M S B A M L   `   `   `  ����I  EMahApps.Metro, Version=1.1.3.28, Culture=neutral, PublicKeyToken=nullV;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls  5   	    	MyFinance&    MyFinance.Views.TransactionsView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   Pcontrols;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro     5   	   (   "MahApps.Metro.Controls.MetroWindow    IsCloseButtonEnabled  .    WindowTransitionsEnabled .  � WindowStartupLocation$ CenterScreen=�5   E      AccentColorBrush#���   5   	     AccentColorBrush3   	GlowBrush# �  6:    � WindowState$ 	Maximized=�5   	    � Title$ Transaction Manager��5   	   $	��400��6%   $	��600��65    � DataContext 5   !   �� .��5	      � $��Stretch=�6   $��Stretch=�6)    � RowDefinitions 5
   
   �� 5      $
��Auto �6   �� 5      $��* �6    � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $
��Auto �6   .+�5   
   �� $��0��6   $��0��6!   $��10q�61     HeaderFontSize#���  5      #���   5      �� 5      �6   �� *AccountName+ �� 5      $� ��6    �� 5      �6   �� *
NetBalance+	 �� StringFormat$	 C��5      �� 5   
   -   5        $��0��5      $��1��6   
 � Cursor$

 Hand��6.   $
��Left=�5      $��
0,10,10,10q�6,   $��5q�6@     MetroAccentButton#���  5      
������ $��0q�5   +    � ToolTip$  add a new transaction ��5      ��5       �� 5!       �� Orientation$ 
Horizontal=�6   .+�5"      F� �
���p"��z�α@@S�L��"��@@8�=� N�����.�d��w�Z����"����"�ю.����ӀG�}_��u�X;D��X;�a� �X;u����@]��k\��\��?E}Y�/8�����?�AL�H�V�?
X?������?��0ZtN��߿��a�־@@���1�@cB�%Us@@Y���:8@�e��TJt;x@,t\ ��'�<ړ@�4Ӛ7� xS���{��D�{���H1@�	T@@{���~SG �����tX���e��P���e��P�+NN�Ml^�CQ�Q��Md��@@�L��������zO崱@@"��z�α@@pj_jS�H�"@Q���jS�H�"@������� �
 ��� A�,_�)@@��� ���i�@@&�� ѐ@�u� �V���n5@@��1�1���M,���ܽ#I��c� ��c�Qn�co�Z�#o�Z1:�o�Z�N�Xm��[Lf�q�K:��lZ@@s�������������2���$cD��qq�D����}g[���}g[�v��5��s?��h�_#I0@�DYџQ� S1U�k�n�ѣ/�	�\F#��|�F��$egs��$�&���$�w����w�H����w���W����`�m�=��gt2}r��h�hs0@�f��h�hs0@�D��h�hs0@ٯ���� j_�b� ���    S��"D���?Z�>��i�G5�@n��]�� �gt��� �jl� ����
�I99a<��2MEf�	�-�ǳ�B$p���sL_��`��pky� ���J��:@��	/f�:@S9bJ��:@=1� ���i��"@u�`��3@��� уԟ �{� Ӄԟ �{� �� ��� �G� ��� �ЗA)��?��=�qR�P�?��>"�-��2�?�b;&�N!aP?�6=�Sg �?��i>9"@��Ň��?'aK4��@|�7�.�?<<� ��Rm�.�?<<� �	�J�\@��� ���P��@�E �C� D���?Z�>��	  DefaultButtonPathStyle#���  5#   !   �� 5$      $�� NEW TRANSACTION��6!     DefaultButtonTextBlockStyle#���  69   5%      5'      &   System.Windows.Controls.DataGrid  5)   
   $��1��6   $��0��6    $��2��60     AzureDataGrid#���  5*      $��10q�6;      SelectionMode$ Single=�6G      ClipboardCopyMode$ ExcludeHeader=�5+         CanUserSortColumns .    CanUserReorderColumns .     CanUserAddRows .     CanUserDeleteRows .     CanUserResizeRows .     
IsReadOnly .    AutoGenerateColumns .  ��5-      �� *Transactions+   Columns 5.      0  *System.Windows.Controls.DataGridTextColumn  5/      ,  &System.Windows.Controls.DataGridColumn   Header$
 Date��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$
 Auto 6c   1  +System.Windows.Controls.DataGridBoundColumn   Binding 63   �� *CreatedDate+$	 D��6c     50      $ Description��6%   $ * 6Z    6:   �� *Description+6Z   4  .System.Windows.Controls.DataGridTemplateColumn  51      $ Transaction��6)   $
 Auto 6>      CellTemplate 52      �� 53      .R�54      �� ��55   "   �� 56   &    �� 
TargetType" ��6,    �� Triggers 57   *   �� 58   .    �� Binding 6:   �� *
IsIncome+ �� Value True6W   .a�59   2   ��  �� Property � ��  �� Value$   Income ��6I   5:   /   �� 5;   .    6:   �� *
IsIncome+	 False6W   .a�5<   2   ��  � ��$  	 Expense ��6I   5=   /   5?   '   5A      5B      5D        5F      $ Amount��6)   $
 Auto 69    5G      �� 5H      .R�5I      �� $��Right=�6(   $��Stretch=�6l   ��6D   �� *Amount+$	 C��6l   5J      5L        5N      $ Actions��6)   $
 Auto 6:    5O      �� 5P      .R�5Q      �� $ 
Horizontal=�6)   .+�5R   "   �� -   5        $
��10,2q�5R   )   $

 Hand��67   #���  6E   
������ $��0q�5S   C   ��5T   &   F� 5U   *   $��18��6/   $��18��6;   #���  6F   �����    �����!�@���$���?
@��=�	%�� ѥ�3��g�fO�&�э>�/�Ѯ�� �/�� �� �j���Ʀ��!@�\��`���,�@�gD�+�G�@AKpe �      P?SXV���J����Z�)1|0��?ԏ��U_\5�?Q4��]�e>֢ @S+����X�"@!����� ����� ��UwD�� QGtG�  �<Z@Q�`7e�@�l�mo^ �$�����?ȡ?e �      P?	5W   +   5Y   #   �� 5Z   "   -   5        $
��10,2q�5Z   )   $

 Hand��67   #���  6E   
������ $��0q�5[   C   ��5\   &   F� 5]   *   $��18��6/   $��18��6;   #���  6F   �������.hz� �H�� ��.ѓ�q�?��0�� N����.��E���& @@��^����шJ���v�^=>�ш��.�ڮ�hz� ���. @@�q� H�    Sm��13� �4�> ��?��  ��%B�� ��&�m��K�� H�K���à� K��&�%B��    ?�� à� 13� �4�> H�	5_   +   5a   #   5b      5c      5e      5g      5h      5i      