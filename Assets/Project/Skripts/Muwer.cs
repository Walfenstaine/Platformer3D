using UnityEngine;
using System.Collections;

public class Muwer : MonoBehaviour {
    public AudioClip land;
    public AudioClip[] jump;
    public Animator anim;
	public Vector3 muve;
	public float sensitivity = 1.1f;
	public Transform cam;
	public float speed = 6.0F;
	public float gravity = 20.0F;
    public float jumpSpeed = 10;
    public LayerMask mask;
    private Vector3 moveDirection = Vector3.zero;
    private bool grunded = true;
    public float spid { get; set; }
    public CharacterController controller { get; set; }
	public static Muwer rid {get; set;}

	void Awake(){
        spid = speed;
		if (rid == null) {
			rid = this;
		} else {
			Destroy (this);
		}
	}
	void OnDestroy(){
		rid = null;
	}

	void Start () {
		controller = GetComponent<CharacterController>();
	}

    public void Jump()
    {
        if (grunded)
        {
            anim.SetBool("Jump", true);
            muve.y = jumpSpeed;
            int num = Random.Range(0, jump.Length);
            SoundPlayer.regit.sorse.PlayOneShot(jump[num]);
        }
    }
	void Update() {
        if (controller.enabled)
        {
            Collider[] serch = Physics.OverlapSphere(anim.transform.position, 1.1f, mask);
            if (serch.Length == 0)
            {
                grunded = false;
            }
            if (controller.isGrounded)
            {
                grunded = true;
                anim.SetBool("Jump", false);
                if (controller.velocity.y < -0.2f)
                {
                    SoundPlayer.regit.sorse.PlayOneShot(land);
                }
            }
            if (grunded)
            {
                if (controller.velocity.magnitude > 0)
                {
                    anim.SetBool("Run", true);
                    anim.SetFloat("Speed", (controller.velocity.magnitude / speed)+0.5f);
                    if (muve.magnitude > 0)
                    {
                        Vector3 rutnap = new Vector3(0, 0, controller.velocity.z);
                        cam.rotation = Quaternion.Lerp(cam.rotation, Quaternion.LookRotation(rutnap), 10 * Time.deltaTime);
                    }

                }
                else
                {
                    anim.SetBool("Run", false);
                    anim.SetFloat("Speed", 1);
                }
                moveDirection = muve;
                moveDirection = transform.TransformDirection(moveDirection);
                moveDirection *= speed;

            }
            else
            {
                muve.y = 0;
                moveDirection.y -= gravity * Time.deltaTime;
            }
            
            controller.Move(moveDirection * Time.unscaledDeltaTime);
        }
        else
        {
            grunded = true;
            anim.SetBool("Run", false);
            controller.Move(Vector3.zero);
        }
    }
}
