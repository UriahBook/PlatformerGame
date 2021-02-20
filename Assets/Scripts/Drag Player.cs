using System.Collections;
using System.Collections.Generic;
using UnityEngine;



//Need to add: 
//private void OnCollisionEnter2D (Collision2D c)
//{
   // if (c.gameObject.tag == "Platform")
   // {
   //     transform.SetParent(c.transform);
   // }
//}

//private void OnCollisionExit2D(Collision2D c)
//{
//    if (c.gameObject.tag == "Platform")
//    {
//        transform.SetParent(null);
//    }
//}
//
//To the player controller script to allow an object/sprite to grab and drag the player.
//The code bellow allows you to set the start and end position of where you want the object dragging the player to be.
//Note: Change the tag == "Platform" to a new tag for the object you want to have move the player. Ex: for an elevator you'd first create a tag called "Elevator" 
//then go to the object you are using as the elevator and change it's tag to the new tag. Finally change the code to:
//"if (c.gameObject.tag == "Elevator") 
//{
//transform.SetParent(c.transform);
//}
// Make sure to change Platform in both instances to whatever the new tag is called.

//public class PlatformController : MonoBehaviour
//{

//    public Vector3 targetPos;

//    public float speed;

//    Vector3 startPos;

//    bool toTarget = true;

    // Start is called before the first frame update
//    void Start()
//    {
//        startPos = transform.position;
//    }
//
    // Update is called once per frame
//    void Update()
//    {
//        if (toTarget == true)
//        {
//            transform.position = Vector3.MoveTowards(transform.position, targetPos, speed);
//        }
//
//        else
//        {
//            transform.position = Vector3.MoveTowards(transform.position, startPos, speed);
//        }

//        if (transform.position == targetPos)
//        {
//            toTarget = false;
//        }
//
//        if (transform.position == startPos)
//        {
//            toTarget = true;
//        }
//    }
//}