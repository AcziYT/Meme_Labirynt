using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public Transform closePosition;
	public Transform openPosition;
	public Transform door;
	
	public bool open = false;
	
	public float speed = 5f;
	
	private void Start()
	{
		if(open)
		{
			door.position = closePosition.position;
		}
		else
		{
			door.position = closePosition.position;
		}
	}
	
	public void Open()
	{
		open = true;
	}
	
	private void Update()
	{
		if(open && Vector3.Distance(door.position, openPosition.position) < 0.001f)
		{
			door.position = Vector3.MoveTowards(door.position, openPosition.position, speed * Time.deltaTime);
		}
	}
}
