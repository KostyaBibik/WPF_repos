   M S B A M L   `   `   `  ����B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp1WpfApp1  5   	       WpfApp1.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WpfApp1     5   	   b ^MaterialDesignThemes.Wpf, Version=4.1.0.2556, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	     � Title$	  App��5	   	   $	��600��6   $	��750��6"   .��5
      � -   5         �Name$ MainRoot��5
      
����=H�.+�5   
   �� $	��400��6   $��15q�6    
����� �$��Center=�6B    �� Padding$
 30pxq�6]   $	��550��6l    �� CornerRadius$ 20��6{    J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5         
BlurRadius$ 20Q�6#      Color$ DarkGray��63      ShadowDepth$ 0Q�6D   5      ._�5      �� .+�5      �� $��Hello��6   $��30(�6)   $
��Bold"�67   $��0 0 0 20q�6I   6]   � 5      $��0 0 0 20q�6   .+�5      �� $
��Left=�6   $��registration��68   6Q   �� 5      -   5        $��Right=�5         MaterialDesignFlatButton#��[  69   $��enter��6k   6�   5      �� 5      -   5         ��Name$ TextBoxLogin��5      )  #MaterialDesignThemes.Wpf.HintAssist	   Hint$	 Enter login��60    % !MaterialDesignFloatingHintTextBox#��[ 6]   6�   G� 5      -   5        
 G�Name$
 PasswordBoxPassword��5      $	 Enter password��6;    ) %MaterialDesignFloatingHintPasswordBox#��[ 6k   6�   G� 5      -   5        $
 RePasswordBoxLogin��5      $	 Re-Enter password��6:   #��[ 6m   6�   �� 5      -   5        $ textBoxMail��5      $	 
Enter mail��6/   #��[ 6[   6�   �� 5      -   5        $��sign up��5      $��	0 0 10 10q�6+   6V   5      5      5      5      