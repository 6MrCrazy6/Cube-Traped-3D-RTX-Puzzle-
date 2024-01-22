using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    bool Up = false;
    bool Down = false;
    bool Right = false;
    bool Left = false;

    public Vector3 moveDirection = Vector3.zero;
    private Vector3 velocity = Vector3.zero;
    public Vector3 cube;

    public GameObject firstPart;
    public GameObject secondPart;
    public GameObject canvasFirstPart;
    public GameObject canvasSecondPart;

    private int currentLevel;

    [SerializeField] private float moveSpeed = 50f;
    [SerializeField] float smoothness = 0.1f; 
    private Vector3 targetPosition;

    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
       
    }

    private void FixedUpdate()
    {
        Vector3 desiredVelocity = Vector3.zero;

        if (Up == true)
        {
            desiredVelocity += Vector3.forward * moveSpeed;
        }

        if (Down == true)
        {
            desiredVelocity -= Vector3.forward * moveSpeed;
        }

        if (Right == true)
        {
            desiredVelocity += Vector3.right * moveSpeed;
        }

        if (Left == true)
        {
            desiredVelocity -= Vector3.right * moveSpeed;
        }

        velocity = Vector3.Lerp(velocity, desiredVelocity, smoothness);

        if (!Up && !Down && !Right && !Left)
        {
            rb.AddForce(-rb.velocity, ForceMode.VelocityChange);
        }

        targetPosition = transform.position + velocity * Time.deltaTime;
        rb.MovePosition(Vector3.Lerp(transform.position, targetPosition, smoothness));
    }

    public void moveUp(bool _Up)
    {
        Up = _Up;
    }

    public void moveDown(bool _Down)
    {
        Down = _Down;
    }

    public void moveLeft(bool _Left)
    {
        Left = _Left;
    }

    public void moveRight(bool _Right) 
    {
        Right = _Right;
    }


    private void OnTriggerEnter(Collider other)
    {
        if (this.CompareTag("Player") && other.CompareTag("Finish"))
        {
            UnlockLevel();
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        else if (this.CompareTag("Player") && other.CompareTag("LastLevel"))
        {
            SceneManager.LoadScene("Menu");
        }

        else if (this.CompareTag("Player") && other.CompareTag("Second Part"))
        {
            currentLevel = SceneManager.GetActiveScene().buildIndex;

            if (currentLevel == 16)
            {
                firstPart.SetActive(false);
                secondPart.SetActive(true);
                canvasFirstPart.SetActive(false);
                canvasSecondPart.SetActive(true);
            }
            
            else if(currentLevel == 17)
            {
                firstPart.SetActive(false);
                secondPart.SetActive(true);
                canvasFirstPart.SetActive(false);
                canvasSecondPart.SetActive(true);
            }

            else if(currentLevel == 18)
            {
                firstPart.SetActive(false);
                secondPart.SetActive(true);
                canvasFirstPart.SetActive(false);
                canvasSecondPart.SetActive(true);
            }

            else if (currentLevel == 19)
            {
                firstPart.SetActive(false);
                secondPart.SetActive(true);
                canvasFirstPart.SetActive(false);
                canvasSecondPart.SetActive(true);
            }

            else if (currentLevel == 20)
            {
                firstPart.SetActive(false);
                secondPart.SetActive(true);
                canvasFirstPart.SetActive(false);
                canvasSecondPart.SetActive(true);
            }
        }
    }

    public void UnlockLevel()
    {
        int currentLevel = SceneManager.GetActiveScene().buildIndex;

        if (currentLevel >= PlayerPrefs.GetInt("Levels"))
        {
            PlayerPrefs.SetInt("Levels", currentLevel + 1);
        }
    }
}
