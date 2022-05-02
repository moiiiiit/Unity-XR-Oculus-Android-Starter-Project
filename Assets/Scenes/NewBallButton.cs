using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBallButton : MonoBehaviour
{   
    public GameObject o_object; 
    public void OnClickButton(){
        Instantiate (o_object, new Vector3(0f,1.23f,2.95f), o_object.transform.rotation);
    }
}
