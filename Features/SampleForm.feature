Feature: Fill Sample Page Form
  As a user
  I want to fill out the form on the sample page
  So that the data is submitted successfully

  Scenario: Fill the form and submit
    Given I navigate to the sample page form
    When I fill out the form with the following details:
      | Field     | Value                       |
      | Name      | Udeme Akpanudoh             |
      | Email     | udeme.akpanudoh@gmail.com   |
      | Website   | https://example.com         |
      | Experience| 3-5                         |
      | Message   | This is a test form.        |
    Then the form is submitted successfully