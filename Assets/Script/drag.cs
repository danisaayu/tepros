using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class drag : MonoBehaviour
{
    public string namaObjek;
    public int lampu;
    public GameObject detector,lokasi;
    Vector3 pos_awal,scale_awal;
    bool on_pos = false;
    int nilai=0;
    // Start is called before the first frame update
    void Start()
    {
        // PlayerPrefs.SetInt ("lampu",0);
        // PlayerPrefs.SetInt ("lampu"+lampu,0);
        pos_awal = transform.position;
        scale_awal = transform.localScale;
    }

    void OnMouseDrag(){
        Vector3 pos_mouse = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x,Input.mousePosition.y,Input.mousePosition.z));
        transform.position = new Vector3(pos_mouse.x,pos_mouse.y,-1f);
        // transform.localScale = new Vector2(1f,1f);
    }

    void OnMouseUp(){
        // if(on_pos){
            // transform.position = detector.transform.position;
            // transform.position = lokasi.transform.position;
            // Handheld.Vibrate();
            // GameObject.Find("kluk").GetComponent<AudioSource>().Play();

        // }else{
            Handheld.Vibrate();
            transform.position = pos_awal;
            transform.localScale = scale_awal;
        // }
    }

    void OnTriggerStay2D(Collider2D objek){
        if(objek.gameObject == detector){
            on_pos = true;
            // PlayerPrefs.SetInt ("lampu"+lampu,1);
            Debug.Log("detek in");

            if(namaObjek == "buah"){
                transform.position = lokasi.transform.position;
            }

            if(namaObjek == "air"){
                GameObject.Find("animasi").GetComponent<Animator>().SetTrigger("satu");
            }
        }
    }

    void OnTriggerExit2D(Collider2D objek){
        if(objek.gameObject == detector){
            on_pos = false;
            // PlayerPrefs.SetInt ("lampu"+lampu,0);
            Debug.Log("detek out");
        }
    }

    // Update is called once per frame
    void Update()
    {
        // if(PlayerPrefs.GetInt ("lampu1") == 1 && PlayerPrefs.GetInt ("lampu2") == 1 && PlayerPrefs.GetInt ("lampu3") == 1 && PlayerPrefs.GetInt ("lampu4") == 1 && PlayerPrefs.GetInt ("lampu5") == 1){
        //     PlayerPrefs.SetInt ("lampu",1);
        // }else{
        //     PlayerPrefs.SetInt ("lampu",0);
        // }
    }
}
