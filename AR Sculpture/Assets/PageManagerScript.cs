using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PageManagerScript : MonoBehaviour
{
    [Tooltip("Type in current page")]
    public string currentPage;

    void Start()
    {
        if(currentPage != "Birth"){
            GameObject[] objects = GameObject.FindGameObjectsWithTag("Birth");
            foreach(GameObject o in objects){
                Destroy(o);
            }
        }
        if(currentPage != "FirstDay"){
            GameObject[] objects = GameObject.FindGameObjectsWithTag("FirstDay");
            foreach(GameObject o in objects){
                Destroy(o);
            }
        }
        if(currentPage != "Birthday"){
            GameObject[] objects = GameObject.FindGameObjectsWithTag("Birthday");
            foreach(GameObject o in objects){
                Destroy(o);
            }
        }
        if(currentPage != "WeddingDay"){
            GameObject[] objects = GameObject.FindGameObjectsWithTag("WeddingDay");
            foreach(GameObject o in objects){
                Destroy(o);
            }
        }
        if(currentPage != "Funeral"){
            GameObject[] objects = GameObject.FindGameObjectsWithTag("Funeral");
            foreach(GameObject o in objects){
                Destroy(o);
            }
        }
    }
}
