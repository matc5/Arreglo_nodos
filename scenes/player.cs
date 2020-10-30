using Godot;
using System;
using System.Diagnostics;
using System.Drawing.Text;
using System.Security.Cryptography.X509Certificates;

public class player : KinematicBody2D
{

    Vector2 posicion = new Vector2();

    [Export] public int gravedad;

    public bool puedo_saltar = false;

    Node obj_colisionado;
    RayCast2D rayo;
    Node2D colisionadores;
    Node[] elementos; 

   // public Godot.Collections.Array<RayCast2D> colisionadores;
    public override void _Ready()
    {
         colisionadores = GetNode<Node2D>("detectores"); /*Aca quisiera saver como puedo almacenar los hijos 
                                    porque con GetNode<Node2D>("detectores").GuetChilldren() me sale error*/


    }

    public override void _PhysicsProcess(float delta)
    {

     
   
        posicion.y += gravedad * delta;
        posicion = MoveAndSlide(posicion);
    }
    public void Jump()
    {
        /*if (rayo.IsColliding())
        {
            obj_colisionado = (Node)rayo.GetCollider();
            if (obj_colisionado.IsInGroup("suelos"))
            {
                puedo_saltar = true;
            }

        }*/
        foreach (Node i in elementos)
        {
            //GD.Print(i); //quiero que se me impriman los 3 raycast para luego verificar si colisionan con un if i.IsColliding(){}
        }
 
    }


}
