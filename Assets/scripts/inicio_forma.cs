using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class inicio_forma : MonoBehaviour
{
    public VideoPlayer video;

    void Awake()
    {
      
    }

    private void OnMouseDown()
    {
        video = GetComponent<VideoPlayer>();
        video.Play();
        video.loopPointReached += CheckOver;
    }

    void CheckOver(VideoPlayer vp)
    {
        SceneManager.LoadScene(0);
    }

}