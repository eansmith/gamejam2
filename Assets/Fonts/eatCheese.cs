using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eatCheese : MonoBehaviour
{
    [SerializeField] private GameObject mang;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(mang.GetComponent<factory>().isOver && Input.GetKeyDown(KeyCode.F)){
            mang.GetComponent<factory>().endSeq();
            Destroy(this.gameObject);

        }
    }
}
