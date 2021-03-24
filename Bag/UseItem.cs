using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UseItem : MonoBehaviour
{
    public bag recover;
    public item RedBig;
    public item BlueBig;
    public item RedSmall;
    public item BlueSmall;
    public item Attack;
    public item Defense;
    public Slider life;
    public Slider magic;
    public Text AttackNum;
    public Text DefenceNum;
  
    public void UseRedBig()
    {

        if (!recover.itemList.Contains(RedBig))
        {
            return;
        }
        life.value = 1f;
        RedBig.itemHeld -= 1;
        if (RedBig.itemHeld == 0)
        {
            recover.itemList.Remove(RedBig);
        }
        bagManager.RefreshItem();
    }

    public void UseBlueBig()
    {
        if (!recover.itemList.Contains(BlueBig))
        {
            return;
        }
        magic.value = 1f;
        BlueBig.itemHeld -= 1;
        if (BlueBig.itemHeld == 0)
        {
            recover.itemList.Remove(BlueBig);
        }
        bagManager.RefreshItem();
    }

    public void UseRedSmall()
    {
        if (!recover.itemList.Contains(RedSmall))
        {
            return;
        }
        life.value += 0.3f;
        RedSmall.itemHeld -= 1;
        if (RedSmall.itemHeld == 0)
        {
            recover.itemList.Remove(RedSmall);
        }
        bagManager.RefreshItem();
    }

    public void UseBlueSmall()
    {
        if (!recover.itemList.Contains(BlueSmall))
        {
            return;
        }
        magic.value += 0.3f;
        BlueSmall.itemHeld -= 1;
        if (BlueSmall.itemHeld == 0)
        {
            recover.itemList.Remove(BlueSmall);
        }
        bagManager.RefreshItem();
    }

    public void UseAttack()
    {
        if (!recover.itemList.Contains(Attack))
        {
            return;
        }
        int num = 0;
        num = int.Parse(AttackNum.text);
        num += 100;
        AttackNum.text = num.ToString();

        Attack.itemHeld -= 1;
        if (Attack.itemHeld == 0)
        {
            recover.itemList.Remove(Attack);
        }
        bagManager.RefreshItem();
    }

    public void UseDefense()
    {
        if (!recover.itemList.Contains(Defense))
        {
            return;
        }
        int num = 0;
        num = int.Parse(DefenceNum.text);
        num += 100;
        DefenceNum.text = num.ToString();

        Defense.itemHeld -= 1;
        if (Defense.itemHeld == 0)
        {
            recover.itemList.Remove(Defense);
        }
        bagManager.RefreshItem();
    }
   
}
