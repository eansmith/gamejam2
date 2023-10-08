using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntroController : MonoBehaviour
{
    [SerializeField] GameObject[] text;
    [SerializeField] GameObject news;
    [SerializeField] GameObject sound;
    int index = 0;
    // Start is called before the first frame update
    void Start()
    {
        if(index == 0){
            text[index].SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0)){
            if(index<text.Length){
                text[index].SetActive(false);
                index ++;
                if(index == text.Length){
                    text[index-1].SetActive(false);
                    news.SetActive(true);
                    sound.SetActive(true);
                }
                else{
                text[index].SetActive(true);
                }
                
            }
            
            
        }
    }
}
