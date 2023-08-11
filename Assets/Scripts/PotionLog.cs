using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PotionLog : MonoBehaviour, IConsumable
{
    public void Consume()
    {
        Debug.Log("You drank the potion");
    }

    public void Consume(CharacterStats stats)
    {
        Debug.Log("Tomaste la pocion");
    }
}
