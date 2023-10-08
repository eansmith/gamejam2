using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{   
    
    [SerializeField] private string ageTag = "ageable";

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    
        RaycastHit hit;
        if (Physics.Raycast(Camera.main.transform.position, Camera.main.transform.forward, out hit, 100.0f)){
            var selection = hit.transform;
            
            if (selection.CompareTag(ageTag) && Input.GetMouseButton(0)){

                selection.GetComponent<ageableObject>().age();

            }

        }
    }
}
