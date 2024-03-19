using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class Inventory : ScriptableObject
{
    public Items currentItem;
    public List<Items> items = new List<Items>();
    public int numberOfKeys;
    public int coins;
    public float maxMagic = 10;
    public float currentMagic;

    public void OnEnable()
    {
        currentMagic = maxMagic;
    }

    public void ReduceMagic(float magicCost)
    {
        currentMagic -= magicCost;
    }

    public bool CheckForItem(Items item)
    {
        if (items.Contains(item))
        {
            return true;
        }
        return false;
    }

    public void AddItem(Items itemToAdd)
    {
        if(itemToAdd.isKey)
        {
            numberOfKeys++;
        }
        else
        {
            if(!items.Contains(itemToAdd))
            {
                items.Add(itemToAdd);
            }
        }
    }
}
