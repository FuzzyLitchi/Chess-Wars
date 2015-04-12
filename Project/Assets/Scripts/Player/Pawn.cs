using UnityEngine;
using System.Collections;

public class Pawn : MonoBehaviour {

	private int x, y;

	private ChessBoard chessBoard;

	void Start() {

		chessBoard = new ChessBoard();

		for (int i = 0; i < 64; i++) {

			if (chessBoard.getField(i, 0).Equals(null)) {

				chessBoard.setField(this.gameObject, i, 0);

				x = i;
				y = 0;
			}
		}
	}

	void Update() {

		if (Input.GetKey(KeyCode.W)) {

			if (chessBoard.getField(x, y - 1).Equals(null)) {

				chessBoard.setField(this.gameObject, x, y + 1);

				y += 1;
			}
		} else if (Input.GetKey(KeyCode.S)) {
			
			if (chessBoard.getField(x, y - 1).Equals(null)) {
				
				chessBoard.setField(this.gameObject, x, y - 1);
				
				y -= 1;
			}
		} else if (Input.GetKey(KeyCode.D)) {
			
			if (chessBoard.getField(x + 1, y).Equals(null)) {
				
				chessBoard.setField(this.gameObject, x + 1, y);
				
				x += 1;
			}
		} else if (Input.GetKey(KeyCode.A)) {
			
			if (chessBoard.getField(x - 1, y).Equals(null)) {
				
				chessBoard.setField(this.gameObject, x - 1, y);
				
				x -= 1;
			}
		}

		transform.position = new Vector3(x, transform.position.y, y);
	}
}