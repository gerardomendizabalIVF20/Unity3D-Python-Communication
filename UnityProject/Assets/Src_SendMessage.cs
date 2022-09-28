using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Src_SendMessage : MonoBehaviour
{

    private HelloRequester Requester=new HelloRequester();

    // Start is called before the first frame update
    void Start()
    {
        Requester.Start(); //TODO: Kill this thread when Unity will exit
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SendMessageToPython(string Message)
    {
        Requester.SendMessage(Message);
    }
}
