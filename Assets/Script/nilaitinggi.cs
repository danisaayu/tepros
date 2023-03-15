using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class nilaitinggi : MonoBehaviour
{
    // Start is called before the first frame update
    public string status;
    // Start is called before the first frame update
    void Start()
    {
        if(PlayerPrefs.GetInt ("nilai")>PlayerPrefs.GetInt ("high_score")){
            PlayerPrefs.SetInt ("high_score",PlayerPrefs.GetInt ("nilai"));
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(status == "score"){
            this.GetComponent<Text>().text = ""+PlayerPrefs.GetInt ("nilai");
        }else{
            this.GetComponent<Text>().text = "NILAI TERTINGGI : "+PlayerPrefs.GetInt ("high_score");
        }
        
    }
}
