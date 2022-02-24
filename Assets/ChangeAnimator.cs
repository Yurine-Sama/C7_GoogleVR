using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeAnimator : MonoBehaviour
{
        public void getAnimatorHipHop(){
            this.GetComponent<Animator>().Play("Dance HipHop");
        }

     public void getAnimatorTwerk(){
        this.GetComponent<Animator>().Play("Dance Twerk");
    }

       public void getAnimatorSneak(){
        this.GetComponent<Animator>().Play("Sneak Walk");
    }
}
