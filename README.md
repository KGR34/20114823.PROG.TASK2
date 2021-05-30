# 20114823.PROG.TASK2

INTRODUCTION : 
This project is named "Budget App" it is a personal budget planner that is meant to help
a user named Siphiwe to understand how planning and budgeting works and can help him after university.

DESCRIPTION :
This application asks the user to input this monthly income, tax deductions, general expenses and gives them 
the option to choose between Renting, Home Loan or a Vehicle Loan or a combination of the 3. Depending on the 
information the user has chosen to input the application can then calculate the following: Monthly Home Repayment, 
Monthly Vehicle Repayment, Total Expenses and Income Less Expenses. The application will output these calculated
values in message boxes and will output a list of expenses in descending order to a list box.
The application will also send alert messages to the user for the following: if the monthly Home Loan repayment is
greater than 1 thirtd of the users gross income, if the users total Expenses are greater than 75% of their Income,
if the user does not input a valid number. 

Some challenges faced while building the application include outputting the expenses in descending order and implementing
the delegate which should send out an alert. I would like to implement the ability for the application to offer
the user the option to save up for a specified reason over a period of time, the application will then calculate 
the monthly amound needed to be saved to reach that goal within the given timeframe.

HOW TO :
There are 2 branches for this application on Github. The Master branch has a version of the application that runs
perfectly and completes all required functions correctly. The Delegate_Attempt branch has an updated version of the
application that does not function 100% correctly as the delegate which runs the method to warn the user if their
Expenses exceed 75% of their Income does not work correctly and will show errors.

To run any version navigate to the "Git" tab on the top left toolbar of VisualStudio and choose 
to "clone a repository". A window will open and under "Repository location" paste the url to this GitHub repository
and click "Clone" on the bottom right corner of the window. 

The code for the application should now be shown in your Solution Explorer located on the right side of the screen.
To run the application look to the top middle of the window and click on the GREEN tringle which will then 
run the application.

Once the application is open you can input all required values into their textboxes and have the option to select
between Rent, Home Loan and Vehicle loan or a combination of them but NOT Rent and Home Loan at the same time.
(The application should not allow this if it is working correctly). After you have input your values click
the button labelled "SUBMIT" and the application will output the required information to you. You can also
choosee to click the "VIEW EXPENSES" button which will display a list of expenses in descending order to you.


MIT License

Copyright (c) [2021] [Kiashan Govender]

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
