using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class CheeseHouse : ageableObject
{
    [SerializeField] private Material agedMaterial;
    [SerializeField] private GameObject slider;
    [SerializeField] private float ageTime = 2;
    public static event EventHandler cheeseAged;

    public static CheeseHouse Instance{ get; private set;}

    void Awake(){
        Instance = this;
    }
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
                cheeseAged?.Invoke(this, EventArgs.Empty);
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
