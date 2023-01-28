using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Score : MonoBehaviour
{
    Text text;
   public  int  scorevalue ;
    
    // Start is called before the first frame update
    void Start()
    {
       text = GetComponent<Text>();
        //text.canvas.sortingLayerID=1;
        //text.canvas.worldCamera = Camera.main;
   //     text.text = "" + scorevalue;
    }

    // Update is called once per frame
    void Update()
    {
     text.text = "" + scorevalue;
    }
   
}
