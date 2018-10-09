Feature: CourseTab
	
@CourseTab
Scenario: Verify that a User can create a new Course record
Given that Course Management System is successfully loaded on Google Chrome browser
When a user clicks on Course link
And a user clicks on Create New link
And a user navigates to Course Number field and inputs 1
And a user navigates to Title field and inputs Biology
And a user navigates to Credits field and inputs 3
And a user navigates to DepartmentID field and inputs Science
And a user clicks on Create button
Then a new student record should be created


Scenario: Verify that a User can amend an existing Course record
Given that Course Management System is successfully loaded on Google Chrome browser
When a user clicks on Course link
And a user clicks on edit link for existing record ‘Science – Biology – 3’ 
And a user navigates to Grade field and inputs 2
And a user clicks Save button
Then the existing record should be edited


Scenario: Verify that a User can see details of an existing Course record 
Given that Course Management System is successfully loaded on Google Chrome browser
When a user clicks on Course link
And a user clicks on details link for existing record ‘Science – Biology – 3’
Then details for existing record should display


Scenario: Verify that a User can delete an existing Course record
Given that Course Management System is successfully loaded on Google Chrome browser
When a user clicks on Course link
And a user clicks on delete button for existing record ‘Science – Biology – 3’
And clicks delete button
Then the record should be successfully deleted





	
