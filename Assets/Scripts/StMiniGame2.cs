using UnityEngine;
using UnityEngine.SceneManagement;

public class StMiniGame2 : MonoBehaviour
{
    private bool playerInRange = false;
    public GameObject UI;

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
            UI.SetActive(false);
        }
    }

    private void Update()
    {
        if (playerInRange && Input.GetKeyDown(KeyCode.E))
        {
            GameObject player = GameObject.FindGameObjectWithTag("Player");
            PlayerPositionMemory.savedPosition = player.transform.position;
            PlayerPositionMemory.hasSavedPosition = true;
            SceneManager.LoadScene(4);
        }
    }
}
