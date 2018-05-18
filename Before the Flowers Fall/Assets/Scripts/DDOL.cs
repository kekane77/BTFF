using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// The DDOL class.
/// Contains the DontDestroyOnLoad call.
/// </summary>
/// <remarks>
/// <para>This class should be placed in a preloader scene to preserver persistent
/// scripts.</para>
/// <para>All persistent scripts for audio, save data, player inventory, etc.
/// should be placed in the same scene as this class.</para>
/// </remarks>
public class DDOL : MonoBehaviour {

	void Awake () {
        DontDestroyOnLoad(gameObject);
	}
	
}
