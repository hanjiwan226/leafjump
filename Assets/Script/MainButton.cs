using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainButton : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartButton()
    {
        SceneManager.LoadScene("Play");
    }

    public void StoreButton()
    {
        SceneManager.LoadScene("Store");
    }
    
    public void OptionButton()
    {
        SceneManager.LoadScene("Option");
    }

    public void mainButton()
    {
        SceneManager.LoadScene("main");
    }
}
