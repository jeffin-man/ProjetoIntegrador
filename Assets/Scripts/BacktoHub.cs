using UnityEngine;
using UnityEngine.SceneManagement;

public class BacktoHub : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            SceneManager.LoadScene(1);
        }
    }
}
