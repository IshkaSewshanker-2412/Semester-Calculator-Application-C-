   M S B A M L   `   `   `  ????V  RTime Management Application, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:Time_Management_ApplicationTime_Management_Application  5   	   .    (Time_Management_Application.MenuInfoPage   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ;local)clr-namespace:Time_Management_Application     5   	     ? Title$A  ;Menu Information Page - Desktop Time Management Application??5   	   $	??700??6M   $
??1000??6Z   $??DemiBold"?6g   ??5	      ?? 5
   
    ?? ImageSource$ Images/calendar.jpg??6   .??5      ? $??0,0,2,0q?6    ? ColumnDefinitions 5   
   ?? 5      $
??616* ?6   ?? 5      $
??227* ?6   .+?5   
   ?? $P??JWelcome to the menu page, Please insert the following information below : ??6   
???????$??20(?6x   $
??Left=?6?   $??	22,15,0,0q?6?   $	??Top=?6?    J? RenderTransformOrigin$ 0.5,0.5&?6?   $	??770??6?   $??2??6?   z?5      V? 5      .~?5      ?? ?? 5      ?? 5       ?? Angle$ -0.546Q?6&   T? 5      5      5      ?? 5!   
   $1??+Enter the number of weeks in the Semester: ??6   $
??Left=?6F   $??	9,123,0,0q?5"      $	??Top=?6    $	??368??68   
???????$??17(?6W   ?? 5$   
   -   5         ??Name$ txtbox_WeeksInSemester??5%   9   $
??Left=?5$      $??23??6-   $??430,133,0,0q?69    ?? TextWrapping$
 Wrap=?6N   $?? ??5%      $	??Top=?6   $	??120??6-   69   ?? 5'   
   $-??'Enter the start date for the Semester: ??6   $
??Left=?6B   $??	9,197,0,0q?5(      $	??Top=?6    $	??368??68   
???????$??17(?6W   (  "System.Windows.Controls.DatePicker  5*   
   -   5          Name$ DateTimeStart??5+   !   $
??Left=?5*      $??411,197,0,0q?60   $	??Top=?6E   $??65??6]   $	??249??5+      6!   ?? 5.   
   -   5         ??Name$ 
btn_cancel??5/   @   $??CANCEL??5.      $
??Left=?6"   $??112,391,0,0q?6=   $	??Top=?6R   $	??165??5/      $??64??6   6@   ?? 50   
   -   5        $ btn_Next??50   P   $
??NEXT??6   $
??Left=?6    $??489,391,0,0q?6;   $	??Top=?51      $	??171??6)   $??64??65   6A   ?? 52   
   -   5        $ btn_Save??53   V   $??Save Date!!!??52      $
??Left=?6(   $??255,293,0,0q?6C   $	??Top=?53      $	??190??6)   $??44??65   6V   57      58      