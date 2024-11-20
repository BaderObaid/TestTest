using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenericsTest : MonoBehaviour
{
    public void Start()
    {
      GameContainer<string> HealingBag = new GameContainer<string>();  
      HealingBag.SetItem("Healing Potion");
      HealingBag.GetItem();
      string StoringAnItem = HealingBag.GetItem();
      Debug.Log( "Item is Stored!" + "" + StoringAnItem);

      string ItemDescription = GameUtils.DescribeItem(StoringAnItem);
      Debug.Log(ItemDescription);
    }

}
