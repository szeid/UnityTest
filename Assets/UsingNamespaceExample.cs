using System.Collections;
using System.Collections.Generic;

using GameName.SavingSystem;
using UnityEngine;

public class UsingNamespaceExample : MonoBehaviour {
	void Start () {
		NamespaceExample.number = 100;
		NamespaceExample.Test ();
	}
}
