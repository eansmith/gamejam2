using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class factory : MonoBehaviour
{
 
    // Start is called before the first frame update
    
    [SerializeField] private GameObject[] spawners;
    [SerializeField] private GameObject[] objects;
    [SerializeField] private float rate = 0.2f;
        [SerializeField] private float time = 1f;

    [SerializeField] private GameObject introCam;
    [SerializeField] private GameObject player;

    public bool isStarted = false;

    void Start()
    {
        InvokeRepeating("gameTick", 1f, time);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0)){
            isStarted = true;
            introCam.SetActive(false);
            player.SetActive(true);

        }
    }


    void gameTick() {
        if(isStarted){
        if(Random.Range(0f,1f)>rate){
            Random.Range(0,spawners.Length);
            GameObject obj = Instantiate(objects[Random.Range(0,objects.Length)], spawners[Random.Range(0,spawners.Length)].transform.position, Quaternion.identity)  as GameObject;
            obj.SetActive(true);
        }
        }

    }
}
