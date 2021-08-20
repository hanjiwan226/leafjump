using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ingamebutton : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void IsPause()
    {
        Time.timeScale = 0f;
    }
    public void IsPlay()
    {
        Time.timeScale = 1f;
    }
    public void mainButton()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("main");
    }
}
