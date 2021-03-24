using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New bag", menuName = "bag/New bag")]
public class bag : ScriptableObject
{
   public List<item>itemList=new List<item>();
}
