using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crystal : PickUp
{
    [SerializeField] private int points = 5;
	
    void Update()
    {
        Rotation();
    }
	
	public override void Picked()
	{
		GameManager.gameManager.AddPoints(points);
		base.Picked();
	}
}
