using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory
{
    private List<string> items = new List<string>();
    public void AddItem(string item)
    {
        items.Add(item);
    }

    public void ShowItems()
    {
        string itemList = "";

        foreach (string item in items)
    {
        // Add the item to the list with a comma and space
        itemList += item + ", ";

    }

    if (itemList.Length > 0)
    {
        itemList = itemList.Substring(0, itemList.Length - 2);
    }

    // Print the result
    Debug.Log("Inventory contains: " + itemList);

     
    }

    public static Inventory operator +(Inventory inv1, Inventory inv2)
    {
        Inventory Allitems = new Inventory();

        
        foreach (string item in inv1.items)
        {
            Allitems.AddItem(item);
            Debug.Log(inv1.items);
        }

        foreach (string item in inv2.items)
        {
            Allitems.AddItem(item);
            Debug.Log(inv2.items);
        }

        return Allitems;
    }

}
