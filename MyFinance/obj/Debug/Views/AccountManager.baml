   M S B A M L   `   `   `  ����I  EMahApps.Metro, Version=1.1.3.28, Culture=neutral, PublicKeyToken=nullV;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls  5   	   D @MyFinance, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:MyFinance.CoreMyFinance.Core 5   	   $   MyFinance.Views.AccountManager   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   Pcontrols;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro     5   	   -coreclr-namespace:MyFinance.Core     5   	   (   "MahApps.Metro.Controls.MetroWindow    IsCloseButtonEnabled  .     IsMaxRestoreButtonEnabled .     IsMinButtonEnabled .   � Title$  ACCOUNT MANAGER ��5   	   $	��300��6#   $	��300��63    � 
ResizeMode$ NoResize=�6B      WindowTransitionsEnabled .  � WindowStartupLocation$ CenterScreen=�5	   )      AccentColorBrush#���   5
   	     AccentColorBrush3   	GlowBrush# �  6:    � WindowState$ Normal=�5   	   $	��300��6   $	��600��6+   .��5      � $��Stretch=�6   $��Stretch=�6)   	 � RowDefinitions	 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $��* �6   
 � ColumnDefinitions
 5   
   �� 5      $	��200 �6   �� 5      $��* �6   .+�5   
   �� $��	BANK NAME��6   $��0��6%   $��0��62   $��20,20,10,10q�6B   �� 5   
   $	��346��6   *   $MahApps.Metro.Controls.TextBoxHelper   	Watermark$ enter bank name��5      $��0��5      $��1��6   $��
10,20,0,10q�6/   $
��Left=�6C   ��5      �� *AccountName+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=�5   C   �� 5!   
   $��
PAYEE NAME��6   $��1��6&   $��0��63   $��20,10,10,10q�6C   �� 5"   
   $	��346��6   $ enter account payee name��5#      $��1��5$      $��1��6   $��
10,10,0,10q�6/   $
��Left=�6C   ��5"      �� *	PayeeName+$ TwoWay=�$ PropertyChanged=�5$   C   �� 5'   
   $��BALANCE��6   $��2��6#   $��0��60   $��20,10,10,10q�6@   �� 5(   
   $	��150��6   $ enter opening balance��6   $��2��5)      $��1��6   $��
10,10,0,10q�6/   $
��Left=�6C   .��6_   ��5*      �� 5+       �� Path$ Balance�6    �� StringFormat$ N2��6)   $ PropertyChanged=�6;   $ TwoWay=�6a    �� ValidationRules 5,      * $MyFinance.Core.BalanceValidationRule  5-      5/      .��50      51      )   #MahApps.Metro.Controls.ToggleSwitch  54   
   $��3��6    $��1��6-   $��10q�6=   $	��160��6I   $
��Left=�6U      OnLabel$ SAVINGS��55          OffLabel$ CURRENT��62      	IsChecked 6E   �� *	IsSavings+$ TwoWay=��� 58   
   -   5        $��4��58      $��1��6    � Cursor$
 Hand��6.   $	��Top=�6<   $
��Left=�59      $��
10,10,0,10q�6,   $��4q�6@     MetroAccentButton#���  5:      
������ $��0q�5;   +    � ToolTip$  save changes ��5<      ��5=      �� 5>       �� Orientation$ 
Horizontal=�6   .+�5?      F� ������Xv�xB��x��W��9���t����ss/���x��Ѡ�S3_��P)���>tP)� ���x@ ��s/�� ����!�>t�5~��5~ӃВ�5~o6��!o6s/��o6�x@�ВP)��P)��A�    �I*h    �I*h�� �A��� �|p��'@    Ѩ*�     Ѩ*� �3� Ө*� ږr�� �E/y=�E/��V�E/��dy�E/��ږ���3� ���    ��c�    �W?eF�v �W?e�~��{EGx�C& )�� )���{ )�Y�`�)Y��/��Y�]��8E(Y0U}Sڳ\�|p��'@ڳ\� l" ڳ\JG:���    ��L S    ��
@ l" �x��\i>|p��'@	  DefaultButtonPathStyle#���  5@   !   �� 5A      $�� SAVE ��6!     DefaultButtonTextBlockStyle#���  6/   5B      5D      �� 5F   
   $��20��6   $��5��6    5H      5I      