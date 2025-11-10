using UnityEngine;

public class Dialogo_NPC : MonoBehaviour
{
    private bool playerInRange = false;
    private bool dialogueOpen = false;
    public GameObject UI;
    public GameObject Textbox;

    void Start()
    {
        UI.SetActive(false);
        Textbox.SetActive(false);
    }
    private void Update()
    {
        if (playerInRange)
        {
            if (!dialogueOpen)
                UI.SetActive(true);
            else
                UI.SetActive(false);

            if (Input.GetKeyDown(KeyCode.E))
            {
                dialogueOpen = !dialogueOpen;
                Textbox.SetActive(dialogueOpen);
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
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
