using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float m_horizontalMoveSpeed = 5f;
    [SerializeField] private float m_verticalMoveSpeed = 5f;

    [SerializeField] private Transform m_body = null;

    private Rigidbody m_rbComp;

    private PlayerInputs m_playerInput;

    // Start is called before the first frame update
    void Start()
    {
        m_playerInput = GetComponent<PlayerInputManager>().GetPlayerInput();
        m_rbComp = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Movemement();
    }

    private void Movemement()
    {
        float horizontalInput = m_playerInput.ClassicPlayer.Movement.ReadValue<Vector2>().x * m_horizontalMoveSpeed;
        float verticalInput = m_playerInput.ClassicPlayer.Movement.ReadValue<Vector2>().y * m_verticalMoveSpeed;

        Vector3 forwardMovement = m_body.forward * verticalInput;
        Vector3 horizontalMovement = m_body.right * horizontalInput;

        Vector3 newVelocity = forwardMovement + horizontalMovement;

        m_rbComp.velocity = newVelocity;
    }
}
