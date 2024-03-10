using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "New Defult Object", menuName = "Inventory System/Items/Defult")]
public class DefultObject : ItemObject

{
    public void Awake()
    {
        type = ItemType.Defult;
    }
}
