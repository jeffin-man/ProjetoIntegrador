using UnityEngine;
using TMPro;

public class NPC_Dialogo : MonoBehaviour
{
    private bool playerInRange = false;
    private bool dialogueOpen = false;

    [TextArea]
    public string npcText; 

    public GameObject UI; 
    public GameObject Textbox; 
    public TMP_Text Fala; 

    void Start()
    {
        UI.SetActive(false);
        Textbox.SetActive(false);
    }

    void Update()
    {

        if (playerInRange && !dialogueOpen)
        {
            UI.SetActive(true);
            if (!dialogueOpen && Input.GetKeyDown(KeyCode.E))
            {
                dialogueOpen = true;
                Textbox.SetActive(true);
                Fala.text = npcText;
                UI.SetActive(false);
            }
            
        }
        /*if (playerInRange && Input.GetKeyDown(KeyCode.E))
        {
            dialogueOpen = !dialogueOpen;

            if (dialogueOpen)
            {
                Textbox.SetActive(true);
                Fala.text = npcText;
                UI.SetActive(false);
            }
            else
            {
                UI.SetActive(true);
            }
        }

        if (playerInRange && !dialogueOpen)
            UI.SetActive(true);
        else if (!playerInRange)
            UI.SetActive(false);*/
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("enter");
            playerInRange = true;
            UI.SetActive(true);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerInRange = false;
            dialogueOpen = false;
            UI.SetActive(false);
            Textbox.SetActive(false);
        }
    }
}

