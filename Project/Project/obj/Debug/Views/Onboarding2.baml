   M S B A M L   `   `   `  ����B  >Project, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:ProjectProject  5      7 clr-namespace:Project.ViewModelsProject.ViewModels  5          Project.Onboarding2   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      'localclr-namespace:Project     5      /vm clr-namespace:Project.ViewModels     5      $	��900��5	      $	��470��6     N� 
Background
  ����  N� Title$
 Home��5       � DataContext 5      -  'Project.ViewModels.Onboarding2ViewModel  5   
   .��5      � 
������ .+�5   
   �� $	��200��6   $	��200��6    $��	15,0,15,0q�60   $��Center=�6C    �� Padding$ 30q�6^   $	��500��6k    �� CornerRadius$ 55��6z   ���#020504$	��900��6�    J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5         
BlurRadius$ 25Q�6#      Color$ Transparent��63      ShadowDepth$ 3Q�6G   5      �� 5   
   $��/Photos/Onboard2.png��6   $
��Fill=�6.   $��15,252,15,0q�6=   �� 5   
   $��Quick purchase��6   $��28(�6)   ���#EEEEEE$��Roboto)�6L   $��Center=�6`   $��0,656,0,200q�6}   �� 5   
   $2��,View thе schedule and choose the best seats��6   $
��Wrap=�6G   	 �� TextAlignment$	 Center=�6[   $��19(�6r   ���#EEEEEE$��Roboto)�6�   $��87,714,87,136q�6�   �� 5   
   $ 6��6   ���#B10808$��57,778,56,74q�67   ._�5       �� 
������ 
 � Cursor$

 Hand��6R   $��Continue��6`   
������ $��Roboto)�6�   ���#EEEEEE$��18(�6�      TransparentButtonStyle#��[  6�   ��6   �� *ContinueCommand+6�   5!      �� 5#   
   #��[  61   
������ 
������ $��0q�6�   $
��Skip��6�   $	��Top=�6�   $��Roboto)�6�   $��19(�6�   ���#808080$

 Hand��6  $��378,111,56,0q�6  ��6   �� *SkipCommand+6  �� 5%   
   $��/Photos/PageControl2.png��6   $
��Fill=�62   $��39,826,38,30q�6A   $	��393��6W   $��44��6c   �� 5(   
   -   5         ��Name$
 Time��5(      $��75,35,0,833q�6   ���#B3B3B3$
��Left=�6I   $��20(�6d   $��San Francisco)�6r   $��SemiBold"�6�   �� 5)   
   $��/Photos/DynamicIsland.png��6   $
��Fill=�63   $��155,26,155,824q�6B   �� 5*   
   $��/Photos/Wi-fi.png��6   $
��Fill=�6+   $��345,39,43,837q�6:   �� 5+   
   #��[  62   $

 Hand��6b   
������ 
������ $��0q�6�   $��Center=�6�   $��
0,878,0,10q�6�   ��6   �� *CloseCommand+.��5,      �� $��/Photos/HomeBar.png��6   $
��Fill=�61   $��10��6@   $	��188��6L   5-      5.      5/      