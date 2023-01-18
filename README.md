# EmployeeWebApplication
This is a simply crud application used for employee management



Employee Management Web-App
User manual and installation guide 











Installation guide 

To install this web application to your computer or laptop you will need two software’s which are visual studio and Microsoft SQL server management studio 18.

Step 1:
Open the scripted database file named EmployeeDB in Microsoft SQL server management studio 18. After opening this file, please execute it in Microsoft SQL server management studio 18.

Step 2:
Now open the application folder named EmployeeWebApplication in visual studio.


Step 3:
Before running the application in visual studio, you must connect visual studio to your database.




Step 4:
After successfully connect the web application with the database, You have to change the connection string in the EditData.aspx.cs class line number 15  and also the AddData.aspx.cs class line number 15.

If the step above were properly followed now the web application is ready for use.

End of installation guide.













User manual
1)	 The first thing you will come across when running this web application is the home/ welcome page. 
This page contains:
•	A navigation bar at the top of the page, which you can find on all the pages of this web application.
•	A continue button which when clicked will take you to the add data page which is used to insert data into the database.


 





2)	 This is the add data page ,this page is used to insert data into the database.

 

How to insert data
•	Enter an employee’s name in the employee name textbox.
•	Enter an employee’s surname in the  employee surname textbox.
•	Pick the birth date of an employee from the date of birth textbox.
•	Pick the employee’s employment status from the employee status drop down.
•	A submit button which must be click after filling the textboxes above, clicking of this button will result in data being inserted into our database.
 

 




Addition information
•	On this page we have a clear button which when clicked will clear all the textboxes.
•	On this page we have a grid view which display all the records which are stored in the database.
















3) This is the edit data page , on this page you can perform to task which are update and delete.
 


How to update data
•	Enter an employee’s code in the employee code textbox( make sure this code match with the employee’s code you want to update).
•	Enter an employee’s name in the employee name textbox.
•	Enter an employee’s surname in the  employee surname textbox.
•	Pick the birth date of an employee from the date of birth textbox.
•	Pick the employee’s employment status from the employee status drop down.
•	 Update button which must be click after filling the textboxes above, clicking of this button will result in data being updated where employee code match.
 


 


How to delete data
•	Enter an employee’s code in the employee code textbox(make sure this code match with the employee’s code you want to delete)
•	 Delete button which must be click after filling the employee code textbox, clicking of this button will result in data being deleted where employee code match.
 

 

Addition information
•	On this page we have a grid view which display all the records which are stored in the database.



End of user manual

