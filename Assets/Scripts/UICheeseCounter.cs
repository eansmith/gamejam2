using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class UICheeseCounter : MonoBehaviour
{
    private int CheeseCount;
    private int CheeseAged;
    [SerializeField] TMP_Text  counter;
    // Start is called before the first frame update
    void Start()
    {
        // Get total amount of cheese in the scene
    }

    // Update is called once per frame
    void Update()
    {
       /* // if cheese aged, update counter
        if(CheeseAged){
            string cheese_text = CheeseAged + "/" + CheeseCount;
            counter.text = cheese_text;
        }*/
    }
}
