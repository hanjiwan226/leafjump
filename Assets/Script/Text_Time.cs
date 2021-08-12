using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Text_Time : MonoBehaviour
{
    float timer = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        
        this.GetComponent<Text>().text = string.Format("{0:N1}", timer) + "s";
    }
}
