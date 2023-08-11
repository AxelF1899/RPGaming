using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class DialogueSystem : MonoBehaviour
{
    public static DialogueSystem Instance { get; set; }
    public GameObject dialoguePanel;
    public string npcName;
    public  List<string> dialogueLines = new List<string>();

    Button continueButton;
    Text dialogueText, nameText;
    int dialogueIndex;

    void Awake()
    {
        //Busca el boton
        continueButton = dialoguePanel.transform.Find("Button").GetComponent<Button>();
        dialogueText = dialoguePanel.transform.Find("Text").GetComponent<Text>();
        nameText = dialoguePanel.transform.Find("Name").GetChild(0).GetComponent<Text>();

        continueButton.onClick.AddListener(delegate{ ContinueDialogue(); });
        
        dialoguePanel.SetActive(false);

        //Revisa si existe una instancia del dialgogo
        if(Instance != null && Instance != this)
        {  
            //Si existe la destruye
            Destroy(gameObject);
        }else{
            //Sino la crea
            Instance = this;
        }
    }

    //Añade los dialogos
    public void AddNewDialogue(string[] lines, string npcName)
    {
        dialogueIndex = 0;
        dialogueLines = new List<string>();
        foreach (string line in lines)
        {
            dialogueLines.Add(line);
        }
        this.npcName = npcName;

        Debug.Log(dialogueLines.Count);
        CreateDialogue();
    }

    public void CreateDialogue()
    {
        dialogueText.text = dialogueLines[dialogueIndex];
        nameText.text = npcName;
        dialoguePanel.SetActive(true);
    }

    public void  ContinueDialogue()
    {
        if(dialogueIndex < dialogueLines.Count-1)
        {
            dialogueIndex+=1;
            dialogueText.text = dialogueLines[dialogueIndex];
        }else
        {
            dialoguePanel.SetActive(false);
        }
    }
}
