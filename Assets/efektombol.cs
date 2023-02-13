using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class efektombol : MonoBehaviour
{
	float scalex, scaley;
    // Start is called before the first frame update
	void Start () {
		scalex= transform.localScale.x;
		scaley= transform.localScale.y;
    }

    void OnMouseDown() {
    	transform.localScale = new Vector2 (scalex*1.2f, scaley*2)f;
    }
	void OnMouseUp() {
		transform.localScale = new Vector2 (scalex*1.2f, scaley*1.2f);


	}
    // Update is called once per frame
    void Update()
    {
        
    }
}
