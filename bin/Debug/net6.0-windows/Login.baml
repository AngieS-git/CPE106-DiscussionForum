   M S B A M L   `   `   `  ����Q  MCardinalThesisExchange, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:CardinalThesisExchangeCardinalThesisExchange  5   	   "    CardinalThesisExchange.Login   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   LmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes     5   	   6local$clr-namespace:CardinalThesisExchange     5   	     � Title$  Login��5	   	   $	��450��6   $	��800��6$   $��14(�60   ���#E74635.��5      �  � ColumnDefinitions 5   
   �� 5      $
��327* �6   �� 5      $	��73* �6   .+�5   
   �� $��0q�6   $��Right=�6   $	��Top=�69   $��
0,60,138,0q�6Q   $��Login��6e   $��Genera)�6u   ���#FFC635$��45(�6�   $��2��6�   6�   �� 5   
   $
��Left=�6   $	��Top=�6,   $	��317��6E   $	��335��5      $��	30,60,0,0q�6   $��Images/Cardinal 2.png��60   �� 5   
   -   5        $��Username��5      $
��Left=�6#   $��Genera Alt Light)�6?   
���   �$��460,121,0,0q�6p    �� TextWrapping$
 Wrap=�6�   $��Center=�6�   $	��Top=�6�   $	��282��6�   $��51��6�   $��18(�6�   $��2��6�   .��62   � 	Resources 5       �� 
TargetType �� Property �� Value��%^   '��       �� 5      " ��6   .�5      ��  �@��CornerRadius$ 0��65   5      5      .��6!   5      G� 5   
   -   5        $��Password��5      $
��Left=�6'   $��Genera)�6B    G� PasswordChar$	 •��6V   $��460,217,0,0q�6g   $��Center=�6|   $	��Top=�6�   $	��282��6�   $��51��6�   $��2��6�   �� 5!   
   -   5         ��Name$ LoginButton��5!      $��Login��6&   $��Genera)�66   ���#F0CE56$
��Left=�6`   $��440,304,0,0q�6{   $	��Top=�6�   $��73��6�   $	��322��6�   $��24(�6�   $��2��6�   ��6�   Z� ��5"      �� 5#      " ��6   .�5$      ��  � �� �#57342F63   �� 5%       � �� 5&      �� 5'      	 �� 
TargetType"	 ��6.   .R�5(   "   �� #��z��6)   ._�5)   &   �� $��Center=�67   $��Center=�6T   5*   #   5+      5-      
 �� Triggers
 5.      P� 5/       P� Property �@J�IsMouseOver P� Value$
 True��69   . �50      ��  � �� �#7C5B566;   51      53      55      �� 56   
   $
��Left=�6   $��32��6+   $��422,131,0,0q�67   $	��Top=�6L   $��30��6d   $��/Vector.png��6o    J� RenderTransformOrigin$ 0.243,0.501&�6�   �� 57   
   $
��Left=�6   $��418,194,0,186q�6+   $��42��6B   $��/bxs_lock-alt.png��6M   �� 58   
   $��Username��6   $��Genera Alt Light)�6#   
�������$
��Left=�6T   $��460,168,0,0q�6o   $	��Top=�6�   $��12(�6�   �� 59   
   $��Password��6   $��Genera Alt Light)�6#   
�������$
��Left=�6T   $��460,268,0,0q�6o   $	��Top=�6�   $��12(�6�   5;      5=      