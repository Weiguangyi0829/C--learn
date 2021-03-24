using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetRedBig : MonoBehaviour
{
    public  item thisItem;
    public  bag recover;
    

    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.CompareTag("Player"))
        {
            AddNewItem();
            Destroy(gameObject);
        }
    }
  
    
    public void AddNewItem()
    {
        if (!recover.itemList.Contains(thisItem))
        {
            recover.itemList.Add(thisItem);
            //bagManager.CreateNewItem(thisItem);
            thisItem.itemHeld += 1;
        }
        else
        {
            thisItem.itemHeld += 1;
        }
        bagManager.RefreshItem();
        
    }

    
   
}