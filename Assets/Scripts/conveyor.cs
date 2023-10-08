using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class conveyor : MonoBehaviour
{
    public float speed;
    public Vector3 direction;
    public List<GameObject> onBelt;

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {
        for(int i = 0; i <= onBelt.Count -1 ; i++){
            if(onBelt[i] == null){
                onBelt.Remove(onBelt[i]);

            }
            else{
                onBelt[i].GetComponent<Rigidbody>().velocity = speed * direction * Time.fixedDeltaTime;
            }
        }
    }

    private void OnCollisionEnter(Collision col){
        onBelt.Add(col.gameObject);
    }
    private void OnCollisionExit(Collision col){
        onBelt.Remove(col.gameObject);
    }
}
