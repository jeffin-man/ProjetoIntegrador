using UnityEngine;

public class RestorePlayerPosition : MonoBehaviour
{
    void Start()
    {
        if (PlayerPositionMemory.hasSavedPosition)
        {
            GameObject player = GameObject.FindGameObjectWithTag("Player");
            player.transform.position = PlayerPositionMemory.savedPosition;
        }
    }
}
