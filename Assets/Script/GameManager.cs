using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int stagenum = 1;
    public GameObject[] stage = new GameObject[10];
    GameObject playstage;
    public GameObject playerprefabs;
    GameObject player;
    public Transform point;

    // Start is called before the first frame update
    void Start()
    {
        playstage = Instantiate(stage[stagenum - 1]);
        Initstage();
    }


    public void Stageclear()
    {
        Destroy(playstage);
        stagenum++;
        Destroy(player);
        playstage = Instantiate(stage[stagenum - 1]);
        Invoke("Initstage", 0.3f);
    }

    void Initstage()
    {
        player = Instantiate(playerprefabs);
        player.transform.position = point.position;
    }

    public void Stageover()
    {
        Destroy(playstage);
        Destroy(player);
        playstage = Instantiate(stage[stagenum - 1]);
        Invoke("Initstage", 0.3f);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
