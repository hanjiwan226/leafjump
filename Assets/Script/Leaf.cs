using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Leaf : MonoBehaviour
{
    float time;
    float settime;
    public Sprite yellow;
    public Sprite red;

    // Start is called before the first frame update
    void Start()
    {
        time = 0;
    }

    // Update is called once per frame
    void Update()
    {
        time = time + Time.deltaTime;

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

        this.gameObject.GetComponent<SpriteRenderer>().sprite = yellow;
    }

}
