using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class SetPokeToFingerAttachPoint : MonoBehaviour
{
	public Transform PokeAttachPoint;

	private XRPokeInteractor _xrPokeInteractor;

	private void Start()
	{
		_xrPokeInteractor = transform.parent.parent.GetComponentInChildren<XRPokeInteractor>();

		SetPokeAttachPoint();
	}

	private void SetPokeAttachPoint()
	{
		if(PokeAttachPoint == null) { Debug.Log("Poke Attach Point is Null!"); return; }
		if(_xrPokeInteractor == null) { Debug.Log("XR Poke Interactor is Null!"); return;}

		_xrPokeInteractor.attachTransform = PokeAttachPoint;
	}
}
