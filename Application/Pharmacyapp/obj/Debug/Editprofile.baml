   M S B A M L   `   `   `  ����F  BPharmacyapp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:PharmacyappPharmacyapp  5   	       Pharmacyapp.Editprofile   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:Pharmacyapp     5   	     � Title$  Editprofile��5   	   $	��450��6   $	��800��6*    � 	Resources 5	         Button.MouseOver.Background �� Color  Button.MouseOver.Border  Button.Pressed.Background  Button.Pressed.Border  Button.Disabled.Background  Button.Disabled.Border  Button.Disabled.Foreground  ButtonTemplate1 �� 
TargetType ��Name �� CornerRadius J� SnapsToDevicePixels ��Name �� Triggers	 P� Property
 P� Value �� 
TargetName �� Value �� Property��%�  &	        &	 #     &	 F     &	 i     &	 �     &	 �     &	 �     &	 �     7   7  7  7  7  7  7  �� 5
   
   $ 	#FFBEE6FD��6>   �� 5   
   $ 	#FF3C7FB1��6:   �� 5   
   $ 	#FFC4E5F6��6<   �� 5   
   $ 	#FF2C628B��68   �� 5   
   $ 	#FFF4F4F4��6=   �� 5   
   $ 	#FFADB2B5��69   �� 5   
   $ 	#FF838383��6=   �� 5   
   " ��62   .R�5      �� $ border��6'   $ 20��6   #��z��67   #��z��6a   #��z��6�    . ._�5      �� $ contentPresenter��6#   |�.  #��z��6O   #��z��6�   ��. # z 6�   #��z��6  5       5      P� 5      	 �@��IsDefaulted
 . . �5      �� $ border��64   # � ��6H    � ��5      P� 5      	 �@J�IsMouseOver
 . . �5      �� $ border��63   8    � ��6G   �� 5      $ border��64   8   � ��6H   5      P� 5      	 � ��
 . . �5      �� $ border��63   8   � ��6G   �� 5      $ border��64   8   � ��6H   5       P� 5!      	 � {�
 .  . �5"      �� $ border��63   8   � ��6G   �� 5#      $ border��64   8   � ��6H   �� 5$      $ contentPresenter��6?   8   � ��6]   5%      5'      5(      ��5)      �� 5*   
    �� 
StartPoint$	 0,0&�6    �� EndPoint$	 1,1&�6/   .��5+      �  � Color$ #ff6699��6    � Offset$	 0.0Q�6+   � 5,      $ #80ffff��6   $	 1.0Q�6+   5-      .��5/      � .+�50   
   �� $��Name:��6   $��40(�6    $
��Bold"�6.   $
��Left=�6@   $��
57,115,0,0q�6[   $	��Top=�6o   �� 51   
   $��	Location:��6   $��40(�6$   $
��Bold"�62   $
��Left=�6D   $��
63,217,0,0q�6_   $	��Top=�6s   �� 52   
   -   5        $��namelbl��52      $��30(�6    $��SemiBold"�6.   $
��Left=�6D   $��194,122,0,0q�6_   $	��Top=�6t   �� 53   
   -   5        $��locationlbl��53      $��30(�6$   $��SemiBold"�62   $
��Left=�6H   $��250,224,0,0q�6c   $	��Top=�6x   �� 54   
   -   5        $��Updateuser_btn��54   P   #���  6   $��Update��6?   ���#ff6699$
��Left=�6{   $��565,337,0,0q�6�   $	��Top=�6�   $��49��6�   $	��139��6�   6�   �� 55   
   -   5        $��txtUsername��55   -   $
��Left=�6   $��518,133,0,0q�6B    �� TextWrapping$
 Wrap=�6W   $	��Top=�6l   $	��233��6�   $��35��6�   �� 56   
   -   5        $��txtLocation��56   -   $
��Left=�6   $��518,232,0,0q�6@   $
 Wrap=�6U   $	��Top=�6j   $	��233��6�   $��34��6�   �� 57   
   -   5        $��
Backnavbtn��57   M   #���  6   $
��Back��6>   ���#80ffff$
��Left=�6t   $��	36,26,0,0q�6�   $	��Top=�6�   $��44��6�   $��87��6�   6�   59      5:      