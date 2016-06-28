using UnityEngine;
using System.Collections;

public class Grid : MonoBehaviour {

	public static int height=20;
	public static int width=10;
	public static Transform[,] grid = new Transform[width, height];

	// Use this for initialization
	void Start () {
	
	}


	// Update is called once per frame
	void Update () {
	}

	public static Vector2 roundVector(Vector2 v)
	{
		return new Vector2 (Mathf.Round (v.x), Mathf.Round (v.y));


	}
	public static bool InsideBorder(Vector2 pos)
	{
		return((int)pos.x >= 0 && (int)pos.x < width && (int)pos.y >= 0);

	}

	public static void deleteRow(int y)
	{

		for (int x = 0; x < width; x++) 
		{
			Destroy(grid[x,y].gameObject);
			grid [x, y] = null;

		}

	}

	public static void decreaseRow(int y)
	{

	}
}


