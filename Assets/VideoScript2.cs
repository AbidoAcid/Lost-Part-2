using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class VideoScript2 : MonoBehaviour
{
    public VideoPlayer videoPlayer;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Video_Time());
    }

    IEnumerator Video_Time()
    {
        yield return new WaitForSeconds(187);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
