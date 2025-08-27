namespace Ucu.Poo.Persons;
/*Tiziano Belletti 27/8/25*/
public class Person
{
    private String nombre;
    private String cedula ;
    private bool valido;
    public Person(String name, String id)
    {
        /*El constructor seguira creando una instancia a pesar de
         no ser valido, pero con una variable booleana permitira 
         que el programa muestre si la instancia de la persona es 
         valida o no*/
        if (IdUtils.IdIsValid(id) == true && name != "")
        {
            this.nombre = name;
            this.cedula = id;
            this.valido = true;
        }
        else
        {
            this.valido = false;
        }
    }


    public void IntroduceYourself()
    {
        if (this.valido == true)
        {
            Console.WriteLine($"Bienvenido {this.nombre} tu cedula es {this.cedula}");
        }
        else
        {
            Console.WriteLine("Su usuario no es valido");
        }
    }
    
}