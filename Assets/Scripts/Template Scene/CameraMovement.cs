using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class CameraMovement : MonoBehaviour
{
    public CharacterController characterCtrl;
    public float movementSpeed = 5f;


    public GameObject markObj;

    // Start is called before the first frame update
    void Start()
    {
        //sition pos = characterCtrl.GetComponent<Position>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalSpd = Input.GetAxis("Horizontal") * movementSpeed;
        float verticalSpd   = Input.GetAxis("Vertical")   * movementSpeed;

        Vector3 move = transform.right * horizontalSpd + transform.forward * verticalSpd;
        characterCtrl.Move(move * Time.deltaTime);


        if (Input.GetKeyDown("space"))
        {
            createObj();
        }
    }


    void createObj()
    {
        Instantiate<GameObject>(markObj, characterCtrl.transform.position, characterCtrl.transform.rotation);
        markObj.SetActive(true);
    }
}
