   M S B A M L   `   `   `  ����F  BSalesWPFApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:SalesWPFAppSalesWPFApp  5           SalesWPFApp.WindowHomepage   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      +localclr-namespace:SalesWPFApp     5        N� Title$  Homepage��5       N� 
Background
 �����$	��400��6+   $	��600��68   .��5
      � .+�5   
   �� -   5        $��Member��5   ,   $
��Left=�6=   $��	26,23,0,0q�6X   $	��Top=�6k    J� RenderTransformOrigin$ 0.495,0.551&�6�   $��80��6�   $��25��6�   �� 5   
   -   5        $��Product��5   -   $
��Left=�6?   $��
126,23,0,0q�6Z   $	��Top=�6n   $��25��6�   $��80��6�   �� 5   
   -   5        $��Order��5   +   $
��Left=�6;   $��
226,23,0,0q�6V   $	��Top=�6j   $��80��6�   $��25��6�   �� 5   
   $��Welcome back, ADMIN��6   $
��Left=�6.   $��
329,23,0,0q�6I   $	��Top=�6]   $��25��6u   $	��170��6�   $
��Bold"�6�   �� 5   
   -   5        $��Log Out��5   )   $
��Left=�6;   $��
499,23,0,0q�6V   $	��Top=�6j   $��80��6�   $��25��6�   �� 5   
   -   5        $��
objectList��5      $��
5,117,5,61q�6�    �� View 5      �� 5      .P�5      �� $��	Member ID��6%    �� Width$
 Auto��69    �� DisplayMemberBinding 5   %   ��  �� Path$ MemberId��� 5      $��Email��6%   $
 Auto��64    5   %   �� $ Email��� 5      $��Company Name��6%   $
 Auto��6<    5   %   �� $ CompanyName��� 5      $
��City��6%   $
 Auto��63    5   %   �� $
 City��� 5      $��Country��6%   $
 Auto��67    5   %   �� $ Country��� 5      $��Password��6%   $
 Auto��68    5   %   �� $ Password�5      5!      �� 5"   
   -   5        $��
labelTitle��5"      $��Member Management��6"   $
��Left=�6>   $��	10,63,0,0q�6Y   $	��Top=�6l   $	��241��6�   $��38��6�   $
��Bold"�6�   $��20(�6�   �� 5#   
   -   5        $��Create��5#      $
��Left=�6:   $��
78,356,0,0q�6U   $	��Top=�6i   $��80��6�   $��25��6�   �� 5$   
   -   5        $��Delete��5$      $
��Left=�6:   $��199,356,0,0q�6U   $	��Top=�6j   $��80��6�   $��25��6�   �� 5%   
   $%��(Update by double-click on Row)��6   $
��Left=�6:   $��338,356,0,0q�6U   $	��Top=�6j   $��25��6�   $	��190��6�   �� 5'   
   -	   5        $��lblSearchProduct��5'   $   $y�Hidden=�6   $��Search Product��6<   $
��Left=�6U   $��
262,69,0,0q�6p   $	��Top=�6�   $��92��6�   �� 5(   
   -
   5        $��txtSearchProduct��5(   &   $y�Hidden=�6   $
��Left=�6>   $��
364,73,0,0q�6Y    �� TextWrapping$ NoWrap=�6m    �� AcceptsReturn$ False��6�   $	��Top=�6�   $	��138��6�   �� 5)   
   -   5        $��btnSearchProduct��5)   %   $y�Hidden=�6   $��Search��6U   $
��Left=�6f   $��
517,72,0,0q�6�   $	��Top=�6�   $��62��6�   �� 5+   
   -   5        $��lblReportTitle��5+   $   $y�Hidden=�6   $.��(Statistic Sales Report (By Shipped Date)��6:   $
��Left=�6m   $��
251,55,0,0q�6�   $	��Top=�6�   $	��256��6�   �� 5,   
   -   5        $��lblFrom��5,   $   $y�Hidden=�6   $
��From��63   $
��Left=�6B   $��
251,82,0,0q�6]   $	��Top=�6q   $��55��6�   $��26��6�   (  "System.Windows.Controls.DatePicker  5-   
   -   5        $��dtStartDate��5-   )   $y�Hidden=�6   $
��Left=�6<   $��
290,83,0,0q�6W   $	��Top=�6k   �� 5.   
   -   5        $��lblTo��5.   $   $y�Hidden=�6   $��To��61   $
��Left=�6>   $��
397,83,0,0q�6Y   $	��Top=�6m   $��55��6�   $��26��6�     5/   
   -   5        $��	dtEndDate��5/   )   $y�Hidden=�6   $
��Left=�6:   $��
418,84,0,0q�6U   $	��Top=�6i   �� 50   
   -   5        $��	btnExport��50   %   $y�Hidden=�6   $��Export��6N   $
��Left=�6_   $��
528,85,0,0q�6z   $	��Top=�6�   $��51��6�   51      52      