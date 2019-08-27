// Wendy Le
// March 29, 2012
// Program allows user to add new items to an inventory. Item details that can be saved are ID, description, cost and quantity.
// User will also have the option to display all items added to the inventory in a table format.

using System;
using System.Windows.Forms;
using System.Collections.Generic;

namespace SimpleInventory
{
    public partial class frmInventory : Form
    {
        // Declare global variables
        private List<Items> listItems = new List<Items>();      // list of objects defined as class Items
        private int intLongestID, intLongestDesc, intLongestCost, intLongestQuant = 5;      // integers to track inputs longer than 5 characters used for display padding

        public frmInventory()
        {
            InitializeComponent();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            int intID;
            string strDescript;
            double dblCost;
            int intQuantity;

            try
            {
                intID = Convert.ToInt32(txtBxID.Text);
                strDescript = txtBxDescription.Text;
                dblCost = Convert.ToDouble(txtBxCost.Text);
                intQuantity = Convert.ToInt32(txtBxQuantity.Text);

                listItems.Add(new Items(intID, strDescript, dblCost, intQuantity));     // creates new Items object and add to listItems

                // Set new longest input lengths

                if (txtBxID.Text.Length > intLongestID)
                    intLongestID = txtBxID.Text.Length;

                if (strDescript.Length > intLongestDesc)
                    intLongestDesc = strDescript.Length;

                if (txtBxCost.Text.Length > intLongestCost)
                    intLongestCost = txtBxCost.Text.Length;

                if (txtBxQuantity.Text.Length > intLongestQuant)
                    intLongestQuant = txtBxQuantity.Text.Length;

                MessageBox.Show("Item added.", "Successful Entry");
            }
            catch (FormatException)    // catch input errors
            {
                MessageBox.Show("Please check your entries and try again.", "Invalid Input");    // inform user of illogical input
                txtBxID.Focus();
                txtBxID.SelectAll();
            }  // end try catch for format exceptions

            BtnClear_Click(sender, e);
        }  // end BtnAdd_Click

        private void BtnDisplay_Click(object sender, EventArgs e)
        {
            int intIDPad, intDescPad, intCostPad, intQuantPad;

            // Set padding for each column based on longest input plus up to 10 more spaces
            intIDPad = (intLongestID / 5 + 2) * 5;
            intDescPad = (intLongestDesc / 5 + 2) * 5;
            intCostPad = (intLongestCost / 5 + 2) * 5;
            intQuantPad = (intLongestQuant / 5 + 2) * 5;

            // display headers
            txtBxOutput.Text = "Item #".PadRight(intIDPad) + "Description".PadRight(intDescPad) + "Cost".PadLeft(intCostPad) + "Quantity".PadLeft(intQuantPad) + "\n";

            // for loop traverses listItems to display added items
            foreach (Items item in listItems)
            {
                txtBxOutput.AppendText(item.ID.ToString().PadRight(intIDPad));       // displays item #
                txtBxOutput.AppendText(item.Description.PadRight(intDescPad));       // displays item's description
                txtBxOutput.AppendText(item.Cost.ToString("c").PadLeft(intCostPad));       // displays item's cost converted to currency format
                txtBxOutput.AppendText(item.Quantity.ToString().PadLeft(intQuantPad));         // displays item's quantity
                txtBxOutput.AppendText("\n");
            }  // end for loop
        }  // end BtnDisplay_Click

        // clear text boxes
        private void BtnClear_Click(object sender, EventArgs e)
        {
            txtBxID.Text = "";
            txtBxDescription.Text = "";
            txtBxCost.Text = "";
            txtBxQuantity.Text = "";
            txtBxOutput.Text = "";
            txtBxID.Focus();
        }  // end BtnClear_Click

        // clear all entries in listItems after confirming action with user's consent
        private void BtnReset_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Selecting Reset will clear all entries made.\nAre you sure you want to continue with the reset?", "Reset Confirmation", MessageBoxButtons.YesNo);

            // check user's selection
            if (result == DialogResult.Yes)        // if user wants to proceed with reset
            {
                listItems.Clear();
                BtnClear_Click(sender, e);
                MessageBox.Show("All entries were erased.", "Reset Completed");     // inform user of reset completion
            }
            else
            {
                MessageBox.Show("Reset was cancelled.", "Reset Cancelled");       // inform user of reset cancellation
            }  // end if else

            txtBxID.Focus();
        }  // end BtnReset_Click

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }  // end BtnExit_Click


        // When user's tab stops at each of the following text boxes, contents of respective boxes will be selected
        private void TxtBxDescription_Enter(object sender, EventArgs e)
        {
            txtBxDescription.SelectAll();
        }  // end TxtBxDescription_Enter

        private void TxtBxID_Enter(object sender, EventArgs e)
        {
            txtBxID.SelectAll();
        }  // end TxtBxID_Enter

        private void TxtBxCost_Enter(object sender, EventArgs e)
        {
            txtBxCost.SelectAll();
        }  // end TxtBxCost_Enter

        private void TxtBxQuantity_Enter(object sender, EventArgs e)
        {
            txtBxQuantity.SelectAll();
        }  // end TxtBxQuantity_Enter

        private void TxtBxID_KeyPress(object sender, KeyPressEventArgs e)
        {
            // restrict to numbers and control keys
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        } // end TxtBxID_KeyPress_KeyPress

        private void TxtBxQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            // restrict to numbers and control keys
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        } // end TxtBxQuantity_KeyPress

        private void TxtBxCost_KeyPress(object sender, KeyPressEventArgs e)
        {
            // restrict to numbers, decimal and control keys
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            // restrict multiple decimals
            if (e.KeyChar == '.' && txtBxCost.Text.Contains("."))
            {
                e.Handled = true;
            }
        } // end TxtBxCost_KeyPress
    }  // end class frmInventory
}  // end namespace SimpleInventory