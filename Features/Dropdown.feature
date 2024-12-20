Feature: Dropdown Menu
  Scenario: Select a country from the dropdown
    Given I navigate to the Dropdown Menu page
    When I select "India" from the dropdown
    Then the correct country should be selected