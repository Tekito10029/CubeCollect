using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Title : MonoBehaviour
{

	
	void Start()
	{

	}

	
	void Update()
	{
		if (Input.GetMouseButtonDown(0) || Input.GetKeyDown("space") || Input.GetButtonDown("Action1") || Input.GetButtonDown("Jump")) //�}�E�X���N���b�N�A�X�y�[�X�L�[�AA�{�^���A�W�����v�{�^�����������ꍇ
		{
			SceneManager.LoadScene("some_sensei");
		}

	}
}