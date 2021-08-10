using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Leaf : MonoBehaviour
{
    public float time;
    public float settime;
    public Sprite yellow;
    public Sprite red;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Invoke("Leaf1s", 1f);
        Invoke("Leaf2s", 2f);
        Invoke("Leaf3s", 3f);   

    }

    void Leaf1s()
    {
        this.gameObject.GetComponent<SpriteRenderer>().sprite = yellow;
    }

    void Leaf2s()
    {
        this.gameObject.GetComponent<SpriteRenderer>().sprite = red;
    }

    void Leaf3s()
    {
        this.gameObject.SetActive(false);
    }
}
