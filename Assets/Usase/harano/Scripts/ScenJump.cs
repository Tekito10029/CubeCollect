using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ScenJump : MonoBehaviour
{


	void Start()
	{

	}


	void Update()
	{
		if (Input.GetMouseButtonDown(0))    // ���}�E�X�{�^�����N���b�N������
		{
			SceneManager.LoadScene("GameScene");    // GameScene�Ɉړ�
		}
	}
}
