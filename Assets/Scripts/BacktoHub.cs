using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class BacktoHub : MonoBehaviour
{
    public VideoPlayer videoPlayer;

    void Start()
    {
        videoPlayer.loopPointReached += OnVideoEnd;
    }

    void OnVideoEnd(VideoPlayer vp)
    {
        SceneManager.LoadScene(1);
    }
    //void OnTriggerEnter(Collider other)
    //{
    //if (other.CompareTag("Player"))
    //{
    //SceneManager.LoadScene(1);
    //}
    //}
}
