using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColorForSphere : MonoBehaviour
{
    // Start is called before the first frame update
    public void getyellow(){
        this.GetComponent<Renderer>().material.color = Color.yellow;
    }

    public void getBlue(){
        this.GetComponent<Renderer>().material.color = Color.blue;
    }

    public void getBlack(){
        this.GetComponent<Renderer>().material.color = Color.red;
    }
}
