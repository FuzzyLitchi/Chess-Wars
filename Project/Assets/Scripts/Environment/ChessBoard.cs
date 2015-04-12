using UnityEngine;
using System.Collections;

public class ChessBoard : MonoBehaviour {
	
	private GameObject[,] fields;

	public static ChessBoard chessBoard;

	void Awake() {

		fields = new GameObject[64, 64];
	}

	public void setField(GameObject fieldObject, int x, int y) {

		fields[x, y] = fieldObject;
	}

	public GameObject getField (int x, int y) {
	
		return fields[x, y];
	}
}