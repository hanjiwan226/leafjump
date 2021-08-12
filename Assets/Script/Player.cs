using UnityEngine;

public class Player : MonoBehaviour
{
    float starttime;
    public Vector2 addforce = new Vector2();
    float presstime;
    public float speed = 5;
    public float jumpforce = 5;
    bool right;
    bool left;
    bool space;
    Rigidbody2D rigid;
    public float slope;
    float timer = 0;

    // Start is called before the first frame update
    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        timer = timer + Time.deltaTime;

        string aniname = "Player_Animation_Idle";

        if (Input.GetKey(KeyCode.RightArrow))
        {
            right = true;
            transform.localScale = new Vector3(1, 1, 1);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            left = true;
            transform.localScale = new Vector3(-1, 1, 1);
        }


        bool onground = IsOnGround();

        if (Input.GetKeyDown(KeyCode.Space))
        {
            starttime = timer;
        }

        if (Input.GetKeyUp(KeyCode.Space) && onground)
        {
            presstime = timer - starttime;
            if (presstime < 0.5f)
            {
                presstime = 0.5f;
            }
            if (presstime > 2)
            {
                presstime = 2;
            }
            space = true;
        }

        
        if (Input.GetKey(KeyCode.Space))
        {
            aniname = "Player_Animation_Jump";
        }

        if (Input.GetKey(KeyCode.Space) == false && onground)
        {
            aniname = "Player_animation";
        }

        this.GetComponent<Animator>().Play(aniname);


    }

    private void FixedUpdate()
    {
        if (right)
        {
            right = false;
            rigid.AddForce(Vector2.right * speed);
        }
        if (left)
        {
            left = false;
            rigid.AddForce(Vector2.left * speed);
        }
        if (space)
        {
            space = false;
            addforce = new Vector2(0, presstime * jumpforce);
            rigid.AddForce(Vector2.up * addforce);
        }

        if (rigid.velocity.x >= 2.5f) rigid.velocity = new Vector2(2.5f, rigid.velocity.y);
        else if (rigid.velocity.x <= -2.5f) rigid.velocity = new Vector2(-2.5f, rigid.velocity.y);
        


    }

    bool IsOnGround()
    {
        RaycastHit2D raycasthit = Physics2D.BoxCast(this.transform.position, new Vector2(0.8f,0.2f), 0f ,Vector2.down, 0.5f, LayerMask.GetMask("Leaf"));
        return (raycasthit.collider != null && raycasthit.collider.tag == "Leaf");
        
    }

    void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawRay(transform.position, Vector2.down*0.5f);
        Gizmos.DrawWireCube(transform.position + Vector3.down * 0.5f, new Vector2(0.8f, 0.2f));
    }

}
