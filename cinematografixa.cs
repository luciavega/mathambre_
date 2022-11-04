using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class cinematografixa : MonoBehaviour
{
    public VideoPlayer video;

    void Awake()
    {
        video=GetComponent<VideoPlayer>();
        video.Play();
        video.loopPointReached += CheckOver;
    }
    void star(){

    }
    void Update(){
       
    }

    void CheckOver(VideoPlayer vp)
    {
SceneManager.LoadScene(0);    }

}
