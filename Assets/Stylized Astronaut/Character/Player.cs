using UnityEngine;
using System.Collections;
using UnityEngine.AI;

public class Player : MonoBehaviour {


    private NavMeshAgent nav;

    public Vector3 mousePos;//自定义鼠标点向量
    private Ray ray; //射线
    private bool walk;//是否行走

    public Vector3 myPos;

    private Animator anim;
	private CharacterController controller;

	public float speed = 600.0f;
	public float turnSpeed = 400.0f;
	private Vector3 moveDirection = Vector3.zero;
	public float gravity = 20.0f;

	void Start () {
        nav = GetComponent<NavMeshAgent>();
        controller = GetComponent <CharacterController>();
		anim = gameObject.GetComponentInChildren<Animator>();
        myPos = transform.position;
        mousePos = myPos;
        nav.speed = speed;
        nav.stoppingDistance = 0.3f;
    }

	void Update (){


        //鼠标点击点和角色位置之间距离，距离小于1步行走
        if (Vector3.Distance(this.transform.position, mousePos) <= 0.1)
        {
            //行走开关为false
            walk = false;

        }
        //若果点击鼠标
        if (Input.GetMouseButtonDown(0))
        {

            mousePos = Input.mousePosition;

            //从屏幕中间发出一条射线，到鼠标点击点
            ray = Camera.main.ScreenPointToRay(mousePos);

            //定义碰撞点
            RaycastHit hit;
            //发出一条射线碰撞点
            if (Physics.Raycast(ray, out hit))
            {
                //设置碰撞点给mousePos 并且开启行走开关
                mousePos = hit.point;
                walk = true;
                nav.SetDestination(mousePos);//设置目的地是鼠标点
                

            }

        }


        if (walk)
        {
            anim.SetInteger("AnimationPar", 1);
        }
        else
        {
            anim.SetInteger("AnimationPar", 0);




        }
  
       
		//if(controller.isGrounded){
  //          Touch touch = Input.GetTouch(0);
  //          Vector2 position = touch.position;
  //          transform.Translate(position);
  //      }
    }
}
