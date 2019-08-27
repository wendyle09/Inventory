using System;
using System.Text;

namespace SimpleInventory
{
   class Items
   {
      private int _ID;
      private string _descript;
      private double _cost;
      private int _quantity;

      // constructor
      public Items(int intID, string strDescript, double dblCost, int intQuantity)
      {
         _ID = intID;
         _descript = strDescript;
         _cost = dblCost;
         _quantity = intQuantity;
      }

      // properties
      public int ID
      {
         get
         {
            return _ID;
         }
      }

      public string Description
      {
         get
         {
            return _descript;
         }
      }

      public double Cost
      {
         get
         {
            return _cost;
         }
      }

      public int Quantity
      {
         get
         {
            return _quantity;
         }
      }
   }
}
