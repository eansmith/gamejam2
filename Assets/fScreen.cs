using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fScreen : MonoBehaviour
{
    [SerializeField] private GameObject msg;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider col){
       msg.SetActive(true);
    }
}
