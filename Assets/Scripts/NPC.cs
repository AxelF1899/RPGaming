using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//En interactables hay una funcion de interaccion que vamos a sobreescribir en caso de ser un NPC y no un objeto comun
public class NPC : Interactable
{
    public string[] dialogue;
    public string name;

    public override void Interact()
    {
        DialogueSystem.Instance.AddNewDialogue(dialogue, name);
        Debug.Log("Interacting with NPC");
    }
}
