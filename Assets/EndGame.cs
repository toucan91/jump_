using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndGame : MonoBehaviour
{
       public float minY;
       public Transform target;

       void Start(){
               GetComponent<SpriteRenderer> ().enabled = false;
               minY = GetComponent<SpriteRenderer>().bounds.min.y;
       }

       void LateUpdate () {
            if (target.position.y < 0){
               GetComponent<SpriteRenderer> ().enabled = true;
               }
       }

}
