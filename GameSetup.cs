using UnityEngine;

public class GameSetup : MonoBehaviour
{
    public Camera mainCam;

    public BoxCollider2D topWall;
    public BoxCollider2D bottomWall;
    public BoxCollider2D leftWall;
    public BoxCollider2D rightWall;

    public Transform player1;
    public Transform player2;

    
    public float playerEdgeOffset = 0.08f;

    void Update()
    {
        // wall setup so player doesnt escape edges
        Vector3 topRight   = mainCam.ScreenToWorldPoint(new Vector3(Screen.width,  Screen.height, 0f));
        Vector3 bottomLeft = mainCam.ScreenToWorldPoint(new Vector3(0f,          0f,             0f));

        float width  = topRight.x  - bottomLeft.x;
        float height = topRight.y  - bottomLeft.y;


        topWall.size   = new Vector2(width, 1f);
        topWall.offset = new Vector2(0f, topRight.y + 0.5f);


        bottomWall.size   = new Vector2(width, 1f);
        bottomWall.offset = new Vector2(0f, bottomLeft.y - 0.5f);


        leftWall.size   = new Vector2(1f, height);
        leftWall.offset = new Vector2(bottomLeft.x - 0.5f, 0f);


        rightWall.size   = new Vector2(1f, height);
        rightWall.offset = new Vector2(topRight.x + 0.5f, 0f);


        float zDist = -mainCam.transform.position.z; 


        Vector3 p1World = mainCam.ViewportToWorldPoint(
            new Vector3(playerEdgeOffset, 0.5f, zDist)
        );
        p1World.z = 0f;
        p1World.y = player1.position.y;   // keep current height
        player1.position = p1World;


        Vector3 p2World = mainCam.ViewportToWorldPoint(
            new Vector3(1f - playerEdgeOffset, 0.5f, zDist)
        );
        p2World.z = 0f;
        p2World.y = player2.position.y;
        player2.position = p2World;
    }
}
