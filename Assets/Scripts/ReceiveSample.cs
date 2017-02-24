    using UnityEngine;
using System.Collections;

public class ReceiveSample : MonoBehaviour
{
    public SerialHandler sh;
	// Use this for initialization
	void Start ()
	{
	    sh.OnDataReceived += OnDataReceived;
	}

    void OnDataReceived(string message)
    {
        Debug.Log(message);
    }
	// Update is called once per frame
	void Update () {
	
	}
}
