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

    [SerializeField] private GameObject introImage;
    [SerializeField] private GameObject[] ends;

    

    public bool isStarted = false;
    public bool isOver = false;

    public bool isEnd = false;
    private int overIndex = 1;

    void Start()
    {
        InvokeRepeating("gameTick", 1f, time);
    }

    // Update is called once per frame
    void Update()
    {
        if(!isStarted && Input.GetMouseButtonDown(0)){
            isStarted = true;
            introCam.SetActive(false);
            player.SetActive(true);

        }
        if (isOver && Input.GetMouseButtonDown(0)){
            overIndex += 1;
            for(int i = 0; i < ends.Length; i++){
                if(i == overIndex){
                    ends[i].SetActive(true);
                }
                else{
                    ends[i].SetActive(false);
                }
            }
        }
    }

    public void endSeq(){
        isStarted = false;
        isOver = false;
        isEnd = true;
        introCam.SetActive(true);

        player.SetActive(false);
        ends[0].SetActive(true);
    }


    void gameTick() {
        if(!isOver){
        if(Random.Range(0f,1f)>rate){
            Random.Range(0,spawners.Length);
            GameObject obj = Instantiate(objects[Random.Range(0,objects.Length)], spawners[Random.Range(0,spawners.Length)].transform.position, Quaternion.identity)  as GameObject;
            obj.SetActive(true);
        }
        }

    }
}
