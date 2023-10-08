using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HouseWinControl : MonoBehaviour
{
    
    
    // Start is called before the first frame update
    [SerializeField] private GameObject WinMessage;
    [SerializeField] private GameObject LoseMessage;
    [SerializeField] private GameObject Newspaper;
    bool win = false;
    bool timer = false;
    bool newspap = false;

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
        losers();
       }
       if(timer && win){
        WinMessage.SetActive(true);
        winners();
       }

       if(Input.GetKeyDown(KeyCode.Space) && newspap){
            Debug.Log("new Scene");
            SceneManager.LoadScene("HousesScene", LoadSceneMode.Single);
        }
    }

    void winners(){
        if(Input.GetMouseButtonDown(0)){
            SceneManager.LoadScene("factory", LoadSceneMode.Single);
        }
    }

    void losers(){
        if(Input.GetMouseButtonDown(0)){
            Newspaper.SetActive(true);
            news();
        }
    }
    void news(){
        newspap = true;
    }
}
