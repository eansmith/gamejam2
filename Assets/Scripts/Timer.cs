using UnityEngine;
using TMPro;
using System;


public class Timer : MonoBehaviour
{
    public TMP_Text timerText;

    [Header("Time Values")]
    [Range(0,60)]
    public int seconds;
    [Range(0, 60)]
    public int minutes;
    [Range(0, 60)]
    public int hours;

    public Color fontColor;
    
    [SerializeField] private Animator anim;

    public bool showMilliseconds;

    private float currentSeconds;
    private int timerDefault;

    [SerializeField] private GameObject mang;

    void Start()
    {
        anim.SetTrigger("factory");
        timerDefault = 0;
        timerDefault += (seconds + (minutes * 60) + (hours * 60 * 60));
        currentSeconds = timerDefault;
    }

    void Update()
    {   
        if(mang.GetComponent<factory>().isStarted){
        if((currentSeconds -= Time.deltaTime) <= 0)
        {
            TimeUp();
        }
        else
        {
            if(showMilliseconds)
                timerText.text = TimeSpan.FromSeconds(currentSeconds).ToString(@"hh\:mm\:ss\:fff");
            else
                timerText.text = TimeSpan.FromSeconds(currentSeconds).ToString(@"hh\:mm\:ss");

   
        }
        }
    }

    private void TimeUp()
    {
        if (showMilliseconds)
            timerText.text = "00:00:00:000";
        else
            timerText.text = "00:00:00";
    
        anim.SetTrigger("FactoryOpen");
        mang.GetComponent<factory>().isOver = true;
        
    }

    public void addTime(int time){
        currentSeconds += time;
    }
}