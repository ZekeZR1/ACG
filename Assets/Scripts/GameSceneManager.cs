using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSceneManager : MonoBehaviour
{
    [SerializeField]
    GameObject myObject;

    // Start is called before the first frame update
    void Start()
    {
        Destroy(myObject.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        MyLog();
    }

    void Nyan()
    {
        if (true)
        {
            var X = 1;
            Debug.Log(X);
        }
    }
    protected void OnTriggerEnter(Collider collider){

    }

    void OnMouseEnter()
    {
        
    }
    
    void OnCollisionExit2D(Collision2D collisionInfo)
    {
        
    }

    void OnCollisionEnter(Collision collisionInfo)
    {
        

        MyLog();
        MyLog();
        MyLog();
        MyLog();
    }

    void MyLog()
    {
        Debug.Log("MyDebugLog");
    }
    
}
