Feature: StudentTab

@StudentTab
Scenario: Verify that a User can create a new Student record
Given that Course Management System is successfully loaded on Google Chrome browser
When a user clicks on Student link
And a user clicks on Create New link
And a user navigates to Family name field and inputs Thomas
And a user navigates to First Name fields and inputs Samantha
And a user navigates to Enrollment Date and inputs 01/09/2018
And a user clicks on Create button
Then a new Student record should be created

| FamilyName | FirstName | EnrollmentDate |
| Thomas     | Samantha  | 01/09/2018     |


Scenario: Verify that a User can amend an existing Student record
Given that Course Management System is successfully loaded on Google Chrome browser
When a user clicks on Student link
And a user clicks on edit link for existing record ‘Samantha Thomas’
And a user navigates to Family name field and inputs Jones
And a user clicks Save button
Then the existing record should be edited



Scenario: Verify that a User can see details of an existing Student record 
Given that Course Management System is successfully loaded on Google Chrome browser
When a user clicks on Student link
And a user clicks on details link for existing record ‘Samantha Thomas’
Then details for existing record should display



Scenario: Verify that a User can delete an existing Student record
Given that Course Management System is successfully loaded on Google Chrome browser
When a user clicks on Student link
And a user clicks on details link for existing record ‘Samantha Thomas’
Then details for existing record should display
