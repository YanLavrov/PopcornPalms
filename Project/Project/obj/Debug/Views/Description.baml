   M S B A M L   `   `   `  ����B  >Project, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:ProjectProject  5      7 clr-namespace:Project.ViewModelsProject.ViewModels  6+       Project.Description   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      'localclr-namespace:Project     5      /vm clr-namespace:Project.ViewModels     6+   $	��900��5      $	��470��6     N� 
Background
  ����  N� Title$
 Home��5
       � DataContext 5      -  'Project.ViewModels.DescriptionViewModel  5   
   .��5      � 
������ .+�5   
   �� $	��200��6   $	��200��6    $��	15,0,15,0q�60   $��Center=�6C    �� Padding$ 30q�6^   $	��500��6k    �� CornerRadius$ 55��6z   ���#050B19$	��900��6�    J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5         
BlurRadius$ 25Q�6#      Color$ Transparent��63      ShadowDepth$ 3Q�6G   5      �� 5   
   -   5        	 ��Name$	 Border1��5      $ 55��6"   ���#242635���#141726$��1q�6_   $��15,791,15,0q�6s   ._�5      �� 
 � Cursor$

 Hand��65   
������ 
������ ���#EEEEEE$��Roboto)�6�   $��18(�6�      TransparentButtonStyle#��[  6�   $
��Left=�6�   $��48��6�   $��
35,14,0,26q�6  ��6   �� *MainCommand+.��5      �� $��/Photos/HomeGray.png��6   $��40��66   $��Center=�6A   $��Center=�6\   5      5      �� 5   
   $

 Hand��63   
������ 
������ ���#EEEEEE$��Roboto)�6�   $��18(�6�   #��[  6�   $
��Left=�6�   $��48��6�   $��155,803,0,25q�6  ��6   �� *TicketCommand+.��5      �� $��/Photos/TicketsGray.png��6   $��40��65   $��Center=�6@   $��Center=�6[   5      �� 5   
   $

 Hand��64   
������ 
������ ���#EEEEEE$��Roboto)�6�   $��18(�6�   #��[  6�   $
��Left=�6�   $��48��6�   $��269,803,0,25q�6  ��6   �� *SupportCommand+.��5       �� $��/Photos/HelpGray.png��6   $��40��62   $��Center=�6=   $��Center=�6X   5!      �� 5"   
   $

 Hand��64   
������ 
������ ���#EEEEEE$��Roboto)�6�   $��18(�6�   #��[  6�   $
��Left=�6�   $��48��6�   $��371,803,0,25q�6  ��6   �� *ProfileCommand+.��5#      �� $��/Photos/UserGray.png��6   $��40��62   $��Center=�6=   $��Center=�6X   5$      �� 5&   
   $��/Photos/AQuietDesk.png��6   $
��Fill=�60   $��15,0,15,608q�6?   �� 5'   
   $ 6��6   ���#B10808$��47,237,47,623q�67   ._�5(      �� 
������ $

 Hand��6S   $��
Buy ticket��6a   
������ $��Roboto)�6�   ���#EEEEEE$��18(�6�   #��[  6�   ��6   �� *BuyTicketCommand+6�   5)      �� 5+   
   $��Description��6   $��Roboto)�6&   $��18(�6:   $	��Top=�6H   $
��Left=�6`   ���#EEEEEE$��
47,319,0,0q�6�    J� RenderTransformOrigin$ 0.554,0.538&�6�   �� 5,   
   -   5        $
��Full��5,      $

 Hand��6    #��[  6.   $	��Top=�6^   $
��Left=�6v   $��Roboto)�6�   $��14(�6�   ���#D9D9D9
������ 
������ $��0q�6�   $��401,328,0,0q�6  6$  �� 5.   
   $
��Wrap=�6    �� 
LineHeight$ 24��6(   ���#808080$��Roboto)�6M   $��16(�6a   $����A young woman named Samira, long resigned to the fact that she is dying of cancer, takes a bus to New York to watch a puppet show and eat her favorite pizza. On her way back, she finds herself in the midst of a bloodbath: the Earth is under attack by deadly creatures from outer space that navigate by hearing.��6o   $��47,366,47,390q�6�  �� 50   
   $��Trailer��6   $��Roboto)�6"   $��18(�66   $	��Top=�6D   $
��Left=�6\   ���#EEEEEE$��
47,539,0,0q�6�   $ 0.756,0.548&�6�   � 52   
   .+�53      r� -   5        $��mediaElement��53       r� LoadedBehavior$ Manual=�6/   $��-10,575,-6,119q�6G   �� 54      -   5         ��Name$ PlayvsPause��54      $

 Hand��6*   #��[  68   
������ $	��Top=�6�   $
��Left=�6�   
������ $��0q�6�   $��34��6�   $��30��6�   $��216,753,0,0q�6�   .��55      �� -   5         ��Name$ Image��55      $��/Photos/PlayerPlay.png��6'   $
��Fill=�6G   $��24��6V   $��27��6b   56      57      �� 5:   
   $��/Photos/DynamicIsland.png��6   $
��Fill=�63   $��155,26,155,824q�6B   �� 5;   
   -   5         ��Name$
 Time��5;      $��75,35,0,833q�6   ���#B3B3B3$
��Left=�6I   $��20(�6d   $��San Francisco)�6r   $��SemiBold"�6�   �� 5<   
   $��/Photos/Wi-fi.png��6   $
��Fill=�6+   $��345,39,43,837q�6:   �� 5=   
   #��[  62   $

 Hand��6b   
������ 
������ $��0q�6�   $��Center=�6�   $��
0,878,0,10q�6�   ��6   �� *CloseCommand+.��5>      �� $��/Photos/HomeBar.png��6   $
��Fill=�61   $��10��6@   $	��188��6L   5?      5D      5E      