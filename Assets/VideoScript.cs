using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class VideoScript : MonoBehaviour
{
    public VideoPlayer videoPlayer;
    public LevelLoader levelLoader;
    // Start is called before the first frame update
    void Start()
    { 
        StartCoroutine(Video_Time());
    }

    IEnumerator Video_Time()
    {
        yield return new WaitForSeconds(89);
        levelLoader.LoadNextLevel();
    }
    
}
