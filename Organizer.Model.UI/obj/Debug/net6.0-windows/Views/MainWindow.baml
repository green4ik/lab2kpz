   M S B A M L   `   `   `  ����M  IOrganizer.Model.UI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:Organizer.Model.UI.ViewsOrganizer.Model.UI.Views  5   	   7 clr-namespace:Organizer.Model.UIOrganizer.Model.UI  5   	   M+clr-namespace:Organizer.Model.UI.ConvertorsOrganizer.Model.UI.Convertors  5   	   #    Organizer.Model.UI.MainWindow   5   	   0Views&clr-namespace:Organizer.Model.UI.Views  W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:Organizer.Model.UI     5   	   B
Convertors+clr-namespace:Organizer.Model.UI.Convertors     5   	     � Title$  
MainWindow��5	   	   $	��250��6   $	��600��6)    � 	Resources 5
      5   /Organizer.Model.UI.Convertors.ControlVisibility   my:ControlVisibility��%   &	          5   
   6F   5      .��5      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��* �6   .+�5   
   ��  �� Orientation$ 
Horizontal=�6   .+�5   
   �� $��0��6   .+�5      �� $��WeaponShops��6?   $��70��6^   $��20q�6i   
����� ���6   �� *SetControlVisibility+.��6�   Shops6�   �� 5      $
��Guns��6C   $��70��6[   $��20q�6f   
��� � ���6   �� *SetControlVisibility+.��6�   Guns6�   �� 5      $��
GunSellers��6C   $��70��6a   $��20q�6l   
���������6   �� *SetControlVisibility+.��6�   
GunSellers6�   5      �� 5   
   $��1��6   .+�5      2   ,Organizer.Model.UI.Views.GunSelerUserControl  y�6,   ��  �� Path$ VisibleControl� �� 	Converter# [   �� ConverterParameter$ 
GunSellers��-   'Organizer.Model.UI.Views.GunUserControl  5      y�6'   �� $ VisibleControl�# [  $
 Guns��4   .Organizer.Model.UI.Views.WeaponShopUserControl  5      y�6.   �� $ VisibleControl�# [  $ WeaponShops��5      5      5       5!      