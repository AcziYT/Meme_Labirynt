using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    
	public static GameManager gameManager;
	[SerializeField] private int timeToEnd;
	
    void Start()
    {
        if (gameManager == null) gameManager = this;
		
		InvokeRepeating("Stoper", 2, 1);
    }

    void Update()
    {
        
    }
	
	void Stoper () 
	{
		timeToEnd--;
		Debug.Log("Time to end: " + timeToEnd + " s");
	}
}
