# Inventory Application in C#
This program is a simple GUI application that allows for manual entry of items in an inventory and displaying everything stored.
The input fields are for the attributes of the items: ID, description, cost, quantity.
The functions are Add Item, Clear, Display, Reset, and Exit.

## Input Fields
* Item #/ID - This is the numerical ID for the item. This input field will not accept any entry other than numbers and control keys.
* Description - This is the description of the item. It is free text up to 300 characters long.
* Cost - This is the cost of the item. This input field will only allow numerical entries and a single decimal.
* Quantity - This is the quantity of the item in inventory. This input field will not accept any entry other than numbers and control keys.

### Functions
* Add Item - Add a new item to the inventory using the text entered into the input fields. All input fields need to be filled out for this function to work; a warning will be displayed if any input field is empty.
* Clear - Clear all input fields.
* Display - Display the contents of the inventory in the read-only text box in the bottom of the screen. Each item attribute will be displayed in a column.
* Reset - Clear the inventory and the input fields. This function returns the program to its starting state.
* Exit - Exit program.
