   M S B A M L   `   `   `  ����I  EMahApps.Metro, Version=1.1.3.28, Culture=neutral, PublicKeyToken=nullV;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls  5   	    	MyFinance   MyFinance.Views.LoginView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   Pcontrols;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro     5   	   (   "MahApps.Metro.Controls.MetroWindow    IsCloseButtonEnabled  .     IsMaxRestoreButtonEnabled .     IsMinButtonEnabled .     AccentColorBrush#���   5   	     AccentColorBrush3   	GlowBrush# �  5   	    � Title$ MY CHECKBOOK - LOGIN��5   	   $	��259��6&   $	��479��63    � WindowStartupLocation$ CenterScreen=�5	   	    � WindowState$ Normal=�6.   .��5
      � $��Stretch=�6   $��Stretch=�6)    � RowDefinitions 5   
   �� 5      $��20 �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $��* �6    � ColumnDefinitions 5   
   �� 5      $	��100 �6   �� 5      $��* �6   .+�5   
   �� $��USERNAME��6   $��1��6$   $��0��61   $��10q�6A   �� 5   
   -   5        	 ��Name$	 TxtUserName��5      $��1��6'   $��1��64   $	��277��6E   $��0��6Q   $��
10,10,0,10q�5      *   $MahApps.Metro.Controls.TextBoxHelper
   	Watermark$
 enter username��6&   $
��Left=�6X   �� 5   
   $��PASSWORD��6   $��2��6$   $��0��61   $��10q�6A   G� 5   
   -   5         G�Name$ TxtPassword��5      $��2��6+   $��1��68   $��1��6H   $��
10,10,0,10q�5      $
��Left=�6&   $	��277��6A   �� 5   
   -   5        $��3��5      $��1��6    � Cursor$
 Hand��6.   $	��Top=�6<   $
��Left=�5       $��
10,30,0,10q�6,   $��4q�6@     MetroAccentButton#���  5!      $��2��6=   
������ $��0q�5"   +    �� 	IsDefault .  � ToolTip$  save changes ��5#      ��5$      �� 5%       �� Orientation$ 
Horizontal=�6   .+�5&      F� �����k5[ ��3�B[ �//M�u�//M���//M�h�3�B���k5��ӥ�'����h�������u���'[ ��k5[ ��A�!�\mөP��\m�1��z��1��ð��1�a�����}���#����	����	��tC�Ō��tC�Ō��+�PQ��+�PQ�u��a"�u��4�	�,�������S�/+�A�!/+����F/+�;e��;e�ð�;e�z���F�\mA�!�\m���76!��#_76!�(��;s�(�Dh���(�.�=�#_��������jƔ��%�B.�=%�BDh��%�B�;sjƔ76!���76!p�������P=Sg����6;��]�K7�\V}��c?p��c��M��g?S���\V}��c?L+���6;��]�*י�����P=S}�5��6;��]�_	S�ҵ@�/@K�N�l� ӈ�K� � �?C��� �?C��� Ә?C��� ��S��� ��S]���N�\!�/75;Ws)��\�)&aC�Ǡg;�.d��	>�[y�b�)��b�����b�c���C)ʫY�2Jӏ�7�pnZ#
֡nZ#Gj��nZ#����F��^pR|���    ���    +�����7��X�������
@�*��f� 
�^����6��7���7���ӊ�7)��E�6w�@�4.d�Ӟ�+Ǡ��aC��N��\ӈ 75;ſ� �\�� ]���� ��� P� ��� P� ��� �P� ��� l� � � �� �l� ST�� �ҵ@�/@�e���a0@��6;��]��������P=	  DefaultButtonPathStyle#���  5'   !   �� 5(      $�� LOGIN ��6!     DefaultButtonTextBlockStyle#���  60   5)      5+      5,      5-      