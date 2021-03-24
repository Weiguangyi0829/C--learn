using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class iGetRedBig : MonoBehaviour
{
    public item slotItem;
    public Image slotImage;
    public Text slotNum;

    public void ItemOnEnter()
    {
        bagManager.UpdateItemInfo(slotItem.itemInfo);   
    }
    
}
