using System.Collections.Generic;
using System;

namespace OrderSystem
{
    public class Order
    {
        private List<ItemOrder> _orderList;

        public Order()
        {
            _orderList = new List<ItemOrder>();
        }

        public void AddItemOrder(ItemOrder newItem)
        {
            _orderList.Add(newItem);
        }

        public void PrintTotalWithNoMeal()
        {
            Console.WriteLine(QtyPeopleWithNoMeal());
        }

        int QtyPeopleWithNoMeal()
        {
            int sumPeople = 0;

            foreach (ItemOrder item in _orderList)
                sumPeople += item.QtyPeopleWithNoMeal();

            return sumPeople;
        }
    }

    public class ItemOrder
    {
        private Item _itemOrder;
        private int _qtyOrder;

        public ItemOrder(Item newItem, int qtyOrder)
        {
            _itemOrder = newItem;
            _qtyOrder = qtyOrder;
        }

        int DiferenceBetweenAvailableAndOrderValue => _itemOrder.Qty_Available - _qtyOrder;

        public int QtyPeopleWithNoMeal()
        {
            if (DiferenceBetweenAvailableAndOrderValue < 0)
                return Math.Abs(_itemOrder.Qty_Available - _qtyOrder);

            return 0;
        }
    }

    public class Item
    {
        private int _qty_Item;

        public Item(int qty)
        {
            _qty_Item = qty;
        }

        public void AddItem(int qtyToAdd)
        {
            _qty_Item += qtyToAdd;
        }

        public int Qty_Available => _qty_Item;
    }
}