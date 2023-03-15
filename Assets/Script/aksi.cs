using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aksi : MonoBehaviour
{
	public string namaHalaman;
    public string status;
    public AudioSource suara;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown(){
        suara.Play();
    }

    void OnMouseUp(){
        if(status == "benar"){
        	PlayerPrefs.SetInt("nilai",PlayerPrefs.GetInt("nilai")+10);
            GetComponent<SpriteRenderer>().color = new Vector4(0f, 1f, 0f, 0.4f);
        }else{
            GetComponent<SpriteRenderer>().color = new Vector4(1f, 0f, 0f, 0.4f);
        }

        StartCoroutine(delayWaktu());
    }

    IEnumerator delayWaktu()
    {
        yield return new WaitForSeconds(1);
        Application.LoadLevel (namaHalaman); 
    }
}
