using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryController : MonoBehaviour
{
    public static InventoryController Instance { get; set; }
    public PlayerWeaponController playerWeaponController;
    public ConsumableController consumableController;
    public Item sword;
    public Item PotionLog;

    void Start()
    {
        //Esto es para si esta equipado no se vuela a equipar
        if(Instance != null && Instance != this)
        {
            Destroy(gameObject); 
        }else{
            Instance = this;
        }


        playerWeaponController = GetComponent<PlayerWeaponController>();
        consumableController = GetComponent<ConsumableController>();
        
    }

    
}
