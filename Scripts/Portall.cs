using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portall : MonoBehaviour {
public GameObject otherPortal;
public bool portalOn=false;
private void OnTriggerEnter(Collider other)
{
	if(other.CompareTag("Player") && otherPortal.GetComponent<Portall>().portalOn)
{
	Rigidbody otherRigidBody = other.GetComponent<Rigidbody>();
	Vector3 ExitVelocity = otherPortal.transform.forward * otherRigidBody.velocity.magnitude;
	otherRigidBody.velocity = ExitVelocity;
	other.transform.position = otherPortal.transform.position + otherPortal.transform.forward * 1.5f;
}
}
}
