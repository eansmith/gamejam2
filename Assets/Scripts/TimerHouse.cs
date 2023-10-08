using UnityEngine;
using TMPro;
using System;


public class TimerHouse : MonoBehaviour
{
    public TMP_Text timerText;

    [Header("Time Values")]
    [Range(0,60)]
    public int seconds;
    [Range(0, 60)]
    public int minutes;
    [Range(0, 60)]
    public int hours;
    public static event EventHandler OnTimeUp;
    public static TimerHouse Instance{get; private set;}
    public Color fontColor;

    public bool showMilliseconds;

    private float currentSeconds;
    private int timerDefault;
    private bool start = false;
    [SerializeField] GameObject Instructions;
    void Awake(){
        Instance = this;
    }
    void Start()
    {

        timerDefault = 0;
        timerDefault += (seconds + (minutes * 60) + (hours * 60 * 60));
        currentSeconds = timerDefault;
        Instructions.SetActive(true);
    }

    void Update()
    {
        if(start){

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
        else{
            if(Input.GetMouseButtonDown(0)){
                start = true;
                Instructions.SetActive(false);
            }
        }
        
    }

    private void TimeUp()
    {
        if (showMilliseconds)
            timerText.text = "00:00:00:000";
        else
            timerText.text = "00:00:00";
        OnTimeUp?.Invoke(this, EventArgs.Empty);
    }

    public void addTime(int time){
        currentSeconds += time;
    }
}