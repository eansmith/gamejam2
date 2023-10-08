using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HouseWinControl : MonoBehaviour
{
    
    
    // Start is called before the first frame update
    [SerializeField] private GameObject WinMessage;
    [SerializeField] private GameObject LoseMessage;
    [SerializeField] private GameObject Newspaper;
    bool win = false;
    bool timer = false;

     void Start()
    {
        UICheeseCounter.OnWin += CheeseCounter_OnWin;
        TimerHouse.OnTimeUp += TimerHouse_OnTimeUp;
        WinMessage?.SetActive(false);
        LoseMessage?.SetActive(false);
        Newspaper?.SetActive(false);
    }

    private void CheeseCounter_OnWin(object sender, System.EventArgs e){
        win = true;

    }

     private void TimerHouse_OnTimeUp(object sender, System.EventArgs e){
        timer = true;

    }

    // Update is called once per frame
    void Update()
    {
       if(!timer && win){
        //Player wins the game
        WinMessage.SetActive(true);
        winners();
       } 
       if(timer && !win){
        //player loses the game
        LoseMessage.SetActive(true);
       }
       if(timer && win){
        WinMessage.SetActive(true);
        winners();
       }
    }

    void winners(){
        if(Input.GetMouseButtonDown(0)){
            //load the next scene
        }
    }

    void losers(){
        if(Input.GetMouseButtonDown(0)){
            Newspaper.SetActive(true);
            news();
        }
    }
    void news(){
        if(Input.GetMouseButtonDown(0)){
            //switch scenes
        }
    }
}
