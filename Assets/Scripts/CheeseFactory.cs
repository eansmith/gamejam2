using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CheeseFactory : ageableObject
{
    [SerializeField] private Material agedMaterial;
    [SerializeField] private GameObject slider;
    [SerializeField] private  GameObject  timer;
    [SerializeField] private float ageTime = 2;

    // Start is called before the first frame update
    void Start()
    {
        //o
    }

    // Update is called once per frame
    void Update()
    {

    }

    public override void age(){
        if(progress >= ageTime){
            if(!isAged){    
                timer.GetComponent<Timer>().addTime(5);
            }
            isAged = true;
            slider.SetActive(false);
            GetComponent<Renderer>().material = agedMaterial;
            
        }
        else if(!isAged){
            slider.SetActive(true);
            progress += (1 * Time.deltaTime);
            slider.GetComponent<Slider>().value = progress/ageTime;
            
            //isAged = true;
        }
        //var selectionRenderer = selection.GetComponent<Renderer>();
    }
}
