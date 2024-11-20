using System;
using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;


public class GameContainer<T>
{

        public T Item;
        public void SetItem(T Item)
        {
         this.Item = Item;
        }
        
        public T GetItem()
        {
            return Item;
        }
 
    
}
    

        