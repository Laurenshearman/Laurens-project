using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class StartGamebutton : MonoBehaviour
{
    public GameObject myCanvas;

    private int pressAmount  = 0 ;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;

    }




    // Update is called once per frame
    void Update()
    {
        
    }


    public void buttonPressed(){
       
        pressAmount ++;

        if(pressAmount == 1){
        //change text
            GameObject.Find("firsttextbox").GetComponent<TMP_Text>().text="insert text here";

            //change text on button

        }else if(pressAmount == 2){
            hideCanvas();
        }
        


    }

    public void hideCanvas(){
        myCanvas.SetActive(false);

        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;

    }



}
