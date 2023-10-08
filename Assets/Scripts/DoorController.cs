using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{
    [SerializeField] GameObject door;
    [SerializeField] GameObject doorText;
    const string player = "Player";
    bool triggered = false;
    bool opened = false;
    private Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(triggered && Input.GetKeyDown(KeyCode.E)){
            if(anim != null){
                if(!opened){
                    anim.SetTrigger("Open");
                    doorText.SetActive(false);
                    opened = true;
                }
                else{
                    anim.SetTrigger("Close");
                    opened = false;
                    doorText.SetActive(false);
                }
               
                
            }
        }
    }

    private void OnTriggerEnter(Collider other){
        if(other.tag == player){
            doorText.SetActive(true);
            triggered = true;
        }
    }

    private void OnTriggerExit(){
        doorText.SetActive(false);
        triggered = false;
    }
}
