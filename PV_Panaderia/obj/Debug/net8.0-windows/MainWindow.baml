   M S B A M L   `   `   `  ����G  CPV_Panaderia, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:PV_PanaderiaPV_Panaderia  5   	       PV_Panaderia.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:PV_Panaderia     5   	      WindowStyle#��[  5        � Title$  PuntoVentaPanaderia��5   	   $	��450��6%   $	��800��62    � DataContext 5	         PV_Panaderia.PuntoVenta  5
   
   -   5        
PuntoV��5
   -   .��5      ]� .+�5   
   � $	��280��6    � RowDefinitions 5      �� 5      $	��.3* �6    6/   �� 5      $	��.2* �6!   60   .+�5      �� $
��auto��6   .+�5      �� $��Center=�6   ���#CDE1E6$��DemiBold"�6Q   .��6g   SELECCIONE UN PRODUCTO6   �� 5      -   5         ��Name$ cmbPan��5      ���#CDE1E6 �� DisplayMemberPath$ 	NombrePan��6c    �� SelectedIndex$ 1��6�   ��6@   �� *
ListaPanes+6�   �� 5       �� Orientation$ 
Horizontal=�6   $��Center=�63   $��20q�6P   .+�5      �� 
���   �$��2q�6.   
�������._�5      �� $	��100��6X   $��70��6d   ��6   ��  �� ElementName$ cmbPan�� �� Path$ SelectedItem.Imagen�6r   5      �� 5      .+�5      �� .��6   	Precio:6%   �� 5    
   $��Center=�6m   $��Center=�6�   ��6   �� $ cmbPan��$ SelectedItem.Precio�	 �� StringFormat$	 
{0:$ 0.00}��6�   5!      5(      �� 5)      .+�5*      �� .��6   
Cantidad6&   �� 5+      ���#CDE1E6��64   �� *
Cantidad+.��6N   5-      5.      5/      �� 51      $��1��6   ���#B0C0C4.+�52      �� -   5        
 ��Name$
 
btnAgregar��52   >   
������$��25��62   ��6R   �� *AgregarCommand+��6u   �� $ cmbPan��$ SelectedItem�.��6�   	AGREGAR6�   �� 53      
��� E����6,   �� *EliminarCommand+��6P   �� $ cmbPan��$ SelectedItem�.��6�   
ELIMINAR��54      �� 55       �� Triggers 57      �� 58       �� Binding 6*   �� $ gridListaVenta��$ SelectedItem� �� Value 6m   Z� .a�59   "   ��  �� Property � {� �� Value$ False��6E   6U   5;      5=      5?      �� 5@      
�������$��PAGAR��6O   ��6.   �� *PagarCommand+��5A      �� 5B       5C      �� 5D       6*   �� $ gridListaVenta��$ Items.Count� 06k   .a�5E   "   ��  � {�$ False��6E   6U   5F      5I      5K      �� 5M      .��5N      �� 
���  ��$��WrapWithOverflow=�61   ��6Q   �� *	mensaje+5P      5Q      5R      5T      �� 5V   
   ���#B0C0C4 �� TextAlignment$ Right=�6*   $��	ExtraBold"�6@   $��Bottom=�6W   	TOTAL: �� 5W      �6   �� *Total+$	 
{0:$ 0.00}�� �� Mode$ OneWay=�6S   6Y   &   System.Windows.Controls.DataGrid  5Y   
   -   5          Name$ gridListaVenta��5Y      $
��auto��6,      AutoGenerateColumns$ False��6W      CanUserReorderColumns$ False��6s      CanUserDeleteRows$ False��6�      CanUserAddRows$ False��6�   ��69   �� *Panes+   Columns 5Z      0  *System.Windows.Controls.DataGridTextColumn  5[      ,  &System.Windows.Controls.DataGridColumn   Header$ Cantidad��6J      Width5  /System.Windows.Controls.DataGridLengthConverter$	 .2* 6\   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   �� *CantidadComprar+6j     5\      $ Articulo��6C   $	 .5* 6U    6%   �� *	NombrePan+6c     5]      $ Precio Unitario��6Z   $	 .3* 6s    6%   �� *Precio+$	 
{0:$ 0.00}��6�   5_      5b      5e      