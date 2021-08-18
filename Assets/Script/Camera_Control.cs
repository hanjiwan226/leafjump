using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Control : MonoBehaviour
{
    public GameObject player;
    public GameObject point;
    public float velx;
    public float vely;
    public float smoothTimeX;
    public float smoothTimeY;
    public bool cameraBool;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player(Clone)");
        point = GameObject.Find("SpawnPoint");
    }

    // Update is called once per frame
    void Update()
    {
        if (player== null)
        {
            player = GameObject.Find("Player(Clone)");
        }
    }

    private void FixedUpdate()
    {
        if (player != null)
        {
            float posX = Mathf.SmoothDamp(transform.position.x, player.transform.position.x, ref velx, smoothTimeX);

            float posY = Mathf.SmoothDamp(transform.position.y, player.transform.position.y, ref vely, smoothTimeY);

            this.transform.position = new Vector3(posX, posY, -20);
        }
        else
        {
            this.transform.position = new Vector3(point.transform.position.x, point.transform.position.y, -20);
        }
    }
}
