using UnityEngine;
using UnityEngine.InputSystem;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private int playerScore;
    public int PlayerScore { get { return playerScore; } set { playerScore = value; } }

    [SerializeField]
    private GameObject[] ballPosisions;

    [SerializeField]
    private GameObject[] ballPrefab;

    [SerializeField]
    private GameObject[] cueBall;

    [SerializeField]
    private float xInput = 0f;

    private GameObject ballLine;
    

    public static GameManager instance;

    private void Awake()
    {
        instance = this;
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.spaceKey.wasPressedThisFrame)
            ShootBall();

        if (Keyboard.current.aKey.isPressed || Keyboard.current.leftArrowKey.isPressed)
            xInput = -0.05f;
        else if (Keyboard.current.dKey.isPressed || Keyboard.current.rightArrowKey.isPressed)
            xInput = 0.05f;
        else
            xInput = 0f;

        if (Keyboard.current.backspaceKey.wa
    }
    private void SetBall(BallColor col, int i)
    {

    }
    private void ShootBall()
    {
        Rigidbody rd = cueBall.GetComponent<Rigidbody>();
        rd.AddRelativeForce(Vector3.forward * 50, ForceMode.Impulse);

        ballLine
    }

    private void RotateBall()
    {
        if (cueBall != null)
            cueBall.transform.Rotate(new Vector3(0f, xInput, 0f));
    }
     private void Stopball()
    {
        Rigidbody rd = cueBall.GetComponent.<Rigidbody>();
        rb.linearVelocity = Vector3.zero;
        rb.linearVelocity = Vector3.zero;
        cueBall.transform.eulerAndles = new Vector3(0f, 0f, 0f);
    }
   
}
