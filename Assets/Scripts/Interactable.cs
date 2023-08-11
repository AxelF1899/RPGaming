using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour
{
    [HideInInspector]
    private bool hasInteracted;
    UnityEngine.AI.NavMeshAgent playerAgent;
    //Metodo para hacer que se mueva hacia el objeto en si y no interactue antes de llegar
    public virtual void MoveToInteraction(UnityEngine.AI.NavMeshAgent playerAgent)
    {
        hasInteracted = false;
        this.playerAgent = playerAgent;
        //Para que se pare antes de llegar a el
        playerAgent.stoppingDistance = 2f;
        playerAgent.destination = this.transform.position;


    }
    //Para que empiece a hacer la cosa cuando llegue al npc/objeto
    void Update()
    {
        if(!hasInteracted && playerAgent != null && !playerAgent.pathPending)
        {
            if(playerAgent.remainingDistance <= playerAgent.stoppingDistance)
            {
                //Ok aqui solo se hace la interaccion pero si es NPC  gracias al public override como que se reescribe y hace lo del NPC y no solo la interaccion/ tambien cambia si es objeto
                Interact();
                //Para que no  interactue o o verifique demasiadas veces
                hasInteracted = true;
            }
        }
    }

    public virtual void Interact()
    {
        Debug.Log("Interacting with base class");
    }
}
