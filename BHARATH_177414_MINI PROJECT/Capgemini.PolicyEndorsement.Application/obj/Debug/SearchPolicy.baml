   M S B A M L   `   `   `  ����b  ^Capgemini.PolicyEndorsement.Application, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nulla5clr-namespace:Capgemini.PolicyEndorsement.Application'Capgemini.PolicyEndorsement.Application  5   	   :    4Capgemini.PolicyEndorsement.Application.SearchPolicy   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Glocal5clr-namespace:Capgemini.PolicyEndorsement.Application     5   	     � Title$  SearchPolicy��5   	   $��446.617��6   $��695.112��6/   .��5	      �� .@�5
   
   �� $��Search By PolicyID��6   $
��Bold"�6.   $��14(�6@   .��5      � 
�������.+�5      �� $��Enter Policy ID :��6   $
��Left=�64   $��	44,24,0,0q�6O   $	��Top=�6b   �� 5      -   5        $��txtpolicyID��5      $
��Left=�6-   $��23��6H   $��
157,27,0,0q�6T    �� TextWrapping$
 Wrap=�6h   $	��Top=�6|   $	��120��6�   �� 5      -   5        $��	btnSearch��5      $��Search��6*   $
��Left=�6;   $��
329,30,0,0q�6V   $	��Top=�6j   $��75��6�   6�   &   System.Windows.Controls.DataGrid  5      -   5        $��dgPolicy��5      $
��Left=�6C   $	��259��6^   $��	36,83,0,0q�6k   $	��Top=�6~   $	��609��6�    � DataContext 6+   �� 6�   5      5      �� 5   
   $��Search By CustomerNumber��6   $
��Bold"�64   $��14(�6F   .��5      � 
�������.+�5      �� $��Enter CustomerNumber��6   $
��Left=�67   $��	40,30,0,0q�6R   $	��Top=�6e   �� 5      -   5        $��
txtCustNum��5      $
��Left=�6,   $��23��6G   $��
205,34,0,0q�6S   $
 Wrap=�6g   $	��Top=�6|   $	��120��6�   �� 5      -   5        $��
btnSearch1��5      $��Search��6+   $
��Left=�6<   $��
351,33,0,0q�6W   $	��Top=�6k   $��75��6�   6�     5      -   5        $��dgPolicyCNum��5      $
��Left=�6/   $	��259��6J   $��	40,85,0,0q�6W   $	��Top=�6j   $	��620��6�   6�   5      5      �� 5   
   $��Search By Name and DOB��6   $
��Bold"�62   $��14(�6D   .��5      � 
�������.+�5      �� $��Enter Name :��6   $
��Left=�6/   $��	54,10,0,0q�6J   $	��Top=�6]   �� 5      $��Enter DOB  :��6   $
��Left=�6/   $��	54,44,0,0q�6J   $	��Top=�6]   �� 5      -   5        $��txtName��5      $
��Left=�6)   $��23��6D   $��
160,15,0,0q�6P   $
 Wrap=�6d   $	��Top=�6y   $	��120��6�   �� 5      -   5        $��txtDob��5      $
��Left=�6(   $��23��6C   $��
160,48,0,0q�6O   $
 Wrap=�6c   $	��Top=�6x   $	��120��6�   �� 5       -	   5        $��
btnSearch2��5       $��Search��6+   $
��Left=�6<   $��
333,31,0,0q�6W   $	��Top=�6k   $��75��6�   6�     5!      -
   5        $��dgPolicyName��5!      $
��Left=�6/   $	��256��6J   $��	32,92,0,0q�6W   $	��Top=�6j   $	��621��6�   6�   5"      5#      5$      5%      