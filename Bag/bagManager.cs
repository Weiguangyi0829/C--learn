using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class bagManager : MonoBehaviour
{
    static bagManager instance;

    public bag recover;
    public GameObject slotGrid;
    public iGetRedBig slotPerfabs;
    public Text itemInformation;
    public Text Number;

    void Awake()
    {
        if(instance!=null)
            Destroy(this);
        instance=this;
    }

    private void OnEnable()
    {
        RefreshItem();
        instance.itemInformation.text = "";
      
       
    }

    public static void UpdateItemInfo(string itemDescription)
    {
        instance.itemInformation.text = itemDescription;
    }

    

    public static void CreateNewItem(item item)
    {
        iGetRedBig newItem = Instantiate(instance.slotPerfabs, instance.slotGrid.transform.position, Quaternion.identity);
        newItem.gameObject.transform.SetParent(instance.slotGrid.transform);
        newItem.slotItem = item;
        newItem.slotImage.sprite = item.itemImage;
        newItem.slotNum.text = item.itemHeld.ToString();
    }

    public static void RefreshItem()
    {
        for (int i = 0; i < instance.slotGrid.transform.childCount; i++)
        {
            if (instance.slotGrid.transform.childCount == 0)
                break;
            Destroy(instance.slotGrid.transform.GetChild(i).gameObject);
        }
        for (int i = 0; i < instance.recover.itemList.Count; i++)
        {
            CreateNewItem(instance.recover.itemList[i]);
        }
    }
}
