using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public static class GameUtils 
{
  public static string DescribeItem<T>(T Weapone)
  {
     return "" + "This item is" + "" + Weapone; 
    // How can i Make space between the words on the console ? 
    // it shows without spaces even when i put ""
  }   
}
