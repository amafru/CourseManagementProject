Feature: InstructorTab

@InstructorTab
Scenario: Verify that a User can create a new Instructor record
Given that Course Management System is successfully loaded on Google Chrome browser
When a user clicks on Instructor link
And a user clicks on Create New link
And a user navigates to Family name field and inputs Thomas
And a user navigates to First Name fields and inputs Samantha
And a user navigates to Hire Date and inputs 01/09/2018
And a user clicks on Create button
Then a new Instructor record should be created


Scenario: Verify that a User can amend an existing Instructor record
Given that Course Management System is successfully loaded on Google Chrome browser
When a user clicks on Instructor link
And a user clicks on edit link for existing record ‘Samantha Thomas’
And a user navigates to Family name field and inputs Jones
And a user clicks Save button
Then the existing record should be edited


Scenario: Verify that a User can see details of an existing Instructor record 
Given that Course Management System is successfully loaded on Google Chrome browser
When a user clicks on Instructor link
And a user clicks on details link for existing record ‘Samantha Thomas’
Then details for existing record should display


Scenario: Verify that a User can delete an existing Instructor record
Given that Course Management System is successfully loaded on Google Chrome browser
When a user clicks on Instructor link
And a user clicks on delete button for existing record ‘Samantha Thomas’
And clicks delete button
Then the record should be successfully deleted

