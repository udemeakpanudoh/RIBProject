Feature: Drag and Drop
  Scenario: Drag image to trash
    Given I navigate to the Drag and Drop page
    When I drag the image to the trash
    Then the image should be successfully dropped