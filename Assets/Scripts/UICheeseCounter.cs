using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class UICheeseCounter : MonoBehaviour
{
    private int CheeseAged = 0;
    [SerializeField] int CheeseCount;
    [SerializeField] TMP_Text counter;
    bool change = true;
    public static event EventHandler OnWin;

    public static UICheeseCounter Instance{ get; private set;}
    // Start is called before the first frame update
    void Awake(){
        Instance = this;
    }
    void Start()
    {
        CheeseHouse.cheeseAged += CheeseHouse_cheeseAged;

    }

    private void CheeseHouse_cheeseAged(object sender, System.EventArgs e){
        CheeseAged ++;
        change = true;

    }

    // Update is called once per frame
    void Update()
    {
        // if cheese aged, update counter
        if(change){
            string cheese_text = CheeseAged.ToString() + "/" + CheeseCount.ToString();
            counter.text = cheese_text;
            change = false;
        }
        if(CheeseAged == CheeseCount){
            OnWin?.Invoke(this, EventArgs.Empty);
        }
    }
}